public class Bird : Animal, ILayEggs
{
    public string CanFly;
    public int EggsPerBatch{get;set;}
    public Bird(string canfly, string diet, int epb): base("Bird", diet, false)
    {
        CanFly = canfly;
        EggsPerBatch = epb;
    }

    public void LayEggs()
    {
        System.Console.WriteLine($"{Name} laid {EgssPerBatch} egg(s)!");
    }
    public override void ShowInfo()
    {
        base.ShowInfo();
        System.Console.WriteLine($"Can Fly: {CanFly}");
    }
}