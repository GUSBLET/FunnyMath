namespace FannyMath
{
    partial class TugOfWarWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BetterScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CorentScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Action = new System.Windows.Forms.Label();
            this.finish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FannyMath.Properties.Resources.TugOfWarBackground;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(64, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(661, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox1_DragOver);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clean";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BetterScore
            // 
            this.BetterScore.AutoSize = true;
            this.BetterScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BetterScore.Location = new System.Drawing.Point(315, 19);
            this.BetterScore.Name = "BetterScore";
            this.BetterScore.Size = new System.Drawing.Size(34, 41);
            this.BetterScore.TabIndex = 15;
            this.BetterScore.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 41);
            this.label5.TabIndex = 14;
            this.label5.Text = "Лучший результат:";
            // 
            // CorentScore
            // 
            this.CorentScore.AutoSize = true;
            this.CorentScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CorentScore.Location = new System.Drawing.Point(214, 71);
            this.CorentScore.Name = "CorentScore";
            this.CorentScore.Size = new System.Drawing.Size(34, 41);
            this.CorentScore.TabIndex = 13;
            this.CorentScore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 41);
            this.label3.TabIndex = 12;
            this.label3.Text = "Результат:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(566, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 51);
            this.button2.TabIndex = 16;
            this.button2.Text = "Відправити";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Action
            // 
            this.Action.AutoSize = true;
            this.Action.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Action.Location = new System.Drawing.Point(233, 285);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(97, 41);
            this.Action.TabIndex = 17;
            this.Action.Text = "label1";
            // 
            // finish
            // 
            this.finish.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.finish.Location = new System.Drawing.Point(21, 115);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(178, 29);
            this.finish.TabIndex = 18;
            this.finish.Text = "Завершити гру";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // TugOfWarWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BetterScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CorentScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TugOfWarWindow";
            this.Text = "TugOfWarWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button1;
        private Label BetterScore;
        private Label label5;
        private Label CorentScore;
        private Label label3;
        private Button button2;
        private Label Action;
        private Button finish;
    }
}