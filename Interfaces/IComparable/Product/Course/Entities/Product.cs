namespace Course.Entities
{
    internal class Product : IComparable
    {
        public string name { get; set; }
        public double price { get; set; }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return $"{name}, {price}";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product))
                throw new ArgumentException("Argument is not Product");

           Product other = obj as Product;

            return price.CompareTo(other.price);
        }
    }
}
