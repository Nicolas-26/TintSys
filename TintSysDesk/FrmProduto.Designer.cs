﻿namespace TintSysDesk
{
    partial class FrmProduto
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
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.checkBoxDescontinuado = new System.Windows.Forms.CheckBox();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.txtCodBarProduto = new System.Windows.Forms.TextBox();
            this.txtDescontoProduto = new System.Windows.Forms.TextBox();
            this.txtPrecoProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxUnidadeProduto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.ClnIdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnidadeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodBarProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrecoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescontoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnInativoProduto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnInserirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnArquivar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(51, 34);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.ReadOnly = true;
            this.txtIdProduto.Size = new System.Drawing.Size(64, 20);
            this.txtIdProduto.TabIndex = 0;
            this.txtIdProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // checkBoxDescontinuado
            // 
            this.checkBoxDescontinuado.AutoSize = true;
            this.checkBoxDescontinuado.Location = new System.Drawing.Point(190, 37);
            this.checkBoxDescontinuado.Name = "checkBoxDescontinuado";
            this.checkBoxDescontinuado.Size = new System.Drawing.Size(74, 17);
            this.checkBoxDescontinuado.TabIndex = 1;
            this.checkBoxDescontinuado.Text = "Arquivado";
            this.checkBoxDescontinuado.UseVisualStyleBackColor = true;
            this.checkBoxDescontinuado.Visible = false;
            this.checkBoxDescontinuado.CheckedChanged += new System.EventHandler(this.checkBoxDescontinuado_CheckedChanged);
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(51, 88);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(156, 20);
            this.txtDescricaoProduto.TabIndex = 0;
            // 
            // txtCodBarProduto
            // 
            this.txtCodBarProduto.Location = new System.Drawing.Point(51, 139);
            this.txtCodBarProduto.Name = "txtCodBarProduto";
            this.txtCodBarProduto.Size = new System.Drawing.Size(89, 20);
            this.txtCodBarProduto.TabIndex = 0;
            // 
            // txtDescontoProduto
            // 
            this.txtDescontoProduto.Location = new System.Drawing.Point(301, 139);
            this.txtDescontoProduto.Name = "txtDescontoProduto";
            this.txtDescontoProduto.Size = new System.Drawing.Size(64, 20);
            this.txtDescontoProduto.TabIndex = 0;
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.Location = new System.Drawing.Point(190, 139);
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(64, 20);
            this.txtPrecoProduto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidade";
            // 
            // cbxUnidadeProduto
            // 
            this.cbxUnidadeProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUnidadeProduto.FormattingEnabled = true;
            this.cbxUnidadeProduto.Items.AddRange(new object[] {
            "Kilo",
            "Litro",
            "Pacote",
            "Peça",
            "Caixa",
            "Unidade",
            "Gramas",
            "Fardo",
            "MiliLitro",
            "Metro"});
            this.cbxUnidadeProduto.Location = new System.Drawing.Point(226, 88);
            this.cbxUnidadeProduto.Name = "cbxUnidadeProduto";
            this.cbxUnidadeProduto.Size = new System.Drawing.Size(85, 21);
            this.cbxUnidadeProduto.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "CodBar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Preço (R$)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Desconto (%)";
            // 
            // dataGridViewProduto
            // 
            this.dataGridViewProduto.AllowUserToAddRows = false;
            this.dataGridViewProduto.AllowUserToDeleteRows = false;
            this.dataGridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClnIdProduto,
            this.clnDescricaoProduto,
            this.clnUnidadeProduto,
            this.clnCodBarProduto,
            this.clnPrecoProduto,
            this.clnDescontoProduto,
            this.clnInativoProduto});
            this.dataGridViewProduto.Location = new System.Drawing.Point(14, 248);
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            this.dataGridViewProduto.ReadOnly = true;
            this.dataGridViewProduto.RowHeadersVisible = false;
            this.dataGridViewProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProduto.Size = new System.Drawing.Size(699, 150);
            this.dataGridViewProduto.TabIndex = 4;
            this.dataGridViewProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduto_CellDoubleClick);
            // 
            // ClnIdProduto
            // 
            this.ClnIdProduto.Frozen = true;
            this.ClnIdProduto.HeaderText = "ID";
            this.ClnIdProduto.Name = "ClnIdProduto";
            this.ClnIdProduto.ReadOnly = true;
            this.ClnIdProduto.Width = 40;
            // 
            // clnDescricaoProduto
            // 
            this.clnDescricaoProduto.Frozen = true;
            this.clnDescricaoProduto.HeaderText = "Descrição";
            this.clnDescricaoProduto.Name = "clnDescricaoProduto";
            this.clnDescricaoProduto.ReadOnly = true;
            this.clnDescricaoProduto.Width = 159;
            // 
            // clnUnidadeProduto
            // 
            this.clnUnidadeProduto.Frozen = true;
            this.clnUnidadeProduto.HeaderText = "Unidade";
            this.clnUnidadeProduto.Name = "clnUnidadeProduto";
            this.clnUnidadeProduto.ReadOnly = true;
            this.clnUnidadeProduto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnUnidadeProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnCodBarProduto
            // 
            this.clnCodBarProduto.Frozen = true;
            this.clnCodBarProduto.HeaderText = "CodBar";
            this.clnCodBarProduto.Name = "clnCodBarProduto";
            this.clnCodBarProduto.ReadOnly = true;
            this.clnCodBarProduto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnCodBarProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnPrecoProduto
            // 
            this.clnPrecoProduto.Frozen = true;
            this.clnPrecoProduto.HeaderText = "Preço";
            this.clnPrecoProduto.Name = "clnPrecoProduto";
            this.clnPrecoProduto.ReadOnly = true;
            this.clnPrecoProduto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnPrecoProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnDescontoProduto
            // 
            this.clnDescontoProduto.Frozen = true;
            this.clnDescontoProduto.HeaderText = "Desconto";
            this.clnDescontoProduto.Name = "clnDescontoProduto";
            this.clnDescontoProduto.ReadOnly = true;
            // 
            // clnInativoProduto
            // 
            this.clnInativoProduto.Frozen = true;
            this.clnInativoProduto.HeaderText = "Inativo";
            this.clnInativoProduto.Name = "clnInativoProduto";
            this.clnInativoProduto.ReadOnly = true;
            this.clnInativoProduto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnInativoProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnInserirProduto
            // 
            this.btnInserirProduto.Location = new System.Drawing.Point(89, 182);
            this.btnInserirProduto.Name = "btnInserirProduto";
            this.btnInserirProduto.Size = new System.Drawing.Size(75, 23);
            this.btnInserirProduto.TabIndex = 5;
            this.btnInserirProduto.Text = "&Inserir";
            this.btnInserirProduto.UseVisualStyleBackColor = true;
            this.btnInserirProduto.Click += new System.EventHandler(this.btnInserirProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Enabled = false;
            this.btnEditarProduto.Location = new System.Drawing.Point(226, 182);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnEditarProduto.TabIndex = 5;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(121, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(31, 222);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(437, 20);
            this.txtPesquisar.TabIndex = 8;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TintSysDesk.Properties.Resources.Search1;
            this.pictureBox1.Location = new System.Drawing.Point(474, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnArquivar
            // 
            this.btnArquivar.Location = new System.Drawing.Point(351, 182);
            this.btnArquivar.Name = "btnArquivar";
            this.btnArquivar.Size = new System.Drawing.Size(75, 23);
            this.btnArquivar.TabIndex = 10;
            this.btnArquivar.Text = "Arquivar";
            this.btnArquivar.UseVisualStyleBackColor = true;
            this.btnArquivar.Click += new System.EventHandler(this.btnArquivar_Click);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.btnArquivar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEditarProduto);
            this.Controls.Add(this.btnInserirProduto);
            this.Controls.Add(this.dataGridViewProduto);
            this.Controls.Add(this.cbxUnidadeProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxDescontinuado);
            this.Controls.Add(this.txtCodBarProduto);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.txtPrecoProduto);
            this.Controls.Add(this.txtDescontoProduto);
            this.Controls.Add(this.txtIdProduto);
            this.Name = "FrmProduto";
            this.Text = "FrmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.CheckBox checkBoxDescontinuado;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.TextBox txtCodBarProduto;
        private System.Windows.Forms.TextBox txtDescontoProduto;
        private System.Windows.Forms.TextBox txtPrecoProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxUnidadeProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewProduto;
        private System.Windows.Forms.Button btnInserirProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnIdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnidadeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodBarProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrecoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescontoProduto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clnInativoProduto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnArquivar;
    }
}