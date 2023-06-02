namespace ExtensibilityProject1
{
    partial class FDU_ArtigoDescricao
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
            this.tb_codigoArtigo = new System.Windows.Forms.TextBox();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label_codigoArtigo = new System.Windows.Forms.Label();
            this.label_descricao = new System.Windows.Forms.Label();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_codigoArtigo
            // 
            this.tb_codigoArtigo.Location = new System.Drawing.Point(173, 44);
            this.tb_codigoArtigo.Name = "tb_codigoArtigo";
            this.tb_codigoArtigo.Size = new System.Drawing.Size(298, 20);
            this.tb_codigoArtigo.TabIndex = 0;
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(173, 91);
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(298, 98);
            this.tb_descricao.TabIndex = 1;
            // 
            // label_codigoArtigo
            // 
            this.label_codigoArtigo.AutoSize = true;
            this.label_codigoArtigo.Location = new System.Drawing.Point(79, 47);
            this.label_codigoArtigo.Name = "label_codigoArtigo";
            this.label_codigoArtigo.Size = new System.Drawing.Size(88, 13);
            this.label_codigoArtigo.TabIndex = 2;
            this.label_codigoArtigo.Text = "Código de Artigo:";
            // 
            // label_descricao
            // 
            this.label_descricao.AutoSize = true;
            this.label_descricao.Location = new System.Drawing.Point(109, 94);
            this.label_descricao.Name = "label_descricao";
            this.label_descricao.Size = new System.Drawing.Size(58, 13);
            this.label_descricao.TabIndex = 3;
            this.label_descricao.Text = "Descrição:";
            // 
            // btn_verificar
            // 
            this.btn_verificar.Location = new System.Drawing.Point(519, 40);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(75, 23);
            this.btn_verificar.TabIndex = 4;
            this.btn_verificar.Text = "Verificar";
            this.btn_verificar.UseVisualStyleBackColor = true;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(519, 94);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 5;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // PriCustomForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.btn_verificar);
            this.Controls.Add(this.label_descricao);
            this.Controls.Add(this.label_codigoArtigo);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.tb_codigoArtigo);
            this.Name = "PriCustomForm1";
            this.Size = new System.Drawing.Size(668, 242);
            this.Text = "PriCustomForm1";
            this.Load += new System.EventHandler(this.PriCustomForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_codigoArtigo;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label_codigoArtigo;
        private System.Windows.Forms.Label label_descricao;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.Button btn_inserir;
    }
}