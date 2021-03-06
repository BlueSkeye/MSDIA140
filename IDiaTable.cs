using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	/// <summary></summary>
	/// <remarks>
	/// According to the documentation :
	/// The following interfaces are implemented with the IDiaTable interface (that is,
	/// you can query the IDiaTable interface for one of the following interfaces):
	/// IDiaEnumSymbols
	/// IDiaEnumSourceFiles
	/// IDiaEnumLineNumbers
	/// IDiaEnumSectionContribs
	/// IDiaEnumSegments
	/// IDiaEnumInjectedSources
	/// IDiaEnumFrameData</remarks>
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[DefaultMember("Item")]
	[Guid("4A59FB77-ABAC-469B-A30B-9ECC85BFEF14")]
	public interface IDiaTable : IEnumUnknown
	{
		[DispId(0)]
		object /* IUnknown */ NewEnum
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(1)]
		string name
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(2)]
		int count
		{
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IUnknown)]
		object Item(
			[In] uint index);
	}
}
