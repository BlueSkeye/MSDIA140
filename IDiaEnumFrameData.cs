using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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
        uint /* IUnknown */ Count
        {
            [MethodImpl(MethodImplOptions.InternalCall)]
            get;
        }
        
		[MethodImpl(MethodImplOptions.InternalCall)]
        void Item(
            [In] uint index,
            [Out] out IDiaFrameData frame);
        
		[MethodImpl(MethodImplOptions.InternalCall)]
        void Next(
            [In] uint celt,
            [Out] out IDiaFrameData rgelt,
            [Out] out uint pceltFetched);

        [MethodImpl(MethodImplOptions.InternalCall)]
        void Skip(
            [In] uint celt);

        [MethodImpl(MethodImplOptions.InternalCall)]
        void Reset();

        [MethodImpl(MethodImplOptions.InternalCall)]
        void Clone(
            [Out] out IDiaEnumFrameData ppenum);

        [MethodImpl(MethodImplOptions.InternalCall)]
        void frameByRVA(
            [In] uint relativeVirtualAddress,
            [Out] out IDiaFrameData frame);

        [MethodImpl(MethodImplOptions.InternalCall)]
        void frameByVA(
            [In] ulong virtualAddress,
            [Out] out IDiaFrameData frame);
    }
}
