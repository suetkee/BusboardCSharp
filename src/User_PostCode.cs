namespace BusboardCSharp {
    public static class UserPostCode {
        public static string GetUserPostCode(){
            string? PostCode;
            string UserPostCode = "";
            bool status = true;   
            do
            {
                Console.WriteLine("Please enter your postcode");
                PostCode = Console.ReadLine();
   
                if(string.IsNullOrWhiteSpace(PostCode)){
                    Console.WriteLine("Input cannot be empty. Please try again.");
                } else if(!ValidatePostcode.ValidateUKpostcode(PostCode)){
                    Console.WriteLine("Postcode not recognized. Please try again");                  
                } else {
                    UserPostCode = PostCode;
                    status = false;
                }
            } while (status);
            
            return UserPostCode;
        }
    }

}