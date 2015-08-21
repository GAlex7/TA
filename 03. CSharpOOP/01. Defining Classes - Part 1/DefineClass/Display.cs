namespace DefineClass
{
    using System;

    class Display
    {
        private const byte maxSize = 6;
        private const byte defaultSize = 3;
        private const uint defaultColors = 1;

        private float size;
        private uint colors;

        // Parameterless constructor
        public Display()
            : this(defaultSize, defaultColors)
        {
        }

        // Constructor with parameters
        public Display(float inches, uint color)
        {
            this.Size = inches;
            this.Colors = color;
        }

        public float Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value > maxSize)
                {
                    throw new ArgumentOutOfRangeException("This is GSM, not a tablet...");
                }
                this.size = value;
            }
        }

        public uint Colors 
        {
            get { return this.colors; }
            set { this.colors = value; }
        }

    }
}
