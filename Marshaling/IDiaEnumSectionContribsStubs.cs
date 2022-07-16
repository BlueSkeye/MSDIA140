
namespace MSDIA140.Marshaling
{
    public static class IDiaEnumSectionContribsStubs
    {
        public static void Next(IDiaEnumSectionContribs instance, uint celt,
            IDiaSectionContrib[] rgelt, out uint pceltFetched)
        {
            BaseStubs.Next<IDiaSectionContrib>(instance, 6, celt, rgelt, out pceltFetched);
        }
    }
}
