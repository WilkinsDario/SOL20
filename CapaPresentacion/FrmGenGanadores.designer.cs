
namespace CapaPresentacion
{
    partial class FrmGenGanadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenGanadores));
            this.dtpFiltro = new System.Windows.Forms.DateTimePicker();
            this.btnGanadores = new System.Windows.Forms.Button();
            this.printTicket = new System.Drawing.Printing.PrintDocument();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgListado = new System.Windows.Forms.DataGridView();
            this.ckbImprimir = new System.Windows.Forms.CheckBox();
            this.cbBanca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListado)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFiltro
            // 
            this.dtpFiltro.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFiltro.Location = new System.Drawing.Point(328, 122);
            this.dtpFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFiltro.Name = "dtpFiltro";
            this.dtpFiltro.Size = new System.Drawing.Size(331, 30);
            this.dtpFiltro.TabIndex = 72;
            // 
            // btnGanadores
            // 
            this.btnGanadores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGanadores.Location = new System.Drawing.Point(683, 113);
            this.btnGanadores.Margin = new System.Windows.Forms.Padding(4);
            this.btnGanadores.Name = "btnGanadores";
            this.btnGanadores.Size = new System.Drawing.Size(116, 41);
            this.btnGanadores.TabIndex = 71;
            this.btnGanadores.Text = "Ganadores";
            this.btnGanadores.UseVisualStyleBackColor = true;
            this.btnGanadores.Click += new System.EventHandler(this.btnGanadores_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(24, 130);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(264, 22);
            this.label17.TabIndex = 76;
            this.label17.Text = "Más que un juego, una inversión";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(33, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(254, 22);
            this.label18.TabIndex = 75;
            this.label18.Text = "Donde Garantizamos tu Dinero";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CapaPresentacion.Properties.Resources.sol;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(63, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 89);
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // dtgListado
            // 
            this.dtgListado.AllowUserToAddRows = false;
            this.dtgListado.AllowUserToDeleteRows = false;
            this.dtgListado.AllowUserToOrderColumns = true;
            this.dtgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListado.Location = new System.Drawing.Point(16, 219);
            this.dtgListado.Margin = new System.Windows.Forms.Padding(4);
            this.dtgListado.Name = "dtgListado";
            this.dtgListado.ReadOnly = true;
            this.dtgListado.RowHeadersWidth = 51;
            this.dtgListado.Size = new System.Drawing.Size(783, 257);
            this.dtgListado.TabIndex = 77;
            // 
            // ckbImprimir
            // 
            this.ckbImprimir.AutoSize = true;
            this.ckbImprimir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbImprimir.Location = new System.Drawing.Point(16, 183);
            this.ckbImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.ckbImprimir.Name = "ckbImprimir";
            this.ckbImprimir.Size = new System.Drawing.Size(102, 26);
            this.ckbImprimir.TabIndex = 78;
            this.ckbImprimir.Text = "Imprimir";
            this.ckbImprimir.UseVisualStyleBackColor = true;
            this.ckbImprimir.CheckedChanged += new System.EventHandler(this.ckbImprimir_CheckedChanged);
            // 
            // cbBanca
            // 
            this.cbBanca.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbBanca.FormattingEnabled = true;
            this.cbBanca.Items.AddRange(new object[] {
            "EL BONITO"});
            this.cbBanca.Location = new System.Drawing.Point(328, 159);
            this.cbBanca.Name = "cbBanca";
            this.cbBanca.Size = new System.Drawing.Size(164, 30);
            this.cbBanca.TabIndex = 79;
            this.cbBanca.SelectedIndexChanged += new System.EventHandler(this.cbBanca_SelectedIndexChanged);
            // 
            // FrmGenGanadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 491);
            this.Controls.Add(this.cbBanca);
            this.Controls.Add(this.ckbImprimir);
            this.Controls.Add(this.dtgListado);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpFiltro);
            this.Controls.Add(this.btnGanadores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGenGanadores";
            this.Text = ".:. Generar Ganadores .:.";
            this.Load += new System.EventHandler(this.FrmGenGanadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFiltro;
        private System.Windows.Forms.Button btnGanadores;
        private System.Drawing.Printing.PrintDocument printTicket;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgListado;
        private System.Windows.Forms.CheckBox ckbImprimir;
        private System.Windows.Forms.ComboBox cbBanca;
    }
}