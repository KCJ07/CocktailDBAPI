﻿using System.Net.Http.Headers;
using System.Net.Http.Json;



using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

// HTTPS GET request
MainObject result = await client.GetFromJsonAsync<MainObject>
    ("https://www.thecocktaildb.com/api/json/v1/1/list.php?c=list");

// custom overloaded method for cool table
ConsoleVis.ShowTableArray(result);

// get and format user input
Console.WriteLine("Pick a drink type");
string usrInput = Console.ReadLine();
usrInput = usrInput.Replace(" ", "_");
usrInput = "https://www.thecocktaildb.com/api/json/v1/1/filter.php?c=" + usrInput;


//re query for actual drink types 
DrinkWrap drinkResult = await client.GetFromJsonAsync<DrinkWrap>
    (usrInput);

// custom overloaded method for cool table
ConsoleVis.ShowTableArray(drinkResult);