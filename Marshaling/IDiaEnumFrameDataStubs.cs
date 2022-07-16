
namespace MSDIA140.Marshaling
{
    public static class IDiaEnumFrameDataStubs
    {
        public static void Next(IDiaEnumFrameData instance, uint celt, IDiaFrameData[] rgelt,
            out uint pceltFetched)
        {
            BaseStubs.Next<IDiaFrameData>(instance, 6, celt, rgelt, out pceltFetched);
        }
    }
}
