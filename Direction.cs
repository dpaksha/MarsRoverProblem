using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Direction
    {

        public Direction() { }

        public virtual Direction Left()
        {
            return this;
        }

        public virtual Direction Right()
        {
            return this;
        }

        public static Direction GetDirection(char directionChar)
        {
            Direction direction = null;

            if (directionChar.Equals('N'))
                direction= new North();
            else if (directionChar.Equals('S'))
                direction= new South();
            else if (directionChar.Equals('W'))
                direction= new West();
            else if (directionChar.Equals('E'))
                direction= new East();

            return direction;
        }
    }

    public class North : Direction
    {
        public North() { }

        public override Direction Left()
        {
            return new West();
        }

        public override Direction Right()
        {
            return new East();
        }

        public override string ToString()
        {
            return "N";
        }
    }


    public class South : Direction
    {
        public South() { }

        public override Direction Left()
        {
            return new East();
        }

        public override Direction Right()
        {
            return new West();
        }

        public override string ToString()
        {
            return "S";
        }
    }


    public class East : Direction
    {
        public East() { }

        public override Direction Left()
        {
            return new North();
        }

        public override Direction Right()
        {
            return new South();
        }

        public override string ToString()
        {
            return "E";
        }
    }

    public class West : Direction
    {
        public West() { }

        public override Direction Left()
        {
            return new South();
        }

        public override Direction Right()
        {
            return new North();
        }

        public override string ToString()
        {
            return "W";
        }
    }

   
}

