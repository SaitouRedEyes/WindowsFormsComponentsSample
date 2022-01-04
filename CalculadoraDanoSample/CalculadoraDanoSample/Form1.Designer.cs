
namespace CalculadoraDanoSample
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbDamage = new System.Windows.Forms.TextBox();
            this.cbCriticalHit = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLife = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dano recebido";
            // 
            // tbDamage
            // 
            this.tbDamage.Location = new System.Drawing.Point(13, 32);
            this.tbDamage.Name = "tbDamage";
            this.tbDamage.Size = new System.Drawing.Size(100, 23);
            this.tbDamage.TabIndex = 1;
            // 
            // cbCriticalHit
            // 
            this.cbCriticalHit.AutoSize = true;
            this.cbCriticalHit.Location = new System.Drawing.Point(13, 101);
            this.cbCriticalHit.Name = "cbCriticalHit";
            this.cbCriticalHit.Size = new System.Drawing.Size(90, 19);
            this.cbCriticalHit.TabIndex = 3;
            this.cbCriticalHit.Text = "Dano crítico";
            this.cbCriticalHit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vida";
            // 
            // lbLife
            // 
            this.lbLife.AutoSize = true;
            this.lbLife.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLife.Location = new System.Drawing.Point(188, 32);
            this.lbLife.Name = "lbLife";
            this.lbLife.Size = new System.Drawing.Size(62, 37);
            this.lbLife.TabIndex = 5;
            this.lbLife.Text = "100";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(188, 97);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(62, 45);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calcular Dano";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.CalculateDamage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 152);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbLife);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCriticalHit);
            this.Controls.Add(this.tbDamage);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDamage;
        private System.Windows.Forms.CheckBox cbCriticalHit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLife;
        private System.Windows.Forms.Button btnCalculate;
    }
}

