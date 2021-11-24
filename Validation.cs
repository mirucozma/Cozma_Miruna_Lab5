using System.Globalization;
using System.Linq;
using System.Windows.Controls;



namespace Cozma_Miruna_Lab5
{
    //validator pentru camp required
    public class StringNotEmpty : ValidationRule
    {
        //mostenim din clasa ValidationRule
        //suprascriem metoda Validate ce returneaza un ValidationResult
        public override ValidationResult Validate(object value,
        System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString == "")
                return new ValidationResult(false, "String cannot be empty");
            return new ValidationResult(true, null);
        }
    }
    //validator pentru lungime minima a string-ului
    public class StringMinLength : ValidationRule
    {
        public override ValidationResult Validate(object value,
        System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString.Length < 3)
                return new ValidationResult(false, "String must have at least 3 characters!");
        return new ValidationResult(true, null);
        }
    }
    public class NoNumericInputAllowed : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            string aString = value.ToString();
            if (aString == string.Concat(aString.Where(char.IsDigit)))
                return new ValidationResult(false, "String cannot accept numeric input!");
            return new ValidationResult(true, null);
        }
    }
    public class UpperCaseFirstLetter : ValidationRule
    {
       public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            string aString = value.ToString();
            if (aString.Length != 0 && char.IsLower(aString[0]))
                return new ValidationResult(false, "String cannot beggin with lower case letters!");
            return new ValidationResult(true, null);
        }
    } 
}
