namespace CursosLibres.Views
{
	partial class FrmCursos
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
            txtCupo = new TextBox();
            txtCosto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            txtTitulo = new TextBox();
            mbModalidad = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtPlataforma = new TextBox();
            txtEnlace = new TextBox();
            txtCampus = new TextBox();
            txtSalon = new TextBox();
            label13 = new Label();
            label14 = new Label();
            btnAgregarSesion = new Button();
            label15 = new Label();
            txtDuracion = new TextBox();
            label16 = new Label();
            btnCrear = new Button();
            btnCancelar = new Button();
            dtpFechaHora = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label17 = new Label();
            lstSesiones = new ListBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // txtCupo
            // 
            txtCupo.Location = new Point(376, 83);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new Size(137, 27);
            txtCupo.TabIndex = 2;
            txtCupo.TextChanged += txtCupo_TextChanged;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(552, 83);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(137, 27);
            txtCosto.TabIndex = 4;
            txtCosto.TextChanged += txtCosto_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 19);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 13;
            label1.Text = "Titulo:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 129);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 15;
            label2.Text = "Docente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(48, 56);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 16;
            label3.Text = "Categoría:";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(376, 56);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 17;
            label4.Text = "Cupo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(552, 56);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 18;
            label5.Text = "Costo:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 27);
            textBox1.TabIndex = 19;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(111, 16);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(578, 27);
            txtTitulo.TabIndex = 20;
            // 
            // mbModalidad
            // 
            mbModalidad.FormattingEnabled = true;
            mbModalidad.Items.AddRange(new object[] { "Presencial", "Virtual", "Híbrido" });
            mbModalidad.Location = new Point(376, 161);
            mbModalidad.Name = "mbModalidad";
            mbModalidad.Size = new Size(313, 28);
            mbModalidad.TabIndex = 21;
            mbModalidad.SelectedIndexChanged += mbModalidad_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(376, 129);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 22;
            label6.Text = "Modalidad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(48, 209);
            label7.Name = "label7";
            label7.Size = new Size(73, 20);
            label7.TabIndex = 23;
            label7.Text = "Sesiones:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(48, 241);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 24;
            label8.Text = "Fecha";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(376, 209);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 25;
            label9.Text = "Presensial";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(552, 209);
            label10.Name = "label10";
            label10.Size = new Size(56, 20);
            label10.TabIndex = 26;
            label10.Text = "Virtual";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(552, 302);
            label11.Name = "label11";
            label11.Size = new Size(52, 20);
            label11.TabIndex = 27;
            label11.Text = "Enlace";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(552, 241);
            label12.Name = "label12";
            label12.Size = new Size(82, 20);
            label12.TabIndex = 28;
            label12.Text = "Plataforma";
            // 
            // txtPlataforma
            // 
            txtPlataforma.Location = new Point(552, 266);
            txtPlataforma.Name = "txtPlataforma";
            txtPlataforma.Size = new Size(137, 27);
            txtPlataforma.TabIndex = 29;
            // 
            // txtEnlace
            // 
            txtEnlace.Location = new Point(552, 328);
            txtEnlace.Name = "txtEnlace";
            txtEnlace.Size = new Size(137, 27);
            txtEnlace.TabIndex = 30;
            txtEnlace.TextChanged += txtEnlace_TextChanged;
            // 
            // txtCampus
            // 
            txtCampus.Location = new Point(376, 266);
            txtCampus.Name = "txtCampus";
            txtCampus.Size = new Size(137, 27);
            txtCampus.TabIndex = 31;
            // 
            // txtSalon
            // 
            txtSalon.Location = new Point(376, 328);
            txtSalon.Name = "txtSalon";
            txtSalon.Size = new Size(137, 27);
            txtSalon.TabIndex = 32;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(376, 241);
            label13.Name = "label13";
            label13.Size = new Size(62, 20);
            label13.TabIndex = 33;
            label13.Text = "Campus";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(376, 302);
            label14.Name = "label14";
            label14.Size = new Size(46, 20);
            label14.TabIndex = 34;
            label14.Text = "Salón";
            // 
            // btnAgregarSesion
            // 
            btnAgregarSesion.Location = new Point(208, 323);
            btnAgregarSesion.Name = "btnAgregarSesion";
            btnAgregarSesion.Size = new Size(135, 29);
            btnAgregarSesion.TabIndex = 36;
            btnAgregarSesion.Text = "Agregar";
            btnAgregarSesion.UseVisualStyleBackColor = true;
            btnAgregarSesion.Click += button1_Click_1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(48, 302);
            label15.Name = "label15";
            label15.Size = new Size(69, 20);
            label15.TabIndex = 37;
            label15.Text = "Duración";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(48, 325);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(138, 27);
            txtDuracion.TabIndex = 38;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(48, 365);
            label16.Name = "label16";
            label16.Size = new Size(66, 20);
            label16.TabIndex = 40;
            label16.Text = "Sesiones";
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(495, 501);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 42;
            btnCrear.Text = "Crear ";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(595, 501);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtpFechaHora
            // 
            dtpFechaHora.Format = DateTimePickerFormat.Short;
            dtpFechaHora.Location = new Point(48, 266);
            dtpFechaHora.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dtpFechaHora.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dtpFechaHora.Name = "dtpFechaHora";
            dtpFechaHora.Size = new Size(138, 27);
            dtpFechaHora.TabIndex = 44;
            dtpFechaHora.Value = new DateTime(2025, 9, 5, 0, 0, 0, 0);
            dtpFechaHora.ValueChanged += dtpFechaHora_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(208, 266);
            dateTimePicker1.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(135, 27);
            dateTimePicker1.TabIndex = 45;
            dateTimePicker1.Value = new DateTime(2025, 9, 5, 0, 0, 0, 0);
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(208, 241);
            label17.Name = "label17";
            label17.Size = new Size(42, 20);
            label17.TabIndex = 46;
            label17.Text = "Hora";
            // 
            // lstSesiones
            // 
            lstSesiones.FormattingEnabled = true;
            lstSesiones.Location = new Point(48, 388);
            lstSesiones.Name = "lstSesiones";
            lstSesiones.Size = new Size(374, 144);
            lstSesiones.TabIndex = 47;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Presencial", "Virtual", "Híbrido" });
            comboBox1.Location = new Point(48, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(295, 28);
            comboBox1.TabIndex = 48;
            // 
            // FrmCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 543);
            Controls.Add(comboBox1);
            Controls.Add(lstSesiones);
            Controls.Add(label17);
            Controls.Add(dateTimePicker1);
            Controls.Add(dtpFechaHora);
            Controls.Add(btnCancelar);
            Controls.Add(btnCrear);
            Controls.Add(label16);
            Controls.Add(txtDuracion);
            Controls.Add(label15);
            Controls.Add(btnAgregarSesion);
            Controls.Add(txtCampus);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(txtSalon);
            Controls.Add(txtEnlace);
            Controls.Add(txtPlataforma);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(mbModalidad);
            Controls.Add(txtTitulo);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCosto);
            Controls.Add(txtCupo);
            Name = "FrmCursos";
            Text = "FrmCursos";
            Load += FrmCursos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCupo;
        private TextBox txtCosto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox txtTitulo;
        private ComboBox mbModalidad;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtPlataforma;
        private TextBox txtEnlace;
        private TextBox txtCampus;
        private TextBox txtSalon;
        private Label label13;
        private Label label14;
        private Button btnAgregarSesion;
        private Label label15;
        private TextBox txtDuracion;
        private Label label16;
        private Button btnCrear;
        private Button btnCancelar;
        private DateTimePicker dtpFechaHora;
        private DateTimePicker dateTimePicker1;
        private Label label17;
        private ListBox lstSesiones;
        private ComboBox comboBox1;
    }
}