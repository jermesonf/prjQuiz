﻿namespace PrjQuiz
{
    partial class Tela6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoVal1 = new System.Windows.Forms.RadioButton();
            this.rdoVal2 = new System.Windows.Forms.RadioButton();
            this.rdoVal3 = new System.Windows.Forms.RadioButton();
            this.rdoVal4 = new System.Windows.Forms.RadioButton();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoVal4);
            this.groupBox1.Controls.Add(this.rdoVal3);
            this.groupBox1.Controls.Add(this.rdoVal2);
            this.groupBox1.Controls.Add(this.rdoVal1);
            this.groupBox1.Location = new System.Drawing.Point(23, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(300, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quantas cartas tem um baralho comum?";
            // 
            // rdoVal1
            // 
            this.rdoVal1.AutoSize = true;
            this.rdoVal1.Location = new System.Drawing.Point(8, 53);
            this.rdoVal1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoVal1.Name = "rdoVal1";
            this.rdoVal1.Size = new System.Drawing.Size(45, 23);
            this.rdoVal1.TabIndex = 0;
            this.rdoVal1.TabStop = true;
            this.rdoVal1.Text = "52";
            this.rdoVal1.UseVisualStyleBackColor = true;
            // 
            // rdoVal2
            // 
            this.rdoVal2.AutoSize = true;
            this.rdoVal2.Location = new System.Drawing.Point(8, 88);
            this.rdoVal2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoVal2.Name = "rdoVal2";
            this.rdoVal2.Size = new System.Drawing.Size(45, 23);
            this.rdoVal2.TabIndex = 1;
            this.rdoVal2.TabStop = true;
            this.rdoVal2.Text = "50";
            this.rdoVal2.UseVisualStyleBackColor = true;
            // 
            // rdoVal3
            // 
            this.rdoVal3.AutoSize = true;
            this.rdoVal3.Location = new System.Drawing.Point(8, 123);
            this.rdoVal3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoVal3.Name = "rdoVal3";
            this.rdoVal3.Size = new System.Drawing.Size(45, 23);
            this.rdoVal3.TabIndex = 2;
            this.rdoVal3.TabStop = true;
            this.rdoVal3.Text = "54";
            this.rdoVal3.UseVisualStyleBackColor = true;
            // 
            // rdoVal4
            // 
            this.rdoVal4.AutoSize = true;
            this.rdoVal4.Location = new System.Drawing.Point(8, 158);
            this.rdoVal4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoVal4.Name = "rdoVal4";
            this.rdoVal4.Size = new System.Drawing.Size(45, 23);
            this.rdoVal4.TabIndex = 3;
            this.rdoVal4.TabStop = true;
            this.rdoVal4.Text = "48";
            this.rdoVal4.UseVisualStyleBackColor = true;
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(234, 315);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(89, 40);
            this.btnAvancar.TabIndex = 1;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // Tela6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 364);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Tela6";
            this.Padding = new System.Windows.Forms.Padding(30, 88, 30, 29);
            this.Text = "Pergunta 6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoVal4;
        private System.Windows.Forms.RadioButton rdoVal3;
        private System.Windows.Forms.RadioButton rdoVal2;
        private System.Windows.Forms.RadioButton rdoVal1;
        private System.Windows.Forms.Button btnAvancar;
    }
}