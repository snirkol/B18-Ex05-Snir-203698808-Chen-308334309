using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B18_Ex05_1
{
    class ButtonWithPosition : Button
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }

        public ButtonWithPosition(int i_XPosition, int i_YPosition)
        {
            XPosition = i_XPosition;
            YPosition = i_YPosition;
        }
    }
}
