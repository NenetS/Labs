using System;

class Student
{
    private string _name; // Закрытое поле для имени студента
    public int Age { get; set; } // Публичное поле для возраста студента

    // Свойство для доступа к закрытому полю _name
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    // Конструктор, принимающий только имя
    public Student(string name)
    {
        _name = name;
        Age = 0; // Устанавливаем возраст по умолчанию
    }

    // Конструктор, принимающий имя и возраст
    public Student(string name, int age)
    {
        _name = name;
        Age = age;
    }

    // Метод, возвращающий информацию о студенте
    public string WriteInfo()
    {
        return $"Name: {_name}, Age: {Age}";
    }

    // Метод, увеличивающий возраст студента на единицу
    public void BecomeOlder()
    {
        Age++;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объекта Student с именем и возрастом
        Student student1 = new Student("John", 20);
        Console.WriteLine(student1.WriteInfo()); // Output: Name: John, Age: 20

        // Создание объекта Student только с именем
        Student student2 = new Student("Jane");
        Console.WriteLine(student2.WriteInfo()); // Output: Name: Jane, Age: 0

        // Увеличение возраста студента Jane на единицу
        student2.BecomeOlder();
        Console.WriteLine(student2.WriteInfo()); // Output: Name: Jane, Age: 1

        // Увеличение возраста студента John на единицу
        student1.BecomeOlder();
        Console.WriteLine(student1.WriteInfo()); // Output: Name: John, Age: 21

        Console.ReadLine();
    }
}
