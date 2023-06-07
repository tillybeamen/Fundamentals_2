Cat MyCat = new Cat("Shorthair", "Omnivourous");

// System.Console.WriteLine(MyCat.Name);

// MyCat.ShowInfo();

Dog MyDog = new Dog ("Shorthair", "Omnivorous");

Bird MyBird = new Bird("Feathers", "Herbivore");

List<Animal> AllAnimalls = new List<Animal>();
AllAnimalls.Add(MyCat);
AllAnimalls.Add(MyDog);
AllAnimalls.Add(MyBird);

List<ILayEggs> EggLayers = new List<ILayEggs>();
EggLayers.Add(MyBird);

foreach(Animal a in AllAnimalls)
{
    a.ShowInfo();
}

foreach(ILayEggs e in EggLayers)
{
    e.LayEggs();
}

// We could make a person class to own pets

foreach(Animal a in AllAnimalls)
{
    if(a is Cat)
    {
        System.Console.WriteLine("Achoo!");
    }
}