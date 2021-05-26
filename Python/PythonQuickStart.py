import requests

url = "https://face-enroll1.p.rapidapi.com/Login"

payload = "-----011000010111000001101001\r
Content-Disposition: form-data; name=\"photo\"\r
\r
\r
-----011000010111000001101001\r
Content-Disposition: form-data; name=\"personID\"\r
\r
<REQUIRED>\r
-----011000010111000001101001--\r
\r
"
headers = {
    'content-type': "multipart/form-data; boundary=---011000010111000001101001",
    'x-rapidapi-key': "f485496ab8msh2ea068a0bbe333cp179f86jsn2b4afe8962dd",
    'x-rapidapi-host': "face-enroll1.p.rapidapi.com"
    }

response = requests.request("POST", url, data=payload, headers=headers)

print(response.text)
