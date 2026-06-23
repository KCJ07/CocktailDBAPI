// Better table visualization classes
using Spectre.Console;


public class ConsoleVis { 

    public static void TestShowTable() { 
    // Styled text with markup
    AnsiConsole.MarkupLine("[bold blue]Welcome[/] to [green]Spectre.Console[/]!");
  
    // A simple table
    var table = new Table()
        .AddColumn("Drink")
        .AddColumn("Description")
        .AddRow("[green]Markup[/]", "Rich text with colors and styles")
        .AddRow("[blue]Tables[/]", "Structured data display")
        .AddRow("[yellow]Progress[/]", "Spinners and progress bars");
    AnsiConsole.Write(table);
  
    // Status spinner for work
    AnsiConsole.Status()
        .Start("Processing...", ctx =>
        {
            Thread.Sleep(2500);
        });
  
    AnsiConsole.MarkupLine("[green]Done![/]");    

    }

    public static void ShowTableArray(DrinkWrap drinkResult)
    {
  
        // Status spinner for work
        AnsiConsole.Status()
          .Start("Processing...", ctx =>
           {
              Thread.Sleep(2500);
           });
  
        AnsiConsole.MarkupLine("[green]Done![/]");    

        // A simple table with the drink
        var table = new Table()
            .AddColumn("Drink")
            .AddColumn("Description");
        
        foreach (var drinks in drinkResult.Drinks) {
            table.AddRow("[green]" + drinks.strDrink + "[/]", "Not Implemented Yet");
        }

        // write table after calculations
        AnsiConsole.Write(table);
    }
}