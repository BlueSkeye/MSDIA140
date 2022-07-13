using System.Runtime.InteropServices;

namespace MSDIA140
{
    [StructLayout(LayoutKind.Sequential)]
    public struct STATPROPSTG
    {
        public string lpwstrName;
        public uint propid;
        public VARTYPE vt;
    }
}
