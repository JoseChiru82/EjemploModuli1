namespace EjemploModuli1
{
    partial class FrmConteoRegresivo
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.txtResp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInicial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Suma de Valores";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEjecutar);
            this.panel1.Controls.Add(this.txtResp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtFinal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtInicial);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(174, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 294);
            this.panel1.TabIndex = 2;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(173, 237);
            this.btnEjecutar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(153, 46);
            this.btnEjecutar.TabIndex = 6;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // txtResp
            // 
            this.txtResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResp.Location = new System.Drawing.Point(217, 178);
            this.txtResp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtResp.Name = "txtResp";
            this.txtResp.ReadOnly = true;
            this.txtResp.Size = new System.Drawing.Size(125, 38);
            this.txtResp.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Resp: ";
            // 
            // txtFinal
            // 
            this.txtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.Location = new System.Drawing.Point(217, 114);
            this.txtFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(125, 38);
            this.txtFinal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Final: ";
            // 
            // txtInicial
            // 
            this.txtInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInicial.Location = new System.Drawing.Point(217, 36);
            this.txtInicial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(125, 38);
            this.txtInicial.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor Inicial: ";
            // 
            // FrmConteoRegresivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmConteoRegresivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConteoRegresivo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.TextBox txtResp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInicial;
        private System.Windows.Forms.Label label2;
    }
}