using System;
using System.Text.RegularExpressions;

namespace ValidationEngine
{
    public class Validator 
    {
        private string validemail = @"(\b[a-zA-Z](?!.*0-9).*@.*\.com\b)";

        public bool ValidateEmailAdress(string tryingemailaddress)
        {

            if (string.IsNullOrEmpty(tryingemailaddress))
            {
                return false;
            }
            var resultMatch = Regex.IsMatch(tryingemailaddress, validemail);
            return resultMatch;


        }
        

         
    }
}