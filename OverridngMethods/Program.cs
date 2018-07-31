using System;
using System.Collections.Generic;

namespace OverridngMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape s = new Shape();
            //s.Draw();

            //Circle c = s as Circle;
            //if (c != null)
            //{
            //    c.Draw();
            //}


            Circle c = new Circle();
            c.Draw();

            Shape s = c as Shape;
            if (s != null)
            {
                s.Draw();
            }

            //List <Shape> hsapes = new List<Shape>();
            //hsapes.Add(s);
            //hsapes.Add(c);

            //ListOfAll loa = new ListOfAll();
            //loa.DrawAll(hsapes);


            Console.ReadKey();
        }
    }

    public class Shape
    {
        public virtual void Draw()
        {
            //Deafult implementation
            Console.WriteLine("Draw method from Shape class");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            //base.Draw();

            //Add custom loguic
            Console.WriteLine("Draw method from Circle class");
        }
        public void NewCircleMethod()
        {
            Console.WriteLine("NewCircleMethod has been called");
        }
    }

    public class ListOfAll
    {
        public void DrawAll(System.Collections.Generic.List<Shape> shapes)
        {
            foreach(var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
