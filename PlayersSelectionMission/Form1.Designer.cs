namespace PlayersSelectionMission
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
            this.warrior = new System.Windows.Forms.CheckBox();
            this.mage = new System.Windows.Forms.CheckBox();
            this.archer = new System.Windows.Forms.CheckBox();
            this.cleric = new System.Windows.Forms.CheckBox();
            this.assassin = new System.Windows.Forms.CheckBox();
            this.mission1 = new System.Windows.Forms.RadioButton();
            this.mission2 = new System.Windows.Forms.RadioButton();
            this.mission3 = new System.Windows.Forms.RadioButton();
            this.goToMission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // warrior
            // 
            this.warrior.AutoSize = true;
            this.warrior.Location = new System.Drawing.Point(76, 45);
            this.warrior.Name = "warrior";
            this.warrior.Size = new System.Drawing.Size(69, 17);
            this.warrior.TabIndex = 0;
            this.warrior.Text = "Guerreiro";
            this.warrior.UseVisualStyleBackColor = true;
            // 
            // mage
            // 
            this.mage.AutoSize = true;
            this.mage.Location = new System.Drawing.Point(76, 81);
            this.mage.Name = "mage";
            this.mage.Size = new System.Drawing.Size(53, 17);
            this.mage.TabIndex = 1;
            this.mage.Text = "Mago";
            this.mage.UseVisualStyleBackColor = true;
            // 
            // archer
            // 
            this.archer.AutoSize = true;
            this.archer.Location = new System.Drawing.Point(76, 121);
            this.archer.Name = "archer";
            this.archer.Size = new System.Drawing.Size(65, 17);
            this.archer.TabIndex = 2;
            this.archer.Text = "Arqueiro";
            this.archer.UseVisualStyleBackColor = true;
            // 
            // cleric
            // 
            this.cleric.AutoSize = true;
            this.cleric.Location = new System.Drawing.Point(76, 161);
            this.cleric.Name = "cleric";
            this.cleric.Size = new System.Drawing.Size(58, 17);
            this.cleric.TabIndex = 3;
            this.cleric.Text = "Clérigo";
            this.cleric.UseVisualStyleBackColor = true;
            // 
            // assassin
            // 
            this.assassin.AutoSize = true;
            this.assassin.Location = new System.Drawing.Point(76, 205);
            this.assassin.Name = "assassin";
            this.assassin.Size = new System.Drawing.Size(73, 17);
            this.assassin.TabIndex = 4;
            this.assassin.Text = "Assassino";
            this.assassin.UseVisualStyleBackColor = true;
            // 
            // mission1
            // 
            this.mission1.AutoSize = true;
            this.mission1.Checked = true;
            this.mission1.Location = new System.Drawing.Point(441, 45);
            this.mission1.Name = "mission1";
            this.mission1.Size = new System.Drawing.Size(164, 17);
            this.mission1.TabIndex = 5;
            this.mission1.TabStop = true;
            this.mission1.Text = "Matar Tiamat (requer 4 chars)";
            this.mission1.UseVisualStyleBackColor = true;
            // 
            // mission2
            // 
            this.mission2.AutoSize = true;
            this.mission2.Location = new System.Drawing.Point(441, 95);
            this.mission2.Name = "mission2";
            this.mission2.Size = new System.Drawing.Size(159, 17);
            this.mission2.TabIndex = 6;
            this.mission2.TabStop = true;
            this.mission2.Text = "Coletar ervas (requer 1 char)";
            this.mission2.UseVisualStyleBackColor = true;
            // 
            // mission3
            // 
            this.mission3.AutoSize = true;
            this.mission3.Location = new System.Drawing.Point(441, 160);
            this.mission3.Name = "mission3";
            this.mission3.Size = new System.Drawing.Size(254, 17);
            this.mission3.TabIndex = 7;
            this.mission3.Text = "Encontrar o pergaminho secreto (requer o Mago)";
            this.mission3.UseVisualStyleBackColor = true;
            // 
            // goToMission
            // 
            this.goToMission.Location = new System.Drawing.Point(549, 279);
            this.goToMission.Name = "goToMission";
            this.goToMission.Size = new System.Drawing.Size(212, 64);
            this.goToMission.TabIndex = 8;
            this.goToMission.Text = "Ir para Missão";
            this.goToMission.UseVisualStyleBackColor = true;
            this.goToMission.Click += new System.EventHandler(this.goToMission_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goToMission);
            this.Controls.Add(this.mission3);
            this.Controls.Add(this.mission2);
            this.Controls.Add(this.mission1);
            this.Controls.Add(this.assassin);
            this.Controls.Add(this.cleric);
            this.Controls.Add(this.archer);
            this.Controls.Add(this.mage);
            this.Controls.Add(this.warrior);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox warrior;
        private System.Windows.Forms.CheckBox mage;
        private System.Windows.Forms.CheckBox archer;
        private System.Windows.Forms.CheckBox cleric;
        private System.Windows.Forms.CheckBox assassin;
        private System.Windows.Forms.RadioButton mission1;
        private System.Windows.Forms.RadioButton mission2;
        private System.Windows.Forms.RadioButton mission3;
        private System.Windows.Forms.Button goToMission;
    }
}

