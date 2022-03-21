
namespace CapaPresentacion
{
    partial class FrmHorarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHorarios));
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTanda = new System.Windows.Forms.ComboBox();
            this.btnActualizarHorario = new System.Windows.Forms.Button();
            this.cbEstatusHorario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMinutos = new System.Windows.Forms.ComboBox();
            this.cbHora = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLoteria = new System.Windows.Forms.ComboBox();
            this.dtgListado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListado)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 130);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(264, 22);
            this.label17.TabIndex = 17;
            this.label17.Text = "Más que un juego, una inversión";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(21, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(254, 22);
            this.label18.TabIndex = 16;
            this.label18.Text = "Donde Garantizamos tu Dinero";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CapaPresentacion.Properties.Resources.sol;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(51, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 89);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTanda);
            this.groupBox2.Controls.Add(this.btnActualizarHorario);
            this.groupBox2.Controls.Add(this.cbEstatusHorario);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbMinutos);
            this.groupBox2.Controls.Add(this.cbHora);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbLoteria);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 174);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(668, 133);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horarios de Loterias";
            // 
            // cbTanda
            // 
            this.cbTanda.FormattingEnabled = true;
            this.cbTanda.Items.AddRange(new object[] {
            "Semana",
            "Domingo"});
            this.cbTanda.Location = new System.Drawing.Point(340, 29);
            this.cbTanda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTanda.Name = "cbTanda";
            this.cbTanda.Size = new System.Drawing.Size(136, 30);
            this.cbTanda.TabIndex = 10;
            this.cbTanda.Text = "Seleccione";
            this.cbTanda.SelectedIndexChanged += new System.EventHandler(this.cbTanda_SelectedIndexChanged);
            // 
            // btnActualizarHorario
            // 
            this.btnActualizarHorario.Location = new System.Drawing.Point(549, 27);
            this.btnActualizarHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizarHorario.Name = "btnActualizarHorario";
            this.btnActualizarHorario.Size = new System.Drawing.Size(113, 39);
            this.btnActualizarHorario.TabIndex = 9;
            this.btnActualizarHorario.Text = "Actualizar";
            this.btnActualizarHorario.UseVisualStyleBackColor = true;
            this.btnActualizarHorario.Click += new System.EventHandler(this.btnActualizarHorario_Click);
            // 
            // cbEstatusHorario
            // 
            this.cbEstatusHorario.FormattingEnabled = true;
            this.cbEstatusHorario.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstatusHorario.Location = new System.Drawing.Point(340, 74);
            this.cbEstatusHorario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEstatusHorario.Name = "cbEstatusHorario";
            this.cbEstatusHorario.Size = new System.Drawing.Size(136, 30);
            this.cbEstatusHorario.TabIndex = 6;
            this.cbEstatusHorario.Text = "Seleccione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // cbMinutos
            // 
            this.cbMinutos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMinutos.FormattingEnabled = true;
            this.cbMinutos.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cbMinutos.Location = new System.Drawing.Point(223, 74);
            this.cbMinutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMinutos.Name = "cbMinutos";
            this.cbMinutos.Size = new System.Drawing.Size(84, 30);
            this.cbMinutos.TabIndex = 3;
            // 
            // cbHora
            // 
            this.cbHora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHora.FormattingEnabled = true;
            this.cbHora.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "00"});
            this.cbHora.Location = new System.Drawing.Point(111, 74);
            this.cbHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbHora.Name = "cbHora";
            this.cbHora.Size = new System.Drawing.Size(84, 30);
            this.cbHora.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loteria:";
            // 
            // cbLoteria
            // 
            this.cbLoteria.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoteria.FormattingEnabled = true;
            this.cbLoteria.Items.AddRange(new object[] {
            "GanaMas",
            "La Primera",
            "Loteka",
            "Real",
            "New York",
            "New York Noche",
            "Florida",
            "Florida Noche",
            "Nacional",
            "Quiniela Pale",
            "La Suerte",
            "King Tarde",
            "King Noche",
            "Anguila 10 AM",
            "Anguila 1 PM",
            "Anguila 5 PM",
            "Anguila 9 PM"});
            this.cbLoteria.Location = new System.Drawing.Point(111, 30);
            this.cbLoteria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLoteria.Name = "cbLoteria";
            this.cbLoteria.Size = new System.Drawing.Size(196, 30);
            this.cbLoteria.TabIndex = 0;
            this.cbLoteria.Text = "Seleccione Lotería";
            // 
            // dtgListado
            // 
            this.dtgListado.AllowUserToAddRows = false;
            this.dtgListado.AllowUserToDeleteRows = false;
            this.dtgListado.AllowUserToOrderColumns = true;
            this.dtgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListado.Location = new System.Drawing.Point(16, 313);
            this.dtgListado.Margin = new System.Windows.Forms.Padding(4);
            this.dtgListado.Name = "dtgListado";
            this.dtgListado.ReadOnly = true;
            this.dtgListado.RowHeadersWidth = 51;
            this.dtgListado.Size = new System.Drawing.Size(668, 185);
            this.dtgListado.TabIndex = 64;
            // 
            // FrmHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 508);
            this.Controls.Add(this.dtgListado);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHorarios";
            this.Text = ".:. Horarios .:.";
            this.Load += new System.EventHandler(this.FrmHorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbTanda;
        private System.Windows.Forms.Button btnActualizarHorario;
        private System.Windows.Forms.ComboBox cbEstatusHorario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMinutos;
        private System.Windows.Forms.ComboBox cbHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoteria;
        private System.Windows.Forms.DataGridView dtgListado;
    }
}