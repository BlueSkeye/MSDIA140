using System.Runtime.InteropServices;

namespace MSDIA140
{
    [StructLayout(LayoutKind.Explicit)]
    public struct PROPSPEC
    {
        [FieldOffset(0)]
        public _Kind ulKind;
        // union 
        [FieldOffset(8)]
        public uint propid;
        [FieldOffset(8)]
        public string lpwstr;

        public enum _Kind : uint
        {
            PRSPEC_LPWSTR = 0,
            PRSPEC_PROPID = 1,
            PRSPEC_INVALID = uint.MaxValue,
        }
    }
}
