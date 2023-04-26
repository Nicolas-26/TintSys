namespace TintSysDesk
{
    partial class FrmPedido
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
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.comboBoxAtendente = new System.Windows.Forms.ComboBox();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.labelAtendente = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.comboBoxUnidade = new System.Windows.Forms.ComboBox();
            this.textBoxDesconto = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.labelDesconto = new System.Windows.Forms.Label();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.labelUnidade = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clnHashTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido Nº";
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(663, 39);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(100, 20);
            this.txtPedido.TabIndex = 1;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(688, 94);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "+Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInserir);
            this.groupBox1.Controls.Add(this.comboBoxAtendente);
            this.groupBox1.Controls.Add(this.comboBoxCliente);
            this.groupBox1.Controls.Add(this.labelAtendente);
            this.groupBox1.Controls.Add(this.labelCliente);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(43, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(568, 43);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 2;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // comboBoxAtendente
            // 
            this.comboBoxAtendente.FormattingEnabled = true;
            this.comboBoxAtendente.Location = new System.Drawing.Point(392, 43);
            this.comboBoxAtendente.Name = "comboBoxAtendente";
            this.comboBoxAtendente.Size = new System.Drawing.Size(91, 21);
            this.comboBoxAtendente.TabIndex = 1;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(70, 41);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(227, 21);
            this.comboBoxCliente.TabIndex = 1;
            // 
            // labelAtendente
            // 
            this.labelAtendente.AutoSize = true;
            this.labelAtendente.Location = new System.Drawing.Point(330, 43);
            this.labelAtendente.Name = "labelAtendente";
            this.labelAtendente.Size = new System.Drawing.Size(56, 13);
            this.labelAtendente.TabIndex = 0;
            this.labelAtendente.Text = "Atendente";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(9, 41);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(42, 13);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = " Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdicionar);
            this.groupBox2.Controls.Add(this.textBoxDescricao);
            this.groupBox2.Controls.Add(this.comboBoxUnidade);
            this.groupBox2.Controls.Add(this.textBoxDesconto);
            this.groupBox2.Controls.Add(this.textBoxQuantidade);
            this.groupBox2.Controls.Add(this.textBoxPreco);
            this.groupBox2.Controls.Add(this.textBoxCodigo);
            this.groupBox2.Controls.Add(this.labelDesconto);
            this.groupBox2.Controls.Add(this.labelQuantidade);
            this.groupBox2.Controls.Add(this.labelPreco);
            this.groupBox2.Controls.Add(this.labelUnidade);
            this.groupBox2.Controls.Add(this.labelDescricao);
            this.groupBox2.Controls.Add(this.labelCodigo);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(43, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 106);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(598, 53);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 25);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(130, 59);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(154, 20);
            this.textBoxDescricao.TabIndex = 1;
            // 
            // comboBoxUnidade
            // 
            this.comboBoxUnidade.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxUnidade.FormattingEnabled = true;
            this.comboBoxUnidade.Location = new System.Drawing.Point(303, 58);
            this.comboBoxUnidade.Name = "comboBoxUnidade";
            this.comboBoxUnidade.Size = new System.Drawing.Size(69, 21);
            this.comboBoxUnidade.TabIndex = 1;
            // 
            // textBoxDesconto
            // 
            this.textBoxDesconto.Location = new System.Drawing.Point(520, 58);
            this.textBoxDesconto.Name = "textBoxDesconto";
            this.textBoxDesconto.Size = new System.Drawing.Size(40, 20);
            this.textBoxDesconto.TabIndex = 1;
            this.textBoxDesconto.TextChanged += new System.EventHandler(this.textBoxCodigo_TextChanged);
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(465, 58);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(40, 20);
            this.textBoxQuantidade.TabIndex = 1;
            this.textBoxQuantidade.TextChanged += new System.EventHandler(this.textBoxCodigo_TextChanged);
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(392, 59);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(56, 20);
            this.textBoxPreco.TabIndex = 1;
            this.textBoxPreco.TextChanged += new System.EventHandler(this.textBoxCodigo_TextChanged);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(12, 58);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 1;
            this.textBoxCodigo.TextChanged += new System.EventHandler(this.textBoxCodigo_TextChanged);
            // 
            // labelDesconto
            // 
            this.labelDesconto.AutoSize = true;
            this.labelDesconto.Location = new System.Drawing.Point(517, 41);
            this.labelDesconto.Name = "labelDesconto";
            this.labelDesconto.Size = new System.Drawing.Size(53, 13);
            this.labelDesconto.TabIndex = 0;
            this.labelDesconto.Text = "Desconto";
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(462, 41);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(24, 13);
            this.labelQuantidade.TabIndex = 0;
            this.labelQuantidade.Text = "Qtd";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(389, 42);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(35, 13);
            this.labelPreco.TabIndex = 0;
            this.labelPreco.Text = "Preço";
            // 
            // labelUnidade
            // 
            this.labelUnidade.AutoSize = true;
            this.labelUnidade.Location = new System.Drawing.Point(300, 42);
            this.labelUnidade.Name = "labelUnidade";
            this.labelUnidade.Size = new System.Drawing.Size(27, 13);
            this.labelUnidade.TabIndex = 0;
            this.labelUnidade.Text = "Und";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(127, 43);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(55, 13);
            this.labelDescricao.TabIndex = 0;
            this.labelDescricao.Text = "Descrição";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(9, 42);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 0;
            this.labelCodigo.Text = " Código";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnHashTag,
            this.clnCod,
            this.clnDescricao,
            this.clnUnd,
            this.clnPreco,
            this.clnQtd,
            this.clnDesconto,
            this.clnTotal});
            this.dataGridView1.Location = new System.Drawing.Point(43, 431);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(700, 107);
            this.dataGridView1.TabIndex = 5;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(557, 563);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(77, 20);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total R$";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(640, 563);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "-";
            // 
            // clnHashTag
            // 
            this.clnHashTag.Frozen = true;
            this.clnHashTag.HeaderText = "#";
            this.clnHashTag.Name = "clnHashTag";
            this.clnHashTag.ReadOnly = true;
            this.clnHashTag.Width = 40;
            // 
            // clnCod
            // 
            this.clnCod.Frozen = true;
            this.clnCod.HeaderText = "Cód";
            this.clnCod.Name = "clnCod";
            this.clnCod.ReadOnly = true;
            this.clnCod.Width = 80;
            // 
            // clnDescricao
            // 
            this.clnDescricao.Frozen = true;
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 179;
            // 
            // clnUnd
            // 
            this.clnUnd.Frozen = true;
            this.clnUnd.HeaderText = "Und";
            this.clnUnd.Name = "clnUnd";
            this.clnUnd.ReadOnly = true;
            this.clnUnd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnUnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnUnd.Width = 60;
            // 
            // clnPreco
            // 
            this.clnPreco.Frozen = true;
            this.clnPreco.HeaderText = "Preço R$";
            this.clnPreco.Name = "clnPreco";
            this.clnPreco.ReadOnly = true;
            this.clnPreco.Width = 80;
            // 
            // clnQtd
            // 
            this.clnQtd.Frozen = true;
            this.clnQtd.HeaderText = "Qtd";
            this.clnQtd.Name = "clnQtd";
            this.clnQtd.ReadOnly = true;
            this.clnQtd.Width = 60;
            // 
            // clnDesconto
            // 
            this.clnDesconto.Frozen = true;
            this.clnDesconto.HeaderText = "Desconto";
            this.clnDesconto.Name = "clnDesconto";
            this.clnDesconto.ReadOnly = true;
            // 
            // clnTotal
            // 
            this.clnTotal.Frozen = true;
            this.clnTotal.HeaderText = "Total R$";
            this.clnTotal.Name = "clnTotal";
            this.clnTotal.ReadOnly = true;
            // 
            // FrmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1551, 633);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.txtPedido);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label1);
            this.Name = "FrmPedido";
            this.Text = "FrmPedido";
            this.Load += new System.EventHandler(this.FrmPedido_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.ComboBox comboBoxAtendente;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label labelAtendente;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label labelUnidade;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.ComboBox comboBoxUnidade;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox textBoxDesconto;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Label labelDesconto;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnHashTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotal;
    }
}