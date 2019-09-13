# StackExchange.NET

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
  - [Contributers](#contributers)
  - [Usage](#usage)
  - [Parameter Filters](#parameter-filters)

## Overview
StackExchange.NET is a .NET Standard managed library that provides easy access to the StackExchange APi's with virtually no boilerplate code required.

Currently the library supports 18 Endpoints ( As on 11:09:2019) listed in the [API Docs](https://api.stackexchange.com/docs). I will be covering all the other endpoints as well, except those that require Auth.

StackExchange.NET is FOSS (MIT License) and written entirely in c#.

## Contributors

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
;
```

## Parameter Filters

There are different types of parameter filter objects available. Each `Parent Method` will have its own filter. Example : All the `clients.Comments` will accept a `CommentFilter()`

- AnswerFilters
- BadgeFilters
- CommentFilter
- PostFilter

More to be added soon...
