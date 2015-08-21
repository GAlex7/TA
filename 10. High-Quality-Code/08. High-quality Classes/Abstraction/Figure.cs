using System;

namespace Abstraction
{
    public abstract class Figure : IFigure
    {
        protected Figure()
        {
        }

        public abstract double GetPerimeter();

        public abstract double GetSurface();
    }
}
