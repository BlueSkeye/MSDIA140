using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("21F81B1B-C5BB-42A3-BC4F-CCBAA75B9F19")]
	public interface IDiaStackWalkHelper
	{
		[DispId(1)]
		ulong registerValue
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall)]
			[param: In]
			set;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		void readMemory([In] MemoryTypeEnum type, [In] ulong va, [In] uint cbData, out uint pcbData, out byte pbData);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void searchForReturnAddress([In][MarshalAs(UnmanagedType.Interface)] IDiaFrameData frame, out ulong returnAddress);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void searchForReturnAddressStart([In][MarshalAs(UnmanagedType.Interface)] IDiaFrameData frame, [In] ulong startAddress, out ulong returnAddress);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void frameForVA([In] ulong va, [MarshalAs(UnmanagedType.Interface)] out IDiaFrameData ppFrame);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void symbolForVA([In] ulong va, [MarshalAs(UnmanagedType.Interface)] out IDiaSymbol ppSymbol);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void pdataForVA([In] ulong va, [In] uint cbData, out uint pcbData, out byte pbData);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void imageForVA([In] ulong vaContext, out ulong pvaImageStart);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void addressForVA([In] ulong va, out uint pISect, out uint pOffset);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void numberOfFunctionFragmentsForVA([In] ulong vaFunc, [In] uint cbFunc, out uint pNumFragments);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void functionFragmentsForVA([In] ulong vaFunc, [In] uint cbFunc, [In] uint cFragments, out ulong pVaFragment, out uint pLenFragment);
	}
}
