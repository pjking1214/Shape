/*
 * Created by SharpDevelop.
 * User: gaoyinheng
 * Date: 2019/12/2
 * Time: 10:19
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ShapeDemo
{
	/// <summary>
	/// Description of Triangle.
	/// </summary>
	public class Triangle : Shape
	{
		private double width;
		
		public void setWidth(double width)
		{
			this.width=width ;
		}
		
		public double getWidth()
		{
			return width ;
		}
		
		public Triangle()
		{
			
		}
		
		public override double Area()
		{
			return    width * width * Math.Sin(Math.PI/3) / 2 ;
		}
	}
}
