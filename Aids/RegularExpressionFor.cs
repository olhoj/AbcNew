
namespace Abc.Aids {
    public static class RegularExpressionFor {
        public const string EnglishCapitalsOnly = @"^[A-Z]+[A-Z]*$";
        public const string EnglishTextOnly = @"^[A-Z]+[a-zA-Z""'\s-]*$";
        public const string EnglishCapitalsAndNumbersOnly = @"^[A-Z]+[A-Z,0-9]*$";
    }
}

