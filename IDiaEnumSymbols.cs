using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using MSDIA140.Marshaling;

namespace MSDIA140
{
	[ComImport]
	[DefaultMember("Item")]
	[Guid("CAB72C48-443B-48F5-9B0B-42F0820AB29A")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDiaEnumSymbols
	{
		[DispId(0)]
		object /* IUnknown */ NewEnum
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(1)]
		int count
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		IDiaSymbol Item(
			[In] uint index);

		[ManagedToNativeComInteropStub(typeof(IDiaEnumSymbolsStubs), "Next")]
		void Next(
			[In] uint celt,
			[In] IDiaSymbol[] rgelt,
			[Out] out uint pceltFetched);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Skip(
			[In] uint celt);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Reset();

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Clone(
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSymbols ppenum);
	}
}
