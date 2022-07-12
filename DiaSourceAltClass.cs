using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("91904831-49CA-4766-B95C-25397E2DD6DC")]
	public class DiaSourceAltClass : IDiaDataSource, DiaSourceAlt
	{
		[DispId(1)]
		public virtual extern string lastError
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void loadDataFromPdb([In][MarshalAs(UnmanagedType.LPWStr)] string pdbPath);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void loadAndValidateDataFromPdb([In][MarshalAs(UnmanagedType.LPWStr)] string pdbPath, [In] ref Guid pcsig70, [In] uint sig, [In] uint age);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void loadDataForExe([In][MarshalAs(UnmanagedType.LPWStr)] string executable, [In][MarshalAs(UnmanagedType.LPWStr)] string searchPath, [In][MarshalAs(UnmanagedType.IUnknown)] object pCallback);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void loadDataFromIStream([In][MarshalAs(UnmanagedType.Interface)] IStream pIStream);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void openSession([MarshalAs(UnmanagedType.Interface)] out IDiaSession ppSession);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void loadDataFromCodeViewInfo([In][MarshalAs(UnmanagedType.LPWStr)] string executable, [In][MarshalAs(UnmanagedType.LPWStr)] string searchPath, [In] uint cbCvInfo, [In] ref byte pbCvInfo, [In][MarshalAs(UnmanagedType.IUnknown)] object pCallback);


		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void loadDataFromMiscInfo([In][MarshalAs(UnmanagedType.LPWStr)] string executable, [In][MarshalAs(UnmanagedType.LPWStr)] string searchPath, [In] uint timeStampExe, [In] uint timeStampDbg, [In] uint sizeOfExe, [In] uint cbMiscInfo, [In] ref byte pbMiscInfo, [In][MarshalAs(UnmanagedType.IUnknown)] object pCallback);
	}
}
