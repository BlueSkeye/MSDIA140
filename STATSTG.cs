using System.Runtime.InteropServices;

namespace MSDIA140
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct STATSTG
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string pwcsName;

		public uint type;

		public _ULARGE_INTEGER cbSize;

		public _FILETIME mtime;

		public _FILETIME ctime;

		public _FILETIME atime;

		public uint grfMode;

		public uint grfLocksSupported;

		public Guid clsid;

		public uint grfStateBits;

		public uint reserved;
	}
}
