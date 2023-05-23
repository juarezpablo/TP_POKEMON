namespace TP_POKEMON_FORM
{
    partial class Form_principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            loginToolStripMenuItem = new ToolStripMenuItem();
            listaPokemonToolStripMenuItem = new ToolStripMenuItem();
            dueloToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, listaPokemonToolStripMenuItem, dueloToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1275, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(60, 24);
            loginToolStripMenuItem.Text = "Login";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // listaPokemonToolStripMenuItem
            // 
            listaPokemonToolStripMenuItem.Name = "listaPokemonToolStripMenuItem";
            listaPokemonToolStripMenuItem.Size = new Size(118, 24);
            listaPokemonToolStripMenuItem.Text = "Lista Pokemon";
            listaPokemonToolStripMenuItem.Click += listaPokemonToolStripMenuItem_Click;
            // 
            // dueloToolStripMenuItem
            // 
            dueloToolStripMenuItem.Name = "dueloToolStripMenuItem";
            dueloToolStripMenuItem.Size = new Size(69, 24);
            dueloToolStripMenuItem.Text = "Batalla";
            dueloToolStripMenuItem.Click += dueloToolStripMenuItem_Click;
            // 
            // Form_principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 546);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form_principal";
            Text = "POKEMON";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem listaPokemonToolStripMenuItem;
        private ToolStripMenuItem dueloToolStripMenuItem;
    }
}