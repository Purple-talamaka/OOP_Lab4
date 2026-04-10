namespace Lab_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            btnCircle = new ToolStripButton();
            btnSquare = new ToolStripButton();
            btnTriangle = new ToolStripButton();
            btnSegment = new ToolStripButton();
            menuStrip1 = new MenuStrip();
            menuItemColor = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCircle, btnSquare, btnTriangle, btnSegment });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            // 
            // btnCircle
            // 
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(36, 22);
            btnCircle.Text = "Круг";
            btnCircle.Click += btnCircle_Click;
            // 
            // btnSquare
            // 
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(54, 22);
            btnSquare.Text = "Квадрат";
            btnSquare.Click += btnSquare_Click;
            // 
            // btnTriangle
            // 
            btnTriangle.Name = "btnTriangle";
            btnTriangle.Size = new Size(81, 22);
            btnTriangle.Text = "Треугольник";
            btnTriangle.Click += btnTriangle_Click;
            // 
            // btnSegment
            // 
            btnSegment.Name = "btnSegment";
            btnSegment.Size = new Size(56, 22);
            btnSegment.Text = "Отрезок";
            btnSegment.Click += btnSegment_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuItemColor });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            // 
            // menuItemColor
            // 
            menuItemColor.Name = "menuItemColor";
            menuItemColor.Size = new Size(45, 20);
            menuItemColor.Text = "Цвет";
            menuItemColor.Click += menuItemColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnCircle;
        private ToolStripButton btnSquare;
        private ToolStripButton btnTriangle;
        private ToolStripButton btnSegment;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuItemColor;
    }
}
