using System.Runtime.InteropServices;

namespace MSDIA140
{
	[ComImport]
	[Guid("79F1BB5F-B66E-48E5-B6A9-1545C323CA3D")]
	[CoClass(typeof(DiaSourceClass))]
	public interface DiaSource : IDiaDataSource
	{
	}
}
