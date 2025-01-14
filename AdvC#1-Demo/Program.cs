using System.Security.Cryptography.X509Certificates;
using System.Collections;

namespace AdvC_1_Demo
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Before  Generics
            //int A = 4, B = 5;
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            //Helper.SWAP(ref A, ref B );
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            //Console.WriteLine("==========================");
            //double A = 4, B = 5;
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            //Helper.SWAP(ref A, ref B);
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            //Console.WriteLine("==========================");
            //Point P1 = new Point(1, 2);
            //Point P2 = new Point(2, 3);
            //Console.WriteLine($"P1={P1}");
            //Console.WriteLine($"P2={P2}");
            //Helper.SWAP( ref P1, ref P2 );
            //Console.WriteLine($"P1={P1}");
            //Console.WriteLine($"P2={P2}");
            #endregion

            #region After Generics
            #region Example Swap
            //int A = 4, B = 5; //Boxing
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            //Helper.SWAP<int>(ref A, ref B);
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            Console.WriteLine("=====================");
            //double A = 4, B = 5; //Boxing
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            //Helper.SWAP<double>(ref A, ref B);
            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");
            Console.WriteLine("=====================");
            //Point P1 = new Point(1, 2);
            //Point P2 = new Point(2, 3);
            //Console.WriteLine($"P1={P1}");
            //Console.WriteLine($"P2={P2}");
            //Helper.SWAP<Point>(ref P1, ref P2);
            //Console.WriteLine($"P1={P1}");
            //Console.WriteLine($"P2={P2}");
            #endregion

            #region Example Search
            //int[] Numbers = { 2, 3, 4, 5, 6, 7, 1, 23, 12 };

            //int Index = Helper<int>.SearchArray(Numbers, 20);

            //Console.WriteLine(Index);

            //Employee Emp2 = new Employee(1, "Ahmed", 12000);
            //Employee Emp1 = new Employee(1, "Ahmed", 12000);
            //Employee Emp3 = new Employee(3, "Omar", 8000);


            //Employee[] employees =
            //{
            //    Emp1 ,Emp2 , Emp3
            //};


            //int Position = Helper<Employee>.SearchArray(employees, Emp3);
            #endregion

            #region Example Bubble Sprt
            //int[] Numbers = { 1, 2, 3, 4, 5, 6 };
            //Helper<int>.BubbleSort(Numbers);
            //foreach (int number in Numbers)
            //{
            //   Console.WriteLine(number);
            //}
            //--------------------------------
            //Employee employee1 = new Employee(10, "Abdelrahman", 6000);
            //Employee employee2 = new Employee(20, "Sherif", 7000);
            //Employee employee3 = new Employee(30, "Said", 5000);
            //Employee[] employees =
            //{
            //    employee1, employee2 , employee3
            //};
            #endregion

            //Point[] points =
            //{
            //    new Point(3,5),
            //    new Point(4,5),
            //    new Point(6,5),
            //    new Point(7,5)
            //};
            //Employee employee1 = new Employee(10, "Abdelrahman", 6000);
            //Employee employee2 = new Employee(20, "Sherif", 7000);
            //Employee employee3 = new Employee(30, "Said", 5000);
            //Employee[] employees =
            //{
            //    employee1, employee2 , employee3
            //};
            //Helper<Point>.BubbleSort(points);
            //foreach(Point point in points)
            //{
            //    Console.WriteLine(point);
            //}
            //Helper<Employee>.BubbleSort(employees);



            #endregion
        }
    }
}
