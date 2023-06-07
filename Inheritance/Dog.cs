public class Dog : Animal
{
    public string FurType;
    public Dog(string furtype, string diet): base("Dog", diet, true)
    {
        FurType = furtype;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        System.Console.WriteLine($"Fur Type: {FurType}");
    }
}