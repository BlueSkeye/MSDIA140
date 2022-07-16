using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[Guid("EC9D461D-CE74-4711-A020-7D8F9A1DD255")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDiaEnumStackFrames
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Next(
			[In] uint celt,
			// TODO : Very shady definition in the documentation.
			[Out][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Interface, SizeParamIndex = 2)] out IDiaStackFrame[] rgelt,
			[Out] out uint pceltFetched);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Reset();
	}
}
