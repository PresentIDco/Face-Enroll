HttpRequest request = HttpRequest.newBuilder()
		.uri(URI.create("https://face-enroll1.p.rapidapi.com/Login"))
		.header("content-type", "multipart/form-data; boundary=---011000010111000001101001")
		.header("x-rapidapi-key", "APIKEY")
		.header("x-rapidapi-host", "face-enroll1.p.rapidapi.com")
		.method("POST", HttpRequest.BodyPublishers.ofString("-----011000010111000001101001\r
Content-Disposition: form-data; name=\"photo\"\r
\r
\r
-----011000010111000001101001\r
Content-Disposition: form-data; name=\"personID\"\r
\r
<REQUIRED>\r
-----011000010111000001101001--\r
\r
"))
		.build();
HttpResponse<String> response = HttpClient.newHttpClient().send(request, HttpResponse.BodyHandlers.ofString());
System.out.println(response.body());
