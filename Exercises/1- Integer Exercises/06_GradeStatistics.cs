namespace Exercises
{
    public class GradeStatistics
    {
        public static void Solution1()
        {
            Console.WriteLine("Cálculo da maior da menor nota\n");
            Console.Write("Digite o número de notas: ");
            
            int n = int.Parse(Console.ReadLine());

            int i = 0;

            int highest_grade = -1;

            int lowest_grade = 101;

            while (i < n)
            {
                Console.Write("Digite uma nota (inteiro de 0 a 100): ");
                int grade = int.Parse(Console.ReadLine());
                i = i + 1;

                if (grade < lowest_grade)
                {
                    lowest_grade = grade;
                }

                if (grade > highest_grade)
                {
                    highest_grade = grade;
                }
            }

            Console.WriteLine("A maior nota foi {0}", highest_grade);
            Console.WriteLine("A menor nota foi {0}", lowest_grade);
        }
    }
}