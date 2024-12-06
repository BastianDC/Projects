namespace ENE_V2
{
    partial class LoginFrm
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
            txtUsuario = new TextBox();
            label3 = new Label();
            btnIngresar = new Button();
            label2 = new Label();
            txtClave = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(120, 121);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(123, 23);
            txtUsuario.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 42);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 17;
            label3.Text = "Autenticación";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(162, 225);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(81, 31);
            btnIngresar.TabIndex = 12;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 169);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 16;
            label2.Text = "Password:";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(120, 166);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(123, 23);
            txtClave.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 124);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 15;
            label1.Text = "Usuario:";
            // 
            // button1
            // 
            button1.Location = new Point(60, 225);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 18;
            button1.Text = "Registrarse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 323);
            Controls.Add(button1);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(btnIngresar);
            Controls.Add(label2);
            Controls.Add(txtClave);
            Controls.Add(label1);
            Name = "LoginFrm";
            Text = "LoginFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private Label label3;
        private Button btnIngresar;
        private Label label2;
        private TextBox txtClave;
        private Label label1;
        private Button button1;
    }
}