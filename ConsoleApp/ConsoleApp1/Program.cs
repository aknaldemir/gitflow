using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {

        //var person = new Person() {Name = "Akın", Age = 31 };

        //switch (person)
        //{
        //    case Person { Age: < 35 }:
        //        Console.WriteLine(person.Name + " 's age is greater than 35."); 
        //        break;
        //    default:
        //        break;
        //}



        //Console.WriteLine(GetInfo2().Item1);
        //Console.WriteLine(GetInfo2().Item2);
        //Console.WriteLine(GetInfo2().Item3);


        //Console.WriteLine(GetInfo3().age);
        //Console.WriteLine(GetInfo3().name);
        //Console.WriteLine(GetInfo3().job);

        //var (age, name, job) = GetInfo3();

        //Console.WriteLine($"{name} {job} {age}");


        //var obj = new Person() { Name = "Akın"};
        //if (obj is Person newObj)
        //{
        //    Console.WriteLine($"{obj.Name}");
        //}


        //var result = GetInfo3(30);

        //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        //string companyname = "KARDEŞLER TURIZM INSAAT DANIŞMANLIK AS";

        //var someNumbers = numbers[3..7];
        //var indx = companyname.IndexOf("Ş");

        //var shortName = companyname[indx..9];

        //Console.WriteLine(string.Join(",",someNumbers));
        //Console.WriteLine(shortName);


        var person1 = new Person("Akın", 31);
        var person2 = new Person("Akın", 31);
        string Name;
        int Age;
        person1.Deconstruct(out Name, out Age);

        var person3 = person1 with { Age = 1 };

        Console.WriteLine(person1 == person2);



    }

    public static Tuple<int, string, string> GetInfo()
    {

        return new Tuple<int, string, string>(31, "Akın", string.Empty);
    }

    public static (int, string, string) GetInfo2()
    {

        return (31, "Akın", string.Empty);
    }

    public static (int age, string name, string job) GetInfo3(int limit)
    {
        int ChecktheAge(int age)
        {
            return age < limit ? age : limit;
        }
        Console.WriteLine("Tets");
        var result = ChecktheAge(31);

        return (age: 31, name: "Akın", job: "Software Engineer");
    }

}

record class Person(string Name, int Age) { 

    public void SayHi()
    {
        Console.WriteLine($"Hi, {Name} yaşın {Age}");
    }

};