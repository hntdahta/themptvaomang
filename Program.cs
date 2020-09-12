using System;
using System.Text;
namespace themptvaomang
{
    class Program
    {
        
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] arr = { 10, 4, 6, 7, 8 };
            int x, k;
            NhapXK(out x, out k, arr.Length);
            Console.WriteLine("Mảng trước khi chèn: ");
            HienMang(arr, arr.Length - 1);
            Chen(arr, x, k);
            Console.WriteLine("Mảng sau khi chèn: ");
            HienMang(arr, arr.Length);
        }

        private static void Chen(int[] arr, int x, int k)
        {
            for (int i = arr.Length - 1; i > k; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[k] = x;
        }

        static void HienMang(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void NhapXK(out int x, out int k, int n)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập x: ");
            x = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("Nhập vị trí index cần chèn: 0 <= index < {n}");
                k = Convert.ToInt32(Console.ReadLine());
                if (k >= 0 && k < n)
                {
                    Console.WriteLine("Không chèn được phần tử vào mảng");
                    break;
                }
            }
        }
    }
}