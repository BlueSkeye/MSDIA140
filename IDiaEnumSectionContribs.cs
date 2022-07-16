using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[Guid("1994DEB2-2C82-4B1D-A57F-AFF424D54A68")]
	[DefaultMember("Item")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDiaEnumSectionContribs
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

		//[MethodImpl(MethodImplOptions.InternalCall)]
		//[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		//IEnumerator GetEnumerator();

		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		IDiaSectionContrib Item(
			[In] uint index);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Next(
			[In] uint celt,
			// TODO : Very shady definition in the documentation.
			[Out][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface, SizeParamIndex = 2)] out IDiaSectionContrib[] rgelt,
			[Out] out uint pceltFetched);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Skip(
			[In] uint celt);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Reset();

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Clone(
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumSectionContribs ppenum);
	}
}
