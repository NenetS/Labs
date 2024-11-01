using System;

// Абстрактный класс Person
abstract class Person
{
    // Абстрактное поле для имени
    public abstract string Name { get; set; }

    // Абстрактный метод для получения информации о человеке
    public abstract string GetInfo();
}

// Класс Student, наследующий от Person
class Student : Person
{
    private string _name; // Закрытое поле для имени студента
    public int Age { get; set; } // Публичное поле для возраста студента

    // Переопределение абстрактного свойства Name
    public override string Name
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

    // Переопределение метода GetInfo()
    public override string GetInfo()
    {
        return $"Name: {_name}, Age: {Age}";
    }

    // Метод, увеличивающий возраст студента на единицу
    public void BecomeOlder()
    {
        Age++;
    }

    // Переопределение метода ToString() класса Object
    public override string ToString()
    {
        return $"Student: {_name}, Age: {Age}";
    }
}

// Класс ITStudent, наследующий от Student
class ITStudent : Student
{
    public ITStudent(string name, int age) : base(name, age) { }

    // Скрытие метода GetInfo() с помощью ключевого слова new
    public new string GetInfo()
    {
        return $"IT Student: {Name}, Age: {Age}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объекта Student с именем и возрастом
        Student student1 = new Student("John", 20);
        Console.WriteLine(student1.GetInfo()); // Output: Name: John, Age: 20

        // Создание объекта ITStudent с именем и возрастом
        ITStudent itStudent1 = new ITStudent("Alice", 22);
        Console.WriteLine(itStudent1.GetInfo()); // Output: IT Student: Alice, Age: 22

        // Показать разницу между переопределением и скрытием метода
        Console.WriteLine(((Person)student1).GetInfo()); // Output: Name: John, Age: 20 (переопределенный метод)
        Console.WriteLine(((Person)itStudent1).GetInfo()); // Output: Name: Alice, Age: 22 (переопределенный метод)

        // Увеличение возраста студента John на единицу
        student1.BecomeOlder();
        Console.WriteLine(student1.ToString()); // Output: Student: John, Age: 21

        Console.ReadLine();
    }
}