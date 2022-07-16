
namespace MSDIA140.Marshaling
{
    public static class IDiaEnumSourceFilesStubs
    {
        public static void Next(IDiaEnumSourceFiles instance, uint celt,
            IDiaSourceFile[] rgelt, out uint pceltFetched)
        {
            BaseStubs.Next<IDiaSourceFile>(instance, 6, celt, rgelt, out pceltFetched);
        }
    }
}
