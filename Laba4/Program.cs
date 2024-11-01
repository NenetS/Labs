using System;

class Student
{
    private string _name; // Закрытое поле для имени студента
    public int Age { get; set; } // Публичное поле для возраста студента

    // Статическое поле для хранения общего количества студентов
    private static int _studentCount;

    // Статическое свойство для доступа к количеству студентов
    public static int StudentCount
    {
        get { return _studentCount; }
    }

    // Свойство для доступа к закрытому полю _name
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    // Статический конструктор
    static Student()
    {
        _studentCount = 0; // Инициализация количества студентов
    }

    // Конструктор, принимающий только имя
    public Student(string name)
    {
        _name = name;
        Age = 0; // Устанавливаем возраст по умолчанию
        _studentCount++; // Увеличиваем количество студентов
    }

    // Конструктор, принимающий имя и возраст
    public Student(string name, int age)
    {
        _name = name;
        Age = age;
        _studentCount++; // Увеличиваем количество студентов
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

    // Статический метод для получения информации о количестве студентов
    public static string GetStudentCountInfo()
    {
        return $"Total number of students: {StudentCount}";
    }
}

// Статический класс для статистики студентов
static class StudentStatistics
{
    public static void DisplayTotalStudents()
    {
        Console.WriteLine(Student.GetStudentCountInfo());
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объектов Student различными способами
        Student student1 = new Student("John", 20);
        Console.WriteLine(student1.WriteInfo()); // Output: Name: John, Age: 20

        Student student2 = new Student("Jane");
        Console.WriteLine(student2.WriteInfo()); // Output: Name: Jane, Age: 0

        Student student3 = new Student("Alice", 22);
        Console.WriteLine(student3.WriteInfo()); // Output: Name: Alice, Age: 22

        // Увеличение возраста студента Jane на единицу
        student2.BecomeOlder();
        Console.WriteLine(student2.WriteInfo()); // Output: Name: Jane, Age: 1

        // Увеличение возраста студента John на единицу
        student1.BecomeOlder();
        Console.WriteLine(student1.WriteInfo()); // Output: Name: John, Age: 21

        // Вывод общего количества студентов
        StudentStatistics.DisplayTotalStudents(); // Output: Total number of students: 3

        Console.ReadLine();
    }
}