using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;


namespace XamarinFigures
{
	public static class ShapeGenerator
	{
		public static List<Shape> ShapesList;
		public static int QuantityOfShapes { get; set; } = 0;
		public static void Generate(int number)
        {
			Random rand = new Random();
			ShapesList = new List<Shape>();
			for(int i = 0; i<number;i++)
            {
				switch(rand.Next(1, 3))
                {
					case 1:
						ShapesList.Add(new Square(rand.NextDouble()));
						break;
					case 2:
						ShapesList.Add(new Triangle(rand.NextDouble()));
						break;
					case 3:
						ShapesList.Add(new Circle(rand.NextDouble()));
						break;
				}
            }
        }
	}
}