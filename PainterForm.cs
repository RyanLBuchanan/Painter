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

        // SHAUNS CODE
        Graphics graphics;
        Boolean cursorMoving = false;
        Pen cursorPen;
        int cursorX = -1;
        int cursorY = -1;

        bool ShouldPaint { get; set; }  // Whether to paint

        public painterForm()
        {
            InitializeComponent();
            graphics = drawingPanel.CreateGraphics();  // Retrieve a Grpahics object for drawing
            cursorPen = new Pen(Color.Black, 7);
        }

        //private void PainterForm_MouseDown(object sender, MouseEventArgs e)
        //{
        //    // Indicate that the user is dragging the mouse
        //    ShouldPaint = true;
        //}

        //private void PainterForm_MouseUp(object sender, MouseEventArgs e)
        //{
        //    // Indicate that the user released the mouse
        //    ShouldPaint = false;
        //}

        //private void PainterForm_MouseMove(object sender, MouseEventArgs e)
        //{
        //    // Check if the mouse button is being pressed
        //    if (ShouldPaint)
        //        {
        //        // Draw a circle where the mouse pointer is present
        //        using (Graphics graphics = CreateGraphics())
        //        {
        //            graphics.FillEllipse(
        //                new SolidBrush(Color.BlueViolet), e.X, e.Y, 4, 4);
        //        }

        //    }
        //}

        private void InitializeComponent()
        {
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.blackRadioButton = new System.Windows.Forms.RadioButton();
            this.greenRadioButton = new System.Windows.Forms.RadioButton();
            this.blueRadioButton = new System.Windows.Forms.RadioButton();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.largeRadioButton = new System.Windows.Forms.RadioButton();
            this.mediumRadioButton = new System.Windows.Forms.RadioButton();
            this.smallRadioButton = new System.Windows.Forms.RadioButton();
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.colorGroupBox.SuspendLayout();
            this.sizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.colorGroupBox.Controls.Add(this.blackRadioButton);
            this.colorGroupBox.Controls.Add(this.greenRadioButton);
            this.colorGroupBox.Controls.Add(this.blueRadioButton);
            this.colorGroupBox.Controls.Add(this.redRadioButton);
            this.colorGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorGroupBox.Location = new System.Drawing.Point(27, 28);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(150, 235);
            this.colorGroupBox.TabIndex = 0;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Color";
            // 
            // blackRadioButton
            // 
            this.blackRadioButton.AutoSize = true;
            this.blackRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackRadioButton.Location = new System.Drawing.Point(30, 186);
            this.blackRadioButton.Name = "blackRadioButton";
            this.blackRadioButton.Size = new System.Drawing.Size(68, 27);
            this.blackRadioButton.TabIndex = 3;
            this.blackRadioButton.TabStop = true;
            this.blackRadioButton.Text = "Black";
            this.blackRadioButton.UseVisualStyleBackColor = true;
            this.blackRadioButton.Click += new System.EventHandler(this.greenRadioButton_CheckedChanged);
            // 
            // greenRadioButton
            // 
            this.greenRadioButton.AutoSize = true;
            this.greenRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenRadioButton.ForeColor = System.Drawing.Color.Lime;
            this.greenRadioButton.Location = new System.Drawing.Point(30, 137);
            this.greenRadioButton.Name = "greenRadioButton";
            this.greenRadioButton.Size = new System.Drawing.Size(73, 27);
            this.greenRadioButton.TabIndex = 2;
            this.greenRadioButton.TabStop = true;
            this.greenRadioButton.Text = "Green";
            this.greenRadioButton.UseVisualStyleBackColor = true;
            this.greenRadioButton.CheckedChanged += new System.EventHandler(this.greenRadioButton_CheckedChanged);
            // 
            // blueRadioButton
            // 
            this.blueRadioButton.AutoSize = true;
            this.blueRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueRadioButton.ForeColor = System.Drawing.Color.Blue;
            this.blueRadioButton.Location = new System.Drawing.Point(30, 87);
            this.blueRadioButton.Name = "blueRadioButton";
            this.blueRadioButton.Size = new System.Drawing.Size(59, 27);
            this.blueRadioButton.TabIndex = 1;
            this.blueRadioButton.TabStop = true;
            this.blueRadioButton.Text = "Blue";
            this.blueRadioButton.UseVisualStyleBackColor = true;
            this.blueRadioButton.Click += new System.EventHandler(this.greenRadioButton_CheckedChanged);
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = true;
            this.redRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redRadioButton.ForeColor = System.Drawing.Color.Red;
            this.redRadioButton.Location = new System.Drawing.Point(30, 35);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(56, 27);
            this.redRadioButton.TabIndex = 0;
            this.redRadioButton.TabStop = true;
            this.redRadioButton.Text = "Red";
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.Click += new System.EventHandler(this.greenRadioButton_CheckedChanged);
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.sizeGroupBox.Controls.Add(this.largeRadioButton);
            this.sizeGroupBox.Controls.Add(this.mediumRadioButton);
            this.sizeGroupBox.Controls.Add(this.smallRadioButton);
            this.sizeGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeGroupBox.Location = new System.Drawing.Point(27, 285);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(150, 151);
            this.sizeGroupBox.TabIndex = 1;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size";
            // 
            // largeRadioButton
            // 
            this.largeRadioButton.AutoSize = true;
            this.largeRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeRadioButton.Location = new System.Drawing.Point(30, 113);
            this.largeRadioButton.Name = "largeRadioButton";
            this.largeRadioButton.Size = new System.Drawing.Size(88, 34);
            this.largeRadioButton.TabIndex = 2;
            this.largeRadioButton.TabStop = true;
            this.largeRadioButton.Text = "Large";
            this.largeRadioButton.UseVisualStyleBackColor = true;
            // 
            // mediumRadioButton
            // 
            this.mediumRadioButton.AutoSize = true;
            this.mediumRadioButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumRadioButton.Location = new System.Drawing.Point(30, 70);
            this.mediumRadioButton.Name = "mediumRadioButton";
            this.mediumRadioButton.Size = new System.Drawing.Size(84, 27);
            this.mediumRadioButton.TabIndex = 1;
            this.mediumRadioButton.TabStop = true;
            this.mediumRadioButton.Text = "Medium";
            this.mediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // smallRadioButton
            // 
            this.smallRadioButton.AutoSize = true;
            this.smallRadioButton.Location = new System.Drawing.Point(30, 32);
            this.smallRadioButton.Name = "smallRadioButton";
            this.smallRadioButton.Size = new System.Drawing.Size(55, 20);
            this.smallRadioButton.TabIndex = 0;
            this.smallRadioButton.TabStop = true;
            this.smallRadioButton.Text = "Small";
            this.smallRadioButton.UseVisualStyleBackColor = true;
            // 
            // drawingPanel
            // 
            this.drawingPanel.BackColor = System.Drawing.Color.White;
            this.drawingPanel.Location = new System.Drawing.Point(218, 28);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(687, 408);
            this.drawingPanel.TabIndex = 2;
            this.drawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingPanel_Paint);
            this.drawingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseDown);
            this.drawingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseMove);
            this.drawingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawingPanel_MouseUp);
            // 
            // painterForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(931, 472);
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

        //private void greenRadioButton_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        // SHAUNS CODE
        private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            cursorMoving = true;
            cursorX = e.X;
            cursorY = e.Y;
        }

        private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            cursorMoving = false;
            cursorX = -1;
            cursorY = -1;
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(cursorX != -1 && cursorY != -1 && cursorMoving == true)
            {
                graphics.DrawLine(cursorPen, new Point(cursorX, cursorY), e.Location);
                cursorX = e.X;
                cursorY = e.Y;
            }
        }
    }
}
