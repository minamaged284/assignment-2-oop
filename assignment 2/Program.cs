namespace assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee();
            EmpArr[1] = new Employee();
            EmpArr[2] = new Employee();
            EmpArr[0].security = Security.DBA;
            EmpArr[1].security = Security.guest;
            EmpArr[2].security = Security.DBA | Security.guest|Security.Developer|Security.secretary;

            for (int i = 0; i < EmpArr.Length; i++)
            {
                int empId = 0;
                decimal empSalary = 0;
                int empYear = 0;
                int empMonth = 0;
                int empDay = 0;
                Gender empGender = 0;
                do
                {
                    Console.WriteLine($"enter the id of no {i + 1} employee");
                } while (!int.TryParse(Console.ReadLine(), out  empId));

                Console.WriteLine($"enter the name of no {i + 1} employee");
                string empName = Console.ReadLine();

                do
                {
                    Console.WriteLine($"enter the salary of no {i + 1} employee");
                } while (!decimal.TryParse(Console.ReadLine(), out  empSalary));

         

                do
                {
                    Console.WriteLine($"enter the hiring year of no {i + 1} employee");
                } while (!int.TryParse(Console.ReadLine(), out  empYear) || !(empYear >= 1990 && empYear <= 2024));

                do
                {
                    Console.WriteLine($"enter the hiring month of no {i + 1} employee");
                } while (!int.TryParse(Console.ReadLine(), out  empMonth) || !(empMonth >= 1 && empMonth <= 12));


                do
                {
                    Console.WriteLine($"enter the hiring day of no {i + 1} employee");
                } while (!int.TryParse(Console.ReadLine(), out  empDay) || !(empDay >= 1 && empDay <= 31));



                do
                {
                    Console.WriteLine($"enter the gender of no {i + 1} employee");
                } while (!Gender.TryParse(Console.ReadLine().ToLower(), out  empGender));
                EmpArr[i] = new Employee(empId, empName, empSalary, empDay, empMonth, empYear, empGender);


                Console.WriteLine(EmpArr[i].ToString());
            }
            /* as for part 1 i could not i was no able to do it as i had only 2 free hours to study the lecture and complete the assignment
             due to work related issues. question 7 in this narrow time span i was not able to search for a proper solution.*/



        }
    }
}
