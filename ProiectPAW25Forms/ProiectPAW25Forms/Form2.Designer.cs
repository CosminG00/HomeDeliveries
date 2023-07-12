namespace ProiectPAW25Forms
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salvareFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citireFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 450);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareFisierToolStripMenuItem,
            this.citireFisierToolStripMenuItem,
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 100);
            // 
            // salvareFisierToolStripMenuItem
            // 
            this.salvareFisierToolStripMenuItem.Name = "salvareFisierToolStripMenuItem";
            this.salvareFisierToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.salvareFisierToolStripMenuItem.Text = "SalvareFisier";
            this.salvareFisierToolStripMenuItem.Click += new System.EventHandler(this.salvareFisierToolStripMenuItem_Click);
            // 
            // citireFisierToolStripMenuItem
            // 
            this.citireFisierToolStripMenuItem.Name = "citireFisierToolStripMenuItem";
            this.citireFisierToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.citireFisierToolStripMenuItem.Text = "CitireFisier";
            this.citireFisierToolStripMenuItem.Click += new System.EventHandler(this.citireFisierToolStripMenuItem_Click);
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.serializareToolStripMenuItem.Text = "Serializare";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareToolStripMenuItem_Click);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.deserializareToolStripMenuItem.Text = "Deserializare";
            this.deserializareToolStripMenuItem.Click += new System.EventHandler(this.deserializareToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salvareFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
    }
}