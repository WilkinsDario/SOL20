
namespace CapaPresentacion
{
    partial class FrmMigracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMigracion));
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.btnMigrarALocal = new System.Windows.Forms.Button();
            this.btnMigrar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtgListado = new System.Windows.Forms.DataGridView();
            this.ckbMigrarServer = new System.Windows.Forms.CheckBox();
            this.ckbMigrarLocal = new System.Windows.Forms.CheckBox();
            this.btnMigracion = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListado)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(600, 128);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(129, 22);
            this.dtpHasta.TabIndex = 46;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(329, 128);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(127, 22);
            this.dtpDesde.TabIndex = 45;
            // 
            // btnMigrarALocal
            // 
            this.btnMigrarALocal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMigrarALocal.Location = new System.Drawing.Point(627, 76);
            this.btnMigrarALocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMigrarALocal.Name = "btnMigrarALocal";
            this.btnMigrarALocal.Size = new System.Drawing.Size(77, 44);
            this.btnMigrarALocal.TabIndex = 44;
            this.btnMigrarALocal.Text = "Hasta";
            this.btnMigrarALocal.UseVisualStyleBackColor = true;
            this.btnMigrarALocal.Click += new System.EventHandler(this.btnMigrarALocal_Click);
            // 
            // btnMigrar
            // 
            this.btnMigrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMigrar.Location = new System.Drawing.Point(352, 76);
            this.btnMigrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMigrar.Name = "btnMigrar";
            this.btnMigrar.Size = new System.Drawing.Size(81, 44);
            this.btnMigrar.TabIndex = 43;
            this.btnMigrar.Text = "Desde";
            this.btnMigrar.UseVisualStyleBackColor = true;
            this.btnMigrar.Click += new System.EventHandler(this.btnMigrar_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(5, 130);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(264, 22);
            this.label17.TabIndex = 65;
            this.label17.Text = "Más que un juego, una inversión";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(15, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(254, 22);
            this.label18.TabIndex = 64;
            this.label18.Text = "Donde Garantizamos tu Dinero";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CapaPresentacion.Properties.Resources.sol;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(44, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 89);
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // dtgListado
            // 
            this.dtgListado.AllowUserToAddRows = false;
            this.dtgListado.AllowUserToDeleteRows = false;
            this.dtgListado.AllowUserToOrderColumns = true;
            this.dtgListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListado.Location = new System.Drawing.Point(16, 278);
            this.dtgListado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgListado.Name = "dtgListado";
            this.dtgListado.ReadOnly = true;
            this.dtgListado.RowHeadersWidth = 51;
            this.dtgListado.Size = new System.Drawing.Size(755, 202);
            this.dtgListado.TabIndex = 66;
            // 
            // ckbMigrarServer
            // 
            this.ckbMigrarServer.AutoSize = true;
            this.ckbMigrarServer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMigrarServer.Location = new System.Drawing.Point(203, 234);
            this.ckbMigrarServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbMigrarServer.Name = "ckbMigrarServer";
            this.ckbMigrarServer.Size = new System.Drawing.Size(159, 26);
            this.ckbMigrarServer.TabIndex = 79;
            this.ckbMigrarServer.Text = "Migrar a Server";
            this.ckbMigrarServer.UseVisualStyleBackColor = true;
            this.ckbMigrarServer.CheckedChanged += new System.EventHandler(this.ckbMigrarServer_CheckedChanged);
            // 
            // ckbMigrarLocal
            // 
            this.ckbMigrarLocal.AutoSize = true;
            this.ckbMigrarLocal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMigrarLocal.Location = new System.Drawing.Point(411, 234);
            this.ckbMigrarLocal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckbMigrarLocal.Name = "ckbMigrarLocal";
            this.ckbMigrarLocal.Size = new System.Drawing.Size(151, 26);
            this.ckbMigrarLocal.TabIndex = 80;
            this.ckbMigrarLocal.Text = "Migrar a Local";
            this.ckbMigrarLocal.UseVisualStyleBackColor = true;
            this.ckbMigrarLocal.CheckedChanged += new System.EventHandler(this.ckbMigrarLocal_CheckedChanged);
            // 
            // btnMigracion
            // 
            this.btnMigracion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMigracion.Location = new System.Drawing.Point(600, 224);
            this.btnMigracion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMigracion.Name = "btnMigracion";
            this.btnMigracion.Size = new System.Drawing.Size(104, 44);
            this.btnMigracion.TabIndex = 81;
            this.btnMigracion.Text = "Migrar";
            this.btnMigracion.UseVisualStyleBackColor = true;
            this.btnMigracion.Click += new System.EventHandler(this.btnMigracion_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(481, 76);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(104, 44);
            this.btnConsulta.TabIndex = 82;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // FrmMigracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 495);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnMigracion);
            this.Controls.Add(this.ckbMigrarLocal);
            this.Controls.Add(this.ckbMigrarServer);
            this.Controls.Add(this.dtgListado);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.btnMigrarALocal);
            this.Controls.Add(this.btnMigrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMigracion";
            this.Text = ".:. Migracion .:.";
            this.Load += new System.EventHandler(this.FrmMigracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button btnMigrarALocal;
        private System.Windows.Forms.Button btnMigrar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgListado;
        private System.Windows.Forms.CheckBox ckbMigrarServer;
        private System.Windows.Forms.CheckBox ckbMigrarLocal;
        private System.Windows.Forms.Button btnMigracion;
        private System.Windows.Forms.Button btnConsulta;
    }
}