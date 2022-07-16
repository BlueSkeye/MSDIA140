using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using MSDIA140.Marshaling;

namespace MSDIA140
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("08CBB41E-47A6-4F87-92F1-1C9C87CED044")]
	[DefaultMember("Item")]
	public interface IDiaEnumDebugStreams
	{
		[DispId(1)]
		int count
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		IDiaEnumDebugStreamData Item(
			[In][MarshalAs(UnmanagedType.Struct)] object index);

		[ManagedToNativeComInteropStub(typeof(IDiaEnumDebugStreamsStubs), "Next")]
		void Next(
			[In] uint celt,
			[In] IDiaEnumDebugStreamData[] rgelt,
			[Out] out uint pceltFetched);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Skip([In] uint celt);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Reset();

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Clone(
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumDebugStreams ppenum);
	}
}
