using System;
using System.Text.RegularExpressions;

namespace ValidationEngine
{
    public class Validator 
    {
        public Validator()
        {
        }

        public bool ValidateEmailAdress(string v)
        {
            return true;
        }

        public bool ValidateAtSign(string v)
        {
            if (Regex.IsMatch(v, @"@"))
            {
                return true;
            }
            else return false;


        }
    }
}