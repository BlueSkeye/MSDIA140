using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[DefaultMember("Item")]
	[Guid("4A59FB77-ABAC-469B-A30B-9ECC85BFEF14")]
	public interface IDiaTable : IEnumUnknown
	{
		[DispId(1)]
		string name
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(2)]
		int count
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void RemoteNext([In] uint celt, [MarshalAs(UnmanagedType.IUnknown)] out object rgelt, out uint pceltFetched);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void Skip([In] uint celt);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void Reset();

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void Clone([MarshalAs(UnmanagedType.Interface)] out IEnumUnknown ppenum);

		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		IEnumerator GetEnumerator();

		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IUnknown)]
		object Item([In] uint index);
	}
}
