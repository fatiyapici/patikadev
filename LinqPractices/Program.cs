using System;
using System.Linq;
using LinqPractices.DbOperations;
using LinqPractices.Entities;

namespace LinqPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            DataGenerator.Initialize();
            LinqDbContext _context = new LinqDbContext();
            var students = _context.Students.ToList<Student>();

            //Find()
            System.Console.WriteLine("*** Find ***");
            var student = _context.Students.Where(student => student.StudentId == 1).FirstOrDefault();
            student = _context.Students.Find(1);
            System.Console.WriteLine(student.Name);
            // Find metodu icerisindeki aldigi parametreye gore listenin elemanini getirir.

            //FirstOrDefault()
            System.Console.WriteLine("*** FirstOrDefault ***");
            student = _context.Students.Where(student => student.Surname == "Arda").FirstOrDefault();
            System.Console.WriteLine(student.Name);

            student = _context.Students.FirstOrDefault(x => x.Surname == "Arda");
            System.Console.WriteLine(student.Name);
            // FirstOrDefault metodu where kosulunda istenileni bulamadiginda null doner. First metodunda ise hata firlatir.

            //SingleOrDefault()
            System.Console.WriteLine("*** SingleOrDefault ***");
            student = _context.Students.SingleOrDefault(student => student.Name == "Deniz");
            // SingleOrDefault metodunda sorgu sonunda kalan tek veriyi dondurur. Birden fazla eleman varsa hata firlatir. Eleman yoksa null doner.

            //ToList()
            System.Console.WriteLine("*** ToList ***");
            var studentList = _context.Students.Where(student => student.ClassId == 2).ToList();
            System.Console.WriteLine(studentList.Count);
            // ToList metodunda verilen parametreye iliskin ayni degere sahip elemanlardan liste olusturulur.

            //OrderBy()
            System.Console.WriteLine("*** OrderBy ***");
            students = _context.Students.OrderBy(x => x.StudentId).ToList();
            foreach (var st in students)
            {
                System.Console.WriteLine(st.StudentId + " -> " + st.Name + " " + st.Surname);
            }
            // OrderBy metodunda liste istenilen degiskene gore siralanarak yeniden liste olusturulmasidir.

            //OrderByDescending()
            System.Console.WriteLine("*** OrderByDescending ***");
            students = _context.Students.OrderByDescending(x => x.StudentId).ToList();
            foreach (var st in students)
            {
                System.Console.WriteLine(st.StudentId + " -> " + st.Name + " " + st.Surname);
            }
            // OrderBy metodunun tersini gerceklestirir.

            // Anonymous Object Result
            System.Console.WriteLine("*** Anonymous Object Result ***");

            var anonymousObject = _context.Students.Where(x => x.ClassId == 2)
                                .Select(x => new
                                {
                                    Id = x.StudentId,
                                    fullName = x.Name + " " + x.Surname
                                });
            foreach (var obj in anonymousObject)
            {
                System.Console.WriteLine(obj.Id + " -> " + obj.fullName);
            }

        }
    }
}
