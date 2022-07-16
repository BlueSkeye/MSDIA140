using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	/// <summary>Definition taken from Micosoft.VisualStudio.Interop</summary>
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0C733A30-2A1C-11CE-ADE5-00AA0044773D")]
	public interface ISequentialStream
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Read(
			[Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pv,
			[In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] uint cb,
			[ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] out uint pcbRead);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Write(
			[In][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pv,
			[In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] uint cb,
			[ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULONG")] out uint pcbWritten);
	}
}
