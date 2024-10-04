using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AbramushkinAN.Sprint2.Task5.V2.Lib
{
    public class DataService : ISprint2Task5V2
    {
        public string FindMonthSeason(int value)
        {
            string TimeOfYear = "";
            switch (value) 
            {
                case 12:
                    TimeOfYear = "Зима";
                    break;
                case 1:
                    TimeOfYear = "Зима";
                    break;
                case 2:
                    TimeOfYear = "Зима";
                    break;
                case 3:
                    TimeOfYear = "Весна";
                    break;
                case 4:
                    TimeOfYear = "Весна";
                    break;
                case 5:
                    TimeOfYear = "Весна";
                    break;
                case 6:
                    TimeOfYear = "Лето";
                    break;
                case 7:
                    TimeOfYear = "Лето";
                    break;
                case 8:
                    TimeOfYear = "Лето";
                    break;
                case 9:
                    TimeOfYear = "Осень";
                    break;
                case 10:
                    TimeOfYear = "Осень";
                    break;
                case 11:
                    TimeOfYear = "Осень";
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {value} не соответствует условию");
            }
            return TimeOfYear;
        }
    }
}
