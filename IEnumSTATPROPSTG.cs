using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSDIA140
{
    [ComImport]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("00000139-0000-0000-C000-000000000046")]
    public interface IEnumSTATPROPSTG
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        void Next(
            [In] uint celt,
            /* [annotation][length_is][size_is][out] */
            [Out] out STATPROPSTG rgelt,
            [Out] out uint pceltFetched);

        [MethodImpl(MethodImplOptions.InternalCall)]
        void Skip(
            [In] uint celt);

        [MethodImpl(MethodImplOptions.InternalCall)]
        void Reset();

        [MethodImpl(MethodImplOptions.InternalCall)]
        void Clone(
            [Out] out IEnumSTATPROPSTG ppenum);
    }
}
