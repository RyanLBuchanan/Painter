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
        private RadioButton blackRadioButton;
        private RadioButton greenRadioButton;
        private RadioButton blueRadioButton;
        private RadioButton redRadioButton;
        private RadioButton largeRadioButton;
        private RadioButton mediumRadioButton;
        private RadioButton smallRadioButton;
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
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.blueRadioButton = new System.Windows.Forms.RadioButton();
            this.greenRadioButton = new System.Windows.Forms.RadioButton();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.largeRadioButton = new System.Windows.Forms.RadioButton();
            this.colorGroupBox.SuspendLayout();
            this.sizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.blackRadioButton);
            this.colorGroupBox.Controls.Add(this.greenRadioButton);
            this.colorGroupBox.Controls.Add(this.blueRadioButton);
            this.colorGroupBox.Controls.Add(this.redRadioButton);
            this.colorGroupBox.Location = new System.Drawing.Point(27, 28);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(150, 235);
            this.colorGroupBox.TabIndex = 0;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Color";
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.largeRadioButton);
            this.sizeGroupBox.Controls.Add(this.mediumRadioButton);
            this.sizeGroupBox.Controls.Add(this.smallRadioButton);
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
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Location = new System.Drawing.Point(30, 35);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(45, 17);
            this.redRadioButton.TabIndex = 0;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            // 
            // blueRadioButton
            // 
            this.blueRadioButton.AutoSize = true;
            this.blueRadioButton.Location = new System.Drawing.Point(30, 87);
            this.blueRadioButton.Name = "blueRadioButton";
            this.blueRadioButton.Size = new System.Drawing.Size(46, 17);
            this.blueRadioButton.TabIndex = 1;
            this.blueRadioButton.TabStop = true;
            this.blueRadioButton.Text = "Blue";
            this.blueRadioButton.UseVisualStyleBackColor = true;
            // 
            // greenRadioButton
            // 
            this.greenRadioButton.AutoSize = true;
            this.greenRadioButton.Location = new System.Drawing.Point(30, 132);
            this.greenRadioButton.Name = "greenRadioButton";
            this.greenRadioButton.Size = new System.Drawing.Size(54, 17);
            this.greenRadioButton.TabIndex = 2;
            this.greenRadioButton.TabStop = true;
            this.greenRadioButton.Text = "Green";
            this.greenRadioButton.UseVisualStyleBackColor = true;
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Location = new System.Drawing.Point(30, 186);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(52, 17);
            this.blackRadioButton.TabIndex = 3;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Location = new System.Drawing.Point(30, 32);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(50, 17);
            this.smallRadioButton.TabIndex = 0;
            this.smallRadioButton.TabStop = true;
            this.smallRadioButton.Text = "Small";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Location = new System.Drawing.Point(30, 70);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(62, 17);
            this.mediumRadioButton.TabIndex = 1;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // largeRadioButton
            // 
            this.largeRadioButton.AutoSize = true;
            this.largeRadioButton.Location = new System.Drawing.Point(30, 113);
            this.largeRadioButton.Name = "largeRadioButton";
            this.largeRadioButton.Size = new System.Drawing.Size(52, 17);
            this.largeRadioButton.TabIndex = 2;
            this.largeRadioButton.TabStop = true;
            this.largeRadioButton.Text = "Large";
            this.largeRadioButton.UseVisualStyleBackColor = true;
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
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
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
