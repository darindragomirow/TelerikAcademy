using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StudentsAndWorkers
{
    public class ListOfStudents
    {
        static void Main(string[] args)
        {
            var students = new List<Student>(){
                new Student("Iwan","Dimitrow",5),
                new Student("Qnislaw","Stoichew",5),
                new Student("Teodor","Kirilow",3),
                new Student("Petko","Toshew",4),
                new Student("Georgi","Iwanow",6),
                new Student("Dobromir","Iwanow",4),
                new Student("Stefan","Petrow",2),
                new Student("Georgi","Iwanow",6),
                new Student("Stewen","Iwanow",10),
                new Student("Georgi","Georgiew",10)
            };
            var workers=new List<Worker>()
            {
                new Worker("Iwan","Petrow",120,8),
                new Worker("Qnislaw","Dimitrow",200,8),
                new Worker("Teodor","Stoikow",250,10),
                new Worker("Petko","Kirilow",160,4),
                new Worker("Georgi","Toshew",200,8),
                new Worker("Dobromir","Stefanow",170,7),
                new Worker("Stefan","Stefanow",160,5),
                new Worker("Georgi","Goshew",100,3),
                new Worker("Stewen","Mihailow",300,10),
                new Worker("Georgi","Petrow",320,10)
            };

            //Sorting students by grade
            var orderedList = students.OrderByDescending(student => student.grade).ToList();
            foreach(var item in orderedList)
            {
                Console.WriteLine(item.firstName+" "+item.lastName+" "+item.grade);
            }

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            //Sorting workers by Money Per Hour
            var workerList = workers.OrderByDescending(worker => worker.MoneyPerHour()).ToList();
            foreach(var worker in workerList)
            {
                Console.WriteLine(worker.firstName+" "+worker.lastName+" "+worker.MoneyPerHour());
            }
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            //Merging lists and sorting them by FirstName and LastName
            var mergeList = new List<Human>(students);
            foreach(var worker in workers)
            {
                mergeList.Add(worker);
            }

            var sortedList = mergeList.OrderBy(human => human.firstName)
                .ThenBy(human => human.lastName).ToList();
           foreach(var human in sortedList)
           {
               Console.WriteLine(human.firstName+" "+human.lastName);
           }

        }
    }
}
