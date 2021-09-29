using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OTTER
{
    public abstract class Likovi : Sprite
    {
        protected int brzina;
        public int Brzina
        {
            get { return brzina; }
            set { brzina = value; }
        }
        public Likovi(string slika, int xcor, int ycor, int b)
            :base(slika, xcor, ycor)
        {
            this.brzina = b;
        }
    }

    public class Riba : Likovi
    {

        public Riba(string slika, int xcor, int ycor)
            :base(slika,xcor,ycor, 0)
        {
            
        }

        public override int X
        {
            get { return x; }
            set
            {
                if (!(value < GameOptions.LeftEdge) && !(value > GameOptions.RightEdge - this.Width))
                    x = value;

            }
        }

        public override int Y
        {
            get { return y; }
            set
            {
                if (!(value < GameOptions.UpEdge) && !(value > GameOptions.DownEdge - this.Width))
                    y = value;
            }
        }
    }

    public class MrtvaRiba : Likovi
    {
        public MrtvaRiba(string slika, int xcor, int ycor,int b)
            :base(slika,xcor,ycor, 0)
        {
            this.brzina = b;
        }

        public override int X
        {
            get { return x; }
            set
            {
                if (!(value < GameOptions.LeftEdge) && !(value > GameOptions.RightEdge - this.Width))
                    x = value;

            }
        }

       
    }

    public class Hobotnica : Likovi
    {
        public Hobotnica(string slika, int xcor, int ycor)
            :base(slika,xcor,ycor, 0)
        {
            
        }

        public override int X
        {
            get { return x; }
            set
            {
                if (!(value < GameOptions.LeftEdge) && !(value > GameOptions.RightEdge - this.Width))
                    x = value;

            }
        }

        public override int Y
        {
            get { return y; }
            set
            {
                if (!(value < GameOptions.UpEdge) && !(value > GameOptions.DownEdge - this.Width))
                    y = value;
            }
        }
    }

    public class Pingvin : Likovi
    {
        protected int bodovi;
        protected int life;
        public int Bodovi
        {
            get { return bodovi; }
            set { bodovi = value; }
        }
        public int Life
        {
            get { return life; }
            set
            {
                if(value<=0)
                {
                    throw new ArgumentException();
                }
                life = value;
            }
        }
        public Pingvin(string slika, int xcor, int ycor, int bod, int li)
            :base(slika,xcor, ycor, 5)
        {
            this.bodovi = bod;
            this.life = li;
        }
    }

    public class Zvijezda :Likovi
    {
        public Zvijezda(string slika, int xcor, int ycor,int b)
            :base(slika,xcor, ycor,0)
        {
            this.brzina = b;
        }
        public override int X
        {
            get { return x; }
            set
            {
                if (!(value < GameOptions.LeftEdge) && !(value > GameOptions.RightEdge - this.Width))
                    x = value;

            }
        }

       
    }
}
