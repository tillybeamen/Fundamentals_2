// how to create new csharp app
dotnet new console -o FirstCSharp

// or you can do this
mkdir FirstCSharp
cd FirstCSharp
dotnet new console
dotnet run or dotnet watch


===============================
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

=============================
// Random
Random rand = new Random();
for(int i = 1; i <= 10; i++)
{
    // Every time the loop executes we will get a NEW random value between 2 and 7
    Console.WriteLine(rand.Next(2,8));
}

//If you run the code above, you should get 10 values between 2 and 7 printed to your console. Notice in the above snippet that we are using the same instance called rand repeatedly to get new numbers every iteration of our loop. We do not need to continually make new instances of Random to use it.
===============================

// FUNCTIONS
static void SayHello()
{
    Console.WriteLine("Hello how are you doing today?");
}

// STATIC
A static function can be called within the scope of its definition or by calling it on the class it is defined in.

// VOID
You must declare the type of function you are using. We must declare the return type of our function atm we create it
You declare void when there is nothing to return

static int AddNumbers(int a, int b)
{
    return a + b;
}

// Since this function returns something void is replaced with int

// Notice how we specify that we will take in a string called firstName within the parentheses
static void SayHello(string firstName)
{
    // Once inside the function, we treat firstName like any other variable
    // The exact value of this variable will be determined only after we call it
    // Think of the variable name as a placeholder for a value we do not know yet
    Console.WriteLine($"Hello, {firstName}, how are you doing today?");
}

SayHello("Andrew");

#####################
static string SayHello(string firstName = "buddy")
{
    return $"Hey {firstName}";
}
string greeting;
greeting = SayHello();
Console.WriteLine(greeting);

//
This version of SayHello specifies string as the return type. We call SayHello and store the value it returns in the greeting variable, which is also of type string. Finally, we can Console.WriteLine the result to see that it worked.


====================

//TAKING INPUT
Console.WriteLine("Type something, then hit enter: ");
string InputLine = Console.ReadLine();
Console.WriteLine($"You wrote: {InputLine}");
 
=====================
OOP

// put this directly in terminal. console.readline will prompt you to enter your own values

//MEMBERS
Fields, Methods, Properties

// PRROPERTIES
public information you give access to
// GET and SET
Read and write functionality.

// FIELDS

Fields are used to describe the objects our classes create. "How would i Describe this thing to someone". Fields are private you uhave to give access to

// METHODS

Methods are functions that are declared within a class. These are the things that our object can do
The key difference is that these functions can only be used by the class that created them. They cannot be called
upon except by an instance of the class.

// Inheritance

Base from child class referes to the parent class constructor method

// CONSTRUCTOR

public Person()
{
    
}


Virtual method can be overriden by child method
Use override in child class where virtual would be. this signals to progrm this is new method we want to use.
