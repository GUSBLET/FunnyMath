namespace FannyMath
{
    partial class MathTaskWindow
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
            this.Num2 = new System.Windows.Forms.Label();
            this.Action = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CorentScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BetterScore = new System.Windows.Forms.Label();
            this.finish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FannyMath.Properties.Resources.MathTaskBackground;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Num1
            // 
            this.Num1.AutoSize = true;
            this.Num1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num1.Location = new System.Drawing.Point(12, 185);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(194, 81);
            this.Num1.TabIndex = 1;
            this.Num1.Text = "label1";
            // 
            // Num2
            // 
            this.Num2.AutoSize = true;
            this.Num2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Num2.Location = new System.Drawing.Point(360, 185);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(194, 81);
            this.Num2.TabIndex = 2;
            this.Num2.Text = "label2";
            // 
            // Action
            // 
            this.Action.AutoSize = true;
            this.Action.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Action.Location = new System.Drawing.Point(252, 198);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(54, 59);
            this.Action.TabIndex = 3;
            this.Action.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(583, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // AnswerBox
            // 
            this.AnswerBox.AccessibleName = "Answer";
            this.AnswerBox.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnswerBox.Location = new System.Drawing.Point(663, 185);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(125, 87);
            this.AnswerBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Відправити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Count_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "Результат:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CorentScore
            // 
            this.CorentScore.AutoSize = true;
            this.CorentScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CorentScore.Location = new System.Drawing.Point(205, 74);
            this.CorentScore.Name = "CorentScore";
            this.CorentScore.Size = new System.Drawing.Size(34, 41);
            this.CorentScore.TabIndex = 9;
            this.CorentScore.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 41);
            this.label5.TabIndex = 10;
            this.label5.Text = "Лучший результат:";
            // 
            // BetterScore
            // 
            this.BetterScore.AutoSize = true;
            this.BetterScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BetterScore.Location = new System.Drawing.Point(306, 22);
            this.BetterScore.Name = "BetterScore";
            this.BetterScore.Size = new System.Drawing.Size(34, 41);
            this.BetterScore.TabIndex = 11;
            this.BetterScore.Text = "0";
            // 
            // finish
            // 
            this.finish.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.finish.Location = new System.Drawing.Point(61, 375);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(178, 29);
            this.finish.TabIndex = 12;
            this.finish.Text = "Завершити гру";
            this.finish.UseVisualStyleBackColor = true;
            // 
            // MathTaskWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.BetterScore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CorentScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.Name = "MathTaskWindow";
            this.Text = "MathTaskWindow";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label Num1;
        private Label Num2;
        private Label Action;
        private Label label1;
        private TextBox AnswerBox;
        private Button button1;
        private Label label3;
        private Label CorentScore;
        private Label label5;
        private Label BetterScore;
        private Button finish;
    }
}