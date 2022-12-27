using Task1;
{
    {
        var classes = new[]
              {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };

        var allStudents = GetAllStudents(classes);
        Console.WriteLine(string.Join(" ", allStudents));
    }

    static string[] GetAllStudents(Classroom[] classes)
    {
        var groupClasess = classes.SelectMany(_ => _.Students);
        return groupClasess.ToArray();
    }
}

