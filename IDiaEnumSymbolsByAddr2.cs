using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[Guid("1E45BD02-BE45-4D71-BA32-0E576CFCD59F")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDiaEnumSymbolsByAddr2 : IDiaEnumSymbolsByAddr
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		new IDiaSymbol symbolByAddr([In] uint isect, [In] uint offset);

		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		new IDiaSymbol symbolByRVA([In] uint relativeVirtualAddress);

		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		new IDiaSymbol symbolByVA([In] ulong virtualAddress);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void Next([In] uint celt, [MarshalAs(UnmanagedType.Interface)] out IDiaSymbol rgelt, out uint pceltFetched);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void Prev([In] uint celt, [MarshalAs(UnmanagedType.Interface)] out IDiaSymbol rgelt, out uint pceltFetched);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void Clone([MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbolsByAddr ppenum);

		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		IDiaSymbol symbolByAddrEx([In] int fPromoteBlockSym, [In] uint isect, [In] uint offset);

		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		IDiaSymbol symbolByRVAEx([In] int fPromoteBlockSym, [In] uint relativeVirtualAddress);

		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		IDiaSymbol symbolByVAEx([In] int fPromoteBlockSym, [In] ulong virtualAddress);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void NextEx([In] int fPromoteBlockSym, [In] uint celt, [MarshalAs(UnmanagedType.Interface)] out IDiaSymbol rgelt, out uint pceltFetched);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void PrevEx([In] int fPromoteBlockSym, [In] uint celt, [MarshalAs(UnmanagedType.Interface)] out IDiaSymbol rgelt, out uint pceltFetched);
	}
}
