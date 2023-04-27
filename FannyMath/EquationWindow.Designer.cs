namespace FannyMath
{
    partial class EquationWindow
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
            this.Num1 = new System.Windows.Forms.Label();
            this.job = new System.Windows.Forms.Label();
            this.Action = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BetterScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CorentScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.finish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FannyMath.Properties.Resources.EquationTriger;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(955, 499);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num1.Location = new System.Drawing.Point(14, 289);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(137, 59);
            this.Num1.TabIndex = 1;
            this.Num1.Text = "label1";
            // 
            // job
            // 
            this.job.AutoSize = true;
            this.job.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.job.Location = new System.Drawing.Point(627, 289);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(52, 59);
            this.job.TabIndex = 2;
            this.job.Text = "Є";
            // 
            // Action
            // 
            this.Action.AutoSize = true;
            this.Action.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Action.Location = new System.Drawing.Point(209, 289);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(137, 59);
            this.Action.TabIndex = 3;
            this.Action.Text = "label3";
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num2.Location = new System.Drawing.Point(426, 289);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(137, 59);
            this.Num2.TabIndex = 4;
            this.Num2.Text = "label4";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(754, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "Відправити";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(781, 297);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 51);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Який";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BetterScore
            // 
            this.BetterScore.AutoSize = true;
            this.BetterScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BetterScore.Location = new System.Drawing.Point(319, 35);
            this.BetterScore.Name = "BetterScore";
            this.BetterScore.Size = new System.Drawing.Size(34, 41);
            this.BetterScore.TabIndex = 15;
            this.BetterScore.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 41);
            this.label5.TabIndex = 14;
            this.label5.Text = "Лучший результат:";
            // 
            // CorentScore
            // 
            this.CorentScore.AutoSize = true;
            this.CorentScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CorentScore.Location = new System.Drawing.Point(218, 87);
            this.CorentScore.Name = "CorentScore";
            this.CorentScore.Size = new System.Drawing.Size(34, 41);
            this.CorentScore.TabIndex = 13;
            this.CorentScore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 41);
            this.label3.TabIndex = 12;
            this.label3.Text = "Результат:";
            // 
            // finish
            // 
            this.finish.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.finish.Location = new System.Drawing.Point(25, 415);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(178, 29);
            this.finish.TabIndex = 16;
            this.finish.Text = "Завершити гру";
            this.finish.UseVisualStyleBackColor = true;
            // 
            // EquationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 499);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.BetterScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CorentScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.job);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(973, 546);
            this.Name = "EquationWindow";
            this.Text = "EquationWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label Num1;
        private Label job;
        private Label Action;
        private Label Num2;
        private Button button1;
        private CheckBox checkBox1;
        private Label BetterScore;
        private Label label5;
        private Label CorentScore;
        private Label label3;
        private Button finish;
    }
}