
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
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(483, 164);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(83, 34);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Location = new System.Drawing.Point(53, 78);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(261, 26);
            this.dtpDesde.TabIndex = 1;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Location = new System.Drawing.Point(399, 78);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(261, 26);
            this.dtpHasta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(507, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta";
            // 
            // datalistado
            // 
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.Location = new System.Drawing.Point(53, 200);
            this.datalistado.Name = "datalistado";
            this.datalistado.Size = new System.Drawing.Size(607, 150);
            this.datalistado.TabIndex = 5;
            // 
            // ckbTodo
            // 
            this.ckbTodo.AutoSize = true;
            this.ckbTodo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTodo.Location = new System.Drawing.Point(93, 137);
            this.ckbTodo.Name = "ckbTodo";
            this.ckbTodo.Size = new System.Drawing.Size(60, 23);
            this.ckbTodo.TabIndex = 6;
            this.ckbTodo.Text = "Todo";
            this.ckbTodo.UseVisualStyleBackColor = true;
            this.ckbTodo.CheckedChanged += new System.EventHandler(this.ckbTodo_CheckedChanged);
            // 
            // ckbFacturado
            // 
            this.ckbFacturado.AutoSize = true;
            this.ckbFacturado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFacturado.Location = new System.Drawing.Point(187, 137);
            this.ckbFacturado.Name = "ckbFacturado";
            this.ckbFacturado.Size = new System.Drawing.Size(90, 23);
            this.ckbFacturado.TabIndex = 8;
            this.ckbFacturado.Text = "Facturado";
            this.ckbFacturado.UseVisualStyleBackColor = true;
            this.ckbFacturado.CheckedChanged += new System.EventHandler(this.ckbFacturado_CheckedChanged);
            // 
            // lblTotalFacturado
            // 
            this.lblTotalFacturado.AutoSize = true;
            this.lblTotalFacturado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFacturado.Location = new System.Drawing.Point(228, 353);
            this.lblTotalFacturado.Name = "lblTotalFacturado";
            this.lblTotalFacturado.Size = new System.Drawing.Size(49, 19);
            this.lblTotalFacturado.TabIndex = 9;
            this.lblTotalFacturado.Text = "label3";
            // 
            // ckbImprimir
            // 
            this.ckbImprimir.AutoSize = true;
            this.ckbImprimir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbImprimir.Location = new System.Drawing.Point(581, 171);
            this.ckbImprimir.Name = "ckbImprimir";
            this.ckbImprimir.Size = new System.Drawing.Size(79, 23);
            this.ckbImprimir.TabIndex = 10;
            this.ckbImprimir.Text = "Imprimir";
            this.ckbImprimir.UseVisualStyleBackColor = true;
            this.ckbImprimir.CheckedChanged += new System.EventHandler(this.ckbImprimir_CheckedChanged);
            // 
            // ckbPagado
            // 
            this.ckbPagado.AutoSize = true;
            this.ckbPagado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPagado.Location = new System.Drawing.Point(300, 137);
            this.ckbPagado.Name = "ckbPagado";
            this.ckbPagado.Size = new System.Drawing.Size(74, 23);
            this.ckbPagado.TabIndex = 11;
            this.ckbPagado.Text = "Pagado";
            this.ckbPagado.UseVisualStyleBackColor = true;
            this.ckbPagado.CheckedChanged += new System.EventHandler(this.ckbPagado_CheckedChanged);
            // 
            // lblTotalPagado
            // 
            this.lblTotalPagado.AutoSize = true;
            this.lblTotalPagado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagado.Location = new System.Drawing.Point(410, 353);
            this.lblTotalPagado.Name = "lblTotalPagado";
            this.lblTotalPagado.Size = new System.Drawing.Size(49, 19);
            this.lblTotalPagado.TabIndex = 12;
            this.lblTotalPagado.Text = "label3";
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 450);
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
    }
}