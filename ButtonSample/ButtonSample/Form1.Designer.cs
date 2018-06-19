namespace ButtonSample
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
            this.button1 = new System.Windows.Forms.Button();
            this.card1 = new System.Windows.Forms.Button();
            this.card2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(560, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_mouseClick);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button1_mouseDown);
            this.button1.MouseEnter += new System.EventHandler(this.Button1_mouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.Button1_mouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.Button1_mouseHover);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button1_MouseMove);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button1_mouseUp);
            // 
            // card1
            // 
            this.card1.BackgroundImage = global::ButtonSample.Properties.Resources.card_back;
            this.card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.card1.Location = new System.Drawing.Point(425, 112);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(145, 207);
            this.card1.TabIndex = 1;
            this.card1.UseVisualStyleBackColor = true;
            this.card1.MouseEnter += new System.EventHandler(this.card1_MouseEnter);
            this.card1.MouseLeave += new System.EventHandler(this.card1_MouseLeave);
            this.card1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.card1_MouseUp);
            // 
            // card2
            // 
            this.card2.BackgroundImage = global::ButtonSample.Properties.Resources.card_back;
            this.card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card2.Location = new System.Drawing.Point(621, 112);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(147, 207);
            this.card2.TabIndex = 2;
            this.card2.UseVisualStyleBackColor = true;
            this.card2.MouseEnter += new System.EventHandler(this.card2_MouseEnter);
            this.card2.MouseLeave += new System.EventHandler(this.card2_MouseLeave);
            this.card2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.card2_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 468);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HideCards);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button card1;
        private System.Windows.Forms.Button card2;
    }
}

