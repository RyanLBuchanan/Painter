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
        private GroupBox colorGroupBox;
        private GroupBox sizeGroupBox;
        private Panel drawingPanel;

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
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Location = new System.Drawing.Point(27, 28);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(150, 235);
            this.colorGroupBox.TabIndex = 0;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Color";
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Location = new System.Drawing.Point(27, 285);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(150, 151);
            this.sizeGroupBox.TabIndex = 1;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size";
            // 
            // drawingPanel
            // 
            this.drawingPanel.Location = new System.Drawing.Point(218, 28);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(314, 408);
            this.drawingPanel.TabIndex = 2;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint);
            // 
            // painterForm
            // 
            this.ClientSize = new System.Drawing.Size(566, 498);
            this.Controls.Add(this.drawingPanel);
            this.Controls.Add(this.sizeGroupBox);
            this.Controls.Add(this.colorGroupBox);
            this.Name = "painterForm";
            this.Text = "Painter";
            this.Load += new System.EventHandler(this.painterForm_Load);
            this.ResumeLayout(false);

        }

        private void painterForm_Load(object sender, EventArgs e)
        {

        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
