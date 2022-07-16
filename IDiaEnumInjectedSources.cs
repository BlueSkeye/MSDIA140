using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[Guid("D5612573-6925-4468-8883-98CDEC8C384A")]
	[DefaultMember("Item")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDiaEnumInjectedSources
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
		IDiaInjectedSource Item(
			[In] uint index);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Next(
			[In] uint celt,
			[In, Out][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface, SizeParamIndex = 0)] ref IDiaInjectedSource?[] rgelt,
			[Out] out uint pceltFetched);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Skip(
			[In] uint celt);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Reset();

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Clone(
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumInjectedSources ppenum);
	}
}
