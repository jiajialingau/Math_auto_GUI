namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Plus = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.times = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "which function you want choose?";
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(11, 41);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(75, 74);
            this.Plus.TabIndex = 1;
            this.Plus.Text = "Plus";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(125, 41);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(75, 74);
            this.subtraction.TabIndex = 1;
            this.subtraction.Text = "subtraction";
            this.subtraction.UseVisualStyleBackColor = true;
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(242, 41);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(75, 74);
            this.times.TabIndex = 1;
            this.times.Text = "multiplication";
            this.times.UseVisualStyleBackColor = true;
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(357, 41);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 74);
            this.division.TabIndex = 1;
            this.division.Text = "division";
            this.division.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 131);
            this.Controls.Add(this.division);
            this.Controls.Add(this.times);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "question automation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button times;
        private System.Windows.Forms.Button division;
    }
}

