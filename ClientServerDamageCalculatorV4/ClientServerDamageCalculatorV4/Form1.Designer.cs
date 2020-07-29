namespace ClientServerDamageCalculatorV4
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
            this.cbAttacks = new System.Windows.Forms.ComboBox();
            this.cbStab = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBlisseyHP = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbAttacks
            // 
            this.cbAttacks.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cbAttacks.FormattingEnabled = true;
            this.cbAttacks.Items.AddRange(new object[] {
            "Stone Edge",
            "Bite",
            "Earthquake"});
            this.cbAttacks.Location = new System.Drawing.Point(30, 76);
            this.cbAttacks.Name = "cbAttacks";
            this.cbAttacks.Size = new System.Drawing.Size(121, 21);
            this.cbAttacks.TabIndex = 0;
            this.cbAttacks.Text = "Ataques";
            // 
            // cbStab
            // 
            this.cbStab.AutoSize = true;
            this.cbStab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStab.Location = new System.Drawing.Point(30, 40);
            this.cbStab.Name = "cbStab";
            this.cbStab.Size = new System.Drawing.Size(72, 30);
            this.cbStab.TabIndex = 1;
            this.cbStab.Text = "stab";
            this.cbStab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Blissey HP - LVL 100";
            // 
            // lbBlisseyHP
            // 
            this.lbBlisseyHP.AutoSize = true;
            this.lbBlisseyHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBlisseyHP.Location = new System.Drawing.Point(311, 76);
            this.lbBlisseyHP.Name = "lbBlisseyHP";
            this.lbBlisseyHP.Size = new System.Drawing.Size(48, 26);
            this.lbBlisseyHP.TabIndex = 3;
            this.lbBlisseyHP.Text = "714";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(443, 108);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 143);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbBlisseyHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStab);
            this.Controls.Add(this.cbAttacks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAttacks;
        private System.Windows.Forms.CheckBox cbStab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBlisseyHP;
        private System.Windows.Forms.Button btnSubmit;
    }
}

