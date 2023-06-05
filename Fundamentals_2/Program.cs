// Dictionary<string,string> profile = new Dictionary<string,string>();
// // We add values to our dictionary the same way we add in Lists
// // But remember to specify the key AND value
// // When we add, we first specify the key, then the value
// profile.Add("Name", "Sandra");
// profile.Add("Language", "C#");
// profile.Add("Location", "England");
// // Now we can render the data like so
// Console.WriteLine("Student profile");
// // Notice how we use ["KeyName"] to pull the value out
// Console.WriteLine("Name - " + profile["Name"]);
// Console.WriteLine("From - " + profile["Location"]);
// Console.WriteLine("Favorite Language - " + profile["Language"]);

// ARRAYS

int[] MyArray = new int[] {0,1,2,3,4,5,6,7,8,9};
System.Console.WriteLine(MyArray);
string[] MyArray_2 = new string[] {"Tim", "Martin", "Nikki", "Sara"};
System.Console.WriteLine(MyArray_2);
int length = 10;
bool[] boolArray = new bool[length];
for (int i = 0; i < length; i++)
{
    boolArray[i] = i % 2 == 0;
}
System.Console.WriteLine(boolArray);
// LISTS
List<string> MyList = new List<string>();
MyList.Add("Rocky Road");
MyList.Add("Vanilla");
MyList.Add("Chocolate");
MyList.Add("Mint Chocolate");
MyList.Add("Cookies and Cream");
System.Console.WriteLine(MyList[2]);
System.Console.WriteLine($"We know of {MyList.Count} ice cream flavors.");
MyList.RemoveAt(2);
System.Console.WriteLine($"We now know of {MyList.Count} ice cream flavors.");

// Dictionary
Random rand = new Random();

Dictionary<string,string> MyDictionary = new Dictionary<string,string>();
MyDictionary.Add("Tim", MyList[rand.Next(0,4)]);
MyDictionary.Add("Martin", MyList[rand.Next(0,4)]);
MyDictionary.Add("Nikki", MyList[rand.Next(0,4)]);
MyDictionary.Add("Sara", MyList[rand.Next(0,4)]);
// System.Console.WriteLine(MyDictionary);
foreach(KeyValuePair<string,string> entry in MyDictionary)
{
    System.Console.WriteLine($"{entry.Key} - {entry.Value}");
}

