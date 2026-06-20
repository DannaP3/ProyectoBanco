using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoUtpGui
{
    public partial class Form1 : Form
    {
        int intentos = 0;

        Autenticación login = new Autenticación();
        Cuenta cuen = new Cuenta();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (txtCreaUsuario.Text == "" || txtCreaContraseña.Text == "" || txtAñoNac.Text == "")
            {
                MessageBox.Show("Por favor, rellena todos los campos antes de continuar.");
            }
            else
            {
                bool esNumero = true;

                foreach (char c in txtAñoNac.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        esNumero = false;
                    }
                }

                if (esNumero == false)
                {
                    MessageBox.Show("El año de nacimiento debe ser un número válido (ejemplo: 2004).");
                }
                else
                {
                    if (login.ValidarContrasenia(txtCreaContraseña.Text))
                    {
                        MessageBox.Show("Cuenta creada con éxito! La contraseña cumple con los requisitos.\n" + login.EvaluarContrasenia(txtCreaContraseña.Text));
                        tabControl1.SelectedIndex = 2;
                    }
                    else
                    {
                        MessageBox.Show("La contraseña es muy débil. Debe tener al menos 8 caracteres, mayúsculas, minúsculas y números\n" + login.EvaluarContrasenia(txtCreaContraseña.Text));
                    }
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnRegresar_CrearCuenta_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnContinuar_Menu_Click(object sender, EventArgs e)
        {
            if (txtIngreseUsuario.Text == "" || txtIngreseContraseña.Text == "")
            {
                MessageBox.Show("Por favor, introduce tu usuario y contraseña.");
            }
            else
            {
                if (txtIngreseUsuario.Text == txtCreaUsuario.Text && txtIngreseContraseña.Text == txtCreaContraseña.Text)
                {
                    MessageBox.Show("¡Bienvenido a Banco UTP");
                    tabControl1.SelectedIndex = 3;
                }
                else
                {
                    intentos = intentos + 1;

                    if (intentos > 3)
                    {
                        MessageBox.Show("Has perdido tus intentos, has quedado BLOQUEADO.");
                        tabControl1.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Tus datos son incorrectos. Inténtalo nuevamente \n \tError de Autenticación");
                        txtIngreseContraseña.Text = "";
                        txtIngreseUsuario.Text = "";
                        
                    }
                }
            }
        }

        private void btnSalirInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbMostrarDatos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMostrarDatos.Checked)
            {
                lblOperacionRealizada.Text = cuen.MostrarDatosCuenta();
                gpbOperacion.Visible = false;
            }
        }

        private void rdbPagoUTP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPagoUTP.Checked)
            {
                lblOperacionRealizada.Text = "";
                gpbOperacion.Visible = true;
                gpbOperacion.Text = "Pago de Servicios UTP";
                lblMenuPrecios.Visible = true;
                lblMenuPrecios.Text = "1. Constancia de estudios ($100)\n2. Reposición de credencial ($50)\n3. Pago de cuatrimestre ($2600)";
                lblNomOperacion.Text = "Seleccione una opción (1, 2 o 3):";
                txtMontoDinero.Text = "";
                btnConfirmarAccion.Text = "Confirmar Pago";
            }
        }
        private void rdbRetirarSaldo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRetirarSaldo.Checked)
            {
                lblOperacionRealizada.Text = "";
                gpbOperacion.Visible = true;
                gpbOperacion.Text = "Retirar Saldo";
                lblNomOperacion.Text = "Monto a retirar: $";
                lblMenuPrecios.Visible = false;
                txtMontoDinero.Text = "";
                btnConfirmarAccion.Text = "Confirmar Retiro";
            }
        }

        private void rdbDepositoCuenta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDepositoCuenta.Checked)
            {
                lblOperacionRealizada.Text = "";
                gpbOperacion.Visible = true;
                gpbOperacion.Text = "Depositar a Cuenta";
                lblNomOperacion.Text = "Monto a depositar: $";
                lblMenuPrecios.Visible = false;
                txtMontoDinero.Text = "";
                btnConfirmarAccion.Text = "Confirmar Depósito";
            }
        }

        private void btnConfirmarAccion_Click(object sender, EventArgs e)
        {
            if (txtMontoDinero.Text == "")
            {
                MessageBox.Show("Por favor, rellene el campo antes de continuar.");
                return;
            }

            if (btnConfirmarAccion.Text == "Confirmar Retiro")
            {
                int cantidadRetirar = Convert.ToInt32(txtMontoDinero.Text);
                bool exito = cuen.RetirtarCuenta(cantidadRetirar);

                if (exito == true)
                {
                    lblOperacionRealizada.Text = "Retiro exitoso de: $" + cantidadRetirar + "\nNuevo saldo disponible: $" + cuen.SaldoA;
                    MessageBox.Show("Retiro Completado");
                    txtMontoDinero.Text = "";
                }
                else
                {
                    lblOperacionRealizada.Text = "Error Saldo Insuficiente";
                    MessageBox.Show("No cuentas con saldo suficiente para retirar esa cantidad.");
                }
            }
            else if (btnConfirmarAccion.Text == "Confirmar Depósito")
            {
                double cantidadDepositar = Convert.ToDouble(txtMontoDinero.Text);

                if (cuen.DepositarCuenta(cantidadDepositar))
                {
                    lblOperacionRealizada.Text = "Depósito exitoso de: $" + cantidadDepositar + "\nNuevo saldo disponible: $" + cuen.SaldoA;
                    MessageBox.Show("Depósito exitoso");
                    txtMontoDinero.Text = "";
                }
            }
            else if (btnConfirmarAccion.Text == "Confirmar Pago")
            {
                int opcionSeleccionada = Convert.ToInt32(txtMontoDinero.Text);

                if (opcionSeleccionada == 1 || opcionSeleccionada == 2 || opcionSeleccionada == 3)
                {
                    lblOperacionRealizada.Text = cuen.PagoServicios(opcionSeleccionada);
                    txtMontoDinero.Text = "";
                }
                else
                {
                    MessageBox.Show("Opción incorrecta. Por favor, ingresa solo 1, 2 o 3.", "Opción No Válida");
                }
            }
        }

        
    }
}
