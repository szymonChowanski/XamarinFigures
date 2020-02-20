using System;
using System.Reflection;


namespace XamarinFigures
{
	public abstract class Shape
	{
		public double Parameter { get; set; }
		public double Area { get; set; }
		public double Trait { get; set; }

		public string Type { get; set; }

		public Shape()
		{
		}

		public Shape(double number)
		{
			this.Parameter = number;
			CalculateArea();
			CalculateTrait();
		}

		protected abstract void CalculateArea();
		protected abstract void CalculateTrait();

	}


	public class Square : Shape
	{
		public Square() { }

		public Square(double number) : base(number) { Type = "Square"; }

		protected override void CalculateArea()
		{
			Area = Parameter * Parameter;
		}

		protected override void CalculateTrait()
		{
			Trait = Parameter * Math.Sqrt(2);
		}
	}

	public class Triangle : Shape
	{
		public Triangle() { }

		public Triangle(double number) : base(number) { Type = "Triangle"; }

		protected override void CalculateArea()
		{
			Area = (Parameter * Parameter * Math.Sqrt(3)) / 4;
		}

		protected override void CalculateTrait()
		{
			Trait = (Parameter * Math.Sqrt(3)) / 2;
		}
	}

	public class Circle : Shape
	{
		public Circle() { }

		public Circle(double number) : base(number) { Type = "Circle"; }

		protected override void CalculateArea()
		{
			Area = Parameter * Parameter * Math.PI;
		}

		protected override void CalculateTrait()
		{
			Trait = Parameter * Math.PI * 2;
		}
	}
}