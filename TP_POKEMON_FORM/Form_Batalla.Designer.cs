namespace TP_POKEMON_FORM
{
    partial class Form_Batalla
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
            comboBoxMisPokemones = new ComboBox();
            pictureBoxMiPokemon = new PictureBox();
            labelMipokemon = new Label();
            buttonBuscarOponente = new Button();
            pictureBoxOponente = new PictureBox();
            labelOponente = new Label();
            buttonAtaque = new Button();
            progressBarOponente = new ProgressBar();
            progressBarpokemon = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMiPokemon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOponente).BeginInit();
            SuspendLayout();
            // 
            // comboBoxMisPokemones
            // 
            comboBoxMisPokemones.FormattingEnabled = true;
            comboBoxMisPokemones.Location = new Point(59, 381);
            comboBoxMisPokemones.Name = "comboBoxMisPokemones";
            comboBoxMisPokemones.Size = new Size(151, 28);
            comboBoxMisPokemones.TabIndex = 0;
            comboBoxMisPokemones.SelectedIndexChanged += comboBoxMisPokemones_SelectedIndexChanged;
            // 
            // pictureBoxMiPokemon
            // 
            pictureBoxMiPokemon.Location = new Point(48, 39);
            pictureBoxMiPokemon.Name = "pictureBoxMiPokemon";
            pictureBoxMiPokemon.Size = new Size(226, 226);
            pictureBoxMiPokemon.TabIndex = 1;
            pictureBoxMiPokemon.TabStop = false;
            // 
            // labelMipokemon
            // 
            labelMipokemon.AutoSize = true;
            labelMipokemon.Location = new Point(114, 9);
            labelMipokemon.Name = "labelMipokemon";
            labelMipokemon.Size = new Size(72, 20);
            labelMipokemon.TabIndex = 2;
            labelMipokemon.Text = "pokemon";
            // 
            // buttonBuscarOponente
            // 
            buttonBuscarOponente.Location = new Point(339, 23);
            buttonBuscarOponente.Name = "buttonBuscarOponente";
            buttonBuscarOponente.Size = new Size(94, 58);
            buttonBuscarOponente.TabIndex = 3;
            buttonBuscarOponente.Text = "Buscar Oponente";
            buttonBuscarOponente.UseVisualStyleBackColor = true;
            buttonBuscarOponente.Click += buttonBuscarOponente_Click;
            // 
            // pictureBoxOponente
            // 
            pictureBoxOponente.Location = new Point(549, 39);
            pictureBoxOponente.Name = "pictureBoxOponente";
            pictureBoxOponente.Size = new Size(224, 226);
            pictureBoxOponente.TabIndex = 4;
            pictureBoxOponente.TabStop = false;
            // 
            // labelOponente
            // 
            labelOponente.AutoSize = true;
            labelOponente.Location = new Point(611, 9);
            labelOponente.Name = "labelOponente";
            labelOponente.Size = new Size(72, 20);
            labelOponente.TabIndex = 5;
            labelOponente.Text = "pokemon";
            // 
            // buttonAtaque
            // 
            buttonAtaque.Location = new Point(339, 339);
            buttonAtaque.Name = "buttonAtaque";
            buttonAtaque.Size = new Size(94, 29);
            buttonAtaque.TabIndex = 6;
            buttonAtaque.Text = "ATACAR";
            buttonAtaque.UseVisualStyleBackColor = true;
            buttonAtaque.Click += buttonAtaque_Click;
            // 
            // progressBarOponente
            // 
            progressBarOponente.Location = new Point(605, 288);
            progressBarOponente.Name = "progressBarOponente";
            progressBarOponente.Size = new Size(133, 29);
            progressBarOponente.TabIndex = 7;
            // 
            // progressBarpokemon
            // 
            progressBarpokemon.Location = new Point(94, 288);
            progressBarpokemon.Name = "progressBarpokemon";
            progressBarpokemon.Size = new Size(125, 29);
            progressBarpokemon.TabIndex = 8;
            // 
            // Form_Batalla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 515);
            Controls.Add(progressBarpokemon);
            Controls.Add(progressBarOponente);
            Controls.Add(buttonAtaque);
            Controls.Add(labelOponente);
            Controls.Add(pictureBoxOponente);
            Controls.Add(buttonBuscarOponente);
            Controls.Add(labelMipokemon);
            Controls.Add(pictureBoxMiPokemon);
            Controls.Add(comboBoxMisPokemones);
            Name = "Form_Batalla";
            Text = "Form_Batalla";
            Load += Form_Batalla_Load;
            MouseMove += Form_Batalla_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBoxMiPokemon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOponente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxMisPokemones;
        private PictureBox pictureBoxMiPokemon;
        private Label labelMipokemon;
        private Button buttonBuscarOponente;
        private PictureBox pictureBoxOponente;
        private Label labelOponente;
        private Button buttonAtaque;
        private ProgressBar progressBarOponente;
        private ProgressBar progressBarpokemon;
    }
}