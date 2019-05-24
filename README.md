# Build and Train Model
CD to `Console` folder then execute the project `dotnet run`. This will save the trained model into filename `MLData\SentimentModel.zip`. The zip file will be use by the web api.

# Sample usage of web api

Run the web api

### Request
```
POST /api/sentiment
Content-Type: application/json

{
 "text": "Machine learning is fun"
 }
```

### Response
```
HTTP/1.1 200
status: 200
Date: Fri, 24 May 2019 09:25:37 GMT
Content-Type: application/json; charset=utf-8
Server: Kestrel
Transfer-Encoding: chunked
{"text":"Machine learning is fun","probabilty":0.9732384,"prediction":true,"score":8.984151}
```

