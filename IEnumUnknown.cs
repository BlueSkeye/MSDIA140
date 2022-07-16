using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	/// <summary>Definition taken from Microsoft.VisualStudio.Interop</summary>
	[ComImport]
	[Guid("00000100-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IEnumUnknown
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		int Next(
			[In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] uint celt,
			[Out][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.IUnknown)] object[] rgelt,
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
