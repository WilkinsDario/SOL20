
namespace Presentacion
{
    partial class FrmJuagada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJuagada));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTripleta = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalJugada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbImprimir = new System.Windows.Forms.CheckBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.txtDevuelta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPaleA = new System.Windows.Forms.Button();
            this.btnQuinielaA = new System.Windows.Forms.Button();
            this.btnTripletaA = new System.Windows.Forms.Button();
            this.gbAutomaticas = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtQuiniela = new System.Windows.Forms.TextBox();
            this.txtPale = new System.Windows.Forms.TextBox();
            this.gbJugada = new System.Windows.Forms.GroupBox();
            this.btnMostrarJugadas = new System.Windows.Forms.Button();
            this.btnMostrarValores = new System.Windows.Forms.Button();
            this.txtNumeroJugada = new System.Windows.Forms.TextBox();
            this.btnQuiniela = new System.Windows.Forms.Button();
            this.btnPale = new System.Windows.Forms.Button();
            this.btnTripleta = new System.Windows.Forms.Button();
            this.btnSuperPale = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbQJugada = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbPJugada = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbTJugada = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelarTicket = new System.Windows.Forms.Button();
            this.btnQuinielaPale = new System.Windows.Forms.Button();
            this.btnNewYork = new System.Windows.Forms.Button();
            this.btnFlorida = new System.Windows.Forms.Button();
            this.btnReal = new System.Windows.Forms.Button();
            this.btnLaPrimera = new System.Windows.Forms.Button();
            this.btnGanamas = new System.Windows.Forms.Button();
            this.btnNacional = new System.Windows.Forms.Button();
            this.btnLoteka = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAng9 = new System.Windows.Forms.Button();
            this.btnAng1 = new System.Windows.Forms.Button();
            this.btnAng5 = new System.Windows.Forms.Button();
            this.btnAng10 = new System.Windows.Forms.Button();
            this.btnKingNoche = new System.Windows.Forms.Button();
            this.btnKingTarde = new System.Windows.Forms.Button();
            this.btnLasuerte = new System.Windows.Forms.Button();
            this.btnFloridaNoche = new System.Windows.Forms.Button();
            this.btnNewYorkNoche = new System.Windows.Forms.Button();
            this.printTicket = new System.Drawing.Printing.PrintDocument();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnCopiarJugada = new System.Windows.Forms.Button();
            this.gbAutomaticas.SuspendLayout();
            this.gbJugada.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jugada:";
            // 
            // txtTripleta
            // 
            this.txtTripleta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTripleta.Location = new System.Drawing.Point(217, 81);
            this.txtTripleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTripleta.Name = "txtTripleta";
            this.txtTripleta.Size = new System.Drawing.Size(55, 30);
            this.txtTripleta.TabIndex = 24;
            this.txtTripleta.TextChanged += new System.EventHandler(this.txtTripleta_TextChanged);
            this.txtTripleta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTripleta_KeyPress);
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(363, 81);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 30);
            this.txtMonto.TabIndex = 25;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Monto:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(469, 75);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 39);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "Jugar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(591, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Jugada: $RD";
            // 
            // txtTotalJugada
            // 
            this.txtTotalJugada.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalJugada.Location = new System.Drawing.Point(755, 81);
            this.txtTotalJugada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalJugada.Name = "txtTotalJugada";
            this.txtTotalJugada.ReadOnly = true;
            this.txtTotalJugada.Size = new System.Drawing.Size(140, 30);
            this.txtTotalJugada.TabIndex = 8;
            this.txtTotalJugada.Text = "0.00";
            this.txtTotalJugada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1147, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha:";
            // 
            // ckbImprimir
            // 
            this.ckbImprimir.AutoSize = true;
            this.ckbImprimir.Checked = true;
            this.ckbImprimir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbImprimir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbImprimir.Location = new System.Drawing.Point(13, 644);
            this.ckbImprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckbImprimir.Name = "ckbImprimir";
            this.ckbImprimir.Size = new System.Drawing.Size(102, 26);
            this.ckbImprimir.TabIndex = 11;
            this.ckbImprimir.Text = "Imprimir";
            this.ckbImprimir.UseVisualStyleBackColor = true;
            // 
            // btnCobrar
            // 
            this.btnCobrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Location = new System.Drawing.Point(1423, 372);
            this.btnCobrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(161, 39);
            this.btnCobrar.TabIndex = 13;
            this.btnCobrar.Text = "Completar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // txtDevuelta
            // 
            this.txtDevuelta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDevuelta.Location = new System.Drawing.Point(843, 644);
            this.txtDevuelta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDevuelta.Name = "txtDevuelta";
            this.txtDevuelta.ReadOnly = true;
            this.txtDevuelta.Size = new System.Drawing.Size(100, 30);
            this.txtDevuelta.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(749, 647);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Devuelta:";
            // 
            // btnPaleA
            // 
            this.btnPaleA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaleA.Location = new System.Drawing.Point(123, 30);
            this.btnPaleA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPaleA.Name = "btnPaleA";
            this.btnPaleA.Size = new System.Drawing.Size(109, 39);
            this.btnPaleA.TabIndex = 16;
            this.btnPaleA.Text = "Pale";
            this.btnPaleA.UseVisualStyleBackColor = true;
            this.btnPaleA.Click += new System.EventHandler(this.btnPaleA_Click);
            // 
            // btnQuinielaA
            // 
            this.btnQuinielaA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuinielaA.Location = new System.Drawing.Point(8, 30);
            this.btnQuinielaA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuinielaA.Name = "btnQuinielaA";
            this.btnQuinielaA.Size = new System.Drawing.Size(109, 39);
            this.btnQuinielaA.TabIndex = 17;
            this.btnQuinielaA.Text = "Quiniela";
            this.btnQuinielaA.UseVisualStyleBackColor = true;
            this.btnQuinielaA.Click += new System.EventHandler(this.btnQuinielaA_Click);
            // 
            // btnTripletaA
            // 
            this.btnTripletaA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTripletaA.Location = new System.Drawing.Point(237, 30);
            this.btnTripletaA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTripletaA.Name = "btnTripletaA";
            this.btnTripletaA.Size = new System.Drawing.Size(109, 39);
            this.btnTripletaA.TabIndex = 18;
            this.btnTripletaA.Text = "Tripleta";
            this.btnTripletaA.UseVisualStyleBackColor = true;
            this.btnTripletaA.Click += new System.EventHandler(this.btnTripletaA_Click);
            // 
            // gbAutomaticas
            // 
            this.gbAutomaticas.Controls.Add(this.btnPaleA);
            this.gbAutomaticas.Controls.Add(this.btnTripletaA);
            this.gbAutomaticas.Controls.Add(this.btnQuinielaA);
            this.gbAutomaticas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAutomaticas.Location = new System.Drawing.Point(132, 644);
            this.gbAutomaticas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAutomaticas.Name = "gbAutomaticas";
            this.gbAutomaticas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAutomaticas.Size = new System.Drawing.Size(376, 84);
            this.gbAutomaticas.TabIndex = 19;
            this.gbAutomaticas.TabStop = false;
            this.gbAutomaticas.Text = "Jugadas Automaticas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(583, 647);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 22);
            this.label6.TabIndex = 21;
            this.label6.Text = "Pago:";
            // 
            // txtPago
            // 
            this.txtPago.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.Location = new System.Drawing.Point(645, 644);
            this.txtPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(100, 30);
            this.txtPago.TabIndex = 20;
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtQuiniela
            // 
            this.txtQuiniela.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuiniela.Location = new System.Drawing.Point(95, 81);
            this.txtQuiniela.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuiniela.Name = "txtQuiniela";
            this.txtQuiniela.Size = new System.Drawing.Size(55, 30);
            this.txtQuiniela.TabIndex = 22;
            this.txtQuiniela.TextChanged += new System.EventHandler(this.txtQuiniela_TextChanged);
            this.txtQuiniela.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuiniela_KeyPress);
            // 
            // txtPale
            // 
            this.txtPale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPale.Location = new System.Drawing.Point(156, 81);
            this.txtPale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPale.Name = "txtPale";
            this.txtPale.Size = new System.Drawing.Size(55, 30);
            this.txtPale.TabIndex = 23;
            this.txtPale.TextChanged += new System.EventHandler(this.txtPale_TextChanged);
            this.txtPale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPale_KeyPress);
            // 
            // gbJugada
            // 
            this.gbJugada.Controls.Add(this.btnMostrarJugadas);
            this.gbJugada.Controls.Add(this.btnMostrarValores);
            this.gbJugada.Controls.Add(this.txtNumeroJugada);
            this.gbJugada.Controls.Add(this.btnQuiniela);
            this.gbJugada.Controls.Add(this.btnPale);
            this.gbJugada.Controls.Add(this.btnTripleta);
            this.gbJugada.Controls.Add(this.txtPale);
            this.gbJugada.Controls.Add(this.btnSuperPale);
            this.gbJugada.Controls.Add(this.txtQuiniela);
            this.gbJugada.Controls.Add(this.txtTotalJugada);
            this.gbJugada.Controls.Add(this.label3);
            this.gbJugada.Controls.Add(this.btnAgregar);
            this.gbJugada.Controls.Add(this.txtMonto);
            this.gbJugada.Controls.Add(this.label2);
            this.gbJugada.Controls.Add(this.txtTripleta);
            this.gbJugada.Controls.Add(this.label1);
            this.gbJugada.Location = new System.Drawing.Point(15, 212);
            this.gbJugada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbJugada.Name = "gbJugada";
            this.gbJugada.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbJugada.Size = new System.Drawing.Size(1184, 121);
            this.gbJugada.TabIndex = 24;
            this.gbJugada.TabStop = false;
            // 
            // btnMostrarJugadas
            // 
            this.btnMostrarJugadas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarJugadas.Location = new System.Drawing.Point(950, 21);
            this.btnMostrarJugadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarJugadas.Name = "btnMostrarJugadas";
            this.btnMostrarJugadas.Size = new System.Drawing.Size(109, 39);
            this.btnMostrarJugadas.TabIndex = 49;
            this.btnMostrarJugadas.Text = "Jugadas";
            this.btnMostrarJugadas.UseVisualStyleBackColor = true;
            this.btnMostrarJugadas.Click += new System.EventHandler(this.btnMostrarJugadas_Click);
            // 
            // btnMostrarValores
            // 
            this.btnMostrarValores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarValores.Location = new System.Drawing.Point(1067, 21);
            this.btnMostrarValores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarValores.Name = "btnMostrarValores";
            this.btnMostrarValores.Size = new System.Drawing.Size(109, 39);
            this.btnMostrarValores.TabIndex = 48;
            this.btnMostrarValores.Text = "Valores";
            this.btnMostrarValores.UseVisualStyleBackColor = true;
            this.btnMostrarValores.Click += new System.EventHandler(this.btnMostrarValores_Click);
            // 
            // txtNumeroJugada
            // 
            this.txtNumeroJugada.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroJugada.Location = new System.Drawing.Point(1064, 80);
            this.txtNumeroJugada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumeroJugada.Name = "txtNumeroJugada";
            this.txtNumeroJugada.ReadOnly = true;
            this.txtNumeroJugada.Size = new System.Drawing.Size(109, 30);
            this.txtNumeroJugada.TabIndex = 39;
            this.txtNumeroJugada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnQuiniela
            // 
            this.btnQuiniela.BackColor = System.Drawing.Color.Orange;
            this.btnQuiniela.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuiniela.Location = new System.Drawing.Point(45, 20);
            this.btnQuiniela.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuiniela.Name = "btnQuiniela";
            this.btnQuiniela.Size = new System.Drawing.Size(145, 41);
            this.btnQuiniela.TabIndex = 38;
            this.btnQuiniela.Text = "Quiniela";
            this.btnQuiniela.UseVisualStyleBackColor = false;
            this.btnQuiniela.Click += new System.EventHandler(this.btnQuiniela_Click);
            // 
            // btnPale
            // 
            this.btnPale.BackColor = System.Drawing.Color.Orange;
            this.btnPale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPale.Location = new System.Drawing.Point(225, 20);
            this.btnPale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPale.Name = "btnPale";
            this.btnPale.Size = new System.Drawing.Size(145, 41);
            this.btnPale.TabIndex = 37;
            this.btnPale.Text = "Palé";
            this.btnPale.UseVisualStyleBackColor = false;
            this.btnPale.Click += new System.EventHandler(this.btnPale_Click);
            // 
            // btnTripleta
            // 
            this.btnTripleta.BackColor = System.Drawing.Color.Orange;
            this.btnTripleta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTripleta.Location = new System.Drawing.Point(400, 20);
            this.btnTripleta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTripleta.Name = "btnTripleta";
            this.btnTripleta.Size = new System.Drawing.Size(145, 41);
            this.btnTripleta.TabIndex = 36;
            this.btnTripleta.Text = "Tripleta";
            this.btnTripleta.UseVisualStyleBackColor = false;
            this.btnTripleta.Click += new System.EventHandler(this.btnTripleta_Click);
            // 
            // btnSuperPale
            // 
            this.btnSuperPale.BackColor = System.Drawing.Color.Orange;
            this.btnSuperPale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuperPale.Location = new System.Drawing.Point(577, 20);
            this.btnSuperPale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuperPale.Name = "btnSuperPale";
            this.btnSuperPale.Size = new System.Drawing.Size(145, 41);
            this.btnSuperPale.TabIndex = 39;
            this.btnSuperPale.Text = "Super Palé";
            this.btnSuperPale.UseVisualStyleBackColor = false;
            this.btnSuperPale.Click += new System.EventHandler(this.btnSuperPale_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1463, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 22);
            this.label8.TabIndex = 41;
            this.label8.Text = "Consulta";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(1423, 300);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(159, 30);
            this.txtBuscar.TabIndex = 40;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroTicketCanc_KeyPress);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(1423, 415);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(161, 39);
            this.btnImprimir.TabIndex = 26;
            this.btnImprimir.Text = "Re-Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1423, 458);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(161, 39);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbQJugada);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(15, 363);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(464, 274);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quiniela";
            // 
            // lbQJugada
            // 
            this.lbQJugada.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQJugada.FormattingEnabled = true;
            this.lbQJugada.ItemHeight = 26;
            this.lbQJugada.Location = new System.Drawing.Point(5, 42);
            this.lbQJugada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbQJugada.Name = "lbQJugada";
            this.lbQJugada.Size = new System.Drawing.Size(452, 212);
            this.lbQJugada.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 22);
            this.label7.TabIndex = 29;
            this.label7.Text = "Jugada";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbPJugada);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(484, 363);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(464, 274);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pale";
            // 
            // lbPJugada
            // 
            this.lbPJugada.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPJugada.FormattingEnabled = true;
            this.lbPJugada.ItemHeight = 26;
            this.lbPJugada.Location = new System.Drawing.Point(5, 42);
            this.lbPJugada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbPJugada.Name = "lbPJugada";
            this.lbPJugada.Size = new System.Drawing.Size(452, 212);
            this.lbPJugada.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 22);
            this.label10.TabIndex = 31;
            this.label10.Text = "Jugada";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbTJugada);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(953, 363);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(464, 274);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tripleta";
            // 
            // lbTJugada
            // 
            this.lbTJugada.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTJugada.FormattingEnabled = true;
            this.lbTJugada.ItemHeight = 26;
            this.lbTJugada.Location = new System.Drawing.Point(5, 44);
            this.lbTJugada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTJugada.Name = "lbTJugada";
            this.lbTJugada.Size = new System.Drawing.Size(452, 212);
            this.lbTJugada.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(61, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 22);
            this.label12.TabIndex = 33;
            this.label12.Text = "Jugada";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1423, 501);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(161, 39);
            this.btnEliminar.TabIndex = 32;
            this.btnEliminar.Text = "Eliminar Jugada";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelarTicket
            // 
            this.btnCancelarTicket.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarTicket.Location = new System.Drawing.Point(1421, 544);
            this.btnCancelarTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelarTicket.Name = "btnCancelarTicket";
            this.btnCancelarTicket.Size = new System.Drawing.Size(161, 39);
            this.btnCancelarTicket.TabIndex = 34;
            this.btnCancelarTicket.Text = "Cancelar Ticket";
            this.btnCancelarTicket.UseVisualStyleBackColor = true;
            this.btnCancelarTicket.Click += new System.EventHandler(this.btnCancelarTicket_Click);
            // 
            // btnQuinielaPale
            // 
            this.btnQuinielaPale.BackColor = System.Drawing.Color.Orange;
            this.btnQuinielaPale.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuinielaPale.Location = new System.Drawing.Point(308, 36);
            this.btnQuinielaPale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuinielaPale.Name = "btnQuinielaPale";
            this.btnQuinielaPale.Size = new System.Drawing.Size(145, 41);
            this.btnQuinielaPale.TabIndex = 37;
            this.btnQuinielaPale.Text = "Quiniela Pale";
            this.btnQuinielaPale.UseVisualStyleBackColor = false;
            this.btnQuinielaPale.Click += new System.EventHandler(this.btnQuinielaPale_Click);
            // 
            // btnNewYork
            // 
            this.btnNewYork.BackColor = System.Drawing.Color.Orange;
            this.btnNewYork.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewYork.Location = new System.Drawing.Point(611, 36);
            this.btnNewYork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewYork.Name = "btnNewYork";
            this.btnNewYork.Size = new System.Drawing.Size(161, 41);
            this.btnNewYork.TabIndex = 35;
            this.btnNewYork.Text = "New York Tarde";
            this.btnNewYork.UseVisualStyleBackColor = false;
            this.btnNewYork.Click += new System.EventHandler(this.btnNewYork_Click);
            // 
            // btnFlorida
            // 
            this.btnFlorida.BackColor = System.Drawing.Color.Orange;
            this.btnFlorida.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlorida.Location = new System.Drawing.Point(777, 36);
            this.btnFlorida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFlorida.Name = "btnFlorida";
            this.btnFlorida.Size = new System.Drawing.Size(145, 41);
            this.btnFlorida.TabIndex = 34;
            this.btnFlorida.Text = "Florida Tarde";
            this.btnFlorida.UseVisualStyleBackColor = false;
            this.btnFlorida.Click += new System.EventHandler(this.btnFlorida_Click);
            // 
            // btnReal
            // 
            this.btnReal.BackColor = System.Drawing.Color.Orange;
            this.btnReal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReal.Location = new System.Drawing.Point(157, 36);
            this.btnReal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReal.Name = "btnReal";
            this.btnReal.Size = new System.Drawing.Size(145, 41);
            this.btnReal.TabIndex = 38;
            this.btnReal.Text = "Real";
            this.btnReal.UseVisualStyleBackColor = false;
            this.btnReal.Click += new System.EventHandler(this.btnReal_Click);
            // 
            // btnLaPrimera
            // 
            this.btnLaPrimera.BackColor = System.Drawing.Color.Orange;
            this.btnLaPrimera.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaPrimera.Location = new System.Drawing.Point(459, 36);
            this.btnLaPrimera.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLaPrimera.Name = "btnLaPrimera";
            this.btnLaPrimera.Size = new System.Drawing.Size(145, 41);
            this.btnLaPrimera.TabIndex = 36;
            this.btnLaPrimera.Text = "La primera";
            this.btnLaPrimera.UseVisualStyleBackColor = false;
            this.btnLaPrimera.Click += new System.EventHandler(this.btnLaPrimera_Click);
            // 
            // btnGanamas
            // 
            this.btnGanamas.BackColor = System.Drawing.Color.Orange;
            this.btnGanamas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGanamas.Location = new System.Drawing.Point(5, 36);
            this.btnGanamas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGanamas.Name = "btnGanamas";
            this.btnGanamas.Size = new System.Drawing.Size(145, 41);
            this.btnGanamas.TabIndex = 32;
            this.btnGanamas.Text = "GanaMás";
            this.btnGanamas.UseVisualStyleBackColor = false;
            this.btnGanamas.Click += new System.EventHandler(this.btnGanamas_Click);
            // 
            // btnNacional
            // 
            this.btnNacional.BackColor = System.Drawing.Color.Orange;
            this.btnNacional.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNacional.Location = new System.Drawing.Point(928, 36);
            this.btnNacional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNacional.Name = "btnNacional";
            this.btnNacional.Size = new System.Drawing.Size(145, 41);
            this.btnNacional.TabIndex = 40;
            this.btnNacional.Text = "Nacional";
            this.btnNacional.UseVisualStyleBackColor = false;
            this.btnNacional.Click += new System.EventHandler(this.btnNacional_Click_1);
            // 
            // btnLoteka
            // 
            this.btnLoteka.BackColor = System.Drawing.Color.Orange;
            this.btnLoteka.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoteka.Location = new System.Drawing.Point(1079, 36);
            this.btnLoteka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoteka.Name = "btnLoteka";
            this.btnLoteka.Size = new System.Drawing.Size(145, 41);
            this.btnLoteka.TabIndex = 41;
            this.btnLoteka.Text = "Loteka";
            this.btnLoteka.UseVisualStyleBackColor = false;
            this.btnLoteka.Click += new System.EventHandler(this.btnLoteka_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAng9);
            this.groupBox1.Controls.Add(this.btnAng1);
            this.groupBox1.Controls.Add(this.btnAng5);
            this.groupBox1.Controls.Add(this.btnAng10);
            this.groupBox1.Controls.Add(this.btnKingNoche);
            this.groupBox1.Controls.Add(this.btnKingTarde);
            this.groupBox1.Controls.Add(this.btnLasuerte);
            this.groupBox1.Controls.Add(this.btnFloridaNoche);
            this.groupBox1.Controls.Add(this.btnNewYorkNoche);
            this.groupBox1.Controls.Add(this.btnGanamas);
            this.groupBox1.Controls.Add(this.btnLoteka);
            this.groupBox1.Controls.Add(this.btnReal);
            this.groupBox1.Controls.Add(this.btnNacional);
            this.groupBox1.Controls.Add(this.btnQuinielaPale);
            this.groupBox1.Controls.Add(this.btnNewYork);
            this.groupBox1.Controls.Add(this.btnFlorida);
            this.groupBox1.Controls.Add(this.btnLaPrimera);
            this.groupBox1.Location = new System.Drawing.Point(15, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1572, 137);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // btnAng9
            // 
            this.btnAng9.BackColor = System.Drawing.Color.Orange;
            this.btnAng9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAng9.Location = new System.Drawing.Point(999, 81);
            this.btnAng9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAng9.Name = "btnAng9";
            this.btnAng9.Size = new System.Drawing.Size(169, 41);
            this.btnAng9.TabIndex = 50;
            this.btnAng9.Text = "Anguila 9 PM";
            this.btnAng9.UseVisualStyleBackColor = false;
            this.btnAng9.Click += new System.EventHandler(this.btnAng9_Click);
            // 
            // btnAng1
            // 
            this.btnAng1.BackColor = System.Drawing.Color.Orange;
            this.btnAng1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAng1.Location = new System.Drawing.Point(633, 81);
            this.btnAng1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAng1.Name = "btnAng1";
            this.btnAng1.Size = new System.Drawing.Size(185, 41);
            this.btnAng1.TabIndex = 48;
            this.btnAng1.Text = "Anguila 1 PM";
            this.btnAng1.UseVisualStyleBackColor = false;
            this.btnAng1.Click += new System.EventHandler(this.btnAng1_Click);
            // 
            // btnAng5
            // 
            this.btnAng5.BackColor = System.Drawing.Color.Orange;
            this.btnAng5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAng5.Location = new System.Drawing.Point(824, 81);
            this.btnAng5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAng5.Name = "btnAng5";
            this.btnAng5.Size = new System.Drawing.Size(169, 41);
            this.btnAng5.TabIndex = 47;
            this.btnAng5.Text = "Anguila 5 PM";
            this.btnAng5.UseVisualStyleBackColor = false;
            this.btnAng5.Click += new System.EventHandler(this.btnAng5_Click);
            // 
            // btnAng10
            // 
            this.btnAng10.BackColor = System.Drawing.Color.Orange;
            this.btnAng10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAng10.Location = new System.Drawing.Point(459, 81);
            this.btnAng10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAng10.Name = "btnAng10";
            this.btnAng10.Size = new System.Drawing.Size(169, 41);
            this.btnAng10.TabIndex = 49;
            this.btnAng10.Text = "Anguila 10 AM";
            this.btnAng10.UseVisualStyleBackColor = false;
            this.btnAng10.Click += new System.EventHandler(this.btnAng10_Click);
            // 
            // btnKingNoche
            // 
            this.btnKingNoche.BackColor = System.Drawing.Color.Orange;
            this.btnKingNoche.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKingNoche.Location = new System.Drawing.Point(308, 81);
            this.btnKingNoche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKingNoche.Name = "btnKingNoche";
            this.btnKingNoche.Size = new System.Drawing.Size(145, 41);
            this.btnKingNoche.TabIndex = 46;
            this.btnKingNoche.Text = "King Noche";
            this.btnKingNoche.UseVisualStyleBackColor = false;
            this.btnKingNoche.Click += new System.EventHandler(this.btnKingNoche_Click);
            // 
            // btnKingTarde
            // 
            this.btnKingTarde.BackColor = System.Drawing.Color.Orange;
            this.btnKingTarde.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKingTarde.Location = new System.Drawing.Point(157, 81);
            this.btnKingTarde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKingTarde.Name = "btnKingTarde";
            this.btnKingTarde.Size = new System.Drawing.Size(145, 41);
            this.btnKingTarde.TabIndex = 45;
            this.btnKingTarde.Text = "King Tarde";
            this.btnKingTarde.UseVisualStyleBackColor = false;
            this.btnKingTarde.Click += new System.EventHandler(this.btnKingTarde_Click);
            // 
            // btnLasuerte
            // 
            this.btnLasuerte.BackColor = System.Drawing.Color.Orange;
            this.btnLasuerte.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLasuerte.Location = new System.Drawing.Point(4, 81);
            this.btnLasuerte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLasuerte.Name = "btnLasuerte";
            this.btnLasuerte.Size = new System.Drawing.Size(145, 41);
            this.btnLasuerte.TabIndex = 44;
            this.btnLasuerte.Text = "La Suerte";
            this.btnLasuerte.UseVisualStyleBackColor = false;
            this.btnLasuerte.Click += new System.EventHandler(this.btnLasuerte_Click);
            // 
            // btnFloridaNoche
            // 
            this.btnFloridaNoche.BackColor = System.Drawing.Color.Orange;
            this.btnFloridaNoche.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFloridaNoche.Location = new System.Drawing.Point(1408, 36);
            this.btnFloridaNoche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFloridaNoche.Name = "btnFloridaNoche";
            this.btnFloridaNoche.Size = new System.Drawing.Size(145, 41);
            this.btnFloridaNoche.TabIndex = 43;
            this.btnFloridaNoche.Text = "Florida Noche";
            this.btnFloridaNoche.UseVisualStyleBackColor = false;
            this.btnFloridaNoche.Click += new System.EventHandler(this.btnFloridaNoche_Click);
            // 
            // btnNewYorkNoche
            // 
            this.btnNewYorkNoche.BackColor = System.Drawing.Color.Orange;
            this.btnNewYorkNoche.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewYorkNoche.Location = new System.Drawing.Point(1229, 36);
            this.btnNewYorkNoche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewYorkNoche.Name = "btnNewYorkNoche";
            this.btnNewYorkNoche.Size = new System.Drawing.Size(173, 41);
            this.btnNewYorkNoche.TabIndex = 42;
            this.btnNewYorkNoche.Text = "New York Noche";
            this.btnNewYorkNoche.UseVisualStyleBackColor = false;
            this.btnNewYorkNoche.Click += new System.EventHandler(this.btnNewYorkNoche_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(1219, 38);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(60, 23);
            this.lblHora.TabIndex = 48;
            this.lblHora.Text = "label9";
            // 
            // btnCopiarJugada
            // 
            this.btnCopiarJugada.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiarJugada.Location = new System.Drawing.Point(1423, 587);
            this.btnCopiarJugada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopiarJugada.Name = "btnCopiarJugada";
            this.btnCopiarJugada.Size = new System.Drawing.Size(161, 39);
            this.btnCopiarJugada.TabIndex = 49;
            this.btnCopiarJugada.Text = "Copiar Jugada";
            this.btnCopiarJugada.UseVisualStyleBackColor = true;
            this.btnCopiarJugada.Click += new System.EventHandler(this.btnCopiarJugada_Click);
            // 
            // FrmJuagada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1620, 718);
            this.Controls.Add(this.btnCopiarJugada);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelarTicket);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gbJugada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.gbAutomaticas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDevuelta);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.ckbImprimir);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmJuagada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:. Jugada .:.";
            this.Load += new System.EventHandler(this.FrmJuagada_Load);
            this.gbAutomaticas.ResumeLayout(false);
            this.gbJugada.ResumeLayout(false);
            this.gbJugada.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTripleta;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalJugada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbImprimir;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.TextBox txtDevuelta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPaleA;
        private System.Windows.Forms.Button btnQuinielaA;
        private System.Windows.Forms.Button btnTripletaA;
        private System.Windows.Forms.GroupBox gbAutomaticas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtQuiniela;
        private System.Windows.Forms.TextBox txtPale;
        private System.Windows.Forms.GroupBox gbJugada;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lbQJugada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbPJugada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbTJugada;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnQuiniela;
        private System.Windows.Forms.Button btnPale;
        private System.Windows.Forms.Button btnTripleta;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelarTicket;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtNumeroJugada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnQuinielaPale;
        private System.Windows.Forms.Button btnNewYork;
        private System.Windows.Forms.Button btnFlorida;
        private System.Windows.Forms.Button btnReal;
        private System.Windows.Forms.Button btnLaPrimera;
        private System.Windows.Forms.Button btnGanamas;
        private System.Windows.Forms.Button btnSuperPale;
        private System.Windows.Forms.Button btnNacional;
        private System.Windows.Forms.Button btnLoteka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFloridaNoche;
        private System.Windows.Forms.Button btnNewYorkNoche;
        private System.Drawing.Printing.PrintDocument printTicket;
        private System.Windows.Forms.Button btnMostrarValores;
        private System.Windows.Forms.Button btnLasuerte;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnKingNoche;
        private System.Windows.Forms.Button btnKingTarde;
        private System.Windows.Forms.Button btnAng9;
        private System.Windows.Forms.Button btnAng1;
        private System.Windows.Forms.Button btnAng5;
        private System.Windows.Forms.Button btnAng10;
        private System.Windows.Forms.Button btnMostrarJugadas;
        private System.Windows.Forms.Button btnCopiarJugada;
    }
}

