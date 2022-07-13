using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("79F1BB5F-B66E-48E5-B6A9-1545C323CA3D")]
	public interface IDiaDataSource
	{
		[DispId(1)]
		string lastError
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		void loadDataFromPdb([In][MarshalAs(UnmanagedType.LPWStr)] string pdbPath);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void loadAndValidateDataFromPdb([In][MarshalAs(UnmanagedType.LPWStr)] string pdbPath, [In] ref Guid pcsig70, [In] uint sig, [In] uint age);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void loadDataForExe([In][MarshalAs(UnmanagedType.LPWStr)] string executable, [In][MarshalAs(UnmanagedType.LPWStr)] string searchPath, [In][MarshalAs(UnmanagedType.IUnknown)] object pCallback);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void loadDataFromIStream([In][MarshalAs(UnmanagedType.Interface)] IStream pIStream);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void openSession([MarshalAs(UnmanagedType.Interface)] out IDiaSession ppSession);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void loadDataFromCodeViewInfo([In][MarshalAs(UnmanagedType.LPWStr)] string executable, [In][MarshalAs(UnmanagedType.LPWStr)] string searchPath, [In] uint cbCvInfo, [In] ref byte pbCvInfo, [In][MarshalAs(UnmanagedType.IUnknown)] object pCallback);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void loadDataFromMiscInfo([In][MarshalAs(UnmanagedType.LPWStr)] string executable, [In][MarshalAs(UnmanagedType.LPWStr)] string searchPath, [In] uint timeStampExe, [In] uint timeStampDbg, [In] uint sizeOfExe, [In] uint cbMiscInfo, [In] ref byte pbMiscInfo, [In][MarshalAs(UnmanagedType.IUnknown)] object pCallback);
	}
}
