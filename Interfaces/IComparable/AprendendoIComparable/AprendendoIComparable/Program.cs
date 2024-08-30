using Course;

namespace AprendendoIComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "teste.csv";

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    list.Add(new Employee(sr.ReadLine()));
                }

                list.Sort(); // Só funciona por causa do IComparable e seu método CompareTo.
            }

            foreach (Employee emp in list)
                Console.WriteLine(emp);



        }
    }
}