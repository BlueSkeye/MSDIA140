using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	/// <summary>Frm Microsoft.VisualStudio.Interop</summary>
	[ComImport]
	[Guid("0000000C-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IStream // : ISequentialStream
	{
		// COPIED FROM ISequentialStream
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
		// COPY ENDED

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Seek(
			[In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.LARGE_INTEGER")] _LARGE_INTEGER dlibMove,
			[In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")] uint dwOrigin,
			[Out][ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER")][MarshalAs(UnmanagedType.LPArray)] _ULARGE_INTEGER[] plibNewPosition);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void SetSize(
			[In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER")] _ULARGE_INTEGER libNewSize);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void CopyTo(
			[In][MarshalAs(UnmanagedType.Interface)] IStream pstm,
			[In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER")] _ULARGE_INTEGER cb,
			[Out][ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER")][MarshalAs(UnmanagedType.LPArray)] _ULARGE_INTEGER[] pcbRead,
			[Out][ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER")][MarshalAs(UnmanagedType.LPArray)] _ULARGE_INTEGER[] pcbWritten);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Commit(
			[In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")] uint grfCommitFlags);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Revert();

		[MethodImpl(MethodImplOptions.InternalCall)]
		void LockRegion(
			[In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER")] _ULARGE_INTEGER libOffset,
			[In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER")] _ULARGE_INTEGER cb,
			[In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")] uint dwLockType);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void UnlockRegion(
			[In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER")] _ULARGE_INTEGER libOffset,
			[In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.ULARGE_INTEGER")] _ULARGE_INTEGER cb,
			[In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")] uint dwLockType);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Stat(
			[Out][ComAliasName("Microsoft.VisualStudio.OLE.Interop.STATSTG")][MarshalAs(UnmanagedType.LPArray)] STATSTG[] pstatstg,
			[In][ComAliasName("Microsoft.VisualStudio.OLE.Interop.DWORD")] uint grfStatFlag);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Clone(
			[Out][MarshalAs(UnmanagedType.Interface)] out IStream ppstm);
	}
}
