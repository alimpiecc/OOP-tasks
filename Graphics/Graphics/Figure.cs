using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class MyFigure
    {
        public MyFigure()
        {

        }


        virtual public void Draw()
        {

        }
        virtual public void Move()
        {

        }
    }

    class MyCircle : MyFigure
    {
        public MyCircle () : base ()
        {

        }
    }

    class MyRectangle : MyFigure
    {
        public MyRectangle() : base()
        {

        }
    }
}
