namespace FinalExercise
{
    public static class ClientSettings//Classe che memorizza le impostazioni del client (inutile)
    {

        public static string ApiKey = null;
        public static string ApiUrl = "http://api.openweathermap.org/data/2.5";

        public static void SetApiKey(string apiKey)
        {
            ApiKey = apiKey;
        }

        public static void SetApiUrl(string apiUrl)
        {
            ApiUrl = apiUrl;
        }

    }
}
