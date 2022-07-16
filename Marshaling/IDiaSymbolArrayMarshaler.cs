using System.Runtime.InteropServices;

namespace MSDIA140.Marshaling
{
    public class IDiaSymbolArrayMarshaler : ICustomMarshaler
    {
        private static readonly IDiaSymbolArrayMarshaler Instance =
            new IDiaSymbolArrayMarshaler();

        public static IDiaSymbolArrayMarshaler GetInstance(string cookie)
        {
            return Instance;
        }

        public void CleanUpManagedData(object ManagedObj)
        {
            throw new NotImplementedException();
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
            throw new NotImplementedException();
        }

        public int GetNativeDataSize()
        {
            throw new NotImplementedException();
        }

        public IntPtr MarshalManagedToNative(object ManagedObj)
        {
            throw new NotImplementedException();
        }

        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            throw new NotImplementedException();
        }
    }
}
