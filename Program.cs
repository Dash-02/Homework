using System;

namespace ПР9_2ИСП2_Сейдалиев_Семиволос
{
	class MainClass
	{
		static double  z1(double m1, double m2) //задача 1
		  
		{
			if(m1 < m2) return m1;
			else  return m2;
			
		}
		static void  z2() //задача 2
		  
		{	int y;
			if (x < -12)
				{ 
				y = 2/(x-7);
				Console.WriteLine("y = " +  y);
				}
			else
			{
				if  (x > -12  && x < 12)
				{
					y = Math.Sqrt(x + 20);
					Console.WriteLine("y = " +  y);
				}
				
				else
				{
					y = 1/(15-x)+1;
					Console.WriteLine("y = " +  y);
				}
			}
			
		}
		
		public static void Main (string[] args)
		{
			Console.WriteLine("Введите номер задачи ");
			int n = Convert.ToInt32(Console.ReadLine());
			double k1;
			switch (n)
			{
			 case 1: 
			    Console.WriteLine("Введите два числа ");
			    double a = Convert.ToDouble(Console.ReadLine());
			    double b = Convert.ToDouble(Console.ReadLine());
				k1 = z1(a, b);
				Console.WriteLine("Меньшее значение " +k1);
				break;
			case 2:
				Console.WriteLine("Введите x ");
			    int x = Convert.ToInt32(Console.ReadLine());
				z2(x);
				break;
			}
			Console.ReadKey();
		}
	}
}
