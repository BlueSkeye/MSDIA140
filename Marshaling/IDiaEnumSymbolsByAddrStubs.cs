
namespace MSDIA140.Marshaling
{
    public static class IDiaEnumSymbolsByAddrStubs
    {
        public static void Next(IDiaEnumSymbolsByAddr instance, uint celt,
            IDiaSymbol[] rgelt, out uint pceltFetched)
        {
            BaseStubs.Next<IDiaSymbol>(instance, 6, celt, rgelt, out pceltFetched);
        }
    }
}
