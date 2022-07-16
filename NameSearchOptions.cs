
namespace MSDIA140
{
    [Flags()]
    public enum NameSearchOptions : uint
    {
        nsNone,
        nsfCaseSensitive = 0x1,
        nsfCaseInsensitive = 0x2,
        nsfFNameExt = 0x4,
        nsfRegularExpression = 0x8,
        nsfUndecoratedName = 0x10,

        // For backward compatibility:
        nsCaseSensitive = nsfCaseSensitive,
        nsCaseInsensitive = nsfCaseInsensitive,
        nsFNameExt = nsfCaseInsensitive | nsfFNameExt,
        nsRegularExpression = nsfRegularExpression | nsfCaseSensitive,
        nsCaseInRegularExpression = nsfRegularExpression | nsfCaseInsensitive
    }
}
