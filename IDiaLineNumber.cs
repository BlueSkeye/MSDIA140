using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[Guid("B388EB14-BE4D-421D-A8A1-6CF7AB057086")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDiaLineNumber
	{
		[DispId(1)]
		IDiaSymbol compiland
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(2)]
		IDiaSourceFile sourceFile
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(3)]
		uint lineNumber
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(4)]
		uint lineNumberEnd
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(5)]
		uint columnNumber
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(6)]
		uint columnNumberEnd
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(7)]
		uint addressSection
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(8)]
		uint addressOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(9)]
		uint relativeVirtualAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(10)]
		ulong virtualAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(11)]
		uint length
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(12)]
		uint sourceFileId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(13)]
		int statement
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(14)]
		uint compilandId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}
	}
}
