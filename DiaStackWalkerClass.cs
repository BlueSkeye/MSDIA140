using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FCanCreate)]
	[Guid("CE4A85DB-5768-475B-A4E1-C0BCA2112A6B")]
	public class DiaStackWalkerClass : IDiaStackWalker, DiaStackWalker
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void getEnumFrames([In][MarshalAs(UnmanagedType.Interface)] IDiaStackWalkHelper pHelper, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumStackFrames ppenum);

		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void getEnumFrames2([In] CV_CPU_TYPE_e cpuid, [In][MarshalAs(UnmanagedType.Interface)] IDiaStackWalkHelper pHelper, [MarshalAs(UnmanagedType.Interface)] out IDiaEnumStackFrames ppenum);
	}
}
