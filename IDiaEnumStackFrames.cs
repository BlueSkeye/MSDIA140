using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using MSDIA140.Marshaling;

namespace MSDIA140
{
	[ComImport]
	[Guid("EC9D461D-CE74-4711-A020-7D8F9A1DD255")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDiaEnumStackFrames
	{
		[ManagedToNativeComInteropStub(typeof(IDiaEnumStackFramesStubs), "Next")]
		void Next(
			[In] uint celt,
			[In] IDiaStackFrame[] rgelt,
			[Out] out uint pceltFetched);

		[MethodImpl(MethodImplOptions.InternalCall)]
		void Reset();
	}
}
