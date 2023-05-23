namespace TP_POKEMON_FORM
{
    partial class Form_Lista_Pokemon
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Lista_Pokemon));
            contextMenuStrip1 = new ContextMenuStrip(components);
            splitContainer1 = new SplitContainer();
            label5 = new Label();
            comboBoxPokemones = new ComboBox();
            labelFuerzaPoke = new Label();
            label3 = new Label();
            labelTipoPoke = new Label();
            label1 = new Label();
            buttonAgregarPoke = new Button();
            listBoxPokedex = new ListBox();
            labelPokeSelected = new Label();
            picBoxPokeSelected = new PictureBox();
            buttonDelete = new Button();
            labelMipoke = new Label();
            pictureBoxMiPokemon = new PictureBox();
            label2 = new Label();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxPokeSelected).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMiPokemon).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Turquoise;
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(comboBoxPokemones);
            splitContainer1.Panel1.Controls.Add(labelFuerzaPoke);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(labelTipoPoke);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(buttonAgregarPoke);
            splitContainer1.Panel1.Controls.Add(listBoxPokedex);
            splitContainer1.Panel1.Controls.Add(labelPokeSelected);
            splitContainer1.Panel1.Controls.Add(picBoxPokeSelected);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Maroon;
            splitContainer1.Panel2.Controls.Add(buttonDelete);
            splitContainer1.Panel2.Controls.Add(labelMipoke);
            splitContainer1.Panel2.Controls.Add(pictureBoxMiPokemon);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(listBox1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1314, 608);
            splitContainer1.SplitterDistance = 597;
            splitContainer1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(119, 6);
            label5.Name = "label5";
            label5.Size = new Size(193, 39);
            label5.TabIndex = 9;
            label5.Text = "POKEMONES";
            // 
            // comboBoxPokemones
            // 
            comboBoxPokemones.FormattingEnabled = true;
            comboBoxPokemones.Location = new Point(411, 90);
            comboBoxPokemones.Name = "comboBoxPokemones";
            comboBoxPokemones.Size = new Size(167, 28);
            comboBoxPokemones.TabIndex = 8;
            comboBoxPokemones.SelectionChangeCommitted += comboBoxPokemones_SelectionChangeCommitted;
            comboBoxPokemones.Click += comboBoxPokemones_Click;
            // 
            // labelFuerzaPoke
            // 
            labelFuerzaPoke.AutoSize = true;
            labelFuerzaPoke.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelFuerzaPoke.ForeColor = Color.FromArgb(192, 0, 0);
            labelFuerzaPoke.Location = new Point(464, 275);
            labelFuerzaPoke.Name = "labelFuerzaPoke";
            labelFuerzaPoke.Size = new Size(80, 32);
            labelFuerzaPoke.TabIndex = 7;
            labelFuerzaPoke.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(349, 275);
            label3.Name = "label3";
            label3.Size = new Size(109, 32);
            label3.TabIndex = 6;
            label3.Text = "Fuerza :";
            // 
            // labelTipoPoke
            // 
            labelTipoPoke.AutoSize = true;
            labelTipoPoke.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelTipoPoke.ForeColor = Color.FromArgb(192, 0, 0);
            labelTipoPoke.Location = new Point(464, 205);
            labelTipoPoke.Name = "labelTipoPoke";
            labelTipoPoke.Size = new Size(107, 32);
            labelTipoPoke.TabIndex = 5;
            labelTipoPoke.Text = "labeltipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(388, 205);
            label1.Name = "label1";
            label1.Size = new Size(70, 32);
            label1.TabIndex = 4;
            label1.Text = "Tipo:";
            // 
            // buttonAgregarPoke
            // 
            buttonAgregarPoke.BackColor = Color.Red;
            buttonAgregarPoke.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregarPoke.Location = new Point(338, 412);
            buttonAgregarPoke.Name = "buttonAgregarPoke";
            buttonAgregarPoke.Size = new Size(182, 52);
            buttonAgregarPoke.TabIndex = 3;
            buttonAgregarPoke.Text = "AGREGAR ";
            buttonAgregarPoke.UseVisualStyleBackColor = false;
            buttonAgregarPoke.Click += buttonAgregarPoke_Click;
            // 
            // listBoxPokedex
            // 
            listBoxPokedex.FormattingEnabled = true;
            listBoxPokedex.HorizontalScrollbar = true;
            listBoxPokedex.ItemHeight = 20;
            listBoxPokedex.Location = new Point(411, 48);
            listBoxPokedex.Name = "listBoxPokedex";
            listBoxPokedex.Size = new Size(167, 24);
            listBoxPokedex.TabIndex = 2;
            listBoxPokedex.Visible = false;
            listBoxPokedex.Click += listBoxPokedex_Click;
            // 
            // labelPokeSelected
            // 
            labelPokeSelected.AutoSize = true;
            labelPokeSelected.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelPokeSelected.ForeColor = Color.FromArgb(64, 64, 64);
            labelPokeSelected.Location = new Point(143, 70);
            labelPokeSelected.Name = "labelPokeSelected";
            labelPokeSelected.Size = new Size(117, 48);
            labelPokeSelected.TabIndex = 1;
            labelPokeSelected.Text = "label1";
            // 
            // picBoxPokeSelected
            // 
            picBoxPokeSelected.Image = (Image)resources.GetObject("picBoxPokeSelected.Image");
            picBoxPokeSelected.Location = new Point(92, 127);
            picBoxPokeSelected.Name = "picBoxPokeSelected";
            picBoxPokeSelected.Size = new Size(232, 227);
            picBoxPokeSelected.TabIndex = 0;
            picBoxPokeSelected.TabStop = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(192, 255, 255);
            buttonDelete.Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.Black;
            buttonDelete.Location = new Point(77, 412);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(159, 45);
            buttonDelete.TabIndex = 4;
            buttonDelete.Text = "ELIMINAR";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelMipoke
            // 
            labelMipoke.AutoSize = true;
            labelMipoke.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelMipoke.ForeColor = Color.FromArgb(128, 255, 255);
            labelMipoke.Location = new Point(436, 375);
            labelMipoke.Name = "labelMipoke";
            labelMipoke.Size = new Size(83, 25);
            labelMipoke.TabIndex = 3;
            labelMipoke.Text = "pokemon";
            // 
            // pictureBoxMiPokemon
            // 
            pictureBoxMiPokemon.Location = new Point(424, 127);
            pictureBoxMiPokemon.Name = "pictureBoxMiPokemon";
            pictureBoxMiPokemon.Size = new Size(217, 227);
            pictureBoxMiPokemon.TabIndex = 2;
            pictureBoxMiPokemon.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 192, 192);
            label2.Location = new Point(190, 9);
            label2.Name = "label2";
            label2.Size = new Size(271, 37);
            label2.TabIndex = 1;
            label2.Text = "MIS POKEMONES";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.ForeColor = Color.FromArgb(0, 192, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(56, 126);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(127, 200);
            listBox1.TabIndex = 0;
            listBox1.Click += listBox1_Click;
            // 
            // Form_Lista_Pokemon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1314, 608);
            Controls.Add(splitContainer1);
            Name = "Form_Lista_Pokemon";
            Text = "Pokemons";
            WindowState = FormWindowState.Maximized;
            Load += Form_Lista_Pokemon_Load;
            Click += Form_Lista_Pokemon_Click;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxPokeSelected).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMiPokemon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private SplitContainer splitContainer1;
        private DataGridView dataGridListPokemon;
        private ListBox listBoxPokedex;
        private Label labelPokeSelected;
        private PictureBox picBoxPokeSelected;
        private Button buttonAgregarPoke;
        private Label labelFuerzaPoke;
        private Label label3;
        private Label labelTipoPoke;
        private Label label1;
        private ComboBox comboBoxPokemones;
        private ListBox listBox1;
        private Label label4;
        private PictureBox pictureBoxMiPokemon;
        private Label label2;
        private Label labelMipoke;
        private Label label5;
        private Button buttonDelete;
    }
}