/*
 * Created by SharpDevelop.
 * User: gaoyinheng
 * Date: 2019/11/25
 * Time: 13:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ShapeDemo 
{
	/// <summary>
	/// Description of Circle.
	/// </summary>
	public class Circle : Shape
	{
		private double radius;
		
		//无参构造函数
		public Circle()
		{
		}
		
		public void setRadius(double reaius)
		{
			this.radius = radius ;
		}
	
		public double getRadius()
		{
			return radius ;
		}

	}
}
