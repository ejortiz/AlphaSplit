using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlphaSplit.Models
{
    class CaseName
    {

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public CaseName(string lastName, string firstName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }


        private int CompareToRuleCaseName(CaseName ruleCaseName, bool keepLastNameLength = false, bool keepFirstNameLength = false)
        {
            int lastNameLength = this.LastName.Length < ruleCaseName.LastName.Length || keepLastNameLength
                ? this.LastName.Length
                : ruleCaseName.LastName.Length;


            int firstNameLength = this.FirstName.Length < ruleCaseName.FirstName.Length || keepFirstNameLength
                ? this.FirstName.Length
                : ruleCaseName.FirstName.Length;

                        
            string formattedName = LastName.Substring(0, lastNameLength).ToLower() +
                                   " " +
                                   FirstName.Substring(0, firstNameLength).ToLower();
            //formattedName = CaseName.StripUnwantedChars(formattedName);

            string comparedName = ruleCaseName.LastName.ToLower() + " " + ruleCaseName.FirstName.ToLower();
            //comparedName = CaseName.StripUnwantedChars(comparedName);

            return String.CompareOrdinal(formattedName, comparedName);
        }

        //private static string StripUnwantedChars(string str)
        //{
        //    string resultString = Regex.Replace(str, @"[\-]", "");
        //    return resultString;
        //}


        public bool InAlphaRange(CaseName lowerBound, CaseName upperBound, 
                                    bool keepLastNameLenVsLowerBound = false,
                                    bool keepFirstNameLenVsLowerBound = false,
                                    bool keepLastNameLenVsUpperBound = false,
                                    bool keepFirstNameLenVsUpperBound = false)
        {
            if (this.CompareToRuleCaseName(lowerBound, keepLastNameLenVsLowerBound, keepFirstNameLenVsLowerBound) >= 0 &&
                this.CompareToRuleCaseName(upperBound, keepLastNameLenVsUpperBound, keepFirstNameLenVsUpperBound) <= 0)
            {
                return true;
            }

            return false;
        }

    }
}
