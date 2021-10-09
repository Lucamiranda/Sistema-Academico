
namespace wf_ProjetoAluno
{
    partial class frmPeriodoConsultar
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
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdcod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btConsultarPer = new System.Windows.Forms.Button();
            this.btAlerarPer = new System.Windows.Forms.Button();
            this.btExcluirPer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(345, 45);
            this.txtSigla.MaxLength = 25;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(100, 20);
            this.txtSigla.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sigla";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(197, 45);
            this.txtPeriodo.MaxLength = 50;
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(100, 20);
            this.txtPeriodo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Período";
            // 
            // txtIdcod
            // 
            this.txtIdcod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdcod.Location = new System.Drawing.Point(56, 45);
            this.txtIdcod.Name = "txtIdcod";
            this.txtIdcod.ReadOnly = true;
            this.txtIdcod.Size = new System.Drawing.Size(100, 20);
            this.txtIdcod.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codígo Periodo";
            // 
            // btConsultarPer
            // 
            this.btConsultarPer.Location = new System.Drawing.Point(56, 87);
            this.btConsultarPer.Name = "btConsultarPer";
            this.btConsultarPer.Size = new System.Drawing.Size(100, 23);
            this.btConsultarPer.TabIndex = 13;
            this.btConsultarPer.Text = "Consultar";
            this.btConsultarPer.UseVisualStyleBackColor = true;
            this.btConsultarPer.Click += new System.EventHandler(this.btConsultarPer_Click);
            // 
            // btAlerarPer
            // 
            this.btAlerarPer.Location = new System.Drawing.Point(197, 86);
            this.btAlerarPer.Name = "btAlerarPer";
            this.btAlerarPer.Size = new System.Drawing.Size(100, 23);
            this.btAlerarPer.TabIndex = 14;
            this.btAlerarPer.Text = "Alterar";
            this.btAlerarPer.UseVisualStyleBackColor = true;
            this.btAlerarPer.Click += new System.EventHandler(this.btAlerarPer_Click);
            // 
            // btExcluirPer
            // 
            this.btExcluirPer.Location = new System.Drawing.Point(345, 85);
            this.btExcluirPer.Name = "btExcluirPer";
            this.btExcluirPer.Size = new System.Drawing.Size(100, 23);
            this.btExcluirPer.TabIndex = 15;
            this.btExcluirPer.Text = "Excluir";
            this.btExcluirPer.UseVisualStyleBackColor = true;
            this.btExcluirPer.Click += new System.EventHandler(this.btExcluirPer_Click);
            // 
            // frmPeriodoConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 143);
            this.Controls.Add(this.btExcluirPer);
            this.Controls.Add(this.btAlerarPer);
            this.Controls.Add(this.btConsultarPer);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdcod);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPeriodoConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Periodo Consultar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdcod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConsultarPer;
        private System.Windows.Forms.Button btAlerarPer;
        private System.Windows.Forms.Button btExcluirPer;
    }
}