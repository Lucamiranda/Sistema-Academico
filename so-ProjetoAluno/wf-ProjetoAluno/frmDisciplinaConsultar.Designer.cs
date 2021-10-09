
namespace wf_ProjetoAluno
{
    partial class frmDisciplinaConsultar
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
            this.txtObsDisciplina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDisciplina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSiglaDisciplina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodDisciplina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btExcluirDis = new System.Windows.Forms.Button();
            this.btAlerarDis = new System.Windows.Forms.Button();
            this.btConsultarDis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtObsDisciplina
            // 
            this.txtObsDisciplina.Location = new System.Drawing.Point(90, 186);
            this.txtObsDisciplina.MaxLength = 500;
            this.txtObsDisciplina.Name = "txtObsDisciplina";
            this.txtObsDisciplina.Size = new System.Drawing.Size(344, 20);
            this.txtObsDisciplina.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Observações";
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.Location = new System.Drawing.Point(90, 119);
            this.txtDisciplina.MaxLength = 50;
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.Size = new System.Drawing.Size(239, 20);
            this.txtDisciplina.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Disciplina";
            // 
            // txtSiglaDisciplina
            // 
            this.txtSiglaDisciplina.Location = new System.Drawing.Point(229, 60);
            this.txtSiglaDisciplina.MaxLength = 25;
            this.txtSiglaDisciplina.Name = "txtSiglaDisciplina";
            this.txtSiglaDisciplina.Size = new System.Drawing.Size(100, 20);
            this.txtSiglaDisciplina.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sigla da Disciplina";
            // 
            // txtCodDisciplina
            // 
            this.txtCodDisciplina.Location = new System.Drawing.Point(90, 60);
            this.txtCodDisciplina.Name = "txtCodDisciplina";
            this.txtCodDisciplina.ReadOnly = true;
            this.txtCodDisciplina.Size = new System.Drawing.Size(100, 20);
            this.txtCodDisciplina.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codígo do Disciplina";
            // 
            // btExcluirDis
            // 
            this.btExcluirDis.Location = new System.Drawing.Point(359, 237);
            this.btExcluirDis.Name = "btExcluirDis";
            this.btExcluirDis.Size = new System.Drawing.Size(100, 23);
            this.btExcluirDis.TabIndex = 18;
            this.btExcluirDis.Text = "Excluir";
            this.btExcluirDis.UseVisualStyleBackColor = true;
            this.btExcluirDis.Click += new System.EventHandler(this.btExcluirDis_Click);
            // 
            // btAlerarDis
            // 
            this.btAlerarDis.Location = new System.Drawing.Point(211, 238);
            this.btAlerarDis.Name = "btAlerarDis";
            this.btAlerarDis.Size = new System.Drawing.Size(100, 23);
            this.btAlerarDis.TabIndex = 17;
            this.btAlerarDis.Text = "Alterar";
            this.btAlerarDis.UseVisualStyleBackColor = true;
            this.btAlerarDis.Click += new System.EventHandler(this.btAlerarDis_Click);
            // 
            // btConsultarDis
            // 
            this.btConsultarDis.Location = new System.Drawing.Point(70, 239);
            this.btConsultarDis.Name = "btConsultarDis";
            this.btConsultarDis.Size = new System.Drawing.Size(100, 23);
            this.btConsultarDis.TabIndex = 16;
            this.btConsultarDis.Text = "Consultar";
            this.btConsultarDis.UseVisualStyleBackColor = true;
            this.btConsultarDis.Click += new System.EventHandler(this.btConsultarDis_Click);
            // 
            // frmDisciplinaConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 307);
            this.Controls.Add(this.btExcluirDis);
            this.Controls.Add(this.btAlerarDis);
            this.Controls.Add(this.btConsultarDis);
            this.Controls.Add(this.txtObsDisciplina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDisciplina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSiglaDisciplina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodDisciplina);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDisciplinaConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disciplina Consultar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtObsDisciplina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDisciplina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSiglaDisciplina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodDisciplina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExcluirDis;
        private System.Windows.Forms.Button btAlerarDis;
        private System.Windows.Forms.Button btConsultarDis;
    }
}