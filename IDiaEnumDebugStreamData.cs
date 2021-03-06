using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[DefaultMember("Item")]
	[Guid("486943E8-D187-4A6B-A3C4-291259FFF60D")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDiaEnumDebugStreamData
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

		[DispId(2)]
		string name
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		//[MethodImpl(MethodImplOptions.InternalCall)]
		//[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "System.Runtime.InteropServices.CustomMarshalers.EnumeratorToEnumVariantMarshaler, CustomMarshalers, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		//IEnumerator GetEnumerator();

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Item(
			[In] uint index,
			[In] uint cbData,
			[Out] out uint pcbData,
			// The buffer ust be provided by the caller.
			[In] IntPtr pbData);

		// TODO : Implement the associated stub.
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Next(
			[In] uint celt,
			[In] uint cbData,
			[Out] out uint pcbData,
			// The buffer ust be provided by the caller. If the buffer is null,
			// the required size is provided in pcbData
			[In, Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref byte[] pbData,
			[Out] out uint pceltFetched);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Skip(
			[In] uint celt);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Reset();

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Clone(
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumDebugStreamData ppenum);
	}
}
