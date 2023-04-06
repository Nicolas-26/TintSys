namespace TintSysDesk
{
    partial class FrmCliente
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
            this.tbcCliente = new System.Windows.Forms.TabControl();
            this.tpgDadosPessoais = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtCpfCliente = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelCpf = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnInserirCliente = new System.Windows.Forms.Button();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.tpgEnderecos = new System.Windows.Forms.TabPage();
            this.tpgTelefones = new System.Windows.Forms.TabPage();
            this.tbcCliente.SuspendLayout();
            this.tpgDadosPessoais.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCliente
            // 
            this.tbcCliente.Controls.Add(this.tpgDadosPessoais);
            this.tbcCliente.Controls.Add(this.tpgEnderecos);
            this.tbcCliente.Controls.Add(this.tpgTelefones);
            this.tbcCliente.Location = new System.Drawing.Point(100, 38);
            this.tbcCliente.Name = "tbcCliente";
            this.tbcCliente.SelectedIndex = 0;
            this.tbcCliente.Size = new System.Drawing.Size(326, 330);
            this.tbcCliente.TabIndex = 0;
            // 
            // tpgDadosPessoais
            // 
            this.tpgDadosPessoais.Controls.Add(this.checkBox1);
            this.tpgDadosPessoais.Controls.Add(this.txtCpfCliente);
            this.tpgDadosPessoais.Controls.Add(this.txtEmailCliente);
            this.tpgDadosPessoais.Controls.Add(this.txtNomeCliente);
            this.tpgDadosPessoais.Controls.Add(this.txtIdCliente);
            this.tpgDadosPessoais.Controls.Add(this.labelId);
            this.tpgDadosPessoais.Controls.Add(this.labelCpf);
            this.tpgDadosPessoais.Controls.Add(this.labelEmail);
            this.tpgDadosPessoais.Controls.Add(this.labelNome);
            this.tpgDadosPessoais.Controls.Add(this.btnEditarCliente);
            this.tpgDadosPessoais.Controls.Add(this.btnInserirCliente);
            this.tpgDadosPessoais.Controls.Add(this.btnConsultarCliente);
            this.tpgDadosPessoais.Location = new System.Drawing.Point(4, 22);
            this.tpgDadosPessoais.Name = "tpgDadosPessoais";
            this.tpgDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tpgDadosPessoais.Size = new System.Drawing.Size(318, 304);
            this.tpgDadosPessoais.TabIndex = 0;
            this.tpgDadosPessoais.Text = "Dados Pessoais";
            this.tpgDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(184, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Location = new System.Drawing.Point(56, 140);
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(72, 20);
            this.txtCpfCliente.TabIndex = 14;
            this.txtCpfCliente.UseSystemPasswordChar = true;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(56, 103);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(223, 20);
            this.txtEmailCliente.TabIndex = 15;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(56, 68);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(223, 20);
            this.txtNomeCliente.TabIndex = 16;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(56, 28);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 17;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(32, 31);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 9;
            this.labelId.Text = "ID";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(12, 140);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(27, 13);
            this.labelCpf.TabIndex = 11;
            this.labelCpf.Text = "CPF";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(18, 103);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "Email";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(15, 71);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 13;
            this.labelNome.Text = "Nome";
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(237, 250);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCliente.TabIndex = 8;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnInserirCliente
            // 
            this.btnInserirCliente.Location = new System.Drawing.Point(9, 250);
            this.btnInserirCliente.Name = "btnInserirCliente";
            this.btnInserirCliente.Size = new System.Drawing.Size(75, 23);
            this.btnInserirCliente.TabIndex = 6;
            this.btnInserirCliente.Text = "Inserir";
            this.btnInserirCliente.UseVisualStyleBackColor = true;
            this.btnInserirCliente.Click += new System.EventHandler(this.btnInserirCliente_Click);
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Location = new System.Drawing.Point(124, 250);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarCliente.TabIndex = 7;
            this.btnConsultarCliente.Text = "Consultar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // tpgEnderecos
            // 
            this.tpgEnderecos.Location = new System.Drawing.Point(4, 22);
            this.tpgEnderecos.Name = "tpgEnderecos";
            this.tpgEnderecos.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEnderecos.Size = new System.Drawing.Size(318, 304);
            this.tpgEnderecos.TabIndex = 1;
            this.tpgEnderecos.Text = "Endereços";
            this.tpgEnderecos.UseVisualStyleBackColor = true;
            // 
            // tpgTelefones
            // 
            this.tpgTelefones.Location = new System.Drawing.Point(4, 22);
            this.tpgTelefones.Name = "tpgTelefones";
            this.tpgTelefones.Padding = new System.Windows.Forms.Padding(3);
            this.tpgTelefones.Size = new System.Drawing.Size(318, 304);
            this.tpgTelefones.TabIndex = 2;
            this.tpgTelefones.Text = "Telefones";
            this.tpgTelefones.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcCliente);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.tbcCliente.ResumeLayout(false);
            this.tpgDadosPessoais.ResumeLayout(false);
            this.tpgDadosPessoais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCliente;
        private System.Windows.Forms.TabPage tpgDadosPessoais;
        private System.Windows.Forms.TabPage tpgEnderecos;
        private System.Windows.Forms.TabPage tpgTelefones;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnInserirCliente;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.TextBox txtCpfCliente;
    }
}