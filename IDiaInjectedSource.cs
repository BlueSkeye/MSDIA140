using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[Guid("AE605CDC-8105-4A23-B710-3259F1E26112")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDiaInjectedSource
	{
		[DispId(1)]
		uint crc
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(2)]
		ulong length
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(3)]
		string fileName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(4)]
		string objectFileName
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(5)]
		string virtualFilename
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(6)]
		uint sourceCompression
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		void get_source(
			[In] uint cbData,
			[Out] out uint pcbData,
			[In, Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref byte[] pbData);
	}
}
