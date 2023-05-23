namespace TP_POKEMON_FORM
{
    partial class Login_Form
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
            buttonLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxNombre = new TextBox();
            textBoxContrasenia = new TextBox();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(172, 269);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(207, 29);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 82);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 168);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "Contrasenia";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(172, 126);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(125, 27);
            textBoxNombre.TabIndex = 3;
            // 
            // textBoxContrasenia
            // 
            textBoxContrasenia.Location = new Point(172, 200);
            textBoxContrasenia.Name = "textBoxContrasenia";
            textBoxContrasenia.Size = new Size(125, 27);
            textBoxContrasenia.TabIndex = 4;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 477);
            Controls.Add(textBoxContrasenia);
            Controls.Add(textBoxNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonLogin);
            Name = "Login_Form";
            Text = "Login";
            Load += Login_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogin;
        private Label label1;
        private Label label2;
        private TextBox textBoxNombre;
        private TextBox textBoxContrasenia;
    }
}