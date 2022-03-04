using System;

namespace degisken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            sbyte sb = 2;

            short sh = 3;
            ushort us = 4;

            Int16 i16 = 5;
            Int32 i32 = 7;
            Int64 i64 = 8;

            int i = 6;
            uint ui = 9;

            long l = 10;
            ulong k = 11;

            float f = 12;
            double d = 13;
            decimal dc = 14;



            string s = "ab";


            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;

            object oa = "16";
            object ob = "ab";
            object oc = 17;
            object od = 18;
            object oe = 18.1;


            string s1 = string.Empty;
            s1 = "deneme";

            bool b3 = 3 > 5;

            string s5 = "20";
            int i5 = 20;
            string ns = s5 + i5.ToString();
            int er = i5 + Convert.ToInt32(s5);


            int i10 = i5 + int.Parse(s5);

        }
    }
}