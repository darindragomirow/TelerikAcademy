using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Delegates_LINQ
{
    class StudentLINQ
    {
        public static List<Student> list = new List<Student> {
            new Student("std1@abv.bg","12313523","Dimitar",2,"Dimitrow",new List<double>(),"08835123123",20),
            new Student("std2@abv.bg","12124124","Iwan",2,"Iwanow",new List<double>(),"08238138",20),
            new Student("std3@abv.bg","113123","Petyr",53,"Petrow",new List<double>(),"08138138",17)   
        };


        public static void FristBeforeLast()
        {
            
            var std = from student in list
                      where string.Compare(student.FirstName, student.LastName) > 0
                      select student;
            
            foreach(var student in std)
            {
                Console.WriteLine(student.FirstName+" ",student.LastName);
            }
        }

        public static void AgeRange()
        {
            var std = from student in list
                      where student.Age >= 18 && student.Age <= 24
                      select student;

            foreach(var student in std)
            {
                Console.WriteLine(student.FirstName+" "+student.LastName);
            }
        }

        public static void OrderStudentsLambda()
        {
            var std = list.OrderByDescending(student => student.FirstName)
                .OrderByDescending(student => student.LastName);
            foreach(var student in std)
            {
                Console.WriteLine(student.FirstName+" "+student.LastName);
            }
        }

        public static void OrderStudentsLINQ()
        {
            var std = from student in list
                      orderby student.FirstName descending
                      orderby student.LastName descending
                      select student;
            foreach (var student in list)
            {
                Console.WriteLine(student.FirstName+" "+student.LastName);
            }
        }

        public static void DivisibleBy7and3(int[] array)
        {
            var numbers = array.Where(num => (num / 7 == 0) && (num / 3 == 0));
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            } 
        }

        public static List<Student> GroupStudents(List<Student> list)
        {
            var group2 = list.Where(student => student.GroupNumber == 2).ToList();
            return group2;
        }    
        
        public static List<Student> ExtractFromEmail(List<Student> list)
        {
            var emails = from student in list
                         where student.Email.IndexOf("abv.bg") != -1
                         select student;
            var result = new List<Student>();
            foreach(var student in emails)
            {
                result.Add(student);
            }
            return result;
                        
            
        }

        public static List<Student> ExtractFromPhone(List<Student> list)
        {
            var emails = from student in list
                         where student.Email.Substring(0,2).IndexOf("02") != -1
                         select student;
            var result = new List<Student>();
            foreach (var student in emails)
            {
                result.Add(student);
            }
            return result;
        }

        public static List<Student> ExcellentMarks(List<Student> list)
        {
            var result = from student in list
                         where student.Marks.Contains(6)
                         select student;
            var resultList = new List<Student>();
            foreach(var std in result)
            {
                resultList.Add(std);
            }
            return resultList;
        }

        //17
        private static bool GetLongestString(string s)
        {
            int maxLength = 0;
            if (s.Length > maxLength)
            {
                maxLength = s.Length;
                return true;
            }

            return false;
        }
        public static string LongestString(string[] array)
        {
            var result =
                   from s in array
                   where GetLongestString(s)
                   select s;

            return result.Last();
        }

        public static List<Student> GroupStudents(List<Student> list)
        {
            var orderedStudents = from st in list
                                  orderby st.GroupNumber
                                  select st;

            var result=new List<Student>();
            foreach(var student in orderedStudents)
            {
                result.Add(student);
            }
            return result;

        }

    }

}
