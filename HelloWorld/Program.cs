// See https://aka.ms/new-console-template for more information

namespace HelloWorld
{
    class Program {
        public static void Main(string[] args) {
            //int[] array = Readarray();
            //int max = FindMax(array);
            //Console.WriteLine("Max element = " +  max);
            int target = 4;
            int[] arrays = {33,4,5,89,45,23,44,90,65,77,98,66,54,33,12 };
            int BinaryResult = BinarySearch(arrays,target);
            Console.WriteLine("BinaryResult = " + BinaryResult);
        }

        public static int BinarySearch(int[] arrays,int target) { 
            int a = 0;
            int b = arrays.Length - 1;
            while (a <= b) {
                int c = (b - a) / 2 + a;
                int array = arrays[c];
                if (array == target)
                {
                    return c;
                }
                else if (array > target)
                {
                    b = c - 1;
                }
                else {
                    a = c + 1;
                }
            }
            return -1;
        }
        private static int[] Readarray() {
            Console.WriteLine("enter number of elements:");
            string line = Console.ReadLine();
            int count = Int32.Parse(line);

            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("enter element" + i);
                string current = Console.ReadLine();
                array[i] = Int32.Parse(current);

            }
            return array;

        }


        private static int FindMax(int[] array) {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++) {
                if (array[i] > max) {
                   max = array[i];
                }
            }
            return max;
        } 
    }
        
}