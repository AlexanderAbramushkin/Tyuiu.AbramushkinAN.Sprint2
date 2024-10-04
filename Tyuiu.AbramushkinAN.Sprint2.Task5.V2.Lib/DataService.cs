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
                    TimeOfYear = "зима";
                    break;
                case 1:
                    TimeOfYear = "има";
                    break;
                case 2:
                    TimeOfYear = "има";
                    break;
                case 3:
                    TimeOfYear = "весна";
                    break;
                case 4:
                    TimeOfYear = "весна";
                    break;
                case 5:
                    TimeOfYear = "весна";
                    break;
                case 6:
                    TimeOfYear = "лето";
                    break;
                case 7:
                    TimeOfYear = "лето";
                    break;
                case 8:
                    TimeOfYear = "лето";
                    break;
                case 9:
                    TimeOfYear = "осень";
                    break;
                case 10:
                    TimeOfYear = "осень";
                    break;
                case 11:
                    TimeOfYear = "осень";
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {value} не соответствует условию");
            }
            return TimeOfYear;
        }
    }
}
