// Console.Write("Введите цифру, обозначающую день недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());

// void CheckingTheDayOfTheWeek (int dayNumber) {
//   if (dayNumber == 6 || dayNumber == 7) {
//   Console.WriteLine("(этот день выходной) -> да");
//   }
//   else if (dayNumber < 1 || dayNumber > 7) {
//     Console.WriteLine("это вообще не день недели");
//   }
//   else Console.WriteLine("(этот день не выходной) -> нет");
// }

// CheckingTheDayOfTheWeek(dayNumber);

Console.Write("Введите цифру, обозначающую день недели: ");

int dayNumber = Convert.ToInt32(Console.ReadLine());

var mount = new Dictionary<int, string>()
{
    [1] = "Понедельник",
    [2] = "Вторник",
    [3] = "Среда",
    [4] = "Четверг",
    [5] = "Пятница",
    [6] = "Суббота",
    [7] = "Воскресенье",
};

if(dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Этот день выходной.");
}
else
{
    Console.WriteLine("Этот день не явлется выходным.");
}