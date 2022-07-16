using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using MSDIA140.Marshaling;

namespace MSDIA140
{
	[ComImport]
	[Guid("1C7FF653-51F7-457E-8419-B20F57EF7E4D")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[DefaultMember("Item")]
	public interface IDiaEnumInputAssemblyFiles
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
		IDiaInputAssemblyFile Item(
			[In] uint index);

		[ManagedToNativeComInteropStub(typeof(IDiaEnumInputAssemblyFilesStubs), "Next")]
		void Next(
			[In] uint celt,
			[In] IDiaInputAssemblyFile[] rgelt,
			[Out] out uint pceltFetched);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Skip(
			[In] uint celt);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Reset();

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Clone(
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumInputAssemblyFiles ppenum);
	}
}
