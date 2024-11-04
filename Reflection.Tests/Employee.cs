using static Reflection.ReflectionOperations;

namespace Reflection.Tests
{
    [AllowPrivateAccess]
    public class Employee(int id, string name, int age, string role, int salaryPerAnnum, int salaryPerYear) : IEmployee
    {
        public int Id { get; set; } = id;

        public string Name { get; set; } = name;

        public int Age { get; set; } = age;

        public string Role { get; set; } = role;

        public int SalaryPerAnnum { get; set; } = salaryPerAnnum;

        public int SalaryPerYear { get; set; } = salaryPerYear;

        public string GetOrganizationName()
        {
            string orgName = "EPAM";
            Console.WriteLine(orgName);
            return orgName;
        }

        public string GetDetails()
        {
            Console.WriteLine("Id: " + this.Id);
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Age: " + this.Age);
            Console.WriteLine("Role: " + this.Role);
            Console.WriteLine("Salary per Annum: " + this.SalaryPerAnnum);
            return this.Id + this.Name + this.Age + this.SalaryPerAnnum;
        }

        public int GetSalaryPerMonth()
        {
            Console.WriteLine("Salary per Month: " + (this.SalaryPerAnnum / 12));
            return this.SalaryPerAnnum / 12;
        }
    }
}
