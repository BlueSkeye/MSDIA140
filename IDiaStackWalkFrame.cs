using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("07C590C1-438D-4F47-BDCD-4397BC81AD75")]
	public interface IDiaStackWalkFrame
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
	}
}
