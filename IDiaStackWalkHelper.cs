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
		void readMemory(
			[In] MemoryTypeEnum type,
			[In] ulong va,
			[In] uint cbData,
			[Out] out uint pcbData,
			[In, Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ref byte[] pbData);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void searchForReturnAddress(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaFrameData frame,
			[Out] out ulong returnAddress);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void searchForReturnAddressStart(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaFrameData frame,
			[In] ulong startAddress,
			[Out] out ulong returnAddress);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void frameForVA(
			[In] ulong va,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaFrameData ppFrame);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void symbolForVA(
			[In] ulong va,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaSymbol ppSymbol);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void pdataForVA(
			[In] ulong va,
			[In] uint cbData,
			[Out] out uint pcbData,
			[In, Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ref byte[] pbData);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void imageForVA(
			[In] ulong vaContext,
			[Out] out ulong pvaImageStart);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void addressForVA(
			[In] ulong va,
			[Out] out uint pISect,
			[Out] out uint pOffset);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void numberOfFunctionFragmentsForVA(
			[In] ulong vaFunc,
			[In] uint cbFunc,
			[Out] out uint pNumFragments);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void functionFragmentsForVA(
			[In] ulong vaFunc,
			[In] uint cbFunc,
			[In] uint cFragments,
			[Out] out ulong pVaFragment,
			[Out] out uint pLenFragment);
	}
}
