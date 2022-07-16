
namespace MSDIA140.Marshaling
{
    public static class IDiaEnumLineNumbersStubs
    {
        public static void Next(IDiaEnumLineNumbers instance, uint celt, IDiaLineNumber[] rgelt,
            out uint pceltFetched)
        {
            BaseStubs.Next<IDiaLineNumber>(instance, 6, celt, rgelt, out pceltFetched);
        }
    }
}
