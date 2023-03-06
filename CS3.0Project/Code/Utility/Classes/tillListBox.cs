using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CS3._0Project.Code.Utility.Classes {
    class tillListBox : ListBox{ // TODO: Make Work
        
        private bool scrollDisplay;
        
        public tillListBox() {
            //this.DrawMode = DrawMode.OwnerDrawFixed;
        }

        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                if (!scrollDisplay)
                    cp.Style = cp.Style & ~0x200000;
                return cp;
            }
        }
        public bool ShowScrollbar {
            get { return scrollDisplay; }
            set {
                if (value != scrollDisplay) {
                    scrollDisplay = value;
                    if (IsHandleCreated)
                        RecreateHandle();
                }
            }
        }

        protected override void OnSelectedIndexChanged(EventArgs e) {
            base.OnSelectedIndexChanged(e);
            //for(int i = 0; i < this.SelectedIndices.Count; i++) {
                //this.DrawItem += listBox_DrawItem;
            //}
            
        }




        private void listBox_DrawItem(object sender, DrawItemEventArgs e) { // Draw a seperate background colour
            Graphics g = e.Graphics;
            ListBox lb = (ListBox)sender;

            e.DrawBackground(); // Draws background in bounds

            if (lb.SelectedIndices.Contains(e.Index)) {
                g.FillRectangle(new SolidBrush(Color.Blue), e.Bounds);
                g.DrawString(lb.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.White), new PointF(e.Bounds.X, e.Bounds.Y));
            } else {
                g.FillRectangle(new SolidBrush(Color.Black), e.Bounds);
                g.DrawString(lb.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.White), new PointF(e.Bounds.X, e.Bounds.Y));
            }

            e.DrawFocusRectangle();
        }
    }
}
