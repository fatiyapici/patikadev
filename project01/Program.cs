
namespace project01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Homepage();
        }

        public class Contacts
        {
            private string name;
            private string surname;
            private long phoneNumber;

            public string Name
            {
                get => name;
                set => name = value ?? throw new ArgumentNullException(nameof(value));
            }

            public string Surname
            {
                get => surname;
                set => surname = value ?? throw new ArgumentNullException(nameof(value));
            }

            public long PhoneNumber
            {
                get => phoneNumber;
                set => phoneNumber = value;
            }

            public static List<Contacts> ContactsList = new List<Contacts>()
            {
                new Contacts()
                {
                    Name = "Fatih",
                    Surname = "Yapici",
                    PhoneNumber = 5555555555
                },
                new Contacts()
                {
                    Name = "Burak",
                    Surname = "Has",
                    PhoneNumber = 4444444444
                },
                new Contacts()
                {
                    Name = "Baran",
                    Surname = "Tay",
                    PhoneNumber = 3333333333
                },
                new Contacts()
                {
                    Name = "Murat",
                    Surname = "Kara",
                    PhoneNumber = 2222222222
                },
                new Contacts()
                {
                    Name = "Sultan",
                    Surname = "Goz",
                    PhoneNumber = 1111111111
                }
            };
        }

        public static void Homepage()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz\n" +
                              "(1) Yeni Numara Kaydetmek\n" +
                              "(2) Varolan Numarayı Silmek\n" +
                              "(3) Varolan Numarayı Güncelleme\n" +
                              "(4) Rehberi Listelemek\n" +
                              "(5) Rehberde Arama Yapmak");
            string input = Console.ReadLine();
            int selection;
            bool isValidInput = int.TryParse(input, out selection);
            if (isValidInput)
            {
                switch (selection)
                {
                    case 0:
                        break;
                    case 1:
                        AddContact();
                        Homepage();
                        break;
                    case 2:
                        DeleteContact();
                        Homepage();
                        break;
                    case 3:
                        UpdateNumber();
                        Homepage();
                        break;
                    case 4:
                        ShowDirectory();
                        Homepage();
                        break;
                    case 5:
                        SearchDirectory();
                        Homepage();
                        break;
                    default:
                        Homepage();
                        break;
                }
            }
        }

        private static void AddContact()
        {
            Contacts contact = new Contacts();
            Console.WriteLine("Lütfen isim giriniz:");
            contact.Name = Console.ReadLine();
            string nameHead = contact.Name.Substring(0, 1).ToUpper();
            string nameRemainder = contact.Name.Substring(1).ToLower();
            contact.Name = nameHead + nameRemainder;
            Console.WriteLine("Isim : " + contact.Name);
            Console.WriteLine("Lütfen soyisim giriniz:");
            contact.Surname = Console.ReadLine();
            string surnameHead = contact.Surname.Substring(0, 1).ToUpper();
            string surnameRemainder = contact.Surname.Substring(1).ToLower();
            contact.Surname = surnameHead + surnameRemainder;
            Console.WriteLine("Soyisim : " + contact.Surname);
            Console.WriteLine("Lütfen telefon numarasını giriniz:");
            contact.PhoneNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Telefon no : " + contact.PhoneNumber);
            Contacts.ContactsList.Add(contact);
        }

        private static void DeleteContact()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz");
            string input = Console.ReadLine();
            input = input.ToLower();
            foreach (var person in Contacts.ContactsList)
            {
                person.Name = person.Name.ToLower();

                if (String.Equals(input, person.Name) || String.Equals(input, person.Surname))
                {
                    person.Surname.ToLower();
                    Console.WriteLine("{0} {1} adlı kişiyi rehberden silmek istiyor musunuz? (y/n) ", person.Name,
                        person.Surname);
                    char confirmation = char.Parse(Console.ReadLine().ToLower());
                    while (confirmation != 'y' && confirmation != 'n')
                    {
                        Console.WriteLine("Lütfen evet için 'y' hayır için 'n' giriniz.");
                        confirmation = char.Parse(Console.ReadLine().ToLower());
                    }

                    if (confirmation == 'y')
                    {
                        Contacts.ContactsList.Remove(person);
                        Console.WriteLine(person.Name + " rehberden silindi.");
                        Homepage();
                    }
                    else if (confirmation == 'n')
                    {
                        Homepage();
                    }
                }
                else
                {
                    Console.WriteLine(
                        "Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n" +
                        "* Silmeyi sonlandırmak için : (1)\n" +
                        "* Yeniden denemek için      : (2)");
                    int choice;
                    string finishOrTry = Console.ReadLine();
                    bool choiceVerification = int.TryParse(finishOrTry, out choice);
                    while (!choiceVerification && !(choice == 1 || choice == 2))
                    {
                        Console.WriteLine("Lütfen geçerli bir seçim yapınız.\n" +
                                          "* Silmeyi sonlandırmak için : (1)\n" +
                                          "* Yeniden denemek için      : (2)");
                        finishOrTry = Console.ReadLine();
                        choiceVerification = int.TryParse(finishOrTry, out choice);
                    }

                    if (choice == 1)
                        Homepage();
                    else
                        DeleteContact();
                }
            }
        }

        private static void UpdateNumber()
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz.");
            string input = Console.ReadLine();
            input = input.ToLower();
            foreach (var person in Contacts.ContactsList)
            {
                person.Name = person.Name.ToLower();
                person.Surname = person.Surname.ToLower();
                if (String.Equals(person.Name, input) || String.Equals(person.Surname, input))
                {
                    Console.WriteLine("Lütfen yeni telefon numarasını giriniz.");
                    string phoneNumber = Console.ReadLine();
                    long newPhoneNumber;
                    bool phoneNumberIsParsed = long.TryParse(phoneNumber, out newPhoneNumber);
                    while (!phoneNumberIsParsed)
                    {
                        Console.WriteLine(
                            "Telefon numarası sayılardan oluşmalıdır." +
                            " Lütfen telefon numarasını tekrar giriniz.");
                        phoneNumber = Console.ReadLine();
                        phoneNumberIsParsed = long.TryParse(phoneNumber, out newPhoneNumber);
                    }

                    person.PhoneNumber = newPhoneNumber;
                    Console.WriteLine("Telefon numarası başarıyla güncellendi.");
                }
                else
                {
                    Console.WriteLine(
                        "Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.\n" +
                        "* Güncellemeyi sonlandırmak için    : (1)\n" +
                        "* Yeniden denemek için              : (2)");
                    int confirmatory;
                    bool isConfirmationIsValid;
                    do
                    {
                        string confirmationInput = Console.ReadLine();
                        isConfirmationIsValid = int.TryParse(confirmationInput, out confirmatory);
                        isConfirmationIsValid = isConfirmationIsValid && (confirmatory == 1 || confirmatory == 2);
                        if (!isConfirmationIsValid)
                            Console.WriteLine("Hatalı giriş yaptınız. Lütfen tekrar seçim yapınız.\n" +
                                              "* Güncellemeyi sonlandırmak için    : (1)\n" +
                                              "* Yeniden denemek için              : (2)");
                    } while (!isConfirmationIsValid);

                    if (confirmatory == 1)
                        Homepage();
                    else if (confirmatory == 2)
                        UpdateNumber();
                }
            }
        }

        private static void ShowDirectory()
        {
            Console.WriteLine("Telefon Rehberi\n" +
                              "**********************************************");
            foreach (var person in Contacts.ContactsList)
            {
                Console.WriteLine("isim: {0}\nSoyisim: {1}\nTelefon numarası: {2}\n-",
                    person.Name, person.Surname, person.PhoneNumber);
            }

            Console.WriteLine(".");
        }

        private static void SearchDirectory()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.\n" +
                              "**********************************************\n " +
                              " \n" +
                              "İsim veya soyisime göre arama yapmak için: (1)\n" +
                              "Telefon numarasına göre arama yapmak için: (2)");
            int selection;
            bool searchSelectionIsValid;
            do
            {
                string input = Console.ReadLine();
                searchSelectionIsValid = int.TryParse(input, out selection);
                searchSelectionIsValid = searchSelectionIsValid && (selection == 1 || selection == 2);
                if (!searchSelectionIsValid)
                {
                    Console.WriteLine("Geçersiz giriş yaptınız. Lütfen seçiminizi tekrar giriniz.");
                }
            } while (!searchSelectionIsValid && !(selection == 1 || selection == 2));


            if (selection == 1)
            {
                Console.WriteLine("Lütfen aramak istediğiniz kişinin ismi ya da soyismini giriniz.");
                int finderCounterByNameOrSurname = 0;
                string searchWithNameOrSurname = Console.ReadLine();
                searchWithNameOrSurname = searchWithNameOrSurname.ToLower();
                Console.WriteLine("Arama Sonuçlarınız: \n" +
                                  "**********************************************");
                foreach (var person in Contacts.ContactsList)
                {
                    person.Name = person.Name.ToLower();
                    if (String.Equals(searchWithNameOrSurname, person.Name) ||
                        String.Equals(searchWithNameOrSurname, person.Surname))
                    {
                        Console.WriteLine("isim: {0}\nSoyisim: {1}\nTelefon numarası: {2}\n-",
                            person.Name, person.Surname, person.PhoneNumber);
                        finderCounterByNameOrSurname++;
                    }
                }

                if (finderCounterByNameOrSurname == 0)
                {
                    Console.WriteLine("Aradığınız isim ve soyisimde kişi bulunamadı.");
                }
            }
            else if (selection == 2)
            {
                Console.WriteLine("Lütfen aramak istediğiniz kişinin telefon numarasını giriniz.");
                int finderCounterByNumber = 0;
                string searchByNumberInput = Console.ReadLine();
                int searchedNumber;
                bool isNumberValid = int.TryParse(searchByNumberInput, out searchedNumber);
                Console.WriteLine("Arama Sonuçlarınız: \n" +
                                  "**********************************************");
                if (isNumberValid)
                {
                    foreach (var person in Contacts.ContactsList)
                    {
                        if (searchedNumber == person.PhoneNumber)
                        {
                            Console.WriteLine("isim: {0}\nSoyisim: {1}\nTelefon numarası: {2}\n-",
                                person.Name, person.Surname, person.PhoneNumber);
                            finderCounterByNumber++;
                        }
                    }

                    if (finderCounterByNumber == 0)
                    {
                        Console.WriteLine("Aradığınız numara ile kişi bulunamadı.");
                    }
                }
            }
        }
    }
}