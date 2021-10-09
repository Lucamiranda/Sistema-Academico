
namespace wf_ProjetoAluno
{
    partial class frmCursoConsultar
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
            this.txtObsCurso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSiglaCurso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodCurso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btExcluirCur = new System.Windows.Forms.Button();
            this.btAlerarCur = new System.Windows.Forms.Button();
            this.btConsultarCur = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPeriodo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtObsCurso
            // 
            this.txtObsCurso.Location = new System.Drawing.Point(52, 217);
            this.txtObsCurso.MaxLength = 500;
            this.txtObsCurso.Name = "txtObsCurso";
            this.txtObsCurso.Size = new System.Drawing.Size(344, 20);
            this.txtObsCurso.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Observações";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(52, 104);
            this.txtCurso.MaxLength = 50;
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(239, 20);
            this.txtCurso.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Curso";
            // 
            // txtSiglaCurso
            // 
            this.txtSiglaCurso.Location = new System.Drawing.Point(191, 45);
            this.txtSiglaCurso.MaxLength = 25;
            this.txtSiglaCurso.Name = "txtSiglaCurso";
            this.txtSiglaCurso.Size = new System.Drawing.Size(100, 20);
            this.txtSiglaCurso.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Sigla do Curso";
            // 
            // txtCodCurso
            // 
            this.txtCodCurso.Location = new System.Drawing.Point(52, 45);
            this.txtCodCurso.Name = "txtCodCurso";
            this.txtCodCurso.ReadOnly = true;
            this.txtCodCurso.Size = new System.Drawing.Size(100, 20);
            this.txtCodCurso.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Codígo do Curso";
            // 
            // btExcluirCur
            // 
            this.btExcluirCur.Location = new System.Drawing.Point(325, 270);
            this.btExcluirCur.Name = "btExcluirCur";
            this.btExcluirCur.Size = new System.Drawing.Size(100, 23);
            this.btExcluirCur.TabIndex = 29;
            this.btExcluirCur.Text = "Excluir";
            this.btExcluirCur.UseVisualStyleBackColor = true;
            this.btExcluirCur.Click += new System.EventHandler(this.btExcluirCur_Click);
            // 
            // btAlerarCur
            // 
            this.btAlerarCur.Location = new System.Drawing.Point(177, 271);
            this.btAlerarCur.Name = "btAlerarCur";
            this.btAlerarCur.Size = new System.Drawing.Size(100, 23);
            this.btAlerarCur.TabIndex = 28;
            this.btAlerarCur.Text = "Alterar";
            this.btAlerarCur.UseVisualStyleBackColor = true;
            this.btAlerarCur.Click += new System.EventHandler(this.btAlerarCur_Click);
            // 
            // btConsultarCur
            // 
            this.btConsultarCur.Location = new System.Drawing.Point(36, 272);
            this.btConsultarCur.Name = "btConsultarCur";
            this.btConsultarCur.Size = new System.Drawing.Size(100, 23);
            this.btConsultarCur.TabIndex = 27;
            this.btConsultarCur.Text = "Consultar";
            this.btConsultarCur.UseVisualStyleBackColor = true;
            this.btConsultarCur.Click += new System.EventHandler(this.btConsultarCur_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Periodo";
            // 
            // cbPeriodo
            // 
            this.cbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodo.FormattingEnabled = true;
            this.cbPeriodo.Location = new System.Drawing.Point(52, 154);
            this.cbPeriodo.Name = "cbPeriodo";
            this.cbPeriodo.Size = new System.Drawing.Size(121, 21);
            this.cbPeriodo.TabIndex = 24;
            this.cbPeriodo.SelectedIndexChanged += new System.EventHandler(this.cbPeriodo_SelectedIndexChanged);
            // 
            // frmCursoConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 310);
            this.Controls.Add(this.cbPeriodo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btExcluirCur);
            this.Controls.Add(this.btAlerarCur);
            this.Controls.Add(this.btConsultarCur);
            this.Controls.Add(this.txtObsCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSiglaCurso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodCurso);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCursoConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curso Consultar";
            this.Load += new System.EventHandler(this.frmCursoConsultar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtObsCurso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSiglaCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExcluirCur;
        private System.Windows.Forms.Button btAlerarCur;
        private System.Windows.Forms.Button btConsultarCur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPeriodo;
    }
}