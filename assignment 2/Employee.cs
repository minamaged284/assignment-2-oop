namespace assignment_2
{
    public class Employee
    {
        int Id;
        string Name;
        Security SecurityLevel;
        decimal Salary;
        HiringDate HiringDate;
        Gender Gender;

        public int id { get; set; }
        public string name { get; set; }
        public Security security { get; set; }
        public decimal salary { get; set; }
        public HiringDate hiringDate { get; set; }
        Gender gender { get; set; }
  
        public Employee()
        {
            
        }

        public Employee(int _id, string _name, decimal _salary, int  _day,  int  _month,  int  _year,Gender _gender)
        {
            id = _id ;
            name = _name ;
            salary = _salary ;
            hiringDate = new HiringDate() ;
            hiringDate.day = _day ;
            hiringDate.month = _month ;
            hiringDate.year = _year ;
            gender = _gender ;
        }

        public override string ToString()
        {
            return string.Format("{0:C}", salary);
        }

    }
}
