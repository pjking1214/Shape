/*
 * Created by SharpDevelop.
 * User: gaoyinheng
 * Date: 2019/11/25
 * Time: 13:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SharpDemo
{
	/// <summary>
	/// Description of Sharp.
	/// </summary>
	public class Sharp
	{
		protected double x;
		protected double y;
		
		public Sharp()
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
		
		public double distance(Sharp s)
		{
			return Math.Sqrt((x-s.x)*(x-s.x)+(y-s.y)*(y-s.y));
		}
	}
}
