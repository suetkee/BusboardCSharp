using System.Text.RegularExpressions;

namespace BusboardCSharp {
    public static class ValidatePostcode {
    
        public static bool ValidateUKpostcode(string postcode){
            string postcodePattern = "^[A-Za-z]{1,2}[0-9]{1,2}[A-Za-z]{0,1} ?[0-9][A-Za-z]{2}$";
            string formattedPostcode = Regex.Replace(postcode, @"\s+",""); 
            return Regex.IsMatch(formattedPostcode, postcodePattern);
        }
    

    }
}

