namespace task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Byte  : {byte.MinValue} -- {byte.MaxValue}\n"
                + $"Int16 : {Int16.MinValue} -- {Int16.MinValue}\n"
                + $"UInt16: {UInt16.MinValue} -- {UInt16.MaxValue}\n" +
                $"char  : {(int)char.MinValue} -- {(int)char.MaxValue}\n" +
                $"Int32 : {Int32.MinValue} -- {Int32.MaxValue}\n" +
                $"UInt32: {UInt32.MinValue} -- {UInt32.MaxValue}\n" +
                $"Int64 : {Int64.MinValue} --  {Int64.MaxValue}\n" +
                $"System.Single(float) {System.Single.MinValue} -- {System.Single.MaxValue}\n" +
                $"System.Double(float) {System.Double.MinValue} -- {System.Double.MaxValue}\n" +
                $"System.Decimal {System.Decimal.MinValue} -- {System.Decimal.MaxValue}");
        }
    }
}