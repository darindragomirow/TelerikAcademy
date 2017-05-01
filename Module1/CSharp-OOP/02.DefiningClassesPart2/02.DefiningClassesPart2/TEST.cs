using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DefiningClassesPart2
{
        [Version("2.11")]
    class TEST
    {
        public static void Main(string[] args)
        {
            //Testing GenericList
            var testList = new GenericList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            Console.WriteLine(testList.ToString());

            testList.RemoveAt(3);
            Console.WriteLine(testList.ToString());

            testList.InsertAtIndex(10, 2);
            Console.WriteLine(testList.ToString());

            Console.WriteLine(testList.IndexOf(10));

            testList.InsertAtIndex(10,3);
            Console.WriteLine(testList.ToString());

            testList.InsertAtIndex(10, 0);
            Console.WriteLine(testList.ToString());



          


            Console.WriteLine();
            Console.WriteLine();
            




            //Testing Matrixes
            Matrix<int> testMatrix1 = new Matrix<int>(2, 3);

            testMatrix1[0, 0] = 1;
            testMatrix1[0, 1] = 2;
            testMatrix1[0, 2] = 3;

            testMatrix1[1, 0] = 4;
            testMatrix1[1, 1] = 5;
            testMatrix1[1, 2] = 6;

            Matrix<int> testMatrix2 = new Matrix<int>(3, 2);

            testMatrix2[0, 0] = 7;
            testMatrix2[0, 1] = 8;

            testMatrix2[1, 0] = 9;
            testMatrix2[1, 1] = 10;

            testMatrix2[2, 0] = 11;
            testMatrix2[2, 1] = 12;

            Matrix<int> result = testMatrix1 * testMatrix2;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0,4}", result[i, j] + " ");
                }
                Console.WriteLine();

            }

            Point3d p1 = new Point3d();
            Point3d.Point3D point=new Point3d.Point3D(1,2,3);
            
           
            


            var programVersion = typeof(TEST).GetCustomAttributes(false);

            foreach (var item in programVersion)
            {
                var version = (VersionAttribute)item;
                Console.WriteLine("Version:"+version.version);
            }
        }
    }
}
