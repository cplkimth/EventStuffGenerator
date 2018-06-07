// https://github.com/dotnet/roslyn/blob/e123a4207123d5df8c45fb1caba0fb3acbae0e00/src/Compilers/Core/Portable/InternalUtilities/UnicodeCharacterUtilities.cs#L12-L130

#region
using System.Globalization;
using System.Linq;
#endregion

/// <summary>
///     Defines a set of helper methods to classify Unicode characters.
/// </summary>
internal static partial class Utility
{
    private static bool IsIdentifierStartCharacter(char ch)
    {
        // identifier-start-character:
        //   letter-character
        //   _ (the underscore character U+005F)

        if (ch < 'a') // '\u0061'
        {
            if (ch < 'A') // '\u0041'
            {
                return false;
            }

            return ch <= 'Z' // '\u005A'
                   || ch == '_'; // '\u005F'
        }

        if (ch <= 'z') // '\u007A'
        {
            return true;
        }

        if (ch <= '\u007F') // max ASCII
        {
            return false;
        }

        return IsLetterChar(CharUnicodeInfo.GetUnicodeCategory(ch));
    }

    /// <summary>
    ///     Returns true if the Unicode character can be a part of an identifier.
    /// </summary>
    /// <param name="ch">The Unicode character.</param>
    private static bool IsIdentifierPartCharacter(char ch)
    {
        // identifier-part-character:
        //   letter-character
        //   decimal-digit-character
        //   connecting-character
        //   combining-character
        //   formatting-character

        if (ch < 'a') // '\u0061'
        {
            if (ch < 'A') // '\u0041'
            {
                return ch >= '0' // '\u0030'
                       && ch <= '9'; // '\u0039'
            }

            return ch <= 'Z' // '\u005A'
                   || ch == '_'; // '\u005F'
        }

        if (ch <= 'z') // '\u007A'
        {
            return true;
        }

        if (ch <= '\u007F') // max ASCII
        {
            return false;
        }

        UnicodeCategory cat = CharUnicodeInfo.GetUnicodeCategory(ch);
        return IsLetterChar(cat)
               || IsDecimalDigitChar(cat)
               || IsConnectingChar(cat)
               || IsCombiningChar(cat)
               || IsFormattingChar(cat);
    }

    /// <summary>
    ///     Check that the name is a valid Unicode identifier.
    /// </summary>
    public static bool IsValidIdentifier(this string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return false;
        }

        if (!IsIdentifierStartCharacter(name[0]))
        {
            return false;
        }

        int nameLength = name.Length;
        for (int i = 1; i < nameLength; i++) //NB: start at 1
        {
            if (!IsIdentifierPartCharacter(name[i]))
            {
                return false;
            }
        }

        return true;
    }

    private static bool IsLetterChar(UnicodeCategory cat)
    {
        // letter-character:
        //   A Unicode character of classes Lu, Ll, Lt, Lm, Lo, or Nl 
        //   A Unicode-escape-sequence representing a character of classes Lu, Ll, Lt, Lm, Lo, or Nl

        switch (cat)
        {
            case UnicodeCategory.UppercaseLetter:
            case UnicodeCategory.LowercaseLetter:
            case UnicodeCategory.TitlecaseLetter:
            case UnicodeCategory.ModifierLetter:
            case UnicodeCategory.OtherLetter:
            case UnicodeCategory.LetterNumber:
                return true;
        }

        return false;
    }

    private static bool IsCombiningChar(UnicodeCategory cat)
    {
        // combining-character:
        //   A Unicode character of classes Mn or Mc 
        //   A Unicode-escape-sequence representing a character of classes Mn or Mc

        switch (cat)
        {
            case UnicodeCategory.NonSpacingMark:
            case UnicodeCategory.SpacingCombiningMark:
                return true;
        }

        return false;
    }

    private static bool IsDecimalDigitChar(UnicodeCategory cat)
    {
        // decimal-digit-character:
        //   A Unicode character of the class Nd 
        //   A unicode-escape-sequence representing a character of the class Nd

        return cat == UnicodeCategory.DecimalDigitNumber;
    }

    private static bool IsConnectingChar(UnicodeCategory cat)
    {
        // connecting-character:  
        //   A Unicode character of the class Pc
        //   A unicode-escape-sequence representing a character of the class Pc

        return cat == UnicodeCategory.ConnectorPunctuation;
    }

    /// <summary>
    ///     Returns true if the Unicode character is a formatting character (Unicode class Cf).
    /// </summary>
    /// <param name="ch">The Unicode character.</param>
    private static bool IsFormattingChar(char ch)
    {
        // There are no FormattingChars in ASCII range

        return ch > 127 && IsFormattingChar(CharUnicodeInfo.GetUnicodeCategory(ch));
    }

    /// <summary>
    ///     Returns true if the Unicode character is a formatting character (Unicode class Cf).
    /// </summary>
    /// <param name="cat">The Unicode character.</param>
    private static bool IsFormattingChar(UnicodeCategory cat)
    {
        // formatting-character:  
        //   A Unicode character of the class Cf
        //   A unicode-escape-sequence representing a character of the class Cf

        return cat == UnicodeCategory.Format;
    }

    #region keywords
    private static string[] _keywords =
    {
        "abstract",
        "event",
        "new",
        "struct",
        "as",
        "explicit",
        "null",
        "switch",
        "base",
        "extern",
        "object",
        "this",
        "bool",
        "false",
        "operator",
        "throw",
        "break",
        "finally",
        "out",
        "true",
        "byte",
        "fixed",
        "override",
        "try",
        "case",
        "float",
        "params",
        "typeof",
        "catch",
        "for",
        "private",
        "uint",
        "char",
        "foreach",
        "protected",
        "ulong",
        "checked",
        "goto",
        "public",
        "unchecked",
        "class",
        "if",
        "readonly",
        "unsafe",
        "const",
        "implicit",
        "ref",
        "ushort",
        "continue",
        "in",
        "return",
        "using",
        "decimal",
        "int",
        "sbyte",
        "virtual",
        "default",
        "interface",
        "sealed",
        "volatile",
        "delegate",
        "internal",
        "short",
        "void",
        "do",
        "is",
        "sizeof",
        "while",
        "double",
        "lock",
        "stackalloc",
        "else",
        "long",
        "static",
        "enum",
        "namespace",
        "string",
        "get",
        "partial",
        "set",
        "value",
        "where",
        "yield"
    };
    #endregion

    public static bool IsCSharpKeyword(this string text)
    {
        return _keywords.Contains(text);
    }
}