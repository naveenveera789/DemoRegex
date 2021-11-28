using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DemoRegex
{
    class Patterns
    {
        public static string REGEX_PINCODE1 = "^[1-9][0-9]{5}$";
        public static string REGEX_PINCODE2 = "^[1-9][0-9]{2} [0-9]{3}$";
        public bool validatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode, REGEX_PINCODE1);
        }
        public bool validatePin(string pincode)
        {
            return Regex.IsMatch(pincode, REGEX_PINCODE2);
        }
    }
}