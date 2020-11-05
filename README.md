# How to run
1. Install [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1).
2. After install please make sure your .NET Core version is 3.1.403 our higher by running the following command: `dotnet --version`
3. Go to folder \SOLUTION_FOLDER\MovieStudioApi
4. Run the following command:  dotnet run
5. Find all data on the url: http://localhost:5000/metadata
6. Find data for a MovieId (e.g 3) by using url: http://localhost:5000/metadata/3
7. Find movie stats on the url: http://localhost:5000/movies/stats

# Tools and Frameworks Used
* [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core)
* To recreate the: POST /metadata { ... movie json data ... }, please use [Postman](https://www.postman.com/downloads) and the Postman collection file (MovieStudioApi.postman_collection.json) located on folder: \SOLUTION_FOLDER\Tools\Postman