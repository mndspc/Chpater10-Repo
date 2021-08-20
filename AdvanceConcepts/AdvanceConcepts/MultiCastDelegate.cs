using System;

namespace AdvanceConcepts
{
    //  This program demo. how to create multi-cast delegate
    class MultiCastDelegate
    {
        //1.To Declare Delegate
        public delegate void RectDel(double height, double width);
        public void Area(double height,double width)
        {
            Console.WriteLine("The Area is:{0}",height*width);
        }
        public void Perimeter(double height,double width)
        {
            Console.WriteLine("The perimeter is:{0}",2*(height+width));
        }
        static void Main()
        {
            MultiCastDelegate mulCast = new MultiCastDelegate();
            //2.To initial. Delegate
            RectDel rectDel = new RectDel(mulCast.Area);           
            rectDel += mulCast.Perimeter;
            Console.WriteLine("After adding/attaching ref. perimeter");
            //3.To Invoke Delegate
            rectDel(6.5, 2.5);
            rectDel.Invoke(6.5, 2.5);
            Console.WriteLine("After removing/dettaching ref of perimeter fun ");
            //  To remove ref.
            rectDel -= mulCast.Perimeter;
            rectDel(6.5, 2.5);
            Console.ReadLine();
        }
    }
}
