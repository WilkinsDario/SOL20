
namespace CapaPresentacion
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.ckbTodo = new System.Windows.Forms.CheckBox();
            this.ckbFacturado = new System.Windows.Forms.CheckBox();
            this.lblTotalFacturado = new System.Windows.Forms.Label();
            this.ckbImprimir = new System.Windows.Forms.CheckBox();
            this.printReporte = new System.Drawing.Printing.PrintDocument();
            this.ckbPagado = new System.Windows.Forms.CheckBox();
            this.lblTotalPagado = new System.Windows.Forms.Label();
            this.cbBanca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(644, 202);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(111, 42);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Location = new System.Drawing.Point(71, 96);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(347, 30);
            this.dtpDesde.TabIndex = 1;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Location = new System.Drawing.Point(532, 96);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(347, 30);
            this.dtpHasta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(676, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta";
            // 
            // datalistado
            // 
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.Location = new System.Drawing.Point(71, 246);
            this.datalistado.Margin = new System.Windows.Forms.Padding(4);
            this.datalistado.Name = "datalistado";
            this.datalistado.RowHeadersWidth = 51;
            this.datalistado.Size = new System.Drawing.Size(809, 185);
            this.datalistado.TabIndex = 5;
            // 
            // ckbTodo
            // 
            this.ckbTodo.AutoSize = true;
            this.ckbTodo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTodo.Location = new System.Drawing.Point(71, 210);
            this.ckbTodo.Margin = new System.Windows.Forms.Padding(4);
            this.ckbTodo.Name = "ckbTodo";
            this.ckbTodo.Size = new System.Drawing.Size(73, 26);
            this.ckbTodo.TabIndex = 6;
            this.ckbTodo.Text = "Todo";
            this.ckbTodo.UseVisualStyleBackColor = true;
            this.ckbTodo.CheckedChanged += new System.EventHandler(this.ckbTodo_CheckedChanged);
            // 
            // ckbFacturado
            // 
            this.ckbFacturado.AutoSize = true;
            this.ckbFacturado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFacturado.Location = new System.Drawing.Point(196, 210);
            this.ckbFacturado.Margin = new System.Windows.Forms.Padding(4);
            this.ckbFacturado.Name = "ckbFacturado";
            this.ckbFacturado.Size = new System.Drawing.Size(111, 26);
            this.ckbFacturado.TabIndex = 8;
            this.ckbFacturado.Text = "Facturado";
            this.ckbFacturado.UseVisualStyleBackColor = true;
            this.ckbFacturado.CheckedChanged += new System.EventHandler(this.ckbFacturado_CheckedChanged);
            // 
            // lblTotalFacturado
            // 
            this.lblTotalFacturado.AutoSize = true;
            this.lblTotalFacturado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFacturado.Location = new System.Drawing.Point(304, 434);
            this.lblTotalFacturado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalFacturado.Name = "lblTotalFacturado";
            this.lblTotalFacturado.Size = new System.Drawing.Size(60, 23);
            this.lblTotalFacturado.TabIndex = 9;
            this.lblTotalFacturado.Text = "label3";
            // 
            // ckbImprimir
            // 
            this.ckbImprimir.AutoSize = true;
            this.ckbImprimir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbImprimir.Location = new System.Drawing.Point(775, 210);
            this.ckbImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.ckbImprimir.Name = "ckbImprimir";
            this.ckbImprimir.Size = new System.Drawing.Size(102, 26);
            this.ckbImprimir.TabIndex = 10;
            this.ckbImprimir.Text = "Imprimir";
            this.ckbImprimir.UseVisualStyleBackColor = true;
            this.ckbImprimir.CheckedChanged += new System.EventHandler(this.ckbImprimir_CheckedChanged);
            // 
            // ckbPagado
            // 
            this.ckbPagado.AutoSize = true;
            this.ckbPagado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPagado.Location = new System.Drawing.Point(347, 210);
            this.ckbPagado.Margin = new System.Windows.Forms.Padding(4);
            this.ckbPagado.Name = "ckbPagado";
            this.ckbPagado.Size = new System.Drawing.Size(90, 26);
            this.ckbPagado.TabIndex = 11;
            this.ckbPagado.Text = "Pagado";
            this.ckbPagado.UseVisualStyleBackColor = true;
            this.ckbPagado.CheckedChanged += new System.EventHandler(this.ckbPagado_CheckedChanged);
            // 
            // lblTotalPagado
            // 
            this.lblTotalPagado.AutoSize = true;
            this.lblTotalPagado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagado.Location = new System.Drawing.Point(547, 434);
            this.lblTotalPagado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPagado.Name = "lblTotalPagado";
            this.lblTotalPagado.Size = new System.Drawing.Size(60, 23);
            this.lblTotalPagado.TabIndex = 12;
            this.lblTotalPagado.Text = "label3";
            // 
            // cbBanca
            // 
            this.cbBanca.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cbBanca.FormattingEnabled = true;
            this.cbBanca.Location = new System.Drawing.Point(456, 208);
            this.cbBanca.Name = "cbBanca";
            this.cbBanca.Size = new System.Drawing.Size(164, 30);
            this.cbBanca.TabIndex = 80;
            this.cbBanca.Text = "Todas";
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 501);
            this.Controls.Add(this.cbBanca);
            this.Controls.Add(this.lblTotalPagado);
            this.Controls.Add(this.ckbPagado);
            this.Controls.Add(this.ckbImprimir);
            this.Controls.Add(this.lblTotalFacturado);
            this.Controls.Add(this.ckbFacturado);
            this.Controls.Add(this.ckbTodo);
            this.Controls.Add(this.datalistado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.btnConsultar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReportes";
            this.Text = ".:. Reportes .:.";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datalistado;
        private System.Windows.Forms.CheckBox ckbTodo;
        private System.Windows.Forms.CheckBox ckbFacturado;
        private System.Windows.Forms.Label lblTotalFacturado;
        private System.Windows.Forms.CheckBox ckbImprimir;
        private System.Drawing.Printing.PrintDocument printReporte;
        private System.Windows.Forms.CheckBox ckbPagado;
        private System.Windows.Forms.Label lblTotalPagado;
        private System.Windows.Forms.ComboBox cbBanca;
    }
}