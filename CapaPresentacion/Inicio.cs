using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CapaEntidad;
using FontAwesome.Sharp;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static Form FormularioActivo = null;
        private static IconMenuItem MenuActivo = null;


        public Inicio(Usuario objcd_usuario)
        {           
                usuarioActual = objcd_usuario;

            InitializeComponent();
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {

            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.DarkBlue;

            contenedor.Controls.Add(formulario);
            formulario.Show();


        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            lblusuario.Text = usuarioActual.NombreCompleto;

        }

        private void menuusuarios_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void submenucategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmCategoria());

        }

        private void submenuproducto_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProducto());

        }

        private void submenunegocio_Click(object sender, EventArgs e)
        {

        }

        private void submenuregistrarventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmVentas());

        }

        private void submenuverdetalleventa_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmDetalleVenta());

        }

        private void submenuregistrarcompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmCompras());

        }

        private void submenutverdetallecompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmDetalleCompra());

        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmClientes());

        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProveedores());

        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmReportes());

        }

        private void submenureportecompras_Click(object sender, EventArgs e)
        {

        }

        private void submenureporteventas_Click(object sender, EventArgs e)
        {
            
        }
    }
}
