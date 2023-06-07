class Dog
{
    private string Name;
    public string _Name
    {
        get
        {
            return Name;
        }
        set
        {
            Name = value;
        }
    }
    public string Breed;
    public string FurColor {get;set;}
    public Dog(string n, string b, string f)
    {

        // Notice how we used a capital "N" for our Name above, but a lower case "n" for our parameter
        // This helps us to distringuis which is which
        Name = n;
        Breed = b;
        FurColor = f;
    }

void Bark()
{
    System.Console.WriteLine("Bark! Bark!");
}
    
}

// Notice the typer here is Animal. Classes create their very own data type!
// Please Note: This line will throw an error for now until we make
// the proper adjustments on the next page! The syntax IS correct!