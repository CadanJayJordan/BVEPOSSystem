using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CS3._0Project.Code.Utility.Classes {
    class RoundedButton : Button {
        // Custom rounded button for items
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) { // Override the drawing event on the button 
            GraphicsPath gPath = new GraphicsPath(); // Create a new graphics path
            gPath.AddEllipse(0, 0, this.Width, this.Height); // Create an ellipse 
            this.Region = new System.Drawing.Region(gPath); // Draw the ellipse region
            base.OnPaint(e); // Draw base button
        }

    }
}
