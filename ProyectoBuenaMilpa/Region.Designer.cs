namespace ProyectoBuenaMilpa
{
    partial class Region
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Region));
            this.pcbAtras = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAtras)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbAtras
            // 
            this.pcbAtras.Image = ((System.Drawing.Image)(resources.GetObject("pcbAtras.Image")));
            this.pcbAtras.Location = new System.Drawing.Point(3, 3);
            this.pcbAtras.Name = "pcbAtras";
            this.pcbAtras.Size = new System.Drawing.Size(68, 62);
            this.pcbAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAtras.TabIndex = 0;
            this.pcbAtras.TabStop = false;
            this.pcbAtras.Click += new System.EventHandler(this.pcbAtras_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pcbAtras);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 419);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(605, 67);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // Region
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 486);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Region";
            this.Text = "Region";
            ((System.ComponentModel.ISupportInitialize)(this.pcbAtras)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbAtras;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}