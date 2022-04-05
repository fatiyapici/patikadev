namespace Project02
{
    //Program class'ını çok fazla şey için kullanmamak daha iyi
    //Bu şekilde yardımcı metodlarını ilgili bir class'a alırsan
    //düzenlemesi çok daha iyi olur
    public static class InputHelper
    {
        public static int ValidIntInput(int lowerLimit, int higherLimit)
        {
            int output;
            bool isValidInput;
            do
            {
                string input = ValidStringInput();
                isValidInput = int.TryParse(input, out output);
                if (!isValidInput)
                {
                    Console.WriteLine("Geçersiz giriş yaptınız. Lütfen " + lowerLimit + " ile " + higherLimit +
                                      " sayıları arasında seçim yapınız.");
                }
            } while (!isValidInput && !(output >= lowerLimit && output <= higherLimit));

            return output;
        }

        public static int ValidIntInput()
        {
            int output;
            bool isValidInput;
            do
            {
                string input = ValidStringInput();
                isValidInput = int.TryParse(input, out output);
            } while (!isValidInput);

            return output;
        }

        public static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            return char.ToUpper(s[0]) + s.Substring(1);
        }

        //Kullanıcıdan aldığın string inputları kontrol etmeden kullanmışssın
        //ancak kullanıcı doğrudan entera basarsa muhtemmelen yazdığın program
        //hata verecekti, bu yüzden böyle bir metod ekledim
        public static string ValidStringInput()
        {
            string input = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Boş giriş yapılamaz. Lütfen uygun bir değer girin!");
                input = Console.ReadLine();
            }

            return input;
        }
    }
}