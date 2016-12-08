namespace CMTest
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string str)
        {
            if (str == null)
            {
                return true;
            }

            if (str.Length == 0)
            {
                return true;
            }

            return false;
        }
    }
}
