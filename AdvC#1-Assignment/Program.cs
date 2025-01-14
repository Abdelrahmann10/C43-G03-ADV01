using System.Collections;

namespace AdvC_1
{
    internal class Program
    {


        #region Q 3

        public static void ReverseArrayList(ArrayList list)
        {
            int first = 0;
            int last = list.Count - 1;

            while (first < last)
            {
                object temp = list[first];
                list[first] = list[last];
                list[last] = temp;

                first++;
                last--;
            }

        }

        #endregion


        static void Main(string[] args)
        {



            #region Q 1



            //int[] Numbers = { 5, 3, 4, 2, 1, 7, 8, 8, 6, 2, 10, 9 };

            //Helper<int>.BubbleSort(Numbers);

            //foreach (int Number in Numbers)
            //{
            //    Console.WriteLine(Number);
            //}






            #endregion




            #region Q 2 


            //Range<int> range = new Range<int>( 30, 50 );

            //Console.WriteLine($" Is 30 in the Range?  : {range.IsInRange( 30 )} ");
            //Console.WriteLine($" Is 55 in the Range?  : {range.IsInRange( 55 )} ");
            //Console.WriteLine($" Length of the range  : {  range.Length()     } ");

            //Console.WriteLine("\n===================\n");

            //Range<double> doubleRange = new Range<double>( 5.5, 7.7 );

            //Console.WriteLine($" Is 6.5 the range ?   : {doubleRange.IsInRange(6.5)} "  );
            //Console.WriteLine($" Length of the range  : { doubleRange.Length() }");



            #endregion




            #region Q 3


            //ArrayList list = new ArrayList();

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("====== After Reversing =====");

            //ReverseArrayList( list );

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion




            #region Q 4



            //List<int> list = new List<int>() { 10, 11, 12, 17, 19, 20, 32, 23, 35, 40  };
            //List<int> newList = new List<int>();


            //foreach (var Number in list)
            //{
            //    if (Number % 2 == 0)
            //    {
            //        newList.Add(Number);
            //    }

            //}

            //foreach (var Number in newList)
            //{
            //    Console.WriteLine(Number);

            //}





            #endregion




            #region Q 5



            //FixedSizeList<int> List = new FixedSizeList<int>(6);


            //List.Add(1);
            //List.Add(2);
            //List.Add(3);


            //Console.WriteLine($" Element In Index 1 Is : {List.Get(1)} "  );
            //Console.WriteLine($" Element In Index 4 Is : {List.Get(4)} "  );

            //List.Add(4);
            //List.Add(5);
            //List.Add(6);




            #endregion




            #region Q 6


            //string inputString = " iti ";


            //int result = FirstNonRepeatedCharacter.FindNonRepeatedCharacter(inputString); 

            //if (result != -1)
            //{
            //    Console.WriteLine($" index of the first non-repeated character in the string is : {result} ");
            //}
            //else
            //{
            //    Console.WriteLine(" No non-repeated character in the string ");
            //}


            #endregion



        }
    }
}
