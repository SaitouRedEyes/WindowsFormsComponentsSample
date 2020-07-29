namespace PlayerSelectionMissionV2
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
            this.cbHuman = new System.Windows.Forms.CheckBox();
            this.cbDwarf = new System.Windows.Forms.CheckBox();
            this.cbElf = new System.Windows.Forms.CheckBox();
            this.cbSorcerer = new System.Windows.Forms.CheckBox();
            this.rbMission1 = new System.Windows.Forms.RadioButton();
            this.rbMission2 = new System.Windows.Forms.RadioButton();
            this.rbMission3 = new System.Windows.Forms.RadioButton();
            this.rbMission4 = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbHuman
            // 
            this.cbHuman.AutoSize = true;
            this.cbHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHuman.Location = new System.Drawing.Point(74, 38);
            this.cbHuman.Name = "cbHuman";
            this.cbHuman.Size = new System.Drawing.Size(114, 30);
            this.cbHuman.TabIndex = 0;
            this.cbHuman.Text = "Humano";
            this.cbHuman.UseVisualStyleBackColor = true;
            // 
            // cbDwarf
            // 
            this.cbDwarf.AutoSize = true;
            this.cbDwarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDwarf.Location = new System.Drawing.Point(74, 104);
            this.cbDwarf.Name = "cbDwarf";
            this.cbDwarf.Size = new System.Drawing.Size(82, 30);
            this.cbDwarf.TabIndex = 1;
            this.cbDwarf.Text = "Anão";
            this.cbDwarf.UseVisualStyleBackColor = true;
            // 
            // cbElf
            // 
            this.cbElf.AutoSize = true;
            this.cbElf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbElf.Location = new System.Drawing.Point(74, 180);
            this.cbElf.Name = "cbElf";
            this.cbElf.Size = new System.Drawing.Size(69, 30);
            this.cbElf.TabIndex = 2;
            this.cbElf.Text = "Elfo";
            this.cbElf.UseVisualStyleBackColor = true;
            // 
            // cbSorcerer
            // 
            this.cbSorcerer.AutoSize = true;
            this.cbSorcerer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSorcerer.Location = new System.Drawing.Point(74, 254);
            this.cbSorcerer.Name = "cbSorcerer";
            this.cbSorcerer.Size = new System.Drawing.Size(119, 30);
            this.cbSorcerer.TabIndex = 3;
            this.cbSorcerer.Text = "Feiticeiro";
            this.cbSorcerer.UseVisualStyleBackColor = true;
            // 
            // rbMission1
            // 
            this.rbMission1.AutoSize = true;
            this.rbMission1.Checked = true;
            this.rbMission1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMission1.Location = new System.Drawing.Point(302, 50);
            this.rbMission1.Name = "rbMission1";
            this.rbMission1.Size = new System.Drawing.Size(301, 30);
            this.rbMission1.TabIndex = 4;
            this.rbMission1.TabStop = true;
            this.rbMission1.Text = "Matar Wyvern Real ( todos )";
            this.rbMission1.UseVisualStyleBackColor = true;
            // 
            // rbMission2
            // 
            this.rbMission2.AutoSize = true;
            this.rbMission2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMission2.Location = new System.Drawing.Point(302, 113);
            this.rbMission2.Name = "rbMission2";
            this.rbMission2.Size = new System.Drawing.Size(395, 30);
            this.rbMission2.TabIndex = 5;
            this.rbMission2.TabStop = true;
            this.rbMission2.Text = "Exorcisar Aparição Noturna ( 2 ou + ) ";
            this.rbMission2.UseVisualStyleBackColor = true;
            // 
            // rbMission3
            // 
            this.rbMission3.AutoSize = true;
            this.rbMission3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMission3.Location = new System.Drawing.Point(302, 189);
            this.rbMission3.Name = "rbMission3";
            this.rbMission3.Size = new System.Drawing.Size(420, 30);
            this.rbMission3.TabIndex = 6;
            this.rbMission3.TabStop = true;
            this.rbMission3.Text = "Coletar Minério Raro ( Humano e Anão )";
            this.rbMission3.UseVisualStyleBackColor = true;
            // 
            // rbMission4
            // 
            this.rbMission4.AutoSize = true;
            this.rbMission4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMission4.Location = new System.Drawing.Point(302, 263);
            this.rbMission4.Name = "rbMission4";
            this.rbMission4.Size = new System.Drawing.Size(343, 30);
            this.rbMission4.TabIndex = 7;
            this.rbMission4.TabStop = true;
            this.rbMission4.Text = "Seduzir a Rainha Gelada ( Elfo )";
            this.rbMission4.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(666, 306);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(122, 52);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "Ir para Missão";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rbMission4);
            this.Controls.Add(this.rbMission3);
            this.Controls.Add(this.rbMission2);
            this.Controls.Add(this.rbMission1);
            this.Controls.Add(this.cbSorcerer);
            this.Controls.Add(this.cbElf);
            this.Controls.Add(this.cbDwarf);
            this.Controls.Add(this.cbHuman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbHuman;
        private System.Windows.Forms.CheckBox cbDwarf;
        private System.Windows.Forms.CheckBox cbElf;
        private System.Windows.Forms.CheckBox cbSorcerer;
        private System.Windows.Forms.RadioButton rbMission1;
        private System.Windows.Forms.RadioButton rbMission2;
        private System.Windows.Forms.RadioButton rbMission3;
        private System.Windows.Forms.RadioButton rbMission4;
        private System.Windows.Forms.Button btnOK;
    }
}

