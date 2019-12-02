/*
 * Created by SharpDevelop.
 * User: gaoyinheng
 * Date: 2019/11/25
 * Time: 10:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
 //this is a test
using System;

namespace ShapeDemo
{
	class Program
	{
		
//		//比较两个三角形面积大小，返回较大的面积值
//		public static double MaxArea(Triangle t1,Triangle t2)
//		{
//			if(t1.Area()>t2.Area())
//				return t1.Area();
//			return t2.Area();
//		}
//		
//		//比较两个圆形面积大小，返回较大的面积值
//		public static double MaxArea(Circle c1, Circle c2)
//		{
//			if(c1.Area()>c2.Area())
//				return c1.Area();
//			return c2.Area();
//		}
		
		/*	发现问题，如果图形不断增加，则比较面积的函数需要不断的增加，且后期可能增加1个图形，需要写的函数不止一个（不同图形面积比较）
		 * 因此，我们的想法是，在比较函数中，传递shape类的对象，但是shape类没有area()函数，也无法在shape类中写出area()函数--每个图形面积公式不一样
		 * 由此，引出虚函数概念，虚函数在基类中，用virtual 修饰，在子类中，用override 修饰覆写。
		 * 
		 * 
		 */
		public static double MaxArea(Shape s1, Shape s2)
		{
			if(s1.Area()>s2.Area())
				return s1.Area();
			return s2.Area();
		}
		
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
			
			Console.WriteLine("Area of c1 =" + c1.Area());
			Console.WriteLine("Area of c2 =" + c2.Area());
			Console.WriteLine("c1 with c2,the MAX area is:"+MaxArea(c1,c2));
			
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
			
			Console.WriteLine("Area of s1 =" + s1.Area());
		   Console.WriteLine("Area of s2 =" + s2.Area());
			
			Triangle t1= new Triangle();
			Triangle t2= new Triangle();
			t1.setX(3);
			t1.setY(4);
			t1.setWidth(5);
			t2.setX(4);
			t2.setY(5);
			t2.setWidth(6);
			Console.WriteLine("width="+t1.getWidth());
			
			Console.WriteLine("Area of t1 =" + t1.Area());
			Console.WriteLine("Area of t2 =" + t2.Area());
			Console.WriteLine("t1 with t2,the MAX area is:"+MaxArea(t1,t2));
			
			Console.WriteLine("c1 with t1,the MAX area is:"+MaxArea(c1,t1));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}