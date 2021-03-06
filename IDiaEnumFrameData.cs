using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using MSDIA140.Marshaling;

namespace MSDIA140
{
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("9FC77A4B-3C1C-44ed-A798-6C1DEEA53E1F")]
    public interface IDiaEnumFrameData
    {
        [DispId(0)]
        object /* IUnknown */ NewEnum
        {
            [MethodImpl(MethodImplOptions.InternalCall)]
            get;
        }

        [DispId(1)]
        uint Count
        {
            [MethodImpl(MethodImplOptions.InternalCall)]
            get;
        }
        
		[MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.Interface)]
        IDiaFrameData Item(
            [In] uint index);
        
        [ManagedToNativeComInteropStub(typeof(IDiaEnumFrameDataStubs), "Next")]
        void Next(
            [In] uint celt,
            [In] IDiaFrameData[] rgelt,
            [Out] out uint pceltFetched);

        [MethodImpl(MethodImplOptions.InternalCall)]
        void Skip(
            [In] uint celt);

        [MethodImpl(MethodImplOptions.InternalCall)]
        void Reset();

        [MethodImpl(MethodImplOptions.InternalCall)]
        void Clone(
            [Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumFrameData ppenum);

        [MethodImpl(MethodImplOptions.InternalCall)]
        [return:MarshalAs(UnmanagedType.Interface)]
        IDiaFrameData frameByRVA(
            [In] uint relativeVirtualAddress);

        [MethodImpl(MethodImplOptions.InternalCall)]
        [return: MarshalAs(UnmanagedType.Interface)]
        IDiaFrameData frameByVA(
            [In] ulong virtualAddress);
    }
}
