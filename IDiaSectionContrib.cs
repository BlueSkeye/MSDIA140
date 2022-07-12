using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[Guid("0CF4B60E-35B1-4C6C-BDD8-854B9C8E3857")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDiaSectionContrib
	{
		[DispId(1)]
		IDiaSymbol compiland
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(2)]
		uint addressSection
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(3)]
		uint addressOffset
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(4)]
		uint relativeVirtualAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(5)]
		ulong virtualAddress
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(6)]
		uint length
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(8)]
		int notPaged
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(9)]
		int code
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(10)]
		int initializedData
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(11)]
		int uninitializedData
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(12)]
		int remove
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(13)]
		int comdat
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(14)]
		int discardable
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(15)]
		int notCached
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(16)]
		int share
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(17)]
		int execute
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(18)]
		int read
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(19)]
		int write
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(20)]
		uint dataCrc
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(21)]
		uint relocationsCrc
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(22)]
		uint compilandId
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(23)]
		int code16bit
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}
	}
}
