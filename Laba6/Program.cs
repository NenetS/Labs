using System;

// Интерфейс IPerson
interface IPerson
{
    string Name { get; set; }
    string GetInfo();
}

// Интерфейс ISpecialist, производный от IPerson
interface ISpecialist : IPerson
{
    string Specialization { get; }
}

// Класс Subject для отражения любимого предмета студента
class Subject
{
    public string Name { get; set; }

    public Subject(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}

// Исключение для некорректного возраста
public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}

// Исключение для некорректного имени
public class InvalidNameException : Exception
{
    public InvalidNameException(string message) : base(message) { }
}

// Класс Student, реализующий интерфейсы IPerson, ICloneable и IComparable
class Student : IPerson, ICloneable, IComparable<Student>
{
    private string _name; // Закрытое поле для имени студента
    private int _age; // Закрытое поле для возраста студента
    public Subject FavoriteSubject { get; set; } // Поле для любимого предмета

    // Переопределение свойства Name с проверкой на пустое значение
    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new InvalidNameException("Имя не может быть пустым или состоять только из пробелов.");
            _name = value;
        }
    }

    // Свойство Age с проверкой на корректность значения
    public int Age
    {
        get { return _age; }
        set
        {
            if (value < 0)
                throw new InvalidAgeException("Возраст не может быть отрицательным.");
            _age = value;
        }
    }

    // Конструктор, принимающий только имя
    public Student(string name)
    {
        Name = name;
        Age = 0; // Устанавливаем возраст по умолчанию
        FavoriteSubject = new Subject("Unknown"); // Устанавливаем предмет по умолчанию
    }

    // Конструктор, принимающий имя и возраст
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
        FavoriteSubject = new Subject("Unknown"); // Устанавливаем предмет по умолчанию
    }

    // Переопределение метода GetInfo()
    public string GetInfo()
    {
        return $"Name: {_name}, Age: {Age}, Favorite Subject: {FavoriteSubject}";
    }

    // Метод, увеличивающий возраст студента на единицу
    public void BecomeOlder()
    {
        Age++;
    }

    // Реализация метода ToString() класса Object
    public override string ToString()
    {
        return $"Student: {_name}, Age: {Age}, Favorite Subject: {FavoriteSubject}";
    }

    // Реализация метода ICloneable.Clone()
    public object Clone()
    {
        return new Student(Name, Age) { FavoriteSubject = new Subject(FavoriteSubject.Name) };
    }

    // Реализация метода IComparable<Student>.CompareTo()
    public int CompareTo(Student other)
    {
        return this.Age.CompareTo(other.Age);
    }
}

// Класс ITStudent, наследующий от Student и реализующий ISpecialist
class ITStudent : Student, ISpecialist
{
    public string Specialization { get; private set; }

    public ITStudent(string name, int age, string specialization) : base(name, age)
    {
        Specialization = specialization;
    }

    // Явная реализация метода GetInfo() из интерфейса IPerson
    string IPerson.GetInfo()
    {
        return $"IT Student: {Name}, Age: {Age}, Specialization: {Specialization}, Favorite Subject: {FavoriteSubject}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Создание объекта Student с именем и возрастом
            Student student1 = new Student("John", 20);
            student1.FavoriteSubject = new Subject("Mathematics");
            Console.WriteLine(student1.GetInfo()); // Output: Name: John, Age: 20, Favorite Subject: Mathematics

            // Создание объекта ITStudent с именем и возрастом
            ITStudent itStudent1 = new ITStudent("Alice", 22, "Software Development");
            itStudent1.FavoriteSubject = new Subject("Computer Science");
            Console.WriteLine(itStudent1.GetInfo()); // Output: IT Student: Alice, Age: 22, Specialization: Software Development

            // Увеличение возраста студента John на единицу
            student1.BecomeOlder();
            Console.WriteLine(student1.ToString()); // Output: Student: John, Age: 21

            // Пример некорректного возраста и имени для демонстрации исключений 
            try
            {
                student1.Age = - 5;  // Это вызовет исключение InvalidAgeException.
            }
            catch (InvalidAgeException ex) when (ex.Message.Contains("негативным"))
            {
                Console.WriteLine($"Ошибка при установке возраста: {ex.Message}");
            }

            try
            {
                student1.Name = "";  // Это вызовет исключение InvalidNameException.
            }
            catch (InvalidNameException ex) when (ex.Message.Contains("пустым"))
            {
                Console.WriteLine($"Ошибка при установке имени: {ex.Message}");
            }

            // Клонирование студента John
            Student clonedStudent = (Student)student1.Clone();
            Console.WriteLine(clonedStudent.ToString()); // Output: Student: John, Age: 21

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }

        Console.ReadLine();
    }
}