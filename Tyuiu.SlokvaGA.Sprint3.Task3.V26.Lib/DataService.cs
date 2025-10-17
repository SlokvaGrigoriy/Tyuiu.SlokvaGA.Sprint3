using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SlokvaGA.Sprint3.Task3.V26.Lib
{
    public class DataService : ISprint3Task3V26
    {
        public int GetCharCount(string value, char item)
        {
            int count = 0;
            foreach (char letter in value)
            {
                if (letter == item)
                    count++;
            }
            return count;
        }
    }
}
