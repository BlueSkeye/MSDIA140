
namespace MSDIA140.Marshaling
{
    public static class IDiaEnumInputAssemblyFilesStubs
    {
        public static void Next(IDiaEnumInputAssemblyFiles instance, uint celt,
            IDiaInputAssemblyFile[] rgelt, out uint pceltFetched)
        {
            BaseStubs.Next<IDiaInputAssemblyFile>(instance, 6, celt, rgelt, out pceltFetched);
        }
    }
}
