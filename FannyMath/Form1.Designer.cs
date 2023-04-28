namespace FannyMath
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
            System.Windows.Forms.PictureBox Equation;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MathTask = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TugOfWar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            Equation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(Equation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MathTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TugOfWar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Equation
            // 
            Equation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            Equation.Image = global::FannyMath.Properties.Resources.EquationIcon;
            Equation.Location = new System.Drawing.Point(175, 66);
            Equation.Name = "Equation";
            Equation.Size = new System.Drawing.Size(194, 123);
            Equation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Equation.TabIndex = 6;
            Equation.TabStop = false;
            Equation.Click += new System.EventHandler(this.OpenGame);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FannyMath.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(965, 524);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MathTask
            // 
            this.MathTask.Image = global::FannyMath.Properties.Resources.math1;
            this.MathTask.Location = new System.Drawing.Point(136, 333);
            this.MathTask.Name = "MathTask";
            this.MathTask.Size = new System.Drawing.Size(152, 151);
            this.MathTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MathTask.TabIndex = 1;
            this.MathTask.TabStop = false;
            this.MathTask.Click += new System.EventHandler(this.OpenGame);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Математичні вирази";
            // 
            // TugOfWar
            // 
            this.TugOfWar.Image = global::FannyMath.Properties.Resources.tug_of_war;
            this.TugOfWar.Location = new System.Drawing.Point(622, 364);
            this.TugOfWar.Name = "TugOfWar";
            this.TugOfWar.Size = new System.Drawing.Size(156, 164);
            this.TugOfWar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TugOfWar.TabIndex = 3;
            this.TugOfWar.TabStop = false;
            this.TugOfWar.Click += new System.EventHandler(this.OpenGame);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 508);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Перетягування канату";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.scoresToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // scoresToolStripMenuItem
            // 
            this.scoresToolStripMenuItem.Name = "scoresToolStripMenuItem";
            this.scoresToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.scoresToolStripMenuItem.Text = "Scores";
            this.scoresToolStripMenuItem.Click += new System.EventHandler(this.scoresToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Рівняння";
            this.label3.Click += new System.EventHandler(this.OpenGame);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 552);
            this.Controls.Add(this.label3);
            this.Controls.Add(Equation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TugOfWar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MathTask);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(983, 599);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(Equation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MathTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TugOfWar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox MathTask;
        private Label label1;
        private PictureBox TugOfWar;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Label label3;
        private ToolStripMenuItem scoresToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
    }
}