using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painter
{
    public partial class painterForm : Form
    {
        bool ShouldPaint { get; set; }  // Whether to paint

        public painterForm()
        {
            InitializeComponent();
        }

        private void PainterForm_MouseDown(object sender, MouseEventArgs e)
        {
            // Indicate that the user is dragging the mouse
            ShouldPaint = true;
        }

        private void PainterForm_MouseUp(object sender, MouseEventArgs e)
        {
            // Indicate that the user released the mouse
            ShouldPaint = false;
        }

        private void PainterForm_MouseMove(object sender, MouseEventArgs e)
        {
            // Check if the mouse button is being pressed
            if (ShouldPaint)
                {
                // Draw a circle where the mouse pointer is present
                using (Graphics graphics = CreateGraphics())
                {
                    graphics.FillEllipse(
                        new SolidBrush(Color.BlueViolet), e.X, e.Y, 4, 4);
                }

            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // painterForm
            // 
            this.ClientSize = new System.Drawing.Size(566, 498);
            this.Name = "painterForm";
            this.Text = "Painter";
            this.Load += new System.EventHandler(this.painterForm_Load);
            this.ResumeLayout(false);

        }

        private void painterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
