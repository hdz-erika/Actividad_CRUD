using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_CRUD
{
    public partial class Form1 : Form
    {
        //Se declara el usuario y la contraseña predeterminados
        private string usuario = "admin23";
        private string contraseña = "1234567890";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Obtener el usuario y la contraseña ingresados por el usuario desde los TextBox correspondientes
            string usuarioIngresado = txtUsuario.Text;
            string contraseñaIngresada = txtContraseña.Text;
            //Comprobar si el usuario y la contraseña ingresados son iguales a los almacenados en variables
            if (usuarioIngresado == usuario && contraseñaIngresada == contraseña)
            {
                //Si los datos son correctos, se muestra un mensaje de inicio de sesión exitoso
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Se crea una instancia del formulario principal
                FormularioPrincipal formularioPrincipal = new FormularioPrincipal();
                //Se muestra el formulario principal y se oculta el formulario de inicio de sesión
                formularioPrincipal.Show();
                this.Hide();
            }
            else
            {
                // Si los datos no son correctos, se muestra un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
