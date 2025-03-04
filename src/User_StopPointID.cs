namespace BusboardCSharp {
    public static class StopPointID {
        public static string GetUserStopPointId(){
            string? UserStopPointID;
            do
            {
                Console.WriteLine("Please enter Stop Point ID");
                UserStopPointID = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(UserStopPointID))
                {
                    Console.WriteLine("Input cannot be empty. PLease try again.");
                }
            } while (string.IsNullOrWhiteSpace(UserStopPointID));
            
            return UserStopPointID;
        
        }
    }

}