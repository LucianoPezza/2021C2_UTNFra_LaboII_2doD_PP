
namespace CiberWindowsForm
{
    partial class FormPrincipal
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
            this.brnClientesDesatendidos = new System.Windows.Forms.Button();
            this.btnListarComputadoras = new System.Windows.Forms.Button();
            this.lblInformacionPersonal = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.rtbListarClientesDesatendidos = new System.Windows.Forms.RichTextBox();
            this.rtbListarComputadoras = new System.Windows.Forms.RichTextBox();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.lblCabina = new System.Windows.Forms.Label();
            this.btnIngersarCabina = new System.Windows.Forms.Button();
            this.btnNumeroTelefonico = new System.Windows.Forms.Button();
            this.lblNumeroTelefonico = new System.Windows.Forms.Label();
            this.txtNumeroTelefonico = new System.Windows.Forms.TextBox();
            this.lstLlamadas = new System.Windows.Forms.ListBox();
            this.btnFinalizacionDeServicio = new System.Windows.Forms.Button();
            this.lstDeseoDeClientes = new System.Windows.Forms.ListBox();
            this.btnIngresarIdentificadorComputadora = new System.Windows.Forms.Button();
            this.lblComputadoraIdentificador = new System.Windows.Forms.Label();
            this.txtComputadoraIdentificador = new System.Windows.Forms.TextBox();
            this.btnTiempodePC = new System.Windows.Forms.Button();
            this.txtTiempoDePC = new System.Windows.Forms.TextBox();
            this.lblTiempoDeLaPc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // brnClientesDesatendidos
            // 
            this.brnClientesDesatendidos.AllowDrop = true;
            this.brnClientesDesatendidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.brnClientesDesatendidos.AutoSize = true;
            this.brnClientesDesatendidos.BackColor = System.Drawing.Color.LightSlateGray;
            this.brnClientesDesatendidos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.brnClientesDesatendidos.ForeColor = System.Drawing.Color.AliceBlue;
            this.brnClientesDesatendidos.Location = new System.Drawing.Point(1082, 836);
            this.brnClientesDesatendidos.Name = "brnClientesDesatendidos";
            this.brnClientesDesatendidos.Size = new System.Drawing.Size(273, 42);
            this.brnClientesDesatendidos.TabIndex = 0;
            this.brnClientesDesatendidos.Text = "Listar clientes desatendidos";
            this.brnClientesDesatendidos.UseVisualStyleBackColor = false;
            this.brnClientesDesatendidos.Click += new System.EventHandler(this.brnClientesDesatendidos_Click);
            // 
            // btnListarComputadoras
            // 
            this.btnListarComputadoras.AllowDrop = true;
            this.btnListarComputadoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListarComputadoras.AutoSize = true;
            this.btnListarComputadoras.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnListarComputadoras.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnListarComputadoras.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnListarComputadoras.Location = new System.Drawing.Point(1361, 836);
            this.btnListarComputadoras.Name = "btnListarComputadoras";
            this.btnListarComputadoras.Size = new System.Drawing.Size(243, 42);
            this.btnListarComputadoras.TabIndex = 1;
            this.btnListarComputadoras.Text = "Listar Computadoras";
            this.btnListarComputadoras.UseVisualStyleBackColor = false;
            this.btnListarComputadoras.Click += new System.EventHandler(this.btnListarComputadoras_Click);
            // 
            // lblInformacionPersonal
            // 
            this.lblInformacionPersonal.AllowDrop = true;
            this.lblInformacionPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInformacionPersonal.AutoSize = true;
            this.lblInformacionPersonal.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblInformacionPersonal.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblInformacionPersonal.Location = new System.Drawing.Point(13, 904);
            this.lblInformacionPersonal.Name = "lblInformacionPersonal";
            this.lblInformacionPersonal.Size = new System.Drawing.Size(185, 25);
            this.lblInformacionPersonal.TabIndex = 2;
            this.lblInformacionPersonal.Text = "Luciano Pezza 2021";
            // 
            // btnAsignar
            // 
            this.btnAsignar.AllowDrop = true;
            this.btnAsignar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAsignar.AutoSize = true;
            this.btnAsignar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAsignar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAsignar.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnAsignar.Location = new System.Drawing.Point(1610, 836);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(234, 42);
            this.btnAsignar.TabIndex = 3;
            this.btnAsignar.Text = "Asignar cabina o computadora";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // rtbListarClientesDesatendidos
            // 
            this.rtbListarClientesDesatendidos.BackColor = System.Drawing.Color.LightSlateGray;
            this.rtbListarClientesDesatendidos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbListarClientesDesatendidos.ForeColor = System.Drawing.Color.Azure;
            this.rtbListarClientesDesatendidos.Location = new System.Drawing.Point(13, 37);
            this.rtbListarClientesDesatendidos.Name = "rtbListarClientesDesatendidos";
            this.rtbListarClientesDesatendidos.Size = new System.Drawing.Size(606, 732);
            this.rtbListarClientesDesatendidos.TabIndex = 4;
            this.rtbListarClientesDesatendidos.Text = "";
            // 
            // rtbListarComputadoras
            // 
            this.rtbListarComputadoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbListarComputadoras.BackColor = System.Drawing.Color.LightSlateGray;
            this.rtbListarComputadoras.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtbListarComputadoras.ForeColor = System.Drawing.Color.Azure;
            this.rtbListarComputadoras.Location = new System.Drawing.Point(1238, 37);
            this.rtbListarComputadoras.Name = "rtbListarComputadoras";
            this.rtbListarComputadoras.Size = new System.Drawing.Size(606, 732);
            this.rtbListarComputadoras.TabIndex = 5;
            this.rtbListarComputadoras.Text = "";
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdentificador.Location = new System.Drawing.Point(1049, 99);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.Size = new System.Drawing.Size(135, 23);
            this.txtIdentificador.TabIndex = 6;
            // 
            // lblCabina
            // 
            this.lblCabina.AllowDrop = true;
            this.lblCabina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCabina.AutoSize = true;
            this.lblCabina.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblCabina.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblCabina.Location = new System.Drawing.Point(963, 36);
            this.lblCabina.Name = "lblCabina";
            this.lblCabina.Size = new System.Drawing.Size(269, 50);
            this.lblCabina.TabIndex = 7;
            this.lblCabina.Text = "Ingrese el identificador de la \r\ncabina que desee usar";
            // 
            // btnIngersarCabina
            // 
            this.btnIngersarCabina.AllowDrop = true;
            this.btnIngersarCabina.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngersarCabina.AutoSize = true;
            this.btnIngersarCabina.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnIngersarCabina.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngersarCabina.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnIngersarCabina.Location = new System.Drawing.Point(1049, 142);
            this.btnIngersarCabina.Name = "btnIngersarCabina";
            this.btnIngersarCabina.Size = new System.Drawing.Size(183, 30);
            this.btnIngersarCabina.TabIndex = 8;
            this.btnIngersarCabina.Text = "Ingresar";
            this.btnIngersarCabina.UseVisualStyleBackColor = false;
            this.btnIngersarCabina.Click += new System.EventHandler(this.btnIngersarTelefono_Click);
            // 
            // btnNumeroTelefonico
            // 
            this.btnNumeroTelefonico.AllowDrop = true;
            this.btnNumeroTelefonico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNumeroTelefonico.AutoSize = true;
            this.btnNumeroTelefonico.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnNumeroTelefonico.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNumeroTelefonico.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnNumeroTelefonico.Location = new System.Drawing.Point(1049, 302);
            this.btnNumeroTelefonico.Name = "btnNumeroTelefonico";
            this.btnNumeroTelefonico.Size = new System.Drawing.Size(183, 30);
            this.btnNumeroTelefonico.TabIndex = 11;
            this.btnNumeroTelefonico.Text = "Ingresar";
            this.btnNumeroTelefonico.UseVisualStyleBackColor = false;
            this.btnNumeroTelefonico.Click += new System.EventHandler(this.btnNumeroTelefonico_Click);
            // 
            // lblNumeroTelefonico
            // 
            this.lblNumeroTelefonico.AllowDrop = true;
            this.lblNumeroTelefonico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroTelefonico.AutoSize = true;
            this.lblNumeroTelefonico.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblNumeroTelefonico.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblNumeroTelefonico.Location = new System.Drawing.Point(1058, 205);
            this.lblNumeroTelefonico.Name = "lblNumeroTelefonico";
            this.lblNumeroTelefonico.Size = new System.Drawing.Size(174, 25);
            this.lblNumeroTelefonico.TabIndex = 10;
            this.lblNumeroTelefonico.Text = "Ingrese el numero";
            // 
            // txtNumeroTelefonico
            // 
            this.txtNumeroTelefonico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroTelefonico.Location = new System.Drawing.Point(1049, 264);
            this.txtNumeroTelefonico.Name = "txtNumeroTelefonico";
            this.txtNumeroTelefonico.Size = new System.Drawing.Size(183, 23);
            this.txtNumeroTelefonico.TabIndex = 9;
            // 
            // lstLlamadas
            // 
            this.lstLlamadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLlamadas.BackColor = System.Drawing.Color.LightSlateGray;
            this.lstLlamadas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstLlamadas.ForeColor = System.Drawing.Color.Azure;
            this.lstLlamadas.FormattingEnabled = true;
            this.lstLlamadas.ItemHeight = 20;
            this.lstLlamadas.Location = new System.Drawing.Point(625, 99);
            this.lstLlamadas.Name = "lstLlamadas";
            this.lstLlamadas.Size = new System.Drawing.Size(418, 204);
            this.lstLlamadas.TabIndex = 12;
            // 
            // btnFinalizacionDeServicio
            // 
            this.btnFinalizacionDeServicio.AllowDrop = true;
            this.btnFinalizacionDeServicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizacionDeServicio.AutoSize = true;
            this.btnFinalizacionDeServicio.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnFinalizacionDeServicio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizacionDeServicio.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnFinalizacionDeServicio.Location = new System.Drawing.Point(1610, 794);
            this.btnFinalizacionDeServicio.Name = "btnFinalizacionDeServicio";
            this.btnFinalizacionDeServicio.Size = new System.Drawing.Size(234, 36);
            this.btnFinalizacionDeServicio.TabIndex = 13;
            this.btnFinalizacionDeServicio.Text = "Finalizar servicio";
            this.btnFinalizacionDeServicio.UseVisualStyleBackColor = false;
            this.btnFinalizacionDeServicio.Click += new System.EventHandler(this.btnFinalizacionDeServicio_Click);
            // 
            // lstDeseoDeClientes
            // 
            this.lstDeseoDeClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDeseoDeClientes.BackColor = System.Drawing.Color.LightSlateGray;
            this.lstDeseoDeClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstDeseoDeClientes.ForeColor = System.Drawing.Color.Azure;
            this.lstDeseoDeClientes.FormattingEnabled = true;
            this.lstDeseoDeClientes.ItemHeight = 20;
            this.lstDeseoDeClientes.Location = new System.Drawing.Point(625, 425);
            this.lstDeseoDeClientes.Name = "lstDeseoDeClientes";
            this.lstDeseoDeClientes.Size = new System.Drawing.Size(418, 204);
            this.lstDeseoDeClientes.TabIndex = 20;
            // 
            // btnIngresarIdentificadorComputadora
            // 
            this.btnIngresarIdentificadorComputadora.AllowDrop = true;
            this.btnIngresarIdentificadorComputadora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresarIdentificadorComputadora.AutoSize = true;
            this.btnIngresarIdentificadorComputadora.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnIngresarIdentificadorComputadora.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIngresarIdentificadorComputadora.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnIngresarIdentificadorComputadora.Location = new System.Drawing.Point(1049, 454);
            this.btnIngresarIdentificadorComputadora.Name = "btnIngresarIdentificadorComputadora";
            this.btnIngresarIdentificadorComputadora.Size = new System.Drawing.Size(183, 30);
            this.btnIngresarIdentificadorComputadora.TabIndex = 16;
            this.btnIngresarIdentificadorComputadora.Text = "Ingresar";
            this.btnIngresarIdentificadorComputadora.UseVisualStyleBackColor = false;
            this.btnIngresarIdentificadorComputadora.Click += new System.EventHandler(this.btnIngresarIdentificador_Click);
            // 
            // lblComputadoraIdentificador
            // 
            this.lblComputadoraIdentificador.AllowDrop = true;
            this.lblComputadoraIdentificador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComputadoraIdentificador.AutoSize = true;
            this.lblComputadoraIdentificador.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblComputadoraIdentificador.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblComputadoraIdentificador.Location = new System.Drawing.Point(943, 359);
            this.lblComputadoraIdentificador.Name = "lblComputadoraIdentificador";
            this.lblComputadoraIdentificador.Size = new System.Drawing.Size(289, 50);
            this.lblComputadoraIdentificador.TabIndex = 15;
            this.lblComputadoraIdentificador.Text = "Ingrese el identificador de la Pc\r\n que desee asignar";
            // 
            // txtComputadoraIdentificador
            // 
            this.txtComputadoraIdentificador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComputadoraIdentificador.Location = new System.Drawing.Point(1049, 425);
            this.txtComputadoraIdentificador.Name = "txtComputadoraIdentificador";
            this.txtComputadoraIdentificador.Size = new System.Drawing.Size(135, 23);
            this.txtComputadoraIdentificador.TabIndex = 14;
            // 
            // btnTiempodePC
            // 
            this.btnTiempodePC.AllowDrop = true;
            this.btnTiempodePC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTiempodePC.AutoSize = true;
            this.btnTiempodePC.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnTiempodePC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTiempodePC.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnTiempodePC.Location = new System.Drawing.Point(1049, 582);
            this.btnTiempodePC.Name = "btnTiempodePC";
            this.btnTiempodePC.Size = new System.Drawing.Size(183, 30);
            this.btnTiempodePC.TabIndex = 22;
            this.btnTiempodePC.Text = "Ingresar";
            this.btnTiempodePC.UseVisualStyleBackColor = false;
            this.btnTiempodePC.Click += new System.EventHandler(this.btnTiempodePC_Click);
            // 
            // txtTiempoDePC
            // 
            this.txtTiempoDePC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTiempoDePC.Location = new System.Drawing.Point(1049, 553);
            this.txtTiempoDePC.Name = "txtTiempoDePC";
            this.txtTiempoDePC.Size = new System.Drawing.Size(135, 23);
            this.txtTiempoDePC.TabIndex = 21;
            // 
            // lblTiempoDeLaPc
            // 
            this.lblTiempoDeLaPc.AllowDrop = true;
            this.lblTiempoDeLaPc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTiempoDeLaPc.AutoSize = true;
            this.lblTiempoDeLaPc.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTiempoDeLaPc.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTiempoDeLaPc.Location = new System.Drawing.Point(1049, 487);
            this.lblTiempoDeLaPc.Name = "lblTiempoDeLaPc";
            this.lblTiempoDeLaPc.Size = new System.Drawing.Size(171, 50);
            this.lblTiempoDeLaPc.TabIndex = 23;
            this.lblTiempoDeLaPc.Text = "Ingrese el tiempo \r\ndeseado";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1856, 931);
            this.Controls.Add(this.lblTiempoDeLaPc);
            this.Controls.Add(this.btnTiempodePC);
            this.Controls.Add(this.txtTiempoDePC);
            this.Controls.Add(this.lstDeseoDeClientes);
            this.Controls.Add(this.btnIngresarIdentificadorComputadora);
            this.Controls.Add(this.lblComputadoraIdentificador);
            this.Controls.Add(this.txtComputadoraIdentificador);
            this.Controls.Add(this.btnFinalizacionDeServicio);
            this.Controls.Add(this.lstLlamadas);
            this.Controls.Add(this.btnNumeroTelefonico);
            this.Controls.Add(this.lblNumeroTelefonico);
            this.Controls.Add(this.txtNumeroTelefonico);
            this.Controls.Add(this.btnIngersarCabina);
            this.Controls.Add(this.lblCabina);
            this.Controls.Add(this.txtIdentificador);
            this.Controls.Add(this.rtbListarComputadoras);
            this.Controls.Add(this.rtbListarClientesDesatendidos);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.lblInformacionPersonal);
            this.Controls.Add(this.btnListarComputadoras);
            this.Controls.Add(this.brnClientesDesatendidos);
            this.Name = "FormPrincipal";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnClientesDesatendidos;
        private System.Windows.Forms.Button btnListarComputadoras;
        private System.Windows.Forms.Label lblInformacionPersonal;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.RichTextBox rtbListarClientesDesatendidos;
        private System.Windows.Forms.RichTextBox rtbListarComputadoras;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.Label lblCabina;
        private System.Windows.Forms.Button btnIngersarCabina;
        private System.Windows.Forms.Button btnNumeroTelefonico;
        private System.Windows.Forms.Label lblNumeroTelefonico;
        private System.Windows.Forms.TextBox txtNumeroTelefonico;
        private System.Windows.Forms.ListBox lstLlamadas;
        private System.Windows.Forms.Button btnFinalizacionDeServicio;
        private System.Windows.Forms.ListBox lstDeseoDeClientes;
        private System.Windows.Forms.Button btnIngresarIdentificadorComputadora;
        private System.Windows.Forms.Label lblComputadoraIdentificador;
        private System.Windows.Forms.TextBox txtComputadoraIdentificador;
        private System.Windows.Forms.Button btnTiempodePC;
        private System.Windows.Forms.TextBox txtTiempoDePC;
        private System.Windows.Forms.Label lblTiempoDeLaPc;
    }
}

