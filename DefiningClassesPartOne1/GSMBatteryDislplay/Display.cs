using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GSMBatteryDislplay
{
    public class Display
    {
        private int? size;
        private int? colours;

        public Display(int? size, int? colours)
        {
            this.Size = size;
            this.Colours = colours;
        }

        public Display(): this(null, null) {}

        public int? Size {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("the size of the display cannot be a negative value");
                }

                this.size = value;
            }
        }
        public int? Colours {
            get
            {
                return this.colours;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("the number of colours of the display cannot be a negative value");
                }

                this.colours = value;
            }
        }
    }
}
