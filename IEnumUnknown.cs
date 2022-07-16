using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using MSDIA140.Marshaling;

namespace MSDIA140
{
	/// <summary>Definition taken from Microsoft.VisualStudio.Interop</summary>
	[ComImport]
	[Guid("00000100-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IEnumUnknown
	{
		[ManagedToNativeComInteropStub(typeof(IEnumUnknownStubs), "Next")]
		int Next(
			[In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] uint celt,
			[In] object[] rgelt,
			[Out][ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] out uint pceltFetched);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Skip(
			[In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] uint celt);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Reset();

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Clone(
			[Out][MarshalAs(UnmanagedType.Interface)] out IEnumUnknown ppenum);
	}
}
