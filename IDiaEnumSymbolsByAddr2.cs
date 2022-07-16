using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using MSDIA140.Marshaling;

namespace MSDIA140
{
	[ComImport]
	[Guid("1E45BD02-BE45-4D71-BA32-0E576CFCD59F")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDiaEnumSymbolsByAddr2 : IDiaEnumSymbolsByAddr
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		IDiaSymbol symbolByAddrEx(
			[In] int fPromoteBlockSym,
			[In] uint isect,
			[In] uint offset);

		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		IDiaSymbol symbolByRVAEx(
			[In] int fPromoteBlockSym,
			[In] uint relativeVirtualAddress);

		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		IDiaSymbol symbolByVAEx(
			[In] int fPromoteBlockSym,
			[In] ulong virtualAddress);

		// TODO : Implement stub
		[MethodImpl(MethodImplOptions.InternalCall)]
		void NextEx(
			[In] int fPromoteBlockSym,
			[In] uint celt,
			[Out][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface, SizeParamIndex = 2)] out IDiaSymbol[] rgelt,
			[Out] out uint pceltFetched);

		// TODO : Implement stub
		[MethodImpl(MethodImplOptions.InternalCall)]
		void PrevEx(
			[In] int fPromoteBlockSym,
			[In] uint celt,
			[Out][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface, SizeParamIndex = 2)] out IDiaSymbol[] rgelt,
			[Out]out uint pceltFetched);
	}
}
