using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[CoClass(typeof(DiaStackWalkerClass))]
	[Guid("5485216B-A54C-469F-9670-52B24D5229BB")]
	public interface DiaStackWalker : IDiaStackWalker
	{
	}
}
