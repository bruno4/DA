namespace Bruno_Daniel_Stand
{
    partial class formMenu
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
            this.components = new System.ComponentModel.Container();
            this.btnCarros = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDataHoras = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnOficina = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnAluguer = new System.Windows.Forms.Button();
            this.btnFichCliente = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarros
            // 
            this.btnCarros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCarros.Location = new System.Drawing.Point(586, 109);
            this.btnCarros.Name = "btnCarros";
            this.btnCarros.Size = new System.Drawing.Size(125, 125);
            this.btnCarros.TabIndex = 19;
            this.btnCarros.Text = "Carros";
            this.btnCarros.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCarros.UseVisualStyleBackColor = true;
            this.btnCarros.Click += new System.EventHandler(this.btnCarros_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDataHoras,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 333);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(777, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "Total de vendas: 0";
            // 
            // lblDataHoras
            // 
            this.lblDataHoras.Name = "lblDataHoras";
            this.lblDataHoras.Size = new System.Drawing.Size(110, 17);
            this.lblDataHoras.Text = "00/00/0000 00:00:00";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(61, 17);
            this.toolStripStatusLabel2.Text = "Clientes: 0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(101, 17);
            this.toolStripStatusLabel3.Text = "Total de Vendas: 0";
            // 
            // btnOficina
            // 
            this.btnOficina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOficina.Location = new System.Drawing.Point(193, 109);
            this.btnOficina.Name = "btnOficina";
            this.btnOficina.Size = new System.Drawing.Size(125, 125);
            this.btnOficina.TabIndex = 15;
            this.btnOficina.Text = "Oficina";
            this.btnOficina.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOficina.UseVisualStyleBackColor = true;
            this.btnOficina.Click += new System.EventHandler(this.btnOficina_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Escolha a sua opção:";
            // 
            // btnVenda
            // 
            this.btnVenda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVenda.Location = new System.Drawing.Point(455, 109);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(125, 125);
            this.btnVenda.TabIndex = 17;
            this.btnVenda.Text = "Venda";
            this.btnVenda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnAluguer
            // 
            this.btnAluguer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAluguer.Location = new System.Drawing.Point(324, 109);
            this.btnAluguer.Name = "btnAluguer";
            this.btnAluguer.Size = new System.Drawing.Size(125, 125);
            this.btnAluguer.TabIndex = 16;
            this.btnAluguer.Text = "Aluguer";
            this.btnAluguer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAluguer.UseVisualStyleBackColor = true;
            this.btnAluguer.Click += new System.EventHandler(this.btnAluguer_Click);
            // 
            // btnFichCliente
            // 
            this.btnFichCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFichCliente.Location = new System.Drawing.Point(62, 109);
            this.btnFichCliente.Name = "btnFichCliente";
            this.btnFichCliente.Size = new System.Drawing.Size(125, 125);
            this.btnFichCliente.TabIndex = 14;
            this.btnFichCliente.Text = "Fichas de Cliente";
            this.btnFichCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFichCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFichCliente.UseVisualStyleBackColor = true;
            this.btnFichCliente.Click += new System.EventHandler(this.btnFichCliente_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 355);
            this.Controls.Add(this.btnCarros);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnOficina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVenda);
            this.Controls.Add(this.btnAluguer);
            this.Controls.Add(this.btnFichCliente);
            this.Name = "formMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.formMenu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarros;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDataHoras;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button btnOficina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Button btnAluguer;
        private System.Windows.Forms.Button btnFichCliente;
        private System.Windows.Forms.Timer timer;
    }
}

