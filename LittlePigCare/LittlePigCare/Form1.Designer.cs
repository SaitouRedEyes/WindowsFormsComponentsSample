namespace LittlePigCare
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
            this.pbPig = new System.Windows.Forms.PictureBox();
            this.btnHealth = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPig)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPig
            // 
            this.pbPig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbPig.BackColor = System.Drawing.Color.Transparent;
            this.pbPig.BackgroundImage = global::LittlePigCare.Properties.Resources.little_pig;
            this.pbPig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPig.Location = new System.Drawing.Point(240, 43);
            this.pbPig.Name = "pbPig";
            this.pbPig.Size = new System.Drawing.Size(185, 158);
            this.pbPig.TabIndex = 2;
            this.pbPig.TabStop = false;
            // 
            // btnHealth
            // 
            this.btnHealth.BackColor = System.Drawing.Color.Transparent;
            this.btnHealth.BackgroundImage = global::LittlePigCare.Properties.Resources.physical;
            this.btnHealth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHealth.Location = new System.Drawing.Point(42, 310);
            this.btnHealth.Name = "btnHealth";
            this.btnHealth.Size = new System.Drawing.Size(62, 46);
            this.btnHealth.TabIndex = 1;
            this.btnHealth.UseVisualStyleBackColor = false;
            this.btnHealth.Click += new System.EventHandler(this.btnHealth_Click);
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.Transparent;
            this.btnFood.BackgroundImage = global::LittlePigCare.Properties.Resources.hamburguer;
            this.btnFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFood.Location = new System.Drawing.Point(42, 43);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(62, 62);
            this.btnFood.TabIndex = 0;
            this.btnFood.UseVisualStyleBackColor = false;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbPig);
            this.Controls.Add(this.btnHealth);
            this.Controls.Add(this.btnFood);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbPig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Button btnHealth;
        private System.Windows.Forms.PictureBox pbPig;
    }
}

