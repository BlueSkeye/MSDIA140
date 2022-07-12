MSDIA140

It looks like the .Net 6.0 version of TLBIMP fails to produce the right library for
MSDIA SDK. More specifically, some functions such as IDiaSourceFile::get_checksum
are incorrcetly translated. The generated function is :

[MethodImpl(MethodImplOptions.InternalCall)]
void get_checksum([In] uint cbData, out uint pcbData, out byte pbData);

while it should be :

[MethodImpl(MethodImplOptions.InternalCall)]
void get_checksum([In] uint cbData, out uint pcbData, out byte[] pbData);

This project is intended to fix the problem by providing the right definitions.
This work is in progress. Fixes are provided for the functions the author uses in
other projects.

You are encouraged to open Issues or provide pull request if you have knowledge
of yet unfixed functions.
WARNING : MSDIA140 being a side project, expect some delays for me to answer or
take your proposal into account.