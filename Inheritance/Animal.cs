public class Animal
{
    public string Name;
    public string Diet;
    public bool IsMammal;
    public Animal(string name, string diet, bool ismammal)
    {
        Name = name;
        Diet = diet;
        IsMammal = ismammal;
    }

    public virtual void ShowInfo()
    {
        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine($"Diet: {Diet}");
        System.Console.WriteLine($"Mammal: {IsMammal}");
    }
}