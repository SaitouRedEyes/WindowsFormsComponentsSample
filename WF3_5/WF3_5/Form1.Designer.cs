namespace WF3_5
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.celsiusTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.MeasuresCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura em Celsius";
            // 
            // celsiusTB
            // 
            this.celsiusTB.Location = new System.Drawing.Point(12, 41);
            this.celsiusTB.MaxLength = 5;
            this.celsiusTB.Name = "celsiusTB";
            this.celsiusTB.Size = new System.Drawing.Size(146, 20);
            this.celsiusTB.TabIndex = 1;
            this.celsiusTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.celsiusTB_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultado convertido";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(25, 150);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 3;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MeasuresCB
            // 
            this.MeasuresCB.FormattingEnabled = true;
            this.MeasuresCB.Items.AddRange(new object[] {
            "Fahrenheit",
            "Kelvin"});
            this.MeasuresCB.Location = new System.Drawing.Point(258, 41);
            this.MeasuresCB.Name = "MeasuresCB";
            this.MeasuresCB.Size = new System.Drawing.Size(121, 21);
            this.MeasuresCB.TabIndex = 4;
            this.MeasuresCB.Text = "Fahrenheit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Medidas";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(281, 140);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Converter";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 206);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MeasuresCB);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.celsiusTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox celsiusTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.ComboBox MeasuresCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button convertButton;
    }
}

