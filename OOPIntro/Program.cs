Student studentOne = new Student("Dan", "Wartsbaugh", "C#", 9001);
Person personOne = new Person("Max", "Rauchman");
Person personTwo = new Person()
{
    FirstName = "Zack",
    LastName = "Louk"
};
Student studentTwo = new Student("Tillman", "Pugh", "C#", 42);
Student studentThree = new Student("Zack", "Louk", "C#", 1);

// Console.WriteLine(personOne.FullName());
// Console.WriteLine(personTwo.FullName());
// Console.WriteLine(studentOne.FullName());
// Console.WriteLine(studentOne.CurrentStack);
// Console.WriteLine(studentOne.StudentId);

//we can add instances of Student objects to a list of Person
List<Person> personList = new List<Person>()
{
    personOne,
    personTwo,
    studentOne
};

// foreach (Person person in personList)
// {
//     Console.WriteLine(person.FullName());
// }

List<Student> studentList = new List<Student>();
studentList.Add(studentOne);
studentList.Add(studentTwo);
studentList.Add(studentThree);

Lecture myLecture = new Lecture("C# OOP", 2, personOne, studentList);

Console.WriteLine("hello");