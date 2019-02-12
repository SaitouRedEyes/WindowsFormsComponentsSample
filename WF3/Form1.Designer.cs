namespace WF3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbWarrior = new System.Windows.Forms.RadioButton();
            this.rbMage = new System.Windows.Forms.RadioButton();
            this.rbArcher = new System.Windows.Forms.RadioButton();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.tbPlayer = new System.Windows.Forms.TextBox();
            this.cbPlayers = new System.Windows.Forms.ComboBox();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nick";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Classe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Player Selecionado";
            // 
            // rbWarrior
            // 
            this.rbWarrior.AutoSize = true;
            this.rbWarrior.Checked = true;
            this.rbWarrior.Location = new System.Drawing.Point(58, 198);
            this.rbWarrior.Name = "rbWarrior";
            this.rbWarrior.Size = new System.Drawing.Size(59, 17);
            this.rbWarrior.TabIndex = 4;
            this.rbWarrior.TabStop = true;
            this.rbWarrior.Text = "Warrior";
            this.rbWarrior.UseVisualStyleBackColor = true;
            // 
            // rbMage
            // 
            this.rbMage.AutoSize = true;
            this.rbMage.Location = new System.Drawing.Point(58, 231);
            this.rbMage.Name = "rbMage";
            this.rbMage.Size = new System.Drawing.Size(52, 17);
            this.rbMage.TabIndex = 5;
            this.rbMage.TabStop = true;
            this.rbMage.Text = "Mage";
            this.rbMage.UseVisualStyleBackColor = true;
            // 
            // rbArcher
            // 
            this.rbArcher.AutoSize = true;
            this.rbArcher.Location = new System.Drawing.Point(58, 263);
            this.rbArcher.Name = "rbArcher";
            this.rbArcher.Size = new System.Drawing.Size(56, 17);
            this.rbArcher.TabIndex = 6;
            this.rbArcher.TabStop = true;
            this.rbArcher.Text = "Archer";
            this.rbArcher.UseVisualStyleBackColor = true;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Location = new System.Drawing.Point(283, 202);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(0, 13);
            this.labelPlayer.TabIndex = 7;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(283, 219);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(0, 13);
            this.labelClass.TabIndex = 8;
            // 
            // tbPlayer
            // 
            this.tbPlayer.Location = new System.Drawing.Point(58, 38);
            this.tbPlayer.Name = "tbPlayer";
            this.tbPlayer.Size = new System.Drawing.Size(100, 20);
            this.tbPlayer.TabIndex = 9;
            // 
            // cbPlayers
            // 
            this.cbPlayers.FormattingEnabled = true;
            this.cbPlayers.Location = new System.Drawing.Point(275, 37);
            this.cbPlayers.Name = "cbPlayers";
            this.cbPlayers.Size = new System.Drawing.Size(121, 21);
            this.cbPlayers.TabIndex = 10;
            this.cbPlayers.SelectedIndexChanged += new System.EventHandler(this.cbPlayers_SelectedIndexChanged);
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Location = new System.Drawing.Point(370, 348);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPlayer.TabIndex = 11;
            this.buttonAddPlayer.Text = "Adicionar";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.cbPlayers);
            this.Controls.Add(this.tbPlayer);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelPlayer);
            this.Controls.Add(this.rbArcher);
            this.Controls.Add(this.rbMage);
            this.Controls.Add(this.rbWarrior);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbWarrior;
        private System.Windows.Forms.RadioButton rbMage;
        private System.Windows.Forms.RadioButton rbArcher;
        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.TextBox tbPlayer;
        private System.Windows.Forms.ComboBox cbPlayers;
        private System.Windows.Forms.Button buttonAddPlayer;
    }
}

