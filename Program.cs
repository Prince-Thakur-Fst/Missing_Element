using System;

namespace MissingElement
{
    class Program
    {
        static void Main(string[] args)
        {       
            
            Console.WriteLine("Enter the Size of an Array");
            int size=Convert.ToInt32(Console.ReadLine());
            int [] n=new int[size];
            int sum=0;
            for (int i = 0; i < n.Length-1; i++)
            {
                Console.WriteLine("Enter the"+ i +" Element of an Array");
                n[i]=Convert.ToInt32(Console.ReadLine());
                sum=sum+n[i];
            }

        
          int m=n.Length;
          int total=m*(m+1)/2;
          Console.WriteLine("Missing element = "+(total-sum));

        }
    }
}
