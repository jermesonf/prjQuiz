namespace PrjQuiz
{
    partial class Tela1
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
            this.rdoVal1 = new System.Windows.Forms.RadioButton();
            this.rdoVal2 = new System.Windows.Forms.RadioButton();
            this.rdoVal3 = new System.Windows.Forms.RadioButton();
            this.rdoVal4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoVal1
            // 
            this.rdoVal1.AutoSize = true;
            this.rdoVal1.Location = new System.Drawing.Point(8, 47);
            this.rdoVal1.Margin = new System.Windows.Forms.Padding(4);
            this.rdoVal1.Name = "rdoVal1";
            this.rdoVal1.Size = new System.Drawing.Size(63, 23);
            this.rdoVal1.TabIndex = 0;
            this.rdoVal1.TabStop = true;
            this.rdoVal1.Text = "Alce";
            this.rdoVal1.UseVisualStyleBackColor = true;
            // 
            // rdoVal2
            // 
            this.rdoVal2.AutoSize = true;
            this.rdoVal2.Location = new System.Drawing.Point(8, 78);
            this.rdoVal2.Margin = new System.Windows.Forms.Padding(4);
            this.rdoVal2.Name = "rdoVal2";
            this.rdoVal2.Size = new System.Drawing.Size(72, 23);
            this.rdoVal2.TabIndex = 1;
            this.rdoVal2.TabStop = true;
            this.rdoVal2.Text = "Hiena";
            this.rdoVal2.UseVisualStyleBackColor = true;
            // 
            // rdoVal3
            // 
            this.rdoVal3.AutoSize = true;
            this.rdoVal3.Location = new System.Drawing.Point(8, 109);
            this.rdoVal3.Margin = new System.Windows.Forms.Padding(4);
            this.rdoVal3.Name = "rdoVal3";
            this.rdoVal3.Size = new System.Drawing.Size(90, 23);
            this.rdoVal3.TabIndex = 2;
            this.rdoVal3.TabStop = true;
            this.rdoVal3.Text = "Tubarão";
            this.rdoVal3.UseVisualStyleBackColor = true;
            // 
            // rdoVal4
            // 
            this.rdoVal4.AutoSize = true;
            this.rdoVal4.Location = new System.Drawing.Point(8, 140);
            this.rdoVal4.Margin = new System.Windows.Forms.Padding(4);
            this.rdoVal4.Name = "rdoVal4";
            this.rdoVal4.Size = new System.Drawing.Size(99, 23);
            this.rdoVal4.TabIndex = 3;
            this.rdoVal4.TabStop = true;
            this.rdoVal4.Text = "Cachorro";
            this.rdoVal4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoVal3);
            this.groupBox1.Controls.Add(this.rdoVal1);
            this.groupBox1.Controls.Add(this.rdoVal2);
            this.groupBox1.Controls.Add(this.rdoVal4);
            this.groupBox1.Location = new System.Drawing.Point(24, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(144, 230);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Melhor amigo?";
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(84, 334);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(84, 39);
            this.btnAvancar.TabIndex = 5;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // Tela1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 385);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tela1";
            this.Text = "Pergunta 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoVal1;
        private System.Windows.Forms.RadioButton rdoVal2;
        private System.Windows.Forms.RadioButton rdoVal3;
        private System.Windows.Forms.RadioButton rdoVal4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAvancar;
    }
}

