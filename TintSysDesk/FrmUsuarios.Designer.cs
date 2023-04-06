namespace TintSysDesk
{
    partial class FrmUsuarios
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.comboBoxNivel = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelNivel = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAtivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtNomeNível = new System.Windows.Forms.TextBox();
            this.txtIdNível = new System.Windows.Forms.TextBox();
            this.btnConsultarNível = new System.Windows.Forms.Button();
            this.btnInserirNível = new System.Windows.Forms.Button();
            this.btnEditarNível = new System.Windows.Forms.Button();
            this.dgvNíveis = new System.Windows.Forms.DataGridView();
            this.clnIdNível = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeNível = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSiglaNível = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDeleteNível = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNíveis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(147, 192);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(260, 192);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(32, 192);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(39, 72);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(80, 29);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(80, 69);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(223, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(80, 104);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(80, 141);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(72, 20);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // comboBoxNivel
            // 
            this.comboBoxNivel.FormattingEnabled = true;
            this.comboBoxNivel.Location = new System.Drawing.Point(208, 141);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(77, 21);
            this.comboBoxNivel.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(208, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Ativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(56, 32);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(42, 104);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(36, 141);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Senha";
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.Location = new System.Drawing.Point(167, 144);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(31, 13);
            this.labelNivel.TabIndex = 2;
            this.labelNivel.Text = "Nivel";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnId,
            this.clnNome,
            this.clnEmail,
            this.clnNivel,
            this.clnAtivo});
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 249);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.Size = new System.Drawing.Size(547, 200);
            this.dgvUsuarios.TabIndex = 6;
            // 
            // clnId
            // 
            this.clnId.Frozen = true;
            this.clnId.HeaderText = "Id";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 40;
            // 
            // clnNome
            // 
            this.clnNome.Frozen = true;
            this.clnNome.HeaderText = "Nome";
            this.clnNome.Name = "clnNome";
            this.clnNome.ReadOnly = true;
            this.clnNome.Width = 174;
            // 
            // clnEmail
            // 
            this.clnEmail.Frozen = true;
            this.clnEmail.HeaderText = "Email";
            this.clnEmail.Name = "clnEmail";
            this.clnEmail.ReadOnly = true;
            this.clnEmail.Width = 174;
            // 
            // clnNivel
            // 
            this.clnNivel.Frozen = true;
            this.clnNivel.HeaderText = "Nível";
            this.clnNivel.Name = "clnNivel";
            this.clnNivel.ReadOnly = true;
            // 
            // clnAtivo
            // 
            this.clnAtivo.Frozen = true;
            this.clnAtivo.HeaderText = "Ativo";
            this.clnAtivo.Name = "clnAtivo";
            this.clnAtivo.ReadOnly = true;
            this.clnAtivo.Width = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSigla);
            this.groupBox1.Controls.Add(this.txtNomeNível);
            this.groupBox1.Controls.Add(this.txtIdNível);
            this.groupBox1.Controls.Add(this.btnConsultarNível);
            this.groupBox1.Controls.Add(this.btnInserirNível);
            this.groupBox1.Controls.Add(this.btnEditarNível);
            this.groupBox1.Location = new System.Drawing.Point(742, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 201);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Níveis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sigla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // txtSigla
            // 
            this.txtSigla.Location = new System.Drawing.Point(69, 99);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(62, 20);
            this.txtSigla.TabIndex = 2;
            // 
            // txtNomeNível
            // 
            this.txtNomeNível.Location = new System.Drawing.Point(69, 60);
            this.txtNomeNível.Name = "txtNomeNível";
            this.txtNomeNível.Size = new System.Drawing.Size(142, 20);
            this.txtNomeNível.TabIndex = 2;
            // 
            // txtIdNível
            // 
            this.txtIdNível.Location = new System.Drawing.Point(69, 24);
            this.txtIdNível.Name = "txtIdNível";
            this.txtIdNível.Size = new System.Drawing.Size(41, 20);
            this.txtIdNível.TabIndex = 2;
            // 
            // btnConsultarNível
            // 
            this.btnConsultarNível.FlatAppearance.BorderSize = 0;
            this.btnConsultarNível.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnConsultarNível.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarNível.Image = global::TintSysDesk.Properties.Resources.Search;
            this.btnConsultarNível.Location = new System.Drawing.Point(136, 135);
            this.btnConsultarNível.Name = "btnConsultarNível";
            this.btnConsultarNível.Size = new System.Drawing.Size(75, 48);
            this.btnConsultarNível.TabIndex = 1;
            this.btnConsultarNível.Text = "Consultar";
            this.btnConsultarNível.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultarNível.UseVisualStyleBackColor = true;
            this.btnConsultarNível.Click += new System.EventHandler(this.btnConsultarNível_Click);
            // 
            // btnInserirNível
            // 
            this.btnInserirNível.FlatAppearance.BorderSize = 0;
            this.btnInserirNível.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnInserirNível.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserirNível.Image = global::TintSysDesk.Properties.Resources.Add;
            this.btnInserirNível.Location = new System.Drawing.Point(31, 135);
            this.btnInserirNível.Name = "btnInserirNível";
            this.btnInserirNível.Size = new System.Drawing.Size(75, 48);
            this.btnInserirNível.TabIndex = 0;
            this.btnInserirNível.Text = "Inserir";
            this.btnInserirNível.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInserirNível.UseVisualStyleBackColor = true;
            // 
            // btnEditarNível
            // 
            this.btnEditarNível.FlatAppearance.BorderSize = 0;
            this.btnEditarNível.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnEditarNível.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarNível.Image = global::TintSysDesk.Properties.Resources.Edit;
            this.btnEditarNível.Location = new System.Drawing.Point(262, 135);
            this.btnEditarNível.Name = "btnEditarNível";
            this.btnEditarNível.Size = new System.Drawing.Size(75, 48);
            this.btnEditarNível.TabIndex = 0;
            this.btnEditarNível.Text = "Editar";
            this.btnEditarNível.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarNível.UseVisualStyleBackColor = true;
            // 
            // dgvNíveis
            // 
            this.dgvNíveis.AllowUserToAddRows = false;
            this.dgvNíveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNíveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdNível,
            this.clnNomeNível,
            this.clnSiglaNível,
            this.clnDeleteNível});
            this.dgvNíveis.Location = new System.Drawing.Point(742, 249);
            this.dgvNíveis.Name = "dgvNíveis";
            this.dgvNíveis.ReadOnly = true;
            this.dgvNíveis.RowHeadersVisible = false;
            this.dgvNíveis.Size = new System.Drawing.Size(343, 200);
            this.dgvNíveis.TabIndex = 8;
            // 
            // clnIdNível
            // 
            this.clnIdNível.Frozen = true;
            this.clnIdNível.HeaderText = "ID";
            this.clnIdNível.Name = "clnIdNível";
            this.clnIdNível.ReadOnly = true;
            this.clnIdNível.Width = 40;
            // 
            // clnNomeNível
            // 
            this.clnNomeNível.Frozen = true;
            this.clnNomeNível.HeaderText = "Nome";
            this.clnNomeNível.Name = "clnNomeNível";
            this.clnNomeNível.ReadOnly = true;
            this.clnNomeNível.Width = 140;
            // 
            // clnSiglaNível
            // 
            this.clnSiglaNível.Frozen = true;
            this.clnSiglaNível.HeaderText = "Sigla";
            this.clnSiglaNível.Name = "clnSiglaNível";
            this.clnSiglaNível.ReadOnly = true;
            this.clnSiglaNível.Width = 80;
            // 
            // clnDeleteNível
            // 
            this.clnDeleteNível.Frozen = true;
            this.clnDeleteNível.HeaderText = "Ação";
            this.clnDeleteNível.Name = "clnDeleteNível";
            this.clnDeleteNível.ReadOnly = true;
            this.clnDeleteNível.Text = "Excluir";
            this.clnDeleteNível.Width = 79;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 462);
            this.Controls.Add(this.dgvNíveis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBoxNivel);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelNivel);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnConsultar);
            this.Name = "FrmUsuarios";
            this.Text = "Administração de Usuários";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNíveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.ComboBox comboBoxNivel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNivel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnAtivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultarNível;
        private System.Windows.Forms.Button btnEditarNível;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtNomeNível;
        private System.Windows.Forms.TextBox txtIdNível;
        private System.Windows.Forms.Button btnInserirNível;
        private System.Windows.Forms.DataGridView dgvNíveis;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdNível;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeNível;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSiglaNível;
        private System.Windows.Forms.DataGridViewButtonColumn clnDeleteNível;
    }
}