using System;
namespace Lesson_10
{
	public class Person
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }

            public Person ( int id, string name, int age)
        {
            Id = id;
            Age = age;
            Name = name;
        }

        }
    
}

