using System.Diagnostics;

namespace Task3Model
{

    public class Worcer
    {
        public double AvgArray()
        {
            Trace.Listeners.Add(new TextWriterTraceListener("tr.log"));
            Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine("Время запуска функции: " + DateTime.Now);

            List<double> numbers = new List<double>();
            Console.WriteLine("Введите массив чисел, конец массива заканчивается 0");
            try
            {
                double Sum = 0;
                int count = 0;
                while (true) 
                {
                    double el = Convert.ToDouble(Console.ReadLine());
                    if (el == 0) break;
                    numbers.Add(el);
                    if(el < 0)
                    {
                        Sum += el;
                        count++;
                    }
                }
                return Sum / count;
            }
            catch (Exception ex) 
            {
                Trace.WriteLine("Время: " + DateTime.Now + " Ошибка: " + ex);
                Console.WriteLine($"Ошибка: {ex.Message}");
                throw;
            }
        }

        public bool Polydrom(string str)
        {
            Trace.Listeners.Add(new TextWriterTraceListener("tr.log"));
            Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine("Время запуска функции: " + DateTime.Now);
            try
            {
                Trace.WriteLine("Время запуска функции: " + DateTime.Now);
                Trace.WriteLine($"Исходная строка: '{str}'");
                string revers = "";
                foreach (char c in str)
                {
                    revers = c + revers;  
                }
                if (revers == str) return true;
                else return false;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Время: " + DateTime.Now + " Ошибка: " + ex);
                Console.WriteLine($"Ошибка: {ex.Message}");
                throw;
            }
        }


        public string Letters(string str1, string str2)
        {
            Trace.Listeners.Add(new TextWriterTraceListener("tr.log"));
            Trace.Listeners.Add(new ConsoleTraceListener());
            Trace.WriteLine("Время запуска функции: " + DateTime.Now);
            try
            {
                Trace.WriteLine("Время запуска функции: " + DateTime.Now);
                Trace.WriteLine($"Исходные строки: {str1}, {str2}");
                string letters = "";

                for (int i = 0; i < str1.Length; i++)
                {
                    for (int j = 0; j < str2.Length; j++)
                    {
                        if (str1[i] == str2[j] && !letters.Contains(str2[j])) letters += str2[j] + " ";
                    }
                }
                return letters;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Время: " + DateTime.Now + " Ошибка: " + ex);
                Console.WriteLine($"Ошибка: {ex.Message}");
                throw;
            }
        }
    }
}
