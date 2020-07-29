namespace WordConstruct
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
            this.btnA = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(70, 66);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(73, 66);
            this.btnA.TabIndex = 0;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(149, 66);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(81, 66);
            this.btnE.TabIndex = 1;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnI
            // 
            this.btnI.Location = new System.Drawing.Point(236, 66);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(74, 66);
            this.btnI.TabIndex = 2;
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // btnO
            // 
            this.btnO.Location = new System.Drawing.Point(316, 66);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(72, 66);
            this.btnO.TabIndex = 3;
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.btnO_Click);
            // 
            // btnU
            // 
            this.btnU.Location = new System.Drawing.Point(394, 66);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(76, 66);
            this.btnU.TabIndex = 4;
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.btnU_Click);
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(70, 138);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 69);
            this.btnP.TabIndex = 5;
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnP_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(151, 138);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(79, 69);
            this.btnR.TabIndex = 6;
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(236, 138);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(74, 69);
            this.btnS.TabIndex = 7;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(316, 138);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(72, 69);
            this.btnT.TabIndex = 8;
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(394, 138);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(76, 69);
            this.btnC.TabIndex = 9;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(236, 213);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(76, 69);
            this.btnResult.TabIndex = 10;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.btnU);
            this.Controls.Add(this.btnO);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.Button btnO;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnResult;
    }
}

