using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using MSDIA140.Marshaling;

namespace MSDIA140
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("624B7D9C-24EA-4421-9D06-3B577471C1FA")]
	public interface IDiaEnumSymbolsByAddr
	{
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

		[ManagedToNativeComInteropStub(typeof(IDiaEnumSymbolsByAddrStubs), "Next")]
		void Next(
			[In] uint celt,
			[In] IDiaSymbol[] rgelt,
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
	}
}
