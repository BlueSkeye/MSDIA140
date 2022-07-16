using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using MSDIA140.Marshaling;

namespace MSDIA140
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[DefaultMember("Item")]
	[Guid("C65C2B0A-1150-4D7A-AFCC-E05BF3DEE81E")]
	public interface IDiaEnumTables
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
		IDiaTable Item(
			[In][MarshalAs(UnmanagedType.Struct)] object index);

		[ManagedToNativeComInteropStub(typeof(IDiaEnumTablesStubs), "Next")]
		void Next(
			[In]uint celt,
			[In] IDiaTable[] rgelt,
			[Out] out uint pceltFetched);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Skip(
			[In] uint celt);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Reset();

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Clone(
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumTables ppenum);
	}
}
