using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3._0Project.Code.Utility.Classes {
    class SizeableButton : Button { // Extension of the button

        private bool sizeable; // Sizeable option

        // Initial Constructor
        public SizeableButton(bool sizeable) {
            this.sizeable = sizeable;
            if (sizeable) { // If it's sizable we want it to redraw itself when resized
                this.ResizeRedraw = true;
            }
        }

        // Create parameters of the visual windows object
        protected override CreateParams CreateParams {
            get { // On get
                var cp = base.CreateParams; // Copy base paramaters
                if (sizeable) { // If we want to resize
                    cp.Style |= 0x00040000;  // Turn on WS_SIZEBOX, which will allow resizing
                }
                return cp; // Return the parameters
            }
        }
    }
}
