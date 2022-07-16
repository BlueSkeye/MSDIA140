using System.Runtime.InteropServices;
using System.Text;

namespace MSDIA140.Marshaling
{
    public static class IDiaEnumSymbolsStub
    {
        private delegate void NextDelegate(IntPtr instance, uint celt, IntPtr array,
            out uint fetchedCount);

        public static void Next(IDiaEnumSymbols instance, uint celt, IDiaSymbol[] rgelt,
            out uint pceltFetched)
        {
            if (null == rgelt) {
                throw new ArgumentNullException();
            }
            if (rgelt.Length < celt) {
                throw new ApplicationException();
            }
            StringBuilder debugBuilder = new StringBuilder();
            try {
                // Next is the seventh method 
                IntPtr pCOMObject = Marshal.GetIUnknownForObject(instance);
                debugBuilder.AppendLine($"COM object at 0x{pCOMObject.ToInt64():X8}");
                IntPtr iunknownPtr = Marshal.ReadIntPtr(pCOMObject);
                debugBuilder.AppendLine($"IUnknownPtr at 0x{iunknownPtr.ToInt64():X8}");
                for(int index= 0; index < 7; index++) {
                    debugBuilder.AppendLine($"0x{(Marshal.ReadIntPtr(iunknownPtr, index * Marshal.SizeOf<IntPtr>()).ToInt64()):X8}");
                }
                IntPtr nativeNextPointer = Marshal.ReadIntPtr(iunknownPtr, 6 * Marshal.SizeOf<IntPtr>());
                debugBuilder.AppendLine($"Invoking COM function at 0x{nativeNextPointer.ToInt64():X8}");
                IDiaSymbol[] symbolsArray = new IDiaSymbol[celt];
                NextDelegate nativeMethod =
                    Marshal.GetDelegateForFunctionPointer<NextDelegate>(nativeNextPointer);
                debugBuilder.AppendLine($"Delegate successfully retrieved");
                IntPtr nativeSymbolsArray = Marshal.AllocCoTaskMem((int)(Marshal.SizeOf<IntPtr>() * celt));
                try {
                    nativeMethod(pCOMObject, celt, nativeSymbolsArray, out pceltFetched);
                    debugBuilder.AppendLine($"Returning from COM object call.");
                    for (int index = 0; index < pceltFetched; index++) {
                        IntPtr nativeSymbolPointer = Marshal.ReadIntPtr(nativeSymbolsArray,
                            index * Marshal.SizeOf<IntPtr>());
                        if (IntPtr.Zero == nativeSymbolPointer) {
                            rgelt[index] = null;
                            continue;
                        }
                        object idiaSymbolUnknown = Marshal.GetObjectForIUnknown(nativeSymbolPointer);
                        debugBuilder.AppendLine("COM object successfully wrapped");
                        rgelt[index] = (IDiaSymbol)idiaSymbolUnknown;
                        debugBuilder.AppendLine("IDiaSymbol interface retrieved.");
                    }
                }
                finally { Marshal.FreeCoTaskMem(nativeSymbolsArray); }
                return;
            }
            catch (Exception e) { throw new ApplicationException(debugBuilder.ToString(), e); };
        }
	}
}
