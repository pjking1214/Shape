/*
 * Created by SharpDevelop.
 * User: gaoyinheng
 * Date: 2019/11/25
 * Time: 10:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SharpDemo
{
	class Program
	{
		public static void Main(string[] args)
		{
			Circle c1 = new Circle();
			Circle c2 = new Circle();
			c1.setX(1);
			c1.setY(2);
			c1.setRadius(3);
			c2.setX(4);
			c2.setY(5);
			c2.setRadius(6);
			double disc = c1.distance(c2);
			Console.WriteLine("disc="+disc);
			
			Square s1 = new Square();
			Square s2 = new Square();
			s1.setX(7);
			s1.setY(8);
			s1.setEdge(9);
			s2.setX(10);
			s2.setY(11);
			s2.setEdge(12);
			double disc2 = s1.distance(s2);
			Console.WriteLine("disc2="+disc2);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}