using System.Drawing;


namespace FlyWeight
{
    public class Param
    {
        public int h;
        public Bitmap pic;
    }

    public class Snowflake1 : Param
    {
        public Snowflake1()
        {
            h = 50;
            pic = new Bitmap(@"D:\4 курс\лаб\lab 6\1.png");
        }
    }
    public class Snowflake2 : Param
    {
        public Snowflake2()
        {
            h = 100;
            pic = new Bitmap(@"D:\4 курс\лаб\lab 6\2.jpg");
        }
    }
    public class Snowflake
    {
        public int x, y;
        public Param p;
        public Snowflake()
        {
            x = 0; y = 0;
        }
      
        public Snowflake(int x, int y, Param p)
        {
            this.p = p;
            this.x = x;
            this.y = y;
        }
    }
}