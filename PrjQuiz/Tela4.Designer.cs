﻿namespace PrjQuiz
{
    partial class Tela4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAvancar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoVal4 = new System.Windows.Forms.RadioButton();
            this.rdoVal3 = new System.Windows.Forms.RadioButton();
            this.rdoVal2 = new System.Windows.Forms.RadioButton();
            this.rdoVal1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(210, 280);
            this.btnAvancar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(112, 34);
            this.btnAvancar.TabIndex = 0;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoVal4);
            this.groupBox1.Controls.Add(this.rdoVal3);
            this.groupBox1.Controls.Add(this.rdoVal2);
            this.groupBox1.Controls.Add(this.rdoVal1);
            this.groupBox1.Location = new System.Drawing.Point(22, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(300, 202);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Qual o nome da arte marcial que usa apenas socos?";
            // 
            // rdoVal4
            // 
            this.rdoVal4.AutoSize = true;
            this.rdoVal4.Location = new System.Drawing.Point(12, 156);
            this.rdoVal4.Margin = new System.Windows.Forms.Padding(4);
            this.rdoVal4.Name = "rdoVal4";
            this.rdoVal4.Size = new System.Drawing.Size(99, 23);
            this.rdoVal4.TabIndex = 3;
            this.rdoVal4.TabStop = true;
            this.rdoVal4.Text = "Capoeira";
            this.rdoVal4.UseVisualStyleBackColor = true;
            // 
            // rdoVal3
            // 
            this.rdoVal3.AutoSize = true;
            this.rdoVal3.Location = new System.Drawing.Point(12, 121);
            this.rdoVal3.Margin = new System.Windows.Forms.Padding(4);
            this.rdoVal3.Name = "rdoVal3";
            this.rdoVal3.Size = new System.Drawing.Size(63, 23);
            this.rdoVal3.TabIndex = 2;
            this.rdoVal3.TabStop = true;
            this.rdoVal3.Text = "Boxe";
            this.rdoVal3.UseVisualStyleBackColor = true;
            // 
            // rdoVal2
            // 
            this.rdoVal2.AutoSize = true;
            this.rdoVal2.Location = new System.Drawing.Point(12, 86);
            this.rdoVal2.Margin = new System.Windows.Forms.Padding(4);
            this.rdoVal2.Name = "rdoVal2";
            this.rdoVal2.Size = new System.Drawing.Size(81, 23);
            this.rdoVal2.TabIndex = 1;
            this.rdoVal2.TabStop = true;
            this.rdoVal2.Text = "Karatê";
            this.rdoVal2.UseVisualStyleBackColor = true;
            // 
            // rdoVal1
            // 
            this.rdoVal1.AutoSize = true;
            this.rdoVal1.Location = new System.Drawing.Point(12, 51);
            this.rdoVal1.Margin = new System.Windows.Forms.Padding(4);
            this.rdoVal1.Name = "rdoVal1";
            this.rdoVal1.Size = new System.Drawing.Size(90, 23);
            this.rdoVal1.TabIndex = 0;
            this.rdoVal1.TabStop = true;
            this.rdoVal1.Text = "Kung-Fu";
            this.rdoVal1.UseVisualStyleBackColor = true;
            // 
            // Tela4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 335);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAvancar);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tela4";
            this.Padding = new System.Windows.Forms.Padding(30, 88, 30, 29);
            this.Text = "Pergunta 4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoVal4;
        private System.Windows.Forms.RadioButton rdoVal3;
        private System.Windows.Forms.RadioButton rdoVal2;
        private System.Windows.Forms.RadioButton rdoVal1;
    }
}