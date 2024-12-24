namespace Laba9
{
    partial class Change
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.StudyTextBox = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО студента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер студенческого билета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Направление обучения";
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(293, 41);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(420, 22);
            this.fioTextBox.TabIndex = 3;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(293, 151);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(420, 22);
            this.NumberTextBox.TabIndex = 4;
            // 
            // StudyTextBox
            // 
            this.StudyTextBox.Location = new System.Drawing.Point(293, 266);
            this.StudyTextBox.Name = "StudyTextBox";
            this.StudyTextBox.Size = new System.Drawing.Size(420, 22);
            this.StudyTextBox.TabIndex = 5;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(611, 330);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(102, 34);
            this.Ok.TabIndex = 6;
            this.Ok.Text = "Готово";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click_1);
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 376);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.StudyTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Change";
            this.Text = "Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Ok;
        public System.Windows.Forms.TextBox fioTextBox;
        public System.Windows.Forms.TextBox NumberTextBox;
        public System.Windows.Forms.TextBox StudyTextBox;
    }
}