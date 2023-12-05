void Final_task()

{

Console.WriteLine("Введите массив (элементы отделяйте запятой): ");

string arrayElements = Console.ReadLine();

string[] commonArray = arrayElements.Split(",");

string[] finalArray = commonArray.Where(arrayElements => arrayElements.Length < 4).ToArray();

Console.WriteLine("Итоговый массив из элементовтов, состоящих из 3 меньше элементов:  ");

Console.WriteLine(String.Join(", ", finalArray));

}

Final_task();
