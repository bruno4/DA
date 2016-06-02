namespace Bruno_Daniel_Stand
{
    partial class formAluguer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listClientes = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdCarro = new System.Windows.Forms.Button();
            this.listCarroAlugado = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtKms = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataFim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataInicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdAluguer = new System.Windows.Forms.Button();
            this.listAluguers = new System.Windows.Forms.ListBox();
            this.lblIdCarro = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listClientes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 357);
            this.groupBox1.TabIndex = 6;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdCarro);
            this.groupBox2.Controls.Add(this.listCarroAlugado);
            this.groupBox2.Location = new System.Drawing.Point(487, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 357);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carro Alugado";
            // 
            // btnAdCarro
            // 
            this.btnAdCarro.Location = new System.Drawing.Point(9, 306);
            this.btnAdCarro.Name = "btnAdCarro";
            this.btnAdCarro.Size = new System.Drawing.Size(209, 42);
            this.btnAdCarro.TabIndex = 6;
            this.btnAdCarro.Text = "Adicionar Carro Alugado";
            this.btnAdCarro.UseVisualStyleBackColor = true;
            this.btnAdCarro.Click += new System.EventHandler(this.btnAdCarro_Click);
            // 
            // listCarroAlugado
            // 
            this.listCarroAlugado.FormattingEnabled = true;
            this.listCarroAlugado.Location = new System.Drawing.Point(9, 19);
            this.listCarroAlugado.Name = "listCarroAlugado";
            this.listCarroAlugado.Size = new System.Drawing.Size(209, 277);
            this.listCarroAlugado.TabIndex = 1;
            this.listCarroAlugado.SelectedIndexChanged += new System.EventHandler(this.listCarroAlugado_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtKms);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtValor);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtDataFim);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtDataInicio);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnAdAluguer);
            this.groupBox3.Controls.Add(this.listAluguers);
            this.groupBox3.Location = new System.Drawing.Point(218, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 357);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalhes Aluguer";
            // 
            // txtKms
            // 
            this.txtKms.Location = new System.Drawing.Point(70, 280);
            this.txtKms.Name = "txtKms";
            this.txtKms.Size = new System.Drawing.Size(170, 20);
            this.txtKms.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kms";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(70, 254);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(170, 20);
            this.txtValor.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor";
            // 
            // txtDataFim
            // 
            this.txtDataFim.Location = new System.Drawing.Point(70, 228);
            this.txtDataFim.Name = "txtDataFim";
            this.txtDataFim.Size = new System.Drawing.Size(170, 20);
            this.txtDataFim.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data Fim";
            // 
            // txtDataInicio
            // 
            this.txtDataInicio.Location = new System.Drawing.Point(70, 202);
            this.txtDataInicio.Name = "txtDataInicio";
            this.txtDataInicio.Size = new System.Drawing.Size(170, 20);
            this.txtDataInicio.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data Inicio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAdAluguer
            // 
            this.btnAdAluguer.Location = new System.Drawing.Point(9, 306);
            this.btnAdAluguer.Name = "btnAdAluguer";
            this.btnAdAluguer.Size = new System.Drawing.Size(231, 42);
            this.btnAdAluguer.TabIndex = 6;
            this.btnAdAluguer.Text = "Adicionar Aluguer";
            this.btnAdAluguer.UseVisualStyleBackColor = true;
            this.btnAdAluguer.Click += new System.EventHandler(this.btnAdAluguer_Click);
            // 
            // listAluguers
            // 
            this.listAluguers.FormattingEnabled = true;
            this.listAluguers.Location = new System.Drawing.Point(9, 19);
            this.listAluguers.Name = "listAluguers";
            this.listAluguers.Size = new System.Drawing.Size(231, 173);
            this.listAluguers.TabIndex = 1;
            this.listAluguers.SelectedIndexChanged += new System.EventHandler(this.listAluguers_SelectedIndexChanged);
            // 
            // lblIdCarro
            // 
            this.lblIdCarro.AutoSize = true;
            this.lblIdCarro.Location = new System.Drawing.Point(46, 404);
            this.lblIdCarro.Name = "lblIdCarro";
            this.lblIdCarro.Size = new System.Drawing.Size(35, 13);
            this.lblIdCarro.TabIndex = 9;
            this.lblIdCarro.Text = "label5";
            // 
            // formAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 447);
            this.Controls.Add(this.lblIdCarro);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formAluguer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluguer";
            this.Load += new System.EventHandler(this.formAluguer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdCarro;
        private System.Windows.Forms.ListBox listCarroAlugado;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAdAluguer;
        private System.Windows.Forms.ListBox listAluguers;
        private System.Windows.Forms.TextBox txtDataInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdCarro;
    }
}