namespace Bruno_Daniel_Stand
{
    partial class formVenda
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdVenda = new System.Windows.Forms.Button();
            this.listVenda = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdCarro = new System.Windows.Forms.Button();
            this.listCarroVenda = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listClientes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtData);
            this.groupBox3.Controls.Add(this.txtEstado);
            this.groupBox3.Controls.Add(this.txtValor);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnAdVenda);
            this.groupBox3.Controls.Add(this.listVenda);
            this.groupBox3.Location = new System.Drawing.Point(218, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 357);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalhes Venda";
            // 
            // btnAdVenda
            // 
            this.btnAdVenda.Location = new System.Drawing.Point(9, 306);
            this.btnAdVenda.Name = "btnAdVenda";
            this.btnAdVenda.Size = new System.Drawing.Size(231, 42);
            this.btnAdVenda.TabIndex = 6;
            this.btnAdVenda.Text = "Adicionar Venda";
            this.btnAdVenda.UseVisualStyleBackColor = true;
            this.btnAdVenda.Click += new System.EventHandler(this.btnAdVenda_Click);
            // 
            // listVenda
            // 
            this.listVenda.FormattingEnabled = true;
            this.listVenda.Location = new System.Drawing.Point(9, 19);
            this.listVenda.Name = "listVenda";
            this.listVenda.Size = new System.Drawing.Size(231, 199);
            this.listVenda.TabIndex = 1;
            this.listVenda.SelectedIndexChanged += new System.EventHandler(this.listVenda_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdCarro);
            this.groupBox2.Controls.Add(this.listCarroVenda);
            this.groupBox2.Location = new System.Drawing.Point(487, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 357);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carro Venda";
            // 
            // btnAdCarro
            // 
            this.btnAdCarro.Location = new System.Drawing.Point(9, 309);
            this.btnAdCarro.Name = "btnAdCarro";
            this.btnAdCarro.Size = new System.Drawing.Size(209, 42);
            this.btnAdCarro.TabIndex = 6;
            this.btnAdCarro.Text = "Adicionar Carro Vendido";
            this.btnAdCarro.UseVisualStyleBackColor = true;
            this.btnAdCarro.Click += new System.EventHandler(this.btnAdCarro_Click);
            // 
            // listCarroVenda
            // 
            this.listCarroVenda.FormattingEnabled = true;
            this.listCarroVenda.Location = new System.Drawing.Point(9, 19);
            this.listCarroVenda.Name = "listCarroVenda";
            this.listCarroVenda.Size = new System.Drawing.Size(209, 277);
            this.listCarroVenda.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listClientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 357);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccine um Cliente";
            // 
            // listClientes
            // 
            this.listClientes.FormattingEnabled = true;
            this.listClientes.Location = new System.Drawing.Point(6, 19);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(188, 329);
            this.listClientes.TabIndex = 0;
            this.listClientes.SelectedIndexChanged += new System.EventHandler(this.listClientes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Data";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(88, 280);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(152, 20);
            this.txtData.TabIndex = 21;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(88, 254);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(152, 20);
            this.txtEstado.TabIndex = 20;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(88, 228);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(152, 20);
            this.txtValor.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Valor";
            // 
            // formVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 783);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formVenda";
            this.Text = "formVenda";
            this.Load += new System.EventHandler(this.formVenda_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdVenda;
        private System.Windows.Forms.ListBox listVenda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdCarro;
        private System.Windows.Forms.ListBox listCarroVenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}