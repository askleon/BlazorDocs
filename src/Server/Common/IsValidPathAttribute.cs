using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Server
{
    public class IsValidPathAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var path = (string) value;
            return IsValidPathName(path);
        }

        private bool IsValidPathName(string path)
        {
           return Regex.IsMatch(path, @"^[a-zA-Z0-9_\-\&\+]+$");
        }

        public override string FormatErrorMessage(string name)
        {
            return String.Format(CultureInfo.CurrentCulture,
                ErrorMessageString, name);
        }
    }
}