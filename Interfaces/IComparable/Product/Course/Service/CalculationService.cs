namespace Course.Service
{
    internal class CalculationService
    {
        public T Max <T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
                throw new Exception("List void. ");

            T max = list[0];

            foreach (T item in list)
            {
                if (item.CompareTo(max) > 0)
                    max = item;
            }
            return max;
        }

    }
}
