
﻿List<string> TestStringList = new List<string>() { "Harry", "Steve", "Carla", "Jeanne" };
void PrintList(List<string> MyList)
{
    for (int i = 0; i < TestStringList.Count; i++)
    {
        Console.WriteLine(TestStringList[i]);
    };
};
PrintList(TestStringList);

List<int> TestIntList = new List<int>() { 2, 7, 12, 9, 3 };
void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    for (int i = 0; i < TestIntList.Count; i++)
    {
        sum += TestIntList[i];
    };
    Console.WriteLine(sum);
};
// You should get back 33 in this example

SumOfNumbers(TestIntList);

List<int> TestIntList2 = new List<int>() { -9, 12, 10, 3, 17, 5 };
int FindMax(List<int> IntList)
{
    int high = 0;
    for (int i = 0; i < TestIntList2.Count; i++)
    {
        if (TestIntList2[i] > high)
        {
            high = TestIntList2[i];
        }
    };
    return high;
};
// You should get back 17 in this example
Console.WriteLine(FindMax(TestIntList2));


List<int> TestIntList3 = new List<int>() { 1, 2, 3, 4, 5 };
// int[] array = {};
List<int> SquareValues(List<int> IntList)
{
    for (int i = 0; i < TestIntList3.Count; i++)
    {
        TestIntList3[i] = TestIntList3[i] * TestIntList3[i];
        // array[i] = TestIntList3[i];
    }
    return TestIntList3;
};
// You should get back [1,4,9,16,25], think about how you will show that this worked
List<int> SquaredValues = SquareValues(TestIntList3);
foreach (int num in SquaredValues)
{
    Console.WriteLine(num);
}

int[] TestIntArray = new int[] { -1, 2, 3, -4, 5 };
int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0)
        {
            IntArray[i] = 0;
        }
        Console.WriteLine(IntArray[i]);
    }
    return IntArray;
}
// You should get back [0,2,3,0,5], think about how you will show that this worked
NonNegatives(TestIntArray);


Dictionary<string, string> TestDict = new Dictionary<string, string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);
static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
    foreach (KeyValuePair<string, string> entry in MyDictionary)
    {
        Console.WriteLine($"{entry.Key} - {entry.Value}");
    }

}

static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    foreach (KeyValuePair<string, string> entry in MyDictionary)
    {
        if(entry.Key == SearchTerm)
        {
            return true;
        }
    }
    return false;
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));


// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
List<int> Numbers = new List<int>()
{
    6,12,7,10
};
List<string> Names = new List<string>()
{
    "Julie", "Harold", "James", "Monica"
};
Dictionary<string, int> NewDict = new Dictionary<string, int>();
Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    for(int i=0; i<Names.Count; i++)
    {
        NewDict.Add(Names[i], Numbers[i]);
    }
    return NewDict;
};
GenerateDictionary(Names, Numbers);
foreach(KeyValuePair<string, int> entry in NewDict)
{
    Console.WriteLine($"{entry.Key} - {entry.Value}");
};
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here
