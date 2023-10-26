using SpotifyAPI.Web;


namespace SpotifyAPI
{
    internal class Program
    {
        static void Main()
        {
            //Docs for SpotifyAPI.Web https://johnnycrazy.github.io/SpotifyAPI-NET/docs/introduction

            SpotifyClient client = new SpotifyClient(YourAPIKey.API_KEY);

            GetTrack(client, (v) =>
            {
                Console.WriteLine(v.Album);
                Console.WriteLine(v.Artists);
                Console.WriteLine(v.Explicit ? "This song is explicit" : "This song is not explicit");
            });
        }

        public static async void GetTrack(SpotifyClient client, Action<FullTrack> OnReturn)
        {
            FullTrack track = await client.Tracks.Get("put the song ID here");
            OnReturn(track);
        }

        internal static class YourAPIKey
        {
            public const string API_KEY = "blah blah blah get a key from here: https://developer.spotify.com/documentation/web-api";
        }
    }
}