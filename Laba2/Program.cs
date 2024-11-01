using System;

class Subject
{
    public string Name { get; set; } // Публичное поле для названия предмета

    public Subject(string name)
    {
        Name = name;
    }
}

class Game
{
    private string _name; // Закрытое поле для названия игры

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Game(string name)
    {
        _name = name;
    }
}

class Student
{
    private string _name; // Закрытое поле для имени студента
    public int Age { get; set; } // Публичное поле для возраста студента
    private Subject _favoriteSubject; // Закрытое поле для любимого предмета
    private Game _favoriteGame; // Закрытое поле для любимой игры

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

    // Метод для установки любимого предмета и игры
    public void SetFavorite(Subject subject, Game game)
    {
        _favoriteSubject = subject;
        _favoriteGame = game;
    }

    // Метод, возвращающий информацию о студенте и его любимых предметах и играх
    public string WriteInfo()
    {
        return $"Name: {_name}, Age: {Age}, Favorite Subject: {_favoriteSubject?.Name}, Favorite Game: {_favoriteGame?.Name}";
    }

    // Метод, увеличивающий возраст студента на единицу
    public void BecomeOlder()
    {
        Age++;
    }

    // Метод демонстрации передачи по значению и по ссылке
    public void ChangeStudentName(Student student)
    {
        student.Name = "Changed Name"; // Изменяем имя переданного объекта (по ссылке)
    }

}

class Program
{
    static void Main(string[] args)
    {
        // Создание объектов Subject и Game
        Subject math = new Subject("Math");
        Game chess = new Game("Chess");

        // Создание объекта Student с именем и возрастом
        Student student1 = new Student("John", 20);
        student1.SetFavorite(math, chess);

        Console.WriteLine(student1.WriteInfo()); // Output: Name: John, Age: 20, Favorite Subject: Math, Favorite Game: Chess

        // Создание объекта Student только с именем
        Student student2 = new Student("Jane");

        Console.WriteLine(student2.WriteInfo()); // Output: Name: Jane, Age: 0, Favorite Subject: , Favorite Game: 

        // Увеличение возраста студента Jane на единицу
        student2.BecomeOlder();

        Console.WriteLine(student2.WriteInfo()); // Output: Name: Jane, Age: 1, Favorite Subject: , Favorite Game: 

        // Изменение имени студента через метод ChangeStudentName
        student1.ChangeStudentName(student2);

        Console.WriteLine(student2.WriteInfo()); // Output: Name: Changed Name, Age: 1, Favorite Subject: , Favorite Game:

        Console.ReadLine();
    }
}