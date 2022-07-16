using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[Guid("1E45BD02-BE45-4D71-BA32-0E576CFCD59F")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDiaEnumSymbolsByAddr2 // : IDiaEnumSymbolsByAddr
	{
		// COPIED FROM IDiaEnumSymbolsByAddr
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		IDiaSymbol symbolByAddr(
			[In] uint isect,
			[In] uint offset);

		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		IDiaSymbol symbolByRVA(
			[In] uint relativeVirtualAddress);

		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		IDiaSymbol symbolByVA(
			[In] ulong virtualAddress);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Next(
			[In] uint celt,
			// TODO : Very shady definition in the documentation.
			[Out][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface, SizeParamIndex = 2)] out IDiaSymbol[] rgelt,
			[Out] out uint pceltFetched);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Prev(
			[In] uint celt,
			// TODO : Very shady definition in the documentation.
			[Out][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface, SizeParamIndex = 2)] out IDiaSymbol[] rgelt,
			[Out] out uint pceltFetched);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Clone(
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbolsByAddr ppenum);
		// END OF COPY

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

		[MethodImpl(MethodImplOptions.InternalCall)]
		void NextEx(
			[In] int fPromoteBlockSym,
			[In] uint celt,
			// TODO : Very shady definition in the documentation.
			[Out][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface, SizeParamIndex = 2)] out IDiaSymbol[] rgelt,
			out uint pceltFetched);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void PrevEx(
			[In] int fPromoteBlockSym,
			[In] uint celt,
			// TODO : Very shady definition in the documentation.
			[Out][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface, SizeParamIndex = 2)] out IDiaSymbol[] rgelt,
			[Out]out uint pceltFetched);
	}
}
