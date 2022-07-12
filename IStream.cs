using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[Guid("0000000C-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IStream : ISequentialStream
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		new void RemoteRead(out byte pv, [In] uint cb, out uint pcbRead);

		[MethodImpl(MethodImplOptions.InternalCall)]
		new void RemoteWrite([In] ref byte pv, [In] uint cb, out uint pcbWritten);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoteSeek([In] _LARGE_INTEGER dlibMove, [In] uint dwOrigin, out _ULARGE_INTEGER plibNewPosition);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetSize([In] _ULARGE_INTEGER libNewSize);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void RemoteCopyTo([In][MarshalAs(UnmanagedType.Interface)] IStream pstm, [In] _ULARGE_INTEGER cb, out _ULARGE_INTEGER pcbRead, out _ULARGE_INTEGER pcbWritten);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Commit([In] uint grfCommitFlags);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Revert();

		[MethodImpl(MethodImplOptions.InternalCall)]
		void LockRegion([In] _ULARGE_INTEGER libOffset, [In] _ULARGE_INTEGER cb, [In] uint dwLockType);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void UnlockRegion([In] _ULARGE_INTEGER libOffset, [In] _ULARGE_INTEGER cb, [In] uint dwLockType);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Stat(out tagSTATSTG pstatstg, [In] uint grfStatFlag);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Clone([MarshalAs(UnmanagedType.Interface)] out IStream ppstm);
	}
}
