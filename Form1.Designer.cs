namespace BancoUtpGui
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSeleccionarboton = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.txtAñoNac = new System.Windows.Forms.TextBox();
            this.txtCreaContraseña = new System.Windows.Forms.TextBox();
            this.txtCreaUsuario = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblCrearContraseña = new System.Windows.Forms.Label();
            this.lblCrearUsuario = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnContinuar_Menu = new System.Windows.Forms.Button();
            this.btnRegresar_CrearCuenta = new System.Windows.Forms.Button();
            this.txtIngreseContraseña = new System.Windows.Forms.TextBox();
            this.txtIngreseUsuario = new System.Windows.Forms.TextBox();
            this.lblNomContraseña = new System.Windows.Forms.Label();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gpbOperacion = new System.Windows.Forms.GroupBox();
            this.lblMenuPrecios = new System.Windows.Forms.Label();
            this.btnConfirmarAccion = new System.Windows.Forms.Button();
            this.txtMontoDinero = new System.Windows.Forms.TextBox();
            this.lblNomOperacion = new System.Windows.Forms.Label();
            this.btnSalirInicio = new System.Windows.Forms.Button();
            this.rdbPagoUTP = new System.Windows.Forms.RadioButton();
            this.rdbRetirarSaldo = new System.Windows.Forms.RadioButton();
            this.rdbDepositoCuenta = new System.Windows.Forms.RadioButton();
            this.rdbMostrarDatos = new System.Windows.Forms.RadioButton();
            this.lblOperacionRealizada = new System.Windows.Forms.Label();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gpbOperacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(78, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 598);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblSeleccionarboton);
            this.tabPage1.Controls.Add(this.btnIngresar);
            this.tabPage1.Controls.Add(this.btnCrearCuenta);
            this.tabPage1.Controls.Add(this.pbLogo);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(839, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblSeleccionarboton
            // 
            this.lblSeleccionarboton.AutoSize = true;
            this.lblSeleccionarboton.Location = new System.Drawing.Point(352, 60);
            this.lblSeleccionarboton.Name = "lblSeleccionarboton";
            this.lblSeleccionarboton.Size = new System.Drawing.Size(146, 20);
            this.lblSeleccionarboton.TabIndex = 8;
            this.lblSeleccionarboton.Text = "Precione un boton :";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(395, 205);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(154, 61);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Location = new System.Drawing.Point(395, 107);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(154, 68);
            this.btnCrearCuenta.TabIndex = 6;
            this.btnCrearCuenta.Text = "Crear Cuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            this.btnCrearCuenta.Click += new System.EventHandler(this.btnCrearCuenta_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(97, 75);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(230, 209);
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRegresar);
            this.tabPage2.Controls.Add(this.btnValidar);
            this.tabPage2.Controls.Add(this.txtAñoNac);
            this.tabPage2.Controls.Add(this.txtCreaContraseña);
            this.tabPage2.Controls.Add(this.txtCreaUsuario);
            this.tabPage2.Controls.Add(this.lblEdad);
            this.tabPage2.Controls.Add(this.lblCrearContraseña);
            this.tabPage2.Controls.Add(this.lblCrearUsuario);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(839, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(49, 269);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(224, 49);
            this.btnRegresar.TabIndex = 16;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(320, 269);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(224, 49);
            this.btnValidar.TabIndex = 15;
            this.btnValidar.Text = "Continuar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // txtAñoNac
            // 
            this.txtAñoNac.Location = new System.Drawing.Point(142, 213);
            this.txtAñoNac.Name = "txtAñoNac";
            this.txtAñoNac.Size = new System.Drawing.Size(238, 26);
            this.txtAñoNac.TabIndex = 14;
            // 
            // txtCreaContraseña
            // 
            this.txtCreaContraseña.Location = new System.Drawing.Point(142, 132);
            this.txtCreaContraseña.Name = "txtCreaContraseña";
            this.txtCreaContraseña.Size = new System.Drawing.Size(238, 26);
            this.txtCreaContraseña.TabIndex = 13;
            // 
            // txtCreaUsuario
            // 
            this.txtCreaUsuario.Location = new System.Drawing.Point(142, 50);
            this.txtCreaUsuario.Name = "txtCreaUsuario";
            this.txtCreaUsuario.Size = new System.Drawing.Size(238, 26);
            this.txtCreaUsuario.TabIndex = 12;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(147, 181);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(223, 20);
            this.lblEdad.TabIndex = 11;
            this.lblEdad.Text = "Ingresa tu año de nacimiento :";
            // 
            // lblCrearContraseña
            // 
            this.lblCrearContraseña.AutoSize = true;
            this.lblCrearContraseña.Location = new System.Drawing.Point(138, 109);
            this.lblCrearContraseña.Name = "lblCrearContraseña";
            this.lblCrearContraseña.Size = new System.Drawing.Size(219, 20);
            this.lblCrearContraseña.TabIndex = 10;
            this.lblCrearContraseña.Text = "Crea una contraseña segura :";
            // 
            // lblCrearUsuario
            // 
            this.lblCrearUsuario.AutoSize = true;
            this.lblCrearUsuario.Location = new System.Drawing.Point(138, 27);
            this.lblCrearUsuario.Name = "lblCrearUsuario";
            this.lblCrearUsuario.Size = new System.Drawing.Size(209, 20);
            this.lblCrearUsuario.TabIndex = 9;
            this.lblCrearUsuario.Text = "Crea un nombre de usuario :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnContinuar_Menu);
            this.tabPage3.Controls.Add(this.btnRegresar_CrearCuenta);
            this.tabPage3.Controls.Add(this.txtIngreseContraseña);
            this.tabPage3.Controls.Add(this.txtIngreseUsuario);
            this.tabPage3.Controls.Add(this.lblNomContraseña);
            this.tabPage3.Controls.Add(this.lblNomUsuario);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(839, 565);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnContinuar_Menu
            // 
            this.btnContinuar_Menu.Location = new System.Drawing.Point(391, 321);
            this.btnContinuar_Menu.Name = "btnContinuar_Menu";
            this.btnContinuar_Menu.Size = new System.Drawing.Size(224, 49);
            this.btnContinuar_Menu.TabIndex = 22;
            this.btnContinuar_Menu.Text = "Continuar";
            this.btnContinuar_Menu.UseVisualStyleBackColor = true;
            this.btnContinuar_Menu.Click += new System.EventHandler(this.btnContinuar_Menu_Click);
            // 
            // btnRegresar_CrearCuenta
            // 
            this.btnRegresar_CrearCuenta.Location = new System.Drawing.Point(83, 321);
            this.btnRegresar_CrearCuenta.Name = "btnRegresar_CrearCuenta";
            this.btnRegresar_CrearCuenta.Size = new System.Drawing.Size(224, 49);
            this.btnRegresar_CrearCuenta.TabIndex = 21;
            this.btnRegresar_CrearCuenta.Text = "Regresar";
            this.btnRegresar_CrearCuenta.UseVisualStyleBackColor = true;
            this.btnRegresar_CrearCuenta.Click += new System.EventHandler(this.btnRegresar_CrearCuenta_Click);
            // 
            // txtIngreseContraseña
            // 
            this.txtIngreseContraseña.Location = new System.Drawing.Point(197, 179);
            this.txtIngreseContraseña.Name = "txtIngreseContraseña";
            this.txtIngreseContraseña.Size = new System.Drawing.Size(238, 26);
            this.txtIngreseContraseña.TabIndex = 20;
            // 
            // txtIngreseUsuario
            // 
            this.txtIngreseUsuario.Location = new System.Drawing.Point(197, 77);
            this.txtIngreseUsuario.Name = "txtIngreseUsuario";
            this.txtIngreseUsuario.Size = new System.Drawing.Size(238, 26);
            this.txtIngreseUsuario.TabIndex = 19;
            // 
            // lblNomContraseña
            // 
            this.lblNomContraseña.AutoSize = true;
            this.lblNomContraseña.Location = new System.Drawing.Point(131, 148);
            this.lblNomContraseña.Name = "lblNomContraseña";
            this.lblNomContraseña.Size = new System.Drawing.Size(176, 20);
            this.lblNomContraseña.TabIndex = 18;
            this.lblNomContraseña.Text = "Ingrese su contraseña :";
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Location = new System.Drawing.Point(131, 36);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(225, 20);
            this.lblNomUsuario.TabIndex = 17;
            this.lblNomUsuario.Text = "Ingresa tu nombre de usuario :";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gpbOperacion);
            this.tabPage4.Controls.Add(this.btnSalirInicio);
            this.tabPage4.Controls.Add(this.rdbPagoUTP);
            this.tabPage4.Controls.Add(this.rdbRetirarSaldo);
            this.tabPage4.Controls.Add(this.rdbDepositoCuenta);
            this.tabPage4.Controls.Add(this.rdbMostrarDatos);
            this.tabPage4.Controls.Add(this.lblOperacionRealizada);
            this.tabPage4.Controls.Add(this.lblOpciones);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(839, 565);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gpbOperacion
            // 
            this.gpbOperacion.Controls.Add(this.lblMenuPrecios);
            this.gpbOperacion.Controls.Add(this.btnConfirmarAccion);
            this.gpbOperacion.Controls.Add(this.txtMontoDinero);
            this.gpbOperacion.Controls.Add(this.lblNomOperacion);
            this.gpbOperacion.Location = new System.Drawing.Point(70, 234);
            this.gpbOperacion.Name = "gpbOperacion";
            this.gpbOperacion.Size = new System.Drawing.Size(709, 170);
            this.gpbOperacion.TabIndex = 23;
            this.gpbOperacion.TabStop = false;
            this.gpbOperacion.Visible = false;
            // 
            // lblMenuPrecios
            // 
            this.lblMenuPrecios.AutoSize = true;
            this.lblMenuPrecios.Location = new System.Drawing.Point(408, 22);
            this.lblMenuPrecios.Name = "lblMenuPrecios";
            this.lblMenuPrecios.Size = new System.Drawing.Size(77, 20);
            this.lblMenuPrecios.TabIndex = 21;
            this.lblMenuPrecios.Text = ".................";
            // 
            // btnConfirmarAccion
            // 
            this.btnConfirmarAccion.Location = new System.Drawing.Point(61, 103);
            this.btnConfirmarAccion.Name = "btnConfirmarAccion";
            this.btnConfirmarAccion.Size = new System.Drawing.Size(276, 34);
            this.btnConfirmarAccion.TabIndex = 20;
            this.btnConfirmarAccion.Text = "Confirmar Accion";
            this.btnConfirmarAccion.UseVisualStyleBackColor = true;
            this.btnConfirmarAccion.Click += new System.EventHandler(this.btnConfirmarAccion_Click);
            // 
            // txtMontoDinero
            // 
            this.txtMontoDinero.Location = new System.Drawing.Point(89, 55);
            this.txtMontoDinero.Name = "txtMontoDinero";
            this.txtMontoDinero.Size = new System.Drawing.Size(208, 26);
            this.txtMontoDinero.TabIndex = 19;
            // 
            // lblNomOperacion
            // 
            this.lblNomOperacion.AutoSize = true;
            this.lblNomOperacion.Location = new System.Drawing.Point(46, 22);
            this.lblNomOperacion.Name = "lblNomOperacion";
            this.lblNomOperacion.Size = new System.Drawing.Size(77, 20);
            this.lblNomOperacion.TabIndex = 18;
            this.lblNomOperacion.Text = ".................";
            // 
            // btnSalirInicio
            // 
            this.btnSalirInicio.Location = new System.Drawing.Point(227, 435);
            this.btnSalirInicio.Name = "btnSalirInicio";
            this.btnSalirInicio.Size = new System.Drawing.Size(231, 42);
            this.btnSalirInicio.TabIndex = 22;
            this.btnSalirInicio.Text = "Salir";
            this.btnSalirInicio.UseVisualStyleBackColor = true;
            this.btnSalirInicio.Click += new System.EventHandler(this.btnSalirInicio_Click);
            // 
            // rdbPagoUTP
            // 
            this.rdbPagoUTP.AutoSize = true;
            this.rdbPagoUTP.Location = new System.Drawing.Point(70, 172);
            this.rdbPagoUTP.Name = "rdbPagoUTP";
            this.rdbPagoUTP.Size = new System.Drawing.Size(192, 24);
            this.rdbPagoUTP.TabIndex = 21;
            this.rdbPagoUTP.Text = "Pago de servicios UTP";
            this.rdbPagoUTP.UseVisualStyleBackColor = true;
            this.rdbPagoUTP.CheckedChanged += new System.EventHandler(this.rdbPagoUTP_CheckedChanged);
            // 
            // rdbRetirarSaldo
            // 
            this.rdbRetirarSaldo.AutoSize = true;
            this.rdbRetirarSaldo.Location = new System.Drawing.Point(334, 99);
            this.rdbRetirarSaldo.Name = "rdbRetirarSaldo";
            this.rdbRetirarSaldo.Size = new System.Drawing.Size(124, 24);
            this.rdbRetirarSaldo.TabIndex = 20;
            this.rdbRetirarSaldo.Text = "Retirar saldo";
            this.rdbRetirarSaldo.UseVisualStyleBackColor = true;
            this.rdbRetirarSaldo.CheckedChanged += new System.EventHandler(this.rdbRetirarSaldo_CheckedChanged);
            // 
            // rdbDepositoCuenta
            // 
            this.rdbDepositoCuenta.AutoSize = true;
            this.rdbDepositoCuenta.Location = new System.Drawing.Point(334, 172);
            this.rdbDepositoCuenta.Name = "rdbDepositoCuenta";
            this.rdbDepositoCuenta.Size = new System.Drawing.Size(151, 24);
            this.rdbDepositoCuenta.TabIndex = 19;
            this.rdbDepositoCuenta.Text = "Deposito cuenta";
            this.rdbDepositoCuenta.UseVisualStyleBackColor = true;
            this.rdbDepositoCuenta.CheckedChanged += new System.EventHandler(this.rdbDepositoCuenta_CheckedChanged);
            // 
            // rdbMostrarDatos
            // 
            this.rdbMostrarDatos.AutoSize = true;
            this.rdbMostrarDatos.Checked = true;
            this.rdbMostrarDatos.Location = new System.Drawing.Point(70, 99);
            this.rdbMostrarDatos.Name = "rdbMostrarDatos";
            this.rdbMostrarDatos.Size = new System.Drawing.Size(229, 24);
            this.rdbMostrarDatos.TabIndex = 18;
            this.rdbMostrarDatos.TabStop = true;
            this.rdbMostrarDatos.Text = "Mostrar Datos de la Cuenta";
            this.rdbMostrarDatos.UseVisualStyleBackColor = true;
            this.rdbMostrarDatos.CheckedChanged += new System.EventHandler(this.rdbMostrarDatos_CheckedChanged);
            // 
            // lblOperacionRealizada
            // 
            this.lblOperacionRealizada.AutoSize = true;
            this.lblOperacionRealizada.Location = new System.Drawing.Point(592, 99);
            this.lblOperacionRealizada.Name = "lblOperacionRealizada";
            this.lblOperacionRealizada.Size = new System.Drawing.Size(77, 20);
            this.lblOperacionRealizada.TabIndex = 17;
            this.lblOperacionRealizada.Text = ".................";
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Location = new System.Drawing.Point(66, 47);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(160, 20);
            this.lblOpciones.TabIndex = 16;
            this.lblOpciones.Text = "¿Qué desea realizar?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 672);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "BANCO_UTP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.gpbOperacion.ResumeLayout(false);
            this.gpbOperacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblSeleccionarboton;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TextBox txtAñoNac;
        private System.Windows.Forms.TextBox txtCreaContraseña;
        private System.Windows.Forms.TextBox txtCreaUsuario;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblCrearContraseña;
        private System.Windows.Forms.Label lblCrearUsuario;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnContinuar_Menu;
        private System.Windows.Forms.Button btnRegresar_CrearCuenta;
        private System.Windows.Forms.TextBox txtIngreseContraseña;
        private System.Windows.Forms.TextBox txtIngreseUsuario;
        private System.Windows.Forms.Label lblNomContraseña;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnSalirInicio;
        private System.Windows.Forms.RadioButton rdbPagoUTP;
        private System.Windows.Forms.RadioButton rdbRetirarSaldo;
        private System.Windows.Forms.RadioButton rdbDepositoCuenta;
        private System.Windows.Forms.RadioButton rdbMostrarDatos;
        private System.Windows.Forms.Label lblOperacionRealizada;
        private System.Windows.Forms.Label lblOpciones;
        private System.Windows.Forms.GroupBox gpbOperacion;
        private System.Windows.Forms.Label lblMenuPrecios;
        private System.Windows.Forms.Button btnConfirmarAccion;
        private System.Windows.Forms.TextBox txtMontoDinero;
        private System.Windows.Forms.Label lblNomOperacion;
    }
}

