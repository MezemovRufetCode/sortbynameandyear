using System;
using System.Collections.Generic;

public class PLanguage : IComparable<PLanguage>
{
    public string Name;
    public int Year;
    public override string ToString()
    {
        return "ID: " + Year + "   Name: " + Name;
    }
    public int SortByName(string name1, string name2)
    {

        return name1.CompareTo(name2);
    }
    public int CompareTo(PLanguage comparePart)
    {
        if (comparePart == null)
            return 1;

        else
            return this.Year.CompareTo(comparePart.Year);
    }
}
public class Example
{
    public static void Main()
    {
        List<PLanguage> planguage = new List<PLanguage>();
        planguage.Add(new PLanguage() { Name = "C#", Year = 1992 });
        planguage.Add(new PLanguage() { Name = "C++", Year = 1977 });
        planguage.Add(new PLanguage() { Name = "Java", Year = 2001 });
        planguage.Add(new PLanguage() { Name = "Phyton", Year = 2001 });
        planguage.Add(new PLanguage() { Name = "JavaScript", Year = 1995 });
        Console.WriteLine("Before sort:");
        foreach (PLanguage item in planguage)
        {
            Console.WriteLine(item);
        }
        planguage.Sort();
        Console.WriteLine();
        Console.WriteLine("After sort by years:");
        foreach (PLanguage item in planguage)
        {
            Console.WriteLine(item);
        }
        planguage.Sort(delegate(PLanguage x, PLanguage y)
        {
            if (x.Name == null && y.Name == null) return 0;
            else if (x.Name == null) return -1;
            else if (y.Name == null) return 1;
            else return x.Name.CompareTo(y.Name);
        });
        Console.WriteLine();
        Console.WriteLine("After sort by name:");
        foreach (PLanguage item in planguage)
        {
            Console.WriteLine(item);
        }
    }
}