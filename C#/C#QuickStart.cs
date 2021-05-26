var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Post,
    RequestUri = new Uri("https://face-enroll1.p.rapidapi.com/Login"),
    Headers =
    {
        { "x-rapidapi-key", "f485496ab8msh2ea068a0bbe333cp179f86jsn2b4afe8962dd" },
        { "x-rapidapi-host", "face-enroll1.p.rapidapi.com" },
    },
    Content = new MultipartFormDataContent
    {
        new StringContent("")
        {
            Headers =
            {
                ContentType = new MediaTypeHeaderValue("application/octet-stream"),
                ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "photo",
                }
            }
        },
        new StringContent("<REQUIRED>")
        {
            Headers =
            {
                ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "personID",
                }
            }
        },
    },
};
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    Console.WriteLine(body);
}
