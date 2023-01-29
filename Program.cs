// See https://aka.ms/new-console-template for more information
//q1
using LinqHWMain;

List<int> num1 = new(20) { 1, 2, 3, 4, 5, 5, 6, 6 };

var distinct = num1.Distinct().OrderBy((x => x));

foreach (var item in distinct)
{
    Console.WriteLine(item);
}

//q2
var sentence = "hello world";
Console.WriteLine("avarage num is: " + sentence.Split(' ').Average(s => s.Length));


//q3
char[] char1 = new char[] { 'A', 'B', 'C' };
char[] char2 = new char[] { 'D', 'E', 'F' };
string[] list1 = new string[] { "apple", "andrew", " larry", "sam", "astre" };

var print = list1.Where(x => x.StartsWith("a") && x.EndsWith("e")).ToList();

foreach (var item in print)
{
    Console.WriteLine(item);
}

//q4
List<Student> students = new List<Student>
{
    new Student {Name = "Sarah", Id = 1},
    new Student {Name = "Liron", Id = 2},
    new Student {Name = "Norman", Id = 3},
    new Student {Name = "Anna", Id = 4},
};

List<Grades> grades = new List<Grades>
{
    new Grades {Id = 1, Grade = 80},
    new Grades {Id = 2, Grade = 77},
    new Grades {Id = 3, Grade = 93},
    new Grades {Id = 4, Grade = 90},
};

var join = students.Join(grades,
    (s) => s.Id,
    (g) => g.Id,
    (s, g) => new { Name = s.Name, Grade = g.Grade }
    );

foreach (var item in join)
{
    Console.WriteLine(item);
}




