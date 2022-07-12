using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0C733A30-2A1C-11CE-ADE5-00AA0044773D")]
	public interface ISequentialStream
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoteRead(out byte pv, [In] uint cb, out uint pcbRead);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoteWrite([In] ref byte pv, [In] uint cb, out uint pcbWritten);
	}
}
