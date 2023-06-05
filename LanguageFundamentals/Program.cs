string someString = "Hello world!!";
int someNum = 123;

Console.WriteLine(someString);
Console.WriteLine(someNum);
Console.WriteLine(someString);


void PrintDivisibleNumbers(int num = 100)
{
    for(int i = 1; i <= num; i++)
    {
        bool isDivisibleBy3 = i % 3 == 0;
        bool isDivisibleBy5 = i % 5 == 0;
        bool isDivisibleBy3And5 = isDivisibleBy3 && isDivisibleBy5;
        if(isDivisibleBy3And5)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if(isDivisibleBy3)
        {
            Console.WriteLine("Fizz");
        }
        else if(isDivisibleBy5)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
    }
}

// PrintDivisibleNumbers();
// Console.WriteLine("================");
// PrintDivisibleNumbers(25);

List<string> names = new List<string>()
{
    "Dan", "Ben", "Thien", "Zach", "Mark", "Tillman"
};

names.Add("Blake");
names.Add("Mike");
//we can also add a list of items to our list w/ the AddRange function
names.AddRange(new List<string>{ "name1", "name2"});

Console.WriteLine("Every Name:");
Console.WriteLine(String.Join(", ", names));

List<string> FilterLongNames(List<string> allNames, int numOfChars = 4)
{
    List<string> output = new List<string>();
    foreach (string name in allNames)
    {
        if(name.Length > numOfChars)
        {
            output.Add(name);
        }
    }
    return output;
}

Console.WriteLine("Long Names:");
List<string> longNames = FilterLongNames(names, 6);

Console.WriteLine(String.Join(", ", longNames));
