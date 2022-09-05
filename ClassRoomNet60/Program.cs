// See https://aka.ms/new-console-template for more information
using ClassRoomNet60;

Console.WriteLine("Hello, World!");

Studerende s = new Studerende("cecilie", 03, 31);
Studerende s2 = new Studerende("Marcus", 10, 19);

List<Studerende> list = new List<Studerende>();
list.Add(s);
list.Add(s2);

Klasserum kl = new Klasserum("3B", list, DateTime.Parse("1-9-2022"));
Console.WriteLine(kl.Klassenavn);
Console.WriteLine(kl.Semesterstart);

foreach (var st in kl.Klasseliste)
{
    Console.WriteLine(st);
}

