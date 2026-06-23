﻿using System.Net.Http.Headers;
using System.Net.Http.Json;



using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");


MainObject result = await client.GetFromJsonAsync<MainObject>
    ("https://www.thecocktaildb.com/api/json/v1/1/list.php?c=list");


foreach (var drink in result.Drinks)
     Console.WriteLine(drink.StrCategory);

Console.WriteLine("Pick a drink type");
string usrInput = Console.ReadLine();
usrInput = usrInput.Replace(" ", "_");
usrInput = "https://www.thecocktaildb.com/api/json/v1/1/filter.php?c=" + usrInput;
//re query for actual drink types 
DrinkWrap drinkResult = await client.GetFromJsonAsync<DrinkWrap>
    (usrInput);

// print all individual drinks based on category picked
/*foreach (var drink in drinkResult.Drinks)
{
    Console.WriteLine(drink.strDrink);
}
*/

ConsoleVis.ShowTableArray(drinkResult);