using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5485216B-A54C-469F-9670-52B24D5229BB")]
	public interface IDiaStackWalker
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		void getEnumFrames(
			[In][MarshalAs(UnmanagedType.Interface)] IDiaStackWalkHelper pHelper,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumStackFrames ppenum);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void getEnumFrames2(
			[In] CV_CPU_TYPE_e cpuid,
			[In][MarshalAs(UnmanagedType.Interface)] IDiaStackWalkHelper pHelper,
			[Out][MarshalAs(UnmanagedType.Interface)] out IDiaEnumStackFrames ppenum);
	}
}
