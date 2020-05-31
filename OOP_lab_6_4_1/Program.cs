using System;

namespace OOP_lab_6_4_1
{
    class Program : IProgram
    {
        static void Main(string[] args)
        {
            new Program().Write();
        }

        public void Write()
        {
            Console.Write("Кiлькiсть записiв: ");

            int n = int.Parse(Console.ReadLine());

            Results[] work = new Results[n];

            Console.WriteLine("{0, -10} {1, -30} {2, -50}", "Мiсяць", "План випуску продукцiї", "Фактичний випуск продукцiї");

            string str;

            for (int i = 0; i < n; ++i)
            {
                str = Console.ReadLine();

                work[i] = new Results(str);
            }

            int difference = 0;

            Console.WriteLine("\nНедовиконано:");

            Console.WriteLine("{0, -10} {1, -30} {2, -50}", "Мiсяць", "План випуску продукцiї", "Фактичний випуск продукцiї");

            for (int i = 0; i < n; ++i)
            {
                difference = Results.Compare(work[i].PlannedProductivity, work[i].Productivity);

                if (difference > 0)
                {
                    Console.WriteLine("{0, -10} {1, -30} {2, -50}", work[i].Month, work[i].PlannedProductivity, work[i].Productivity);
                }
            }
        }
    }
}
