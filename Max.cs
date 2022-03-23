namespace Algorithms
{
    public static class Max
    {
        /// <summary>
        /// Get largest value from integer array
        /// </summary>
        /// <param name="array">Integer array</param>
        /// <returns>Largest value from array</returns>
        public static int GetMax(int[] array)
        {
            var tempMax = 0;
            foreach (var item in array)
            {
                if (tempMax < item)
                    tempMax = item;
            }

            return tempMax;
        }
    }
}