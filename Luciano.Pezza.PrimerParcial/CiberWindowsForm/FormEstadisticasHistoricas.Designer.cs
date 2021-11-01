
namespace CiberWindowsForm
{
    partial class FormEstadisticasHistoricas
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
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtIdentificadorFinalizante = new System.Windows.Forms.TextBox();
            this.lblFinalizar = new System.Windows.Forms.Label();
            this.lstIdentificadoresFinales = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizar.Location = new System.Drawing.Point(512, 115);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(100, 23);
            this.btnFinalizar.TabIndex = 1;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtIdentificadorFinalizante
            // 
            this.txtIdentificadorFinalizante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdentificadorFinalizante.Location = new System.Drawing.Point(512, 77);
            this.txtIdentificadorFinalizante.Name = "txtIdentificadorFinalizante";
            this.txtIdentificadorFinalizante.Size = new System.Drawing.Size(130, 23);
            this.txtIdentificadorFinalizante.TabIndex = 2;
            // 
            // lblFinalizar
            // 
            this.lblFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinalizar.AutoSize = true;
            this.lblFinalizar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFinalizar.Location = new System.Drawing.Point(512, 23);
            this.lblFinalizar.Name = "lblFinalizar";
            this.lblFinalizar.Size = new System.Drawing.Size(276, 40);
            this.lblFinalizar.TabIndex = 3;
            this.lblFinalizar.Text = "Ingrese el identificador de la maquina \r\nque quiera dar fin a su uso\r\n";
            // 
            // lstIdentificadoresFinales
            // 
            this.lstIdentificadoresFinales.BackColor = System.Drawing.Color.ForestGreen;
            this.lstIdentificadoresFinales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstIdentificadoresFinales.FormattingEnabled = true;
            this.lstIdentificadoresFinales.ItemHeight = 21;
            this.lstIdentificadoresFinales.Location = new System.Drawing.Point(13, 13);
            this.lstIdentificadoresFinales.Name = "lstIdentificadoresFinales";
            this.lstIdentificadoresFinales.Size = new System.Drawing.Size(493, 424);
            this.lstIdentificadoresFinales.TabIndex = 4;
            // 
            // FormEstadisticasHistoricas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstIdentificadoresFinales);
            this.Controls.Add(this.lblFinalizar);
            this.Controls.Add(this.txtIdentificadorFinalizante);
            this.Controls.Add(this.btnFinalizar);
            this.Name = "FormEstadisticasHistoricas";
            this.Text = "FormEstadisticasHistoricas";
            this.Load += new System.EventHandler(this.FormEstadisticasHistoricas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtIdentificadorFinalizante;
        private System.Windows.Forms.Label lblFinalizar;
        private System.Windows.Forms.ListBox lstIdentificadoresFinales;
    }
}