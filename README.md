# StackExchange.NET
[![All Contributors](https://img.shields.io/badge/all_contributors-1-orange.svg?style=flat-square)](#contributors)

```
 _____ _             _    ______          _                              _   _ ______ _______ 
 / ____| |           | |  |  ____|        | |                            | \ | |  ____|__   __|
| (___ | |_ __ _  ___| | _| |__  __  _____| |__   __ _ _ __   __ _  ___  |  \| | |__     | |   
 \___ \| __/ _` |/ __| |/ /  __| \ \/ / __| '_ \ / _` | '_ \ / _` |/ _ \ | . ` |  __|    | |   
 ____) | || (_| | (__|   <| |____ >  < (__| | | | (_| | | | | (_| |  __/_| |\  | |____   | |   
|_____/ \__\__,_|\___|_|\_\______/_/\_\___|_| |_|\__,_|_| |_|\__, |\___(_)_| \_|______|  |_|   
                                                              __/ |                            
                                                             |___/                             
 
```
Created by Hari Haran
- [StackExchange.NET](#stackexchangenet)
  - [Overview](#overview)
  - [Installation](#installation)
  - [Supported Operations](#supported-operations)
  - [Contributors](#contributors)
  - [Usage](#usage)
  - [Parameter Filters](#parameter-filters)
  - [Contributing](#contributing)
  - [ChangeLogs](#changelogs)
    - [Version 1.3](#version-13)
    - [Version 1.2](#version-12)
    - [Version 1.1](#version-11)

  
## Overview
StackExchange.NET is a .NET Standard managed library that provides easy access to the StackExchange APi's with virtually no boilerplate code required.

StackExchange.NET is FOSS (MIT License) and written entirely in c#.

## Installation

Use a NuGet package reference inside your project with the name [`StackExchange.NET`](https://www.nuget.org/packages/StackExchange.NET/) Alternatively, binaries can be pulled from the build server linked above under artifacts or compiled manually from the build folder.

## Supported Operations
  - Answers
  - Badges
  - Comments
  - Posts
  - Questions
  - Suggested Edits
  - Tags

## Contributors

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore -->
<table>
  <tr>
    <td align="center"><a href="http://efficientuser.com"><img src="https://avatars1.githubusercontent.com/u/6157834?v=4" width="100px;" alt="Pandiyan Murugan"/><br /><sub><b>Pandiyan Murugan</b></sub></a><br /><a href="https://github.com/gethari/StackExchange.NET/commits?author=PandiyanCool" title="Documentation">📖</a></td>
  </tr>
</table>

<!-- ALL-CONTRIBUTORS-LIST:END -->
## Usage

To create a new API instance provide the apikey. If you need a new key check [docs](https://stackapps.com/apps/oauth/register)

```
  var client = new StackExchangeClient("yourApiKey");
```

You can easily find the relevant method under your preferred section. For example, lets say i want to `GetAllPosts` It can be simply achived by

```
var posts = client.Posts.GetAllPosts(postFilter);
```

Noticed the `postFiler` parameter. Similar to that, each method has its own parameter to filter the results from the api. The `Post Filter` object can also be accessed like this 

```
var postFilter = new PostFilter()
{
    Sort = PostSort.Creation
};
```

## Parameter Filters

There are different types of parameter filter objects available. Each `Parent Method` will have its own filter. Example : All the `clients.Comments` will accept a `CommentFilter()`

- AnswerFilters
- BadgeFilters
- CommentFilter
- PostFilter

## Contributing

If you're looking to contribute, thanks for your interest. Feel free to submit reports for any issues you can find, or request potential features you'd like to see [here](https://github.com/gethari/StackExchange.NET/issues).

## ChangeLogs
  ### Version 1.3
  - Added support for most of the methods in Tags interface.
  ### Version 1.2
  - Added support for Suggested Edits API's

  ### Version 1.1
  - Improved overall code quality using Fluent API Url Builders
  - Removed all Hardcoded API URL's
  - More Clean code
   
        # Before V.0 (Initial commit)

        var apiParams = filters.GetQueryParams();
        var url = $"{_baseApiUrl}/answers?key={_apiKey}&{apiParams}";
        var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
        var apiResult = response.DeserializeJson<Data<Answer>>().ValidateApiResponse();
        return apiResult;

        # After V1.1

        var url = ApiUrlBuilder
                    .Initialize(_apiKey)
                    .ForClient(ClientType.Answers)
                    .WithFilter(filters)
                    .GetApiUrl();
        var response = _httpClient.GetAsync(url).Result
                    .ReadAsJsonAsync<Data<Answer>>()
                    .ValidateApiResponse();
        return response;

