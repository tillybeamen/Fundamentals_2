public class Cat : Animal
{
    public string FurType;
    public Cat(string furtype, string diet): base("Cat", diet, true)
    {
        FurType = furtype;
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        System.Console.WriteLine($"Fur Type: {FurType}");
    }
}