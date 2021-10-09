
namespace wf_ProjetoAluno
{
    partial class frmDisciplinas
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
            this.txtCodDisciplina = new System.Windows.Forms.TextBox();
            this.txtSiglaDis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObsDis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btCadastrarDis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codígo do Disciplina";
            // 
            // txtCodDisciplina
            // 
            this.txtCodDisciplina.Location = new System.Drawing.Point(40, 52);
            this.txtCodDisciplina.Name = "txtCodDisciplina";
            this.txtCodDisciplina.ReadOnly = true;
            this.txtCodDisciplina.Size = new System.Drawing.Size(100, 20);
            this.txtCodDisciplina.TabIndex = 10;
            // 
            // txtSiglaDis
            // 
            this.txtSiglaDis.Location = new System.Drawing.Point(179, 52);
            this.txtSiglaDis.MaxLength = 25;
            this.txtSiglaDis.Name = "txtSiglaDis";
            this.txtSiglaDis.Size = new System.Drawing.Size(100, 20);
            this.txtSiglaDis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sigla da Disciplina";
            // 
            // txtDis
            // 
            this.txtDis.Location = new System.Drawing.Point(40, 111);
            this.txtDis.MaxLength = 50;
            this.txtDis.Name = "txtDis";
            this.txtDis.Size = new System.Drawing.Size(239, 20);
            this.txtDis.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Disciplina";
            // 
            // txtObsDis
            // 
            this.txtObsDis.Location = new System.Drawing.Point(40, 178);
            this.txtObsDis.MaxLength = 500;
            this.txtObsDis.Name = "txtObsDis";
            this.txtObsDis.Size = new System.Drawing.Size(344, 20);
            this.txtObsDis.TabIndex = 7;
            this.txtObsDis.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Observações";
            // 
            // btCadastrarDis
            // 
            this.btCadastrarDis.Location = new System.Drawing.Point(309, 232);
            this.btCadastrarDis.Name = "btCadastrarDis";
            this.btCadastrarDis.Size = new System.Drawing.Size(75, 23);
            this.btCadastrarDis.TabIndex = 8;
            this.btCadastrarDis.Text = "Cadastrar";
            this.btCadastrarDis.UseVisualStyleBackColor = true;
            this.btCadastrarDis.Click += new System.EventHandler(this.btCadastrarDis_Click);
            // 
            // frmDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 279);
            this.Controls.Add(this.btCadastrarDis);
            this.Controls.Add(this.txtObsDis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSiglaDis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodDisciplina);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDisciplinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disciplinas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodDisciplina;
        private System.Windows.Forms.TextBox txtSiglaDis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObsDis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btCadastrarDis;
    }
}