namespace PlayerSelection
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
            this.player = new System.Windows.Forms.PictureBox();
            this.selector2 = new System.Windows.Forms.Button();
            this.selector1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackgroundImage = global::PlayerSelection.Properties.Resources.Akuma;
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(202, 12);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(374, 351);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // selector2
            // 
            this.selector2.Location = new System.Drawing.Point(603, 162);
            this.selector2.Name = "selector2";
            this.selector2.Size = new System.Drawing.Size(75, 55);
            this.selector2.TabIndex = 1;
            this.selector2.Text = "-->";
            this.selector2.UseVisualStyleBackColor = true;
            this.selector2.Click += new System.EventHandler(this.selector2_Click);
            // 
            // selector1
            // 
            this.selector1.Location = new System.Drawing.Point(108, 166);
            this.selector1.Name = "selector1";
            this.selector1.Size = new System.Drawing.Size(75, 55);
            this.selector1.TabIndex = 2;
            this.selector1.Text = "<---";
            this.selector1.UseVisualStyleBackColor = true;
            this.selector1.Click += new System.EventHandler(this.selector1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selector1);
            this.Controls.Add(this.selector2);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Button selector2;
        private System.Windows.Forms.Button selector1;
    }
}

