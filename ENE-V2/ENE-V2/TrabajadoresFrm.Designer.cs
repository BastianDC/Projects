namespace ENE_V2
{
    partial class TrabajadoresFrm
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
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtExtra = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtHora = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtRut = new TextBox();
            btnAgregar = new Button();
            groupBox2 = new GroupBox();
            btnModificar = new Button();
            dgvResultado = new DataGridView();
            cmbBuscar = new ComboBox();
            label8 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultado).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtExtra);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtHora);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtRut);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 382);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Trabajador";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 264);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 14;
            label7.Text = "ValorExtra";
            // 
            // txtExtra
            // 
            txtExtra.Location = new Point(112, 264);
            txtExtra.Name = "txtExtra";
            txtExtra.Size = new Size(100, 23);
            txtExtra.TabIndex = 13;
            txtExtra.KeyPress += txtExtra_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 224);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 12;
            label4.Text = "ValorHora";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 186);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 11;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 148);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Direccion";
            // 
            // txtHora
            // 
            txtHora.Location = new Point(112, 224);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(100, 23);
            txtHora.TabIndex = 9;
            txtHora.KeyPress += txtHora_KeyPress;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(112, 187);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 8;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(112, 150);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 109);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 71);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 33);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 4;
            label1.Text = "Rut";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(112, 109);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 3;
            txtApellido.TextChanged += txtApellido_TextChanged;
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(112, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtRut
            // 
            txtRut.Location = new Point(112, 35);
            txtRut.Name = "txtRut";
            txtRut.Size = new Size(100, 23);
            txtRut.TabIndex = 1;
            txtRut.KeyPress += txtRut_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(91, 319);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Info;
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Controls.Add(dgvResultado);
            groupBox2.Controls.Add(cmbBuscar);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(284, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(504, 382);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Buscar Trabajador";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(125, 319);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // dgvResultado
            // 
            dgvResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultado.Location = new Point(34, 86);
            dgvResultado.Name = "dgvResultado";
            dgvResultado.Size = new Size(434, 214);
            dgvResultado.TabIndex = 9;
            // 
            // cmbBuscar
            // 
            cmbBuscar.FormattingEnabled = true;
            cmbBuscar.Location = new Point(157, 40);
            cmbBuscar.Name = "cmbBuscar";
            cmbBuscar.Size = new Size(121, 23);
            cmbBuscar.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 43);
            label8.Name = "label8";
            label8.Size = new Size(84, 15);
            label8.TabIndex = 7;
            label8.Text = "Seleccione Rut";
            // 
            // button1
            // 
            button1.Location = new Point(265, 319);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // TrabajadoresFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "TrabajadoresFrm";
            Text = "TrabajadoresFrm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtHora;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtRut;
        private Button btnAgregar;
        private Label label7;
        private TextBox txtExtra;
        private GroupBox groupBox2;
        private DataGridView dgvResultado;
        private ComboBox cmbBuscar;
        private Label label8;
        private Button btnModificar;
        private Button button1;
    }
}