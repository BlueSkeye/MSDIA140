using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using MSDIA140.Marshaling;

namespace MSDIA140
{
	[ComImport]
	[Guid("FE30E878-54AC-44F1-81BA-39DE940F6052")]
	[DefaultMember("Item")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDiaEnumLineNumbers
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
		IDiaLineNumber Item(
			[In] uint index);

		[ManagedToNativeComInteropStub(typeof(IDiaEnumLineNumbersStubs), "Next")]
		void Next(
			[In] uint celt,
			[In] IDiaLineNumber[] rgelt,
			[Out] out uint pceltFetched);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Skip(
			[In] uint celt);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Reset();

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Clone(
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumLineNumbers ppenum);
	}
}
