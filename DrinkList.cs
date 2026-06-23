// classes for deserilization

//class for drink category types 
public class Categories
{
    public string StrCategory { get; set; }
}

// wrapper class for drink category lists
public class MainObject
{
    public List<Categories> Drinks { get; set; }
}


// wrapper for actual drink lists
public class DrinkWrap
{
    public List<IndDrinks> Drinks {get; set;}
}

// individual drinks 
public class IndDrinks
{
    public string strDrink {get ; set; }
}