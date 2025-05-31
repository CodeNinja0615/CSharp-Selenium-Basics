using Newtonsoft.Json.Linq;
using RestSharp;

namespace AutomationAndCSharpBasics.RestSharp;

public class GoogleMapsApiTest
{
    private static string baseUrl = "https://rahulshettyacademy.com";
    private static string apiKey = "qaclick123";
    private static string placeId = "";

    [Test]
    public void ApiTest()
    {
        Console.WriteLine("▶️ ADD PLACE");
        AddPlace();

        Console.WriteLine("\n▶️ GET PLACE");
        GetPlace();

        Console.WriteLine("\n▶️ UPDATE PLACE");
        UpdatePlace();

        Console.WriteLine("\n▶️ DELETE PLACE");
        DeletePlace();
    }

    static void AddPlace()
    {
        var client = new RestClient(baseUrl);
        var request = new RestRequest("/maps/api/place/add/json", Method.Post);
        request.AddQueryParameter("key", apiKey);

        var body = new
        {
            location = new { lat = -38.383494, lng = 33.427362 },
            accuracy = 50,
            name = "Frontline house",
            phone_number = "(+91) 983 893 3937",
            address = "29, side layout, cohen 09",
            types = new[] { "shoe park", "shop" },
            website = "http://google.com",
            language = "French-IN"
        };
        request.AddJsonBody(body);

        var response = client.Execute(request);
        Console.WriteLine(response.Content);

        var json = JObject.Parse(response.Content);
        placeId = json["place_id"].ToString();
        Console.WriteLine("📌 Extracted Place ID: " + placeId);
    }

    static void GetPlace()
    {
        var client = new RestClient(baseUrl);
        var request = new RestRequest("/maps/api/place/get/json", Method.Get);
        request.AddQueryParameter("key", apiKey);
        request.AddQueryParameter("place_id", placeId);

        var response = client.Execute(request);
        Console.WriteLine(response.Content);
    }

    static void UpdatePlace()
    {
        var client = new RestClient(baseUrl);
        var request = new RestRequest("/maps/api/place/update/json", Method.Put);
        request.AddQueryParameter("key", apiKey);

        var body = new
        {
            place_id = placeId,
            address = "70 winter walk, USA",
            key = apiKey
        };
        request.AddJsonBody(body);

        var response = client.Execute(request);
        Console.WriteLine(response.Content);
    }

    static void DeletePlace()
    {
        var client = new RestClient(baseUrl);
        var request = new RestRequest("/maps/api/place/delete/json", Method.Post);
        request.AddQueryParameter("key", apiKey);

        var body = new
        {
            place_id = placeId
        };
        request.AddJsonBody(body);

        var response = client.Execute(request);
        Console.WriteLine(response.Content);
    }
}
