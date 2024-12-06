namespace ENE_V2
{
    partial class RegistroSueldo
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
            txtHoras = new TextBox();
            txtExtra = new TextBox();
            txtBruto = new TextBox();
            txtLiquido = new TextBox();
            cmbSalud = new ComboBox();
            cmbAfp = new ComboBox();
            groupBox1 = new GroupBox();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(196, 45);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(100, 23);
            txtHoras.TabIndex = 0;
            txtHoras.KeyPress += txtHoras_KeyPress;
            // 
            // txtExtra
            // 
            txtExtra.Location = new Point(196, 87);
            txtExtra.Name = "txtExtra";
            txtExtra.Size = new Size(100, 23);
            txtExtra.TabIndex = 1;
            txtExtra.KeyPress += txtExtra_KeyPress;
            // 
            // txtBruto
            // 
            txtBruto.Location = new Point(345, 164);
            txtBruto.Name = "txtBruto";
            txtBruto.Size = new Size(121, 23);
            txtBruto.TabIndex = 2;
            // 
            // txtLiquido
            // 
            txtLiquido.Location = new Point(345, 204);
            txtLiquido.Name = "txtLiquido";
            txtLiquido.Size = new Size(121, 23);
            txtLiquido.TabIndex = 3;
            // 
            // cmbSalud
            // 
            cmbSalud.FormattingEnabled = true;
            cmbSalud.Items.AddRange(new object[] { "FONASA", "CONSALUD", "MASVIDA", "BANMEDICA" });
            cmbSalud.Location = new Point(345, 87);
            cmbSalud.Name = "cmbSalud";
            cmbSalud.Size = new Size(121, 23);
            cmbSalud.TabIndex = 4;
            // 
            // cmbAfp
            // 
            cmbAfp.FormattingEnabled = true;
            cmbAfp.Items.AddRange(new object[] { "CUPRUM", "MODELO", "CAPITAL", "PROVIDA" });
            cmbAfp.Location = new Point(345, 45);
            cmbAfp.Name = "cmbAfp";
            cmbAfp.Size = new Size(121, 23);
            cmbAfp.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbAfp);
            groupBox1.Controls.Add(txtLiquido);
            groupBox1.Controls.Add(cmbSalud);
            groupBox1.Controls.Add(txtBruto);
            groupBox1.Controls.Add(txtExtra);
            groupBox1.Controls.Add(txtHoras);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(520, 283);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "CalcularSueldos";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(61, 204);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 42);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar Campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(61, 163);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 207);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 9;
            label4.Text = "Sueldo Liquido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 167);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 8;
            label3.Text = "Sueldo Bruto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 93);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 7;
            label2.Text = "Horas Extras";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 48);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 6;
            label1.Text = "Horas Trabajadas";
            // 
            // RegistroSueldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 307);
            Controls.Add(groupBox1);
            Name = "RegistroSueldo";
            Text = "RegistroSueldo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtHoras;
        private TextBox txtExtra;
        private TextBox txtBruto;
        private TextBox txtLiquido;
        private ComboBox cmbSalud;
        private ComboBox cmbAfp;
        private GroupBox groupBox1;
        private Button btnLimpiar;
        private Button btnCalcular;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}