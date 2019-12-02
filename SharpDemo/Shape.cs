/*
 * Created by SharpDevelop.
 * User: gaoyinheng
 * Date: 2019/11/25
 * Time: 13:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ShapeDemo
{
	/// <summary>
	/// Description of Shpe.
	/// </summary>
	public class Shape
	{
		protected double x;
		protected double y;
		
		public Shape()
		{
		}
		
		public void setX(double x)
		{
			this.x = x ;
		}
		
		public void setY(double y)
		{
			this.y = y ;
		}
		
		public double getX()
		{
			return x ;
		}
		
		public double getY()
		{
			return y ;
		}
		
		public double distance(Shape s)
		{
			return Math.Sqrt((x-s.x)*(x-s.x)+(y-s.y)*(y-s.y));
		}
	}
}
