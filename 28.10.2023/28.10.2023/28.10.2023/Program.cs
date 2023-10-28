using _28._10._2023;

//class Program
//{
//    static void Main()
//    {
//        int[] intArray = { 1, 2, 3, 4, 3, 2, 5, 6, 7, 5 };
//        string[] stringArray = { "apple", "orange", "banana", "apple", "grape", "banana", "orange" };

//        var duplicateInts = FindDuplicates(intArray);
//        var duplicateStrings = FindDuplicates(stringArray);

//        Console.WriteLine("Duplicate integers: " + string.Join(", ", duplicateInts));
//        Console.WriteLine("Duplicate strings: " + string.Join(", ", duplicateStrings));
//    }

//    static T[] FindDuplicates<T>(T[] array)
//    {
//        var duplicates = new List<T>();
//        var uniqueItems = new HashSet<T>();

//        foreach (var item in array)
//        {
//            if (!uniqueItems.Add(item))
//            {
//                if (!duplicates.Contains(item))
//                {
//                    duplicates.Add(item);
//                }
//            }
//        }
//        return duplicates.ToArray();
//    }
//}


class Program
{
    static void Main()
    {
        Person[] people = new Person[5];

        people[0] = new Person { Name = "John", Surname = "Doe", Birthday = new DateTime(1990, 5, 15), Salary = 1200 };
        people[1] = new Person { Name = "Alice", Surname = "Smith", Birthday = new DateTime(1985, 10, 8), Salary = 1500 };
        people[2] = new Person { Name = "Bob", Surname = "Johnson", Birthday = new DateTime(1988, 12, 20), Salary = 5000 };
        people[3] = new Person { Name = "Emily", Surname = "Brown", Birthday = new DateTime(1995, 7, 3), Salary = 2000 };
        people[4] = new Person { Name = "David", Surname = "Lee", Birthday = new DateTime(1982, 3, 28), Salary = 1000 };

        Console.WriteLine("People with salary greater than 2000:");
        var highEarners = FilterBySalary(people, 2000);

        foreach (var person in highEarners)
        {
            Console.WriteLine($"Name: {person.Name} {person.Surname}, Salary: {person.Salary:C}");
        }
    }

    static T[] FilterBySalary<T>(T[] array, double minSalary) where T : Person
    {
        return array.Where(person => person.Salary >= minSalary).ToArray();
    }
}