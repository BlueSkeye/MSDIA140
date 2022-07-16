using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MSDIA140.Marshaling
{
    /// <summary>A set of base stub methods for use by interface stubs.</summary>
    internal static class BaseStubs
    {
        private delegate void NextDelegate(IntPtr instance, uint celt, IntPtr array,
            out uint fetchedCount);

        private static void AssertMinimumSize<T>(T[] candidate, uint minimumSize,
            string parameterName)
        {
            AssertNotNull(candidate, parameterName);
            if (candidate.Length < minimumSize) {
                throw new ArgumentException($"{parameterName ?? "UNDEFINED"} size of {candidate.Length} should be at least {minimumSize}.");
            }
        }

        private static void AssertNotNull(object candidate, string parameterName)
        {
            if (null == candidate) {
                throw new ArgumentNullException(parameterName ?? "UNDEFINED");
            }
        }

        internal static void Next<T>(object instance, int methodIndex, uint celt, T[] rgelt,
            out uint pceltFetched)
        {
            AssertMinimumSize(rgelt, celt, nameof(rgelt));
#if _DEBUG_NEXT
            StringBuilder debugBuilder = new StringBuilder();
#endif
            try {
                IntPtr pCOMObject = Marshal.GetIUnknownForObject(instance);
#if _DEBUG_NEXT
                debugBuilder.AppendLine($"COM object at 0x{pCOMObject.ToInt64():X8}");
#endif
                IntPtr iunknownPtr = Marshal.ReadIntPtr(pCOMObject);
#if _DEBUG_NEXT
                debugBuilder.AppendLine($"IUnknownPtr at 0x{iunknownPtr.ToInt64():X8}");
#endif
                IntPtr nativeNextPointer = Marshal.ReadIntPtr(iunknownPtr,
                    methodIndex * Marshal.SizeOf<IntPtr>());
#if _DEBUG_NEXT
                debugBuilder.AppendLine($"Invoking COM function at 0x{nativeNextPointer.ToInt64():X8}");
#endif
                NextDelegate nativeMethod =
                    Marshal.GetDelegateForFunctionPointer<NextDelegate>(nativeNextPointer);
#if _DEBUG_NEXT
                debugBuilder.AppendLine($"Delegate successfully retrieved");
#endif
                IntPtr nativeItemsArray = Marshal.AllocCoTaskMem((int)(Marshal.SizeOf<IntPtr>() * celt));
                try {
                    nativeMethod(pCOMObject, celt, nativeItemsArray, out pceltFetched);
#if _DEBUG_NEXT
                    debugBuilder.AppendLine($"Returning from COM object call.");
#endif
                    for (int index = 0; index < pceltFetched; index++) {
                        IntPtr nativeSymbolPointer = Marshal.ReadIntPtr(nativeItemsArray,
                            index * Marshal.SizeOf<IntPtr>());
                        if (IntPtr.Zero == nativeSymbolPointer) {
                            rgelt[index] = default(T);
                            continue;
                        }
                        object idiaSymbolUnknown = Marshal.GetObjectForIUnknown(nativeSymbolPointer);
#if _DEBUG_NEXT
                        debugBuilder.AppendLine("COM object successfully wrapped");
#endif
                        rgelt[index] = (T)idiaSymbolUnknown;
#if _DEBUG_NEXT
                        debugBuilder.AppendLine($"{typeof(T).Name} interface retrieved.");
#endif
                    }
                }
                finally { Marshal.FreeCoTaskMem(nativeItemsArray); }
                return;
            }
#if _DEBUG_NEXT
            catch (Exception e) {
                throw new ApplicationException(debugBuilder.ToString(), e);
            }
#else
            catch { throw; }
#endif
        }
    }
}
