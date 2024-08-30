using System.Globalization;
namespace Course
{
    class Employee : IComparable
    {
        public string name { get; set; }
        public double salary { get; set; }

        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            name = vect[0];
            salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return $"{name},{salary}";
        }
        public int CompareTo(object obj)
        {
            if (!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }

            Employee other = obj as Employee;

            return name.CompareTo(other.name); // salary.CompareTo(other.salary);
        }
    }
}