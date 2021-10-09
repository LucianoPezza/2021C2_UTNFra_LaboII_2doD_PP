
namespace CiberWindowsForm
{
    partial class FormClientesALaEspera
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
            this.txtClientesALAEspera = new System.Windows.Forms.RichTextBox();
            this.lblClientesALAEspera = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtClientesALAEspera
            // 
            this.txtClientesALAEspera.BackColor = System.Drawing.Color.Black;
            this.txtClientesALAEspera.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClientesALAEspera.ForeColor = System.Drawing.SystemColors.Window;
            this.txtClientesALAEspera.Location = new System.Drawing.Point(12, 11);
            this.txtClientesALAEspera.Name = "txtClientesALAEspera";
            this.txtClientesALAEspera.Size = new System.Drawing.Size(268, 426);
            this.txtClientesALAEspera.TabIndex = 0;
            this.txtClientesALAEspera.Text = "";
            // 
            // lblClientesALAEspera
            // 
            this.lblClientesALAEspera.AutoSize = true;
            this.lblClientesALAEspera.BackColor = System.Drawing.Color.DarkRed;
            this.lblClientesALAEspera.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblClientesALAEspera.ForeColor = System.Drawing.Color.White;
            this.lblClientesALAEspera.Location = new System.Drawing.Point(320, 13);
            this.lblClientesALAEspera.Name = "lblClientesALAEspera";
            this.lblClientesALAEspera.Size = new System.Drawing.Size(250, 21);
            this.lblClientesALAEspera.TabIndex = 1;
            this.lblClientesALAEspera.Text = "Clientes a la espera de atencion";
            // 
            // FormClientesALaEspera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.lblClientesALAEspera);
            this.Controls.Add(this.txtClientesALAEspera);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "FormClientesALaEspera";
            this.Text = "FormClientesALaEspera";
            this.Load += new System.EventHandler(this.ClientesALaEspera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtClientesALAEspera;
        private System.Windows.Forms.Label lblClientesALAEspera;
    }
}