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
	/// Description of Square.
	/// </summary>
	public class Square : Shape
	{
		private double edge;
		
		public Square()
		{
		}
		
		public void setEdge(double edge)
		{
			this.edge = edge ;
		}
		
		public double getEdge()
		{
			return edge ;
		}
		
	}
}
