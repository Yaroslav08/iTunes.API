iTunesAPI [![NuGet](https://img.shields.io/nuget/v/iTunesAPI.svg)](https://www.nuget.org/packages/iTunesAPI)
============

.NET port [iTunesSearch ](https://github.com/danesparza/iTunesSearch) as crossplatform

### Quick Start

Install the [NuGet package](https://www.nuget.org/packages/iTunesAPI/) from the package manager console:

```powershell
Install-Package iTunesAPI
```

### Examples

##### Get songs by name:
```csharp
iTunesClient client = new iTunesClient();
var songs = await client.Song.GetSongsAsync("Roses");
```
