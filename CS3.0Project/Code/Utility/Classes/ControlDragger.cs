using System.Windows.Forms;
using System.Drawing;
using System.Linq.Expressions;

namespace CS3._0Project.Forms.Utility.Classes {
    // Allows ctrls to be dragged from any point
    // Envoke by creating a new instance of this class in the constructor of the draggable class passing through the control to drag
    class ControlDragger { 
        private readonly Control ctrl; // Form to drag
        private Point mouseDown; // Mouse location
        private bool hasBoundingParent;

        public ControlDragger(Control ctrl, bool dragSubControls, bool hasBoundingParent) {
            this.ctrl = ctrl; // Get input ctrl
            AllowDrag(ctrl, dragSubControls, hasBoundingParent);
        }

        protected void OnMouseDown(object sender, MouseEventArgs e) { // Where has mouse been pressed too
            mouseDown = e.Location; // Getting the mouse location on initial mouse down
        }

        protected void OnMouseMove(object sender, MouseEventArgs e) { // If mouse is being held down and moveds
            if (e.Button == MouseButtons.Left) {
                // Get change in x and y
                int dx = e.X - mouseDown.X;
                int dy = e.Y - mouseDown.Y;

                Point newPoint = new Point(ctrl.Location.X + dx, ctrl.Location.Y + dy); // Move ctrl to the new point

                if (hasBoundingParent) { // However if the parent is bounding keep the control within the parent, do not let it leave
                    Control parentCtrl = ctrl.Parent;
                    // Revert movement in these directions if the pointer is outside the box
                    if (parentCtrl.Size.Width < newPoint.X + ctrl.Width) { // Right
                        newPoint.X -= dx;
                    }
                    if (0 > newPoint.X) { // Left
                        newPoint.X -= dx;
                    }
                    if (parentCtrl.Size.Height < newPoint.Y + ctrl.Height) { // Down
                        newPoint.Y -= dy;
                    }
                    if (0 > newPoint.Y) { // UP
                        newPoint.Y -= dy;
                    }
                }
                ctrl.Location = newPoint; // Move Point
            }
        }

        private void AllowDrag(Control ctrl, bool dragSubControls, bool hasBoundingParent) { // Allow for ctrls to be dragged
            this.hasBoundingParent = hasBoundingParent;
            if (ctrl.GetType() == typeof(Button)) { // If the control is a button dont drag
                return;
            }
            // Envoke events
            ctrl.MouseDown += OnMouseDown;
            ctrl.MouseMove += OnMouseMove;

            // Make all child controls also draggable, if drga sub controls is true
            if (dragSubControls) {
                foreach (Control child in ctrl.Controls) {
                    AllowDrag(child, true, false) ;
                }
            }
        }
    }
}
