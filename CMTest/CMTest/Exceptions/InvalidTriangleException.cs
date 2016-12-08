namespace CMTest.Exceptions
{
    using System;

    public class InvalidTriangleException : Exception
    {
        public InvalidTriangleException(string message)
            : base(message)
        {
        }
    }
}
