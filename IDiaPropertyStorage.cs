using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


namespace MSDIA140
{
    [ComImport]
    [Guid("9D416F9C-E184-45B2-A4F0-CE517F719E9B")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDiaPropertyStorage
    {
        [MethodImpl(MethodImplOptions.InternalCall)]
        void ReadMultiple(
            [In] uint cpspec,
            [In] PROPSPEC[] rgpspec,
            [In, Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref PROPVARIANT[] rgvar);
        
		[MethodImpl(MethodImplOptions.InternalCall)]
        void ReadPropertyNames(
            [In] uint cpropid,
            [In] uint[] rgpropid,
            [In, Out][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 0)] ref string[] rglpwstrName);
        
		[MethodImpl(MethodImplOptions.InternalCall)]
        void Enum(
            [Out][MarshalAs(UnmanagedType.Interface)] out IEnumSTATPROPSTG ppenum);
        
		[MethodImpl(MethodImplOptions.InternalCall)]
        void ReadDWORD(
            [In] uint id,
            [Out] out int pValue);

        [MethodImpl(MethodImplOptions.InternalCall)]
        void ReadLONG(
            [In] uint id,
            [Out] out int pValue);
        
		[MethodImpl(MethodImplOptions.InternalCall)]
        void ReadBOOL(
            [In] uint id,
            [Out] out bool pValue);
        
		[MethodImpl(MethodImplOptions.InternalCall)]
        void ReadULONGLONG(
            [In] uint id,
            [Out] out ulong pValue);
        
		[MethodImpl(MethodImplOptions.InternalCall)]
        void ReadBSTR(
            [In] uint id,
            [Out][MarshalAs(UnmanagedType.LPWStr)] out string pValue);
    }
}
