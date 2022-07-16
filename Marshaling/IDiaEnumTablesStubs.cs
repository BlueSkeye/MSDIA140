
namespace MSDIA140.Marshaling
{
    public static class IDiaEnumTablesStubs
    {
        public static void Next(IDiaEnumTables instance, uint celt, IDiaTable[] rgelt,
            out uint pceltFetched)
        {
            BaseStubs.Next<IDiaTable>(instance, 6, celt, rgelt, out pceltFetched);
        }
    }
}
