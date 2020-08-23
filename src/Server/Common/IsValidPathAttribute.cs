using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Server
{
    public class IsValidPathAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var path = (string) value;
            return IsPath(path);
        }

        private bool IsPath(string path)
        {
            if (path.Length <= 0)
                return false;
            else if (path.Contains(' '))
                return false;
            else if(path.Contains('/'))
                return false;
            else if(path.Contains('\\'))
                return false;
            else
                return true;
        }

        public override string FormatErrorMessage(string name)
        {
            return String.Format(CultureInfo.CurrentCulture,
                ErrorMessageString, name);
        }
    }
}