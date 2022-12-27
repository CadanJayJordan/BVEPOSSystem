using System.Windows.Forms;
using System.Drawing;

namespace CS3._0Project.Forms.Utility.Classes {
    // Allows forms to be dragged from any point EXCEPT buttons
    // Envoke by creating a new instance of this class in the constructor of the dragable class
    class FormDragger { 
        private readonly Form form; // Form to drag
        private Point mouseDown; // Mouse location

        public FormDragger(Form form) {
            this.form = form; // Get input form
            AllowDrag(form);
        }

        protected void OnMouseDown(object sender, MouseEventArgs e) { // Where has mouse been pressed too
            mouseDown = e.Location;
        }

        protected void OnMouseMove(object sender, MouseEventArgs e) { // If mouse is being held down and moveds
            if (e.Button == MouseButtons.Left) {
                // Get change in x and y
                int dx = e.X - mouseDown.X;
                int dy = e.Y - mouseDown.Y;
                form.Location = new Point(form.Location.X + dx, form.Location.Y + dy); // Move form to the new point
            }
        }

        private void AllowDrag(Control ctrl) { // Allow for forms to be dragged
            if (ctrl.GetType() == typeof(Button)) { // If the control is a button dont drag
                return;
            }
            // Envoke events
            ctrl.MouseDown += OnMouseDown;
            ctrl.MouseMove += OnMouseMove;

            // Make all child controls (except buttons) also draggable
            foreach (Control child in ctrl.Controls) {
                AllowDrag(child);
            }
        }
    }
}
