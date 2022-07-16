
namespace MSDIA140.Marshaling
{
    public static class IDiaEnumDebugStreamsStubs
    {
        public static void Next(IDiaEnumDebugStreams instance, uint celt,
            IDiaEnumDebugStreamData[] rgelt, out uint pceltFetched)
        {
            BaseStubs.Next<IDiaEnumDebugStreamData>(instance, 5, celt, rgelt, out pceltFetched);
        }
    }
}
