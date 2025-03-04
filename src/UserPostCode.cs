namespace BusboardCSharp {
    public static class UserPostCode {
        public static string GetUserPostCode(){
            string? UserPostCode;
            do
            {
                Console.WriteLine("Please enter your postcode");
                UserPostCode = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(UserPostCode))
                {
                    Console.WriteLine("Input cannot be empty. PLease try again.");
                }
            } while (string.IsNullOrWhiteSpace(UserPostCode));
            
            return UserPostCode;
        
        }
    }

}