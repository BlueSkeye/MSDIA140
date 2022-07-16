using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using MSDIA140.Marshaling;

namespace MSDIA140
{
    /// <summary>Definition copied from Microsoft.VisualStudio.Interop</summary>
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("00000139-0000-0000-C000-000000000046")]
    public interface IEnumSTATPROPSTG
    {
        [ManagedToNativeComInteropStub(typeof(IEnumSTATPROPSTGStubs), "Next")]
        void Next(
            [In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] uint celt,
            [In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.STATPROPSTG")] STATPROPSTG[] rgelt,
            [Out][ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] out uint pceltFetched);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
        int Skip(
            [In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] uint celt);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
        int Reset();

        [MethodImpl(MethodImplOptions.InternalCall)]
        void Clone(
            [Out][MarshalAs(UnmanagedType.Interface)] out IEnumSTATPROPSTG ppEnum);
    }
}
