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

            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCircle, btnSquare, btnTriangle, btnSegment });

            btnCircle.Text = "Круг";
            btnCircle.Click += btnCircle_Click;

            btnSquare.Text = "Квадрат";
            btnSquare.Click += btnSquare_Click;

            btnTriangle.Text = "Треугольник";
            btnTriangle.Click += btnTriangle_Click;

            btnSegment.Text = "Отрезок";
            btnSegment.Click += btnSegment_Click;

            SuspendLayout();
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnCircle;
        private ToolStripButton btnSquare;
        private ToolStripButton btnTriangle;
        private ToolStripButton btnSegment;
    }
}
