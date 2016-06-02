namespace Bruno_Daniel_Stand
{
    partial class formOficina
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataSaida = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdServicos = new System.Windows.Forms.Button();
            this.listServicos = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAdParcelas = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.listParcelas = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listCarrosOficina = new System.Windows.Forms.ListBox();
            this.btnAdCarroOficina = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblNif = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listClientes = new System.Windows.Forms.ListBox();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.txtDataSaida);
            this.groupBox6.Controls.Add(this.txtTipo);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.btnAdServicos);
            this.groupBox6.Controls.Add(this.listServicos);
            this.groupBox6.Location = new System.Drawing.Point(424, 104);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 372);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Serviços";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tipo";
            // 
            // txtDataSaida
            // 
            this.txtDataSaida.Location = new System.Drawing.Point(72, 303);
            this.txtDataSaida.Name = "txtDataSaida";
            this.txtDataSaida.Size = new System.Drawing.Size(121, 20);
            this.txtDataSaida.TabIndex = 15;
            // 
            // txtTipo
            // 
            this.txtTipo.FormattingEnabled = true;
            this.txtTipo.Items.AddRange(new object[] {
            "Revisão",
            "Pneu",
            "Vidro",
            "Manutencao Geral"});
            this.txtTipo.Location = new System.Drawing.Point(72, 276);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(122, 21);
            this.txtTipo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "DataSaida";
            // 
            // btnAdServicos
            // 
            this.btnAdServicos.Location = new System.Drawing.Point(5, 329);
            this.btnAdServicos.Name = "btnAdServicos";
            this.btnAdServicos.Size = new System.Drawing.Size(188, 31);
            this.btnAdServicos.TabIndex = 3;
            this.btnAdServicos.Text = "Adicionar Serviços";
            this.btnAdServicos.UseVisualStyleBackColor = true;
            this.btnAdServicos.Click += new System.EventHandler(this.btnAdServicos_Click);
            // 
            // listServicos
            // 
            this.listServicos.FormattingEnabled = true;
            this.listServicos.Location = new System.Drawing.Point(6, 19);
            this.listServicos.Name = "listServicos";
            this.listServicos.Size = new System.Drawing.Size(188, 251);
            this.listServicos.TabIndex = 3;
            this.listServicos.SelectedIndexChanged += new System.EventHandler(this.listServicos_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAdParcelas);
            this.groupBox5.Controls.Add(this.txtValor);
            this.groupBox5.Controls.Add(this.txtDescricao);
            this.groupBox5.Controls.Add(this.lblValor);
            this.groupBox5.Controls.Add(this.lblDescricao);
            this.groupBox5.Controls.Add(this.listParcelas);
            this.groupBox5.Location = new System.Drawing.Point(630, 104);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 372);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Parcelas";
            // 
            // btnAdParcelas
            // 
            this.btnAdParcelas.Location = new System.Drawing.Point(6, 328);
            this.btnAdParcelas.Name = "btnAdParcelas";
            this.btnAdParcelas.Size = new System.Drawing.Size(188, 31);
            this.btnAdParcelas.TabIndex = 5;
            this.btnAdParcelas.Text = "Adicionar Parcelas";
            this.btnAdParcelas.UseVisualStyleBackColor = true;
            this.btnAdParcelas.Click += new System.EventHandler(this.btnAdParcelas_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(73, 302);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 20);
            this.txtValor.TabIndex = 9;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(73, 276);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(121, 20);
            this.txtDescricao.TabIndex = 8;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(8, 305);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 7;
            this.lblValor.Text = "Valor:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(8, 279);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Descrição:";
            // 
            // listParcelas
            // 
            this.listParcelas.FormattingEnabled = true;
            this.listParcelas.Location = new System.Drawing.Point(6, 19);
            this.listParcelas.Name = "listParcelas";
            this.listParcelas.Size = new System.Drawing.Size(188, 251);
            this.listParcelas.TabIndex = 5;
            this.listParcelas.SelectedIndexChanged += new System.EventHandler(this.listParcelas_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listCarrosOficina);
            this.groupBox3.Controls.Add(this.btnAdCarroOficina);
            this.groupBox3.Location = new System.Drawing.Point(218, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 372);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Carro ";
            // 
            // listCarrosOficina
            // 
            this.listCarrosOficina.FormattingEnabled = true;
            this.listCarrosOficina.Location = new System.Drawing.Point(6, 19);
            this.listCarrosOficina.Name = "listCarrosOficina";
            this.listCarrosOficina.Size = new System.Drawing.Size(188, 303);
            this.listCarrosOficina.TabIndex = 1;
            this.listCarrosOficina.SelectedIndexChanged += new System.EventHandler(this.listCarrosOficina_SelectedIndexChanged);
            // 
            // btnAdCarroOficina
            // 
            this.btnAdCarroOficina.Location = new System.Drawing.Point(6, 329);
            this.btnAdCarroOficina.Name = "btnAdCarroOficina";
            this.btnAdCarroOficina.Size = new System.Drawing.Size(188, 31);
            this.btnAdCarroOficina.TabIndex = 2;
            this.btnAdCarroOficina.Text = "Adicionar Carro";
            this.btnAdCarroOficina.UseVisualStyleBackColor = true;
            this.btnAdCarroOficina.Click += new System.EventHandler(this.btnAdCarroOficina_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblData);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblContacto);
            this.groupBox2.Controls.Add(this.lblNif);
            this.groupBox2.Controls.Add(this.lblNomeCliente);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 86);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Cliente Seleccionado";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(431, 25);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(65, 13);
            this.lblData.TabIndex = 5;
            this.lblData.Text = "00/00/0000";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(551, 52);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor Total:";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(10, 61);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(16, 13);
            this.lblContacto.TabIndex = 2;
            this.lblContacto.Text = "...";
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(10, 42);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(16, 13);
            this.lblNif.TabIndex = 1;
            this.lblNif.Text = "...";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(6, 16);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(220, 22);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Sem Cliente Seleccionado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listClientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 464);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccine um Cliente";
            // 
            // listClientes
            // 
            this.listClientes.FormattingEnabled = true;
            this.listClientes.Location = new System.Drawing.Point(12, 23);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(188, 433);
            this.listClientes.TabIndex = 0;
            this.listClientes.SelectedIndexChanged += new System.EventHandler(this.listClientes_SelectedIndexChanged);
            // 
            // formOficina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 480);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formOficina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formOficina";
            this.Load += new System.EventHandler(this.formOficina_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataSaida;
        private System.Windows.Forms.ComboBox txtTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdServicos;
        private System.Windows.Forms.ListBox listServicos;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAdParcelas;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ListBox listParcelas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listCarrosOficina;
        private System.Windows.Forms.Button btnAdCarroOficina;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.Label lblData;
    }
}