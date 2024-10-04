using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AbramushkinAN.Sprint2.Task6.V1.Lib
{
    public class DataService : ISprint2Task6V1
    {
        public int FindMonthDaysCount(int value)
        {
            int NumbersOfDays;
            return value switch
            {
                1 => NumbersOfDays = 31,
                2 => NumbersOfDays = 28,
                3 => NumbersOfDays = 31,
                4 => NumbersOfDays = 30,
                5 => NumbersOfDays = 31,
                6 => NumbersOfDays = 30,
                7 => NumbersOfDays = 31,
                8 => NumbersOfDays = 31,
                9 => NumbersOfDays = 30,
                10 => NumbersOfDays = 31,
                11 => NumbersOfDays = 30,
                12 => NumbersOfDays = 31,
                <1 => throw new ArgumentException($"Номер месяца должен быть от 1 до 12. Значение {value} не соответствует условию."),
                >12 => throw new ArgumentException($"Номер месяца должен быть от 1 до 12. Значение {value} не соответствует условию."),
            };
        }
    }
}
