
namespace MSDIA140
{
	/// <summary>From Microsoft.VisualStudio.Interop
	/// ComAliasNameAttribute are for documentation purpose and are commented out.</summary>
	public struct PROPVARIANT
	{
		// [ComAliasName("Microsoft.VisualStudio.OLE.Interop.VARTYPE")]
		public VARTYPE vt;

		// [ComAliasName("Microsoft.VisualStudio.OLE.Interop.PROPVAR_PAD1")]
		public ushort wReserved1;

		// [ComAliasName("Microsoft.VisualStudio.OLE.Interop.PROPVAR_PAD2")]
		public ushort wReserved2;

		// [ComAliasName("Microsoft.VisualStudio.OLE.Interop.PROPVAR_PAD3")]
		public ushort wReserved3;

		public uint unionmember1;

		public IntPtr unionmember2;
	}
}
