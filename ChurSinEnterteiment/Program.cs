// See https://aka.ms/new-console-template for more information
//Console.Write("Введите свое имя: ");
//var name = Console.ReadLine();
//Console.WriteLine($"Привет {name}");

//string name = "Tom";
//int age = 34;
//double height = 1.7;
//Console.Write($"Имя: {name}  Возраст: {age}  Рост: {height}м");
//Console.Write("Введите свое имя: ");
//string name = Console.ReadLine();
//Console.WriteLine($"Привет {name}");
Console.Write("Введите имя: ");
string? name = Console.ReadLine();

Console.Write("Введите возраст: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите рост: ");
double height = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите размер зарплаты: ");
decimal salary = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м  Зарплата: {salary}$");