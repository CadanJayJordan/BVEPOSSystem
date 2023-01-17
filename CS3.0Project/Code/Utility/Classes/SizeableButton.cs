using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3._0Project.Code.Utility.Classes {
    class SizeableButton : Button {

        private bool sizeable;

        //https://stackoverflow.com/questions/17264225/how-can-user-resize-control-at-runtime-in-winforms
        public SizeableButton(bool sizeable) {
            this.sizeable = sizeable;
            if (sizeable) {
                this.ResizeRedraw = true;
            }
        }
        protected override CreateParams CreateParams {
            get {
                var cp = base.CreateParams;
                if (sizeable) {
                    cp.Style |= 0x00040000;  // Turn on WS_SIZEBOX
                }
                return cp;
            }
        }
    }
}
