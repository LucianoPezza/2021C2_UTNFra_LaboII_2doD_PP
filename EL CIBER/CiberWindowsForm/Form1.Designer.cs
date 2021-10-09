
namespace CiberWindowsForm
{
    partial class Form1
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
            System.Windows.Forms.Button btnVerClientes;
            this.lblInformacion = new System.Windows.Forms.Label();
            btnVerClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerClientes
            // 
            btnVerClientes.Location = new System.Drawing.Point(291, 196);
            btnVerClientes.Name = "btnVerClientes";
            btnVerClientes.Size = new System.Drawing.Size(147, 34);
            btnVerClientes.TabIndex = 0;
            btnVerClientes.Text = "Ver Clientes a la espera";
            btnVerClientes.UseVisualStyleBackColor = true;
            btnVerClientes.Click += new System.EventHandler(this.btnVerClientes_Click);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(72, 53);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(38, 15);
            this.lblInformacion.TabIndex = 1;
            this.lblInformacion.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(btnVerClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerClientes;
        private System.Windows.Forms.Label lblInformacion;
    }
}

