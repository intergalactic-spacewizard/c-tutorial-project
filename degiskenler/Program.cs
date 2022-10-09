using System;
namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 255; // 1byte
            sbyte s = -128; // 1byte

            short shrt = 32767; // 2byte
            ushort ushrt = 65365; //2byte

            Int16 i16 = 2;   //2byte
            int i = 5; //4byte
            Int32 i32 = 5; //4byte
            Int64 i64 = 8; //8byte

            uint ui = 5; //4byte
            long lng = -50000000; //8byte
            ulong ulng = 500000000; //8btyte

            float f = 5.4f; //4byte;
            double db = 5.12512089569162321354; // 8byte
            decimal dcml = 221566584847773228; //16byte

            char ch = '5'; // 2byte
            string str = "1203u102asdfasd"; //unlimited

            bool b00l = true;
            Boolean test = false;
            DateTime dt = DateTime.Now;

            object on5 = "test";
            object ctwo = 'c';
            object ftob = 5.2;
            object unnullobj = 11234.24d;


            //strings
            string strt = string.Empty;

            string str2 = "20";

            int i2 = 20;

            string tests = str2 + i2;

            int int21 = i2 + Convert.ToInt32(b00l);
            Console.WriteLine("Bool to int:  " + int21);

            Console.WriteLine(dt);

            int i10 = int21 + int.Parse(str2);


            string dateTime = DateTime.Now.ToString("dd/mm/yyyy - hh:mm");

            if (b00l)
            {
                Console.WriteLine(ch + str + (decimal)(b + s + shrt + ushrt + i16 + i + i32 + i64 + ui + (lng + (long)ulng) + f + db) + dcml);
            }
            if (!test)
            {
                Console.WriteLine(bool.TrueString);
            }
            Console.WriteLine(dateTime);
        }
    }
}