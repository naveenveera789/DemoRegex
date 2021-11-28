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
        public static string REGEX_FIRST_NAME = "^[a-z]{3}";
        public static string REGEX_SECOND_PART = "^[a-z]{3}[@][a-z]{10}";
        public static string REGEX_THIRD_PART = "^[a-z]{3}[@][a-z]{10}[.][a-z]{2}";
        public static string REGEX_OPTIONAL_PART = "^[a-z]{3}[_+-.]{0,1}[a-z1-9]{3}[@][a-z]{10}[.][a-z]{2}[.][a-z]{2}";
        public bool validatePinCode(string pincode)
        {
            return Regex.IsMatch(pincode, REGEX_PINCODE1);
        }
        public bool validatePin(string pincode)
        {
            return Regex.IsMatch(pincode, REGEX_PINCODE2);
        }
        public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRST_NAME);
        }
        public bool validateSecondPart(string secondPart)
        {
            return Regex.IsMatch(secondPart, REGEX_SECOND_PART);
        }
        public bool validateThirdPart(string thirdPart)
        {
            return Regex.IsMatch(thirdPart, REGEX_THIRD_PART);
        }
        public bool validateOptionalPart(string optionalPart)
        {
            return Regex.IsMatch(optionalPart, REGEX_OPTIONAL_PART);
        }
    }
}