// how to create new csharp app
dotnet new console -o FirstCSharp

// or you can do this
mkdir FirstCSharp
cd FirstCSharp
dotnet new console
dotnet run or dotnet watch

Dictionary<string,string> profile = new Dictionary<string,string>();
// We add values to our dictionary the same way we add in Lists
// But remember to specify the key AND value
// When we add, we first specify the key, then the value
profile.Add("Name", "Sandra");
profile.Add("Language", "C#");
profile.Add("Location", "England");
// Now we can render the data like so
Console.WriteLine("Student profile");
// Notice how we use ["KeyName"] to pull the value out
Console.WriteLine("Name - " + profile["Name"]);
Console.WriteLine("From - " + profile["Location"]);
Console.WriteLine("Favorite Language - " + profile["Language"]);

// Random
Random rand = new Random();
for(int i = 1; i <= 10; i++)
{
    // Every time the loop executes we will get a NEW random value between 2 and 7
    Console.WriteLine(rand.Next(2,8));
}

//If you run the code above, you should get 10 values between 2 and 7 printed to your console. Notice in the above snippet that we are using the same instance called rand repeatedly to get new numbers every iteration of our loop. We do not need to continually make new instances of Random to use it.




