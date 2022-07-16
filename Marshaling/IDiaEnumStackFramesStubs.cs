
namespace MSDIA140.Marshaling
{
    public static class IDiaEnumStackFramesStubs
    {
        public static void Next(IDiaEnumStackFrames instance, uint celt,
            IDiaStackFrame[] rgelt, out uint pceltFetched)
        {
            BaseStubs.Next<IDiaStackFrame>(instance, 3, celt, rgelt, out pceltFetched);
        }
    }
}
