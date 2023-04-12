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
            this.mstCpf = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.txtBairroEnd = new System.Windows.Forms.TextBox();
            this.txtTipoEnd = new System.Windows.Forms.TextBox();
            this.txtComplementoEnd = new System.Windows.Forms.TextBox();
            this.txtNumeroEnd = new System.Windows.Forms.TextBox();
            this.txtEstadoEnd = new System.Windows.Forms.TextBox();
            this.txtCidadeEnd = new System.Windows.Forms.TextBox();
            this.txtLograEnd = new System.Windows.Forms.TextBox();
            this.txtCepEnd = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtCliente_id = new System.Windows.Forms.TextBox();
            this.txtIdEnd = new System.Windows.Forms.TextBox();
            this.labelCliente_id = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelUF = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelBairro = new System.Windows.Forms.Label();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelLogradouro = new System.Windows.Forms.Label();
            this.labelCepEnd = new System.Windows.Forms.Label();
            this.labelIdEnd = new System.Windows.Forms.Label();
            this.tpgTelefones = new System.Windows.Forms.TabPage();
            this.btnInserirEnd = new System.Windows.Forms.Button();
            this.btnConsultarEnd = new System.Windows.Forms.Button();
            this.btnEditarEnd = new System.Windows.Forms.Button();
            this.labelIdTel = new System.Windows.Forms.Label();
            this.labelNumeroTel = new System.Windows.Forms.Label();
            this.labelTipoTel = new System.Windows.Forms.Label();
            this.labelClienteidTel = new System.Windows.Forms.Label();
            this.txtIdTel = new System.Windows.Forms.TextBox();
            this.txtNumeroTel = new System.Windows.Forms.TextBox();
            this.txtTipoTel = new System.Windows.Forms.TextBox();
            this.txtClienteidTel = new System.Windows.Forms.TextBox();
            this.btnEditarTel = new System.Windows.Forms.Button();
            this.btnConsultarTel = new System.Windows.Forms.Button();
            this.btnInserirTel = new System.Windows.Forms.Button();
            this.tbcCliente.SuspendLayout();
            this.tpgDadosPessoais.SuspendLayout();
            this.tpgEnderecos.SuspendLayout();
            this.tpgTelefones.SuspendLayout();
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
            this.tbcCliente.Size = new System.Drawing.Size(466, 463);
            this.tbcCliente.TabIndex = 0;
            // 
            // tpgDadosPessoais
            // 
            this.tpgDadosPessoais.Controls.Add(this.mstCpf);
            this.tpgDadosPessoais.Controls.Add(this.checkBox1);
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
            this.tpgDadosPessoais.Size = new System.Drawing.Size(458, 437);
            this.tpgDadosPessoais.TabIndex = 0;
            this.tpgDadosPessoais.Text = "Dados Pessoais";
            this.tpgDadosPessoais.UseVisualStyleBackColor = true;
            this.tpgDadosPessoais.Click += new System.EventHandler(this.tpgDadosPessoais_Click);
            // 
            // mstCpf
            // 
            this.mstCpf.Location = new System.Drawing.Point(127, 165);
            this.mstCpf.Mask = "000.000.000-99";
            this.mstCpf.Name = "mstCpf";
            this.mstCpf.Size = new System.Drawing.Size(115, 20);
            this.mstCpf.TabIndex = 20;
            this.mstCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(255, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(127, 206);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(223, 20);
            this.txtEmailCliente.TabIndex = 15;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(127, 113);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(223, 20);
            this.txtNomeCliente.TabIndex = 16;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(127, 73);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 17;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(103, 76);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 9;
            this.labelId.Text = "ID";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(89, 165);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(27, 13);
            this.labelCpf.TabIndex = 11;
            this.labelCpf.Text = "CPF";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(89, 209);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "Email";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(86, 116);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 13;
            this.labelNome.Text = "Nome";
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(308, 294);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCliente.TabIndex = 8;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnInserirCliente
            // 
            this.btnInserirCliente.Location = new System.Drawing.Point(80, 294);
            this.btnInserirCliente.Name = "btnInserirCliente";
            this.btnInserirCliente.Size = new System.Drawing.Size(75, 23);
            this.btnInserirCliente.TabIndex = 6;
            this.btnInserirCliente.Text = "Inserir";
            this.btnInserirCliente.UseVisualStyleBackColor = true;
            this.btnInserirCliente.Click += new System.EventHandler(this.btnInserirCliente_Click);
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Location = new System.Drawing.Point(195, 294);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarCliente.TabIndex = 7;
            this.btnConsultarCliente.Text = "Consultar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // tpgEnderecos
            // 
            this.tpgEnderecos.Controls.Add(this.btnEditarEnd);
            this.tpgEnderecos.Controls.Add(this.btnConsultarEnd);
            this.tpgEnderecos.Controls.Add(this.btnInserirEnd);
            this.tpgEnderecos.Controls.Add(this.txtBairroEnd);
            this.tpgEnderecos.Controls.Add(this.txtTipoEnd);
            this.tpgEnderecos.Controls.Add(this.txtComplementoEnd);
            this.tpgEnderecos.Controls.Add(this.txtNumeroEnd);
            this.tpgEnderecos.Controls.Add(this.txtEstadoEnd);
            this.tpgEnderecos.Controls.Add(this.txtCidadeEnd);
            this.tpgEnderecos.Controls.Add(this.txtLograEnd);
            this.tpgEnderecos.Controls.Add(this.txtCepEnd);
            this.tpgEnderecos.Controls.Add(this.txtUF);
            this.tpgEnderecos.Controls.Add(this.txtCliente_id);
            this.tpgEnderecos.Controls.Add(this.txtIdEnd);
            this.tpgEnderecos.Controls.Add(this.labelCliente_id);
            this.tpgEnderecos.Controls.Add(this.labelTipo);
            this.tpgEnderecos.Controls.Add(this.labelUF);
            this.tpgEnderecos.Controls.Add(this.labelEstado);
            this.tpgEnderecos.Controls.Add(this.labelCidade);
            this.tpgEnderecos.Controls.Add(this.labelBairro);
            this.tpgEnderecos.Controls.Add(this.labelComplemento);
            this.tpgEnderecos.Controls.Add(this.labelNumero);
            this.tpgEnderecos.Controls.Add(this.labelLogradouro);
            this.tpgEnderecos.Controls.Add(this.labelCepEnd);
            this.tpgEnderecos.Controls.Add(this.labelIdEnd);
            this.tpgEnderecos.Location = new System.Drawing.Point(4, 22);
            this.tpgEnderecos.Name = "tpgEnderecos";
            this.tpgEnderecos.Padding = new System.Windows.Forms.Padding(3);
            this.tpgEnderecos.Size = new System.Drawing.Size(458, 437);
            this.tpgEnderecos.TabIndex = 1;
            this.tpgEnderecos.Text = "Endereços";
            this.tpgEnderecos.UseVisualStyleBackColor = true;
            this.tpgEnderecos.Click += new System.EventHandler(this.tpgEnderecos_Click);
            // 
            // txtBairroEnd
            // 
            this.txtBairroEnd.Location = new System.Drawing.Point(43, 335);
            this.txtBairroEnd.Name = "txtBairroEnd";
            this.txtBairroEnd.Size = new System.Drawing.Size(83, 20);
            this.txtBairroEnd.TabIndex = 3;
            // 
            // txtTipoEnd
            // 
            this.txtTipoEnd.Location = new System.Drawing.Point(253, 206);
            this.txtTipoEnd.Name = "txtTipoEnd";
            this.txtTipoEnd.Size = new System.Drawing.Size(83, 20);
            this.txtTipoEnd.TabIndex = 3;
            // 
            // txtComplementoEnd
            // 
            this.txtComplementoEnd.Location = new System.Drawing.Point(43, 278);
            this.txtComplementoEnd.Name = "txtComplementoEnd";
            this.txtComplementoEnd.Size = new System.Drawing.Size(83, 20);
            this.txtComplementoEnd.TabIndex = 3;
            // 
            // txtNumeroEnd
            // 
            this.txtNumeroEnd.Location = new System.Drawing.Point(43, 222);
            this.txtNumeroEnd.Name = "txtNumeroEnd";
            this.txtNumeroEnd.Size = new System.Drawing.Size(142, 20);
            this.txtNumeroEnd.TabIndex = 3;
            // 
            // txtEstadoEnd
            // 
            this.txtEstadoEnd.Location = new System.Drawing.Point(253, 114);
            this.txtEstadoEnd.Name = "txtEstadoEnd";
            this.txtEstadoEnd.Size = new System.Drawing.Size(142, 20);
            this.txtEstadoEnd.TabIndex = 3;
            // 
            // txtCidadeEnd
            // 
            this.txtCidadeEnd.Location = new System.Drawing.Point(253, 54);
            this.txtCidadeEnd.Name = "txtCidadeEnd";
            this.txtCidadeEnd.Size = new System.Drawing.Size(142, 20);
            this.txtCidadeEnd.TabIndex = 3;
            // 
            // txtLograEnd
            // 
            this.txtLograEnd.Location = new System.Drawing.Point(43, 163);
            this.txtLograEnd.Name = "txtLograEnd";
            this.txtLograEnd.Size = new System.Drawing.Size(142, 20);
            this.txtLograEnd.TabIndex = 3;
            // 
            // txtCepEnd
            // 
            this.txtCepEnd.Location = new System.Drawing.Point(43, 103);
            this.txtCepEnd.Name = "txtCepEnd";
            this.txtCepEnd.Size = new System.Drawing.Size(83, 20);
            this.txtCepEnd.TabIndex = 3;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(256, 162);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(58, 20);
            this.txtUF.TabIndex = 3;
            // 
            // txtCliente_id
            // 
            this.txtCliente_id.Location = new System.Drawing.Point(256, 262);
            this.txtCliente_id.Name = "txtCliente_id";
            this.txtCliente_id.Size = new System.Drawing.Size(58, 20);
            this.txtCliente_id.TabIndex = 3;
            // 
            // txtIdEnd
            // 
            this.txtIdEnd.Location = new System.Drawing.Point(43, 54);
            this.txtIdEnd.Name = "txtIdEnd";
            this.txtIdEnd.Size = new System.Drawing.Size(58, 20);
            this.txtIdEnd.TabIndex = 3;
            // 
            // labelCliente_id
            // 
            this.labelCliente_id.AutoSize = true;
            this.labelCliente_id.Location = new System.Drawing.Point(253, 245);
            this.labelCliente_id.Name = "labelCliente_id";
            this.labelCliente_id.Size = new System.Drawing.Size(53, 13);
            this.labelCliente_id.TabIndex = 2;
            this.labelCliente_id.Text = "Cliente_id";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(253, 190);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(28, 13);
            this.labelTipo.TabIndex = 2;
            this.labelTipo.Text = "Tipo";
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Location = new System.Drawing.Point(253, 146);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(21, 13);
            this.labelUF.TabIndex = 2;
            this.labelUF.Text = "UF";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(250, 98);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 1;
            this.labelEstado.Text = "Estado";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(250, 38);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(40, 13);
            this.labelCidade.TabIndex = 0;
            this.labelCidade.Text = "Cidade";
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Location = new System.Drawing.Point(40, 319);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(34, 13);
            this.labelBairro.TabIndex = 0;
            this.labelBairro.Text = "Bairro";
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Location = new System.Drawing.Point(40, 262);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(71, 13);
            this.labelComplemento.TabIndex = 0;
            this.labelComplemento.Text = "Complemento";
            this.labelComplemento.Click += new System.EventHandler(this.labelComplemento_Click);
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(40, 206);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(44, 13);
            this.labelNumero.TabIndex = 0;
            this.labelNumero.Text = "Número";
            // 
            // labelLogradouro
            // 
            this.labelLogradouro.AutoSize = true;
            this.labelLogradouro.Location = new System.Drawing.Point(40, 146);
            this.labelLogradouro.Name = "labelLogradouro";
            this.labelLogradouro.Size = new System.Drawing.Size(61, 13);
            this.labelLogradouro.TabIndex = 0;
            this.labelLogradouro.Text = "Logradouro";
            // 
            // labelCepEnd
            // 
            this.labelCepEnd.AutoSize = true;
            this.labelCepEnd.Location = new System.Drawing.Point(40, 87);
            this.labelCepEnd.Name = "labelCepEnd";
            this.labelCepEnd.Size = new System.Drawing.Size(26, 13);
            this.labelCepEnd.TabIndex = 0;
            this.labelCepEnd.Text = "Cep";
            // 
            // labelIdEnd
            // 
            this.labelIdEnd.AutoSize = true;
            this.labelIdEnd.Location = new System.Drawing.Point(40, 38);
            this.labelIdEnd.Name = "labelIdEnd";
            this.labelIdEnd.Size = new System.Drawing.Size(18, 13);
            this.labelIdEnd.TabIndex = 0;
            this.labelIdEnd.Text = "ID";
            // 
            // tpgTelefones
            // 
            this.tpgTelefones.Controls.Add(this.btnEditarTel);
            this.tpgTelefones.Controls.Add(this.btnConsultarTel);
            this.tpgTelefones.Controls.Add(this.btnInserirTel);
            this.tpgTelefones.Controls.Add(this.txtTipoTel);
            this.tpgTelefones.Controls.Add(this.txtNumeroTel);
            this.tpgTelefones.Controls.Add(this.txtClienteidTel);
            this.tpgTelefones.Controls.Add(this.txtIdTel);
            this.tpgTelefones.Controls.Add(this.labelClienteidTel);
            this.tpgTelefones.Controls.Add(this.labelTipoTel);
            this.tpgTelefones.Controls.Add(this.labelNumeroTel);
            this.tpgTelefones.Controls.Add(this.labelIdTel);
            this.tpgTelefones.Location = new System.Drawing.Point(4, 22);
            this.tpgTelefones.Name = "tpgTelefones";
            this.tpgTelefones.Padding = new System.Windows.Forms.Padding(3);
            this.tpgTelefones.Size = new System.Drawing.Size(458, 437);
            this.tpgTelefones.TabIndex = 2;
            this.tpgTelefones.Text = "Telefones";
            this.tpgTelefones.UseVisualStyleBackColor = true;
            // 
            // btnInserirEnd
            // 
            this.btnInserirEnd.Location = new System.Drawing.Point(51, 399);
            this.btnInserirEnd.Name = "btnInserirEnd";
            this.btnInserirEnd.Size = new System.Drawing.Size(75, 23);
            this.btnInserirEnd.TabIndex = 4;
            this.btnInserirEnd.Text = "Inserir";
            this.btnInserirEnd.UseVisualStyleBackColor = true;
            // 
            // btnConsultarEnd
            // 
            this.btnConsultarEnd.Location = new System.Drawing.Point(184, 399);
            this.btnConsultarEnd.Name = "btnConsultarEnd";
            this.btnConsultarEnd.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarEnd.TabIndex = 4;
            this.btnConsultarEnd.Text = "Consultar";
            this.btnConsultarEnd.UseVisualStyleBackColor = true;
            // 
            // btnEditarEnd
            // 
            this.btnEditarEnd.Location = new System.Drawing.Point(320, 399);
            this.btnEditarEnd.Name = "btnEditarEnd";
            this.btnEditarEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEditarEnd.TabIndex = 4;
            this.btnEditarEnd.Text = "Editar";
            this.btnEditarEnd.UseVisualStyleBackColor = true;
            // 
            // labelIdTel
            // 
            this.labelIdTel.AutoSize = true;
            this.labelIdTel.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdTel.Location = new System.Drawing.Point(75, 106);
            this.labelIdTel.Name = "labelIdTel";
            this.labelIdTel.Size = new System.Drawing.Size(26, 19);
            this.labelIdTel.TabIndex = 0;
            this.labelIdTel.Text = "ID";
            // 
            // labelNumeroTel
            // 
            this.labelNumeroTel.AutoSize = true;
            this.labelNumeroTel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroTel.Location = new System.Drawing.Point(261, 106);
            this.labelNumeroTel.Name = "labelNumeroTel";
            this.labelNumeroTel.Size = new System.Drawing.Size(69, 19);
            this.labelNumeroTel.TabIndex = 0;
            this.labelNumeroTel.Text = "Número";
            // 
            // labelTipoTel
            // 
            this.labelTipoTel.AutoSize = true;
            this.labelTipoTel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoTel.Location = new System.Drawing.Point(75, 184);
            this.labelTipoTel.Name = "labelTipoTel";
            this.labelTipoTel.Size = new System.Drawing.Size(42, 19);
            this.labelTipoTel.TabIndex = 0;
            this.labelTipoTel.Text = "Tipo";
            // 
            // labelClienteidTel
            // 
            this.labelClienteidTel.AutoSize = true;
            this.labelClienteidTel.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClienteidTel.Location = new System.Drawing.Point(262, 184);
            this.labelClienteidTel.Name = "labelClienteidTel";
            this.labelClienteidTel.Size = new System.Drawing.Size(81, 19);
            this.labelClienteidTel.TabIndex = 0;
            this.labelClienteidTel.Text = "Cliente_id";
            // 
            // txtIdTel
            // 
            this.txtIdTel.Location = new System.Drawing.Point(78, 131);
            this.txtIdTel.Name = "txtIdTel";
            this.txtIdTel.Size = new System.Drawing.Size(52, 20);
            this.txtIdTel.TabIndex = 1;
            // 
            // txtNumeroTel
            // 
            this.txtNumeroTel.Location = new System.Drawing.Point(264, 131);
            this.txtNumeroTel.Name = "txtNumeroTel";
            this.txtNumeroTel.Size = new System.Drawing.Size(138, 20);
            this.txtNumeroTel.TabIndex = 1;
            // 
            // txtTipoTel
            // 
            this.txtTipoTel.Location = new System.Drawing.Point(78, 213);
            this.txtTipoTel.Name = "txtTipoTel";
            this.txtTipoTel.Size = new System.Drawing.Size(138, 20);
            this.txtTipoTel.TabIndex = 1;
            // 
            // txtClienteidTel
            // 
            this.txtClienteidTel.Location = new System.Drawing.Point(265, 213);
            this.txtClienteidTel.Name = "txtClienteidTel";
            this.txtClienteidTel.Size = new System.Drawing.Size(90, 20);
            this.txtClienteidTel.TabIndex = 1;
            // 
            // btnEditarTel
            // 
            this.btnEditarTel.Location = new System.Drawing.Point(324, 308);
            this.btnEditarTel.Name = "btnEditarTel";
            this.btnEditarTel.Size = new System.Drawing.Size(75, 23);
            this.btnEditarTel.TabIndex = 5;
            this.btnEditarTel.Text = "Editar";
            this.btnEditarTel.UseVisualStyleBackColor = true;
            // 
            // btnConsultarTel
            // 
            this.btnConsultarTel.Location = new System.Drawing.Point(188, 308);
            this.btnConsultarTel.Name = "btnConsultarTel";
            this.btnConsultarTel.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarTel.TabIndex = 6;
            this.btnConsultarTel.Text = "Consultar";
            this.btnConsultarTel.UseVisualStyleBackColor = true;
            // 
            // btnInserirTel
            // 
            this.btnInserirTel.Location = new System.Drawing.Point(55, 308);
            this.btnInserirTel.Name = "btnInserirTel";
            this.btnInserirTel.Size = new System.Drawing.Size(75, 23);
            this.btnInserirTel.TabIndex = 7;
            this.btnInserirTel.Text = "Inserir";
            this.btnInserirTel.UseVisualStyleBackColor = true;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.tbcCliente);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.tbcCliente.ResumeLayout(false);
            this.tpgDadosPessoais.ResumeLayout(false);
            this.tpgDadosPessoais.PerformLayout();
            this.tpgEnderecos.ResumeLayout(false);
            this.tpgEnderecos.PerformLayout();
            this.tpgTelefones.ResumeLayout(false);
            this.tpgTelefones.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox mstCpf;
        private System.Windows.Forms.TextBox txtNumeroEnd;
        private System.Windows.Forms.TextBox txtLograEnd;
        private System.Windows.Forms.TextBox txtCepEnd;
        private System.Windows.Forms.TextBox txtIdEnd;
        private System.Windows.Forms.Label labelCliente_id;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelUF;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.Label labelComplemento;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelLogradouro;
        private System.Windows.Forms.Label labelCepEnd;
        private System.Windows.Forms.Label labelIdEnd;
        private System.Windows.Forms.TextBox txtBairroEnd;
        private System.Windows.Forms.TextBox txtTipoEnd;
        private System.Windows.Forms.TextBox txtComplementoEnd;
        private System.Windows.Forms.TextBox txtEstadoEnd;
        private System.Windows.Forms.TextBox txtCidadeEnd;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtCliente_id;
        private System.Windows.Forms.Button btnEditarEnd;
        private System.Windows.Forms.Button btnConsultarEnd;
        private System.Windows.Forms.Button btnInserirEnd;
        private System.Windows.Forms.Button btnEditarTel;
        private System.Windows.Forms.Button btnConsultarTel;
        private System.Windows.Forms.Button btnInserirTel;
        private System.Windows.Forms.TextBox txtTipoTel;
        private System.Windows.Forms.TextBox txtNumeroTel;
        private System.Windows.Forms.TextBox txtClienteidTel;
        private System.Windows.Forms.TextBox txtIdTel;
        private System.Windows.Forms.Label labelClienteidTel;
        private System.Windows.Forms.Label labelTipoTel;
        private System.Windows.Forms.Label labelNumeroTel;
        private System.Windows.Forms.Label labelIdTel;
    }
}