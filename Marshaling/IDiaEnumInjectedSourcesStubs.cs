
namespace MSDIA140.Marshaling
{
    public static class IDiaEnumInjectedSourcesStubs
    {
        public static void Next(IDiaEnumInjectedSources instance, uint celt,
            IDiaInjectedSource[] rgelt, out uint pceltFetched)
        {
            BaseStubs.Next<IDiaInjectedSource>(instance, 6, celt, rgelt, out pceltFetched);
        }
    }
}
