using Tyuiu.AbramushkinAN.Sprint2.Task5.V2.Lib;
namespace Tyuiu.AbramushkinAN.Sprint2.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Абрамушкин А. Н. | ИИПб-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Абрамушкин Александр Николаевич | ИИПб-24-2                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Условие: По данному месяцу, определите в какую пору года попадает этот  *");
            Console.WriteLine("* месяц (Зима, Лето, Весна, Осень).                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца:");
            int NumberOfMonth = Convert.ToInt32(Console.ReadLine());
            string result;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if ((NumberOfMonth<1) || (NumberOfMonth > 12))
            {
                Console.WriteLine("Указано неверное значение. Укажите значение от 1 до 12.");
            }
            
            else
            {
                Console.WriteLine($"Время года : {ds.FindMonthSeason(NumberOfMonth)}");
            }
        }
    }
}
