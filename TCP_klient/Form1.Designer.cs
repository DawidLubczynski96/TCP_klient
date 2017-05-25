namespace TCP_klient
{
    partial class Form1
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
            this.adres = new System.Windows.Forms.TextBox();
            this.my_port = new System.Windows.Forms.NumericUpDown();
            this.info_o_polaczeniu = new System.Windows.Forms.ListBox();
            this.przycisk_polacz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).BeginInit();
            this.SuspendLayout();
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(47, 12);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(346, 20);
            this.adres.TabIndex = 0;
            this.adres.Text = "adres";
            this.adres.TextChanged += new System.EventHandler(this.adres_TextChanged);
            // 
            // my_port
            // 
            this.my_port.Location = new System.Drawing.Point(413, 12);
            this.my_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.my_port.Name = "my_port";
            this.my_port.Size = new System.Drawing.Size(333, 20);
            this.my_port.TabIndex = 1;
            this.my_port.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // info_o_polaczeniu
            // 
            this.info_o_polaczeniu.FormattingEnabled = true;
            this.info_o_polaczeniu.Location = new System.Drawing.Point(47, 79);
            this.info_o_polaczeniu.Name = "info_o_polaczeniu";
            this.info_o_polaczeniu.Size = new System.Drawing.Size(699, 173);
            this.info_o_polaczeniu.TabIndex = 2;
            this.info_o_polaczeniu.SelectedIndexChanged += new System.EventHandler(this.info_o_polaczeniu_SelectedIndexChanged);
            // 
            // przycisk_polacz
            // 
            this.przycisk_polacz.Location = new System.Drawing.Point(324, 268);
            this.przycisk_polacz.Name = "przycisk_polacz";
            this.przycisk_polacz.Size = new System.Drawing.Size(145, 67);
            this.przycisk_polacz.TabIndex = 3;
            this.przycisk_polacz.Text = "Połącz";
            this.przycisk_polacz.UseVisualStyleBackColor = true;
            this.przycisk_polacz.Click += new System.EventHandler(this.przycisk_polacz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 363);
            this.Controls.Add(this.przycisk_polacz);
            this.Controls.Add(this.info_o_polaczeniu);
            this.Controls.Add(this.my_port);
            this.Controls.Add(this.adres);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.my_port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.NumericUpDown my_port;
        private System.Windows.Forms.ListBox info_o_polaczeniu;
        private System.Windows.Forms.Button przycisk_polacz;
    }
}

