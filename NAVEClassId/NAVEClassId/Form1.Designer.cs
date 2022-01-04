
namespace NAVEClassId
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
            this.rbMM = new System.Windows.Forms.RadioButton();
            this.rbProg = new System.Windows.Forms.RadioButton();
            this.cb100a = new System.Windows.Forms.CheckBox();
            this.cb100b = new System.Windows.Forms.CheckBox();
            this.cb200a = new System.Windows.Forms.CheckBox();
            this.cb200b = new System.Windows.Forms.CheckBox();
            this.cb300a = new System.Windows.Forms.CheckBox();
            this.cb300b = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rbMM
            // 
            this.rbMM.AutoSize = true;
            this.rbMM.Checked = true;
            this.rbMM.Location = new System.Drawing.Point(24, 32);
            this.rbMM.Name = "rbMM";
            this.rbMM.Size = new System.Drawing.Size(83, 19);
            this.rbMM.TabIndex = 0;
            this.rbMM.TabStop = true;
            this.rbMM.Text = "Multimídia";
            this.rbMM.UseVisualStyleBackColor = true;
            this.rbMM.CheckedChanged += new System.EventHandler(this.rbMM_CheckedChanged);
            // 
            // rbProg
            // 
            this.rbProg.AutoSize = true;
            this.rbProg.Location = new System.Drawing.Point(24, 70);
            this.rbProg.Name = "rbProg";
            this.rbProg.Size = new System.Drawing.Size(96, 19);
            this.rbProg.TabIndex = 1;
            this.rbProg.Text = "Programação";
            this.rbProg.UseVisualStyleBackColor = true;
            this.rbProg.CheckedChanged += new System.EventHandler(this.rbProg_CheckedChanged);
            // 
            // cb100a
            // 
            this.cb100a.AutoSize = true;
            this.cb100a.Location = new System.Drawing.Point(182, 33);
            this.cb100a.Name = "cb100a";
            this.cb100a.Size = new System.Drawing.Size(50, 19);
            this.cb100a.TabIndex = 2;
            this.cb100a.Text = "1001";
            this.cb100a.UseVisualStyleBackColor = true;
            // 
            // cb100b
            // 
            this.cb100b.AutoSize = true;
            this.cb100b.Location = new System.Drawing.Point(182, 71);
            this.cb100b.Name = "cb100b";
            this.cb100b.Size = new System.Drawing.Size(50, 19);
            this.cb100b.TabIndex = 3;
            this.cb100b.Text = "1002";
            this.cb100b.UseVisualStyleBackColor = true;
            // 
            // cb200a
            // 
            this.cb200a.AutoSize = true;
            this.cb200a.Location = new System.Drawing.Point(288, 32);
            this.cb200a.Name = "cb200a";
            this.cb200a.Size = new System.Drawing.Size(50, 19);
            this.cb200a.TabIndex = 4;
            this.cb200a.Text = "2001";
            this.cb200a.UseVisualStyleBackColor = true;
            // 
            // cb200b
            // 
            this.cb200b.AutoSize = true;
            this.cb200b.Location = new System.Drawing.Point(288, 71);
            this.cb200b.Name = "cb200b";
            this.cb200b.Size = new System.Drawing.Size(50, 19);
            this.cb200b.TabIndex = 5;
            this.cb200b.Text = "2002";
            this.cb200b.UseVisualStyleBackColor = true;
            // 
            // cb300a
            // 
            this.cb300a.AutoSize = true;
            this.cb300a.Location = new System.Drawing.Point(392, 32);
            this.cb300a.Name = "cb300a";
            this.cb300a.Size = new System.Drawing.Size(50, 19);
            this.cb300a.TabIndex = 6;
            this.cb300a.Text = "3001";
            this.cb300a.UseVisualStyleBackColor = true;
            // 
            // cb300b
            // 
            this.cb300b.AutoSize = true;
            this.cb300b.Location = new System.Drawing.Point(392, 71);
            this.cb300b.Name = "cb300b";
            this.cb300b.Size = new System.Drawing.Size(50, 19);
            this.cb300b.TabIndex = 7;
            this.cb300b.Text = "3002";
            this.cb300b.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 110);
            this.Controls.Add(this.cb300b);
            this.Controls.Add(this.cb300a);
            this.Controls.Add(this.cb200b);
            this.Controls.Add(this.cb200a);
            this.Controls.Add(this.cb100b);
            this.Controls.Add(this.cb100a);
            this.Controls.Add(this.rbProg);
            this.Controls.Add(this.rbMM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMM;
        private System.Windows.Forms.RadioButton rbProg;
        private System.Windows.Forms.CheckBox cb100a;
        private System.Windows.Forms.CheckBox cb100b;
        private System.Windows.Forms.CheckBox cb200a;
        private System.Windows.Forms.CheckBox cb200b;
        private System.Windows.Forms.CheckBox cb300a;
        private System.Windows.Forms.CheckBox cb300b;
    }
}

