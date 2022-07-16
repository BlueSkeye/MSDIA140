
namespace MSDIA140.Marshaling
{
    public static class IDiaEnumSymbolsStubs
    {
        public static void Next(IDiaEnumSymbols instance, uint celt, IDiaSymbol[] rgelt,
            out uint pceltFetched)
        {
            BaseStubs.Next<IDiaSymbol>(instance, 6, celt, rgelt, out pceltFetched);
        }
	}
}
