
namespace wf_ProjetoAluno
{
    partial class frmDisciplinaPesquisa
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
            this.dgDisciplinas = new System.Windows.Forms.DataGridView();
            this.btSelecionar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDisciplinas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDisciplinas
            // 
            this.dgDisciplinas.AllowUserToAddRows = false;
            this.dgDisciplinas.AllowUserToDeleteRows = false;
            this.dgDisciplinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDisciplinas.Location = new System.Drawing.Point(12, 12);
            this.dgDisciplinas.MultiSelect = false;
            this.dgDisciplinas.Name = "dgDisciplinas";
            this.dgDisciplinas.ReadOnly = true;
            this.dgDisciplinas.Size = new System.Drawing.Size(776, 150);
            this.dgDisciplinas.TabIndex = 0;
            // 
            // btSelecionar
            // 
            this.btSelecionar.Location = new System.Drawing.Point(12, 222);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(118, 23);
            this.btSelecionar.TabIndex = 1;
            this.btSelecionar.Text = "Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = true;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(322, 222);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(118, 23);
            this.btAtualizar.TabIndex = 2;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(670, 222);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(118, 23);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // frmDisciplinaPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 268);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.dgDisciplinas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDisciplinaPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Disciplinas";
            ((System.ComponentModel.ISupportInitialize)(this.dgDisciplinas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDisciplinas;
        private System.Windows.Forms.Button btSelecionar;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btSair;
    }
}