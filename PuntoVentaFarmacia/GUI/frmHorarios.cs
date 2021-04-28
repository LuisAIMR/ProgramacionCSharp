using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHorarios : Form
    {
        public frmHorarios()
        {
            InitializeComponent();
        }

        private void tmrFech_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToLongTimeString();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString();
        }
        #region botones
        private void btnAgregarPuesto_Click(object sender, EventArgs e)
        {
            if (cmbNombrePuesto.Text == "")
            {
                errorProvider1.SetError(cmbNombrePuesto, "Este campo no puede quedar vacio");
                cmbNombrePuesto.Focus();
                return;
            }
            errorProvider1.SetError(cmbNombrePuesto, "");

            if (nudSalarioTurno.Value == 0)
            {
                errorProvider1.SetError(nudSalarioTurno, "Este campo no puede quedar vacio");
                nudSalarioTurno.Focus();
                return;
            }
            errorProvider1.SetError(nudSalarioTurno, "");

            limpiarTurno();
        }

        private void btnCancelarPuesto_Click(object sender, EventArgs e)
        {
            limpiarTurno();
        }

        private void btnBuscarPuesto_Click(object sender, EventArgs e)
        {
            cmbBusPuesto.Text = "";
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            if (cmbTipoTurno.Text == "")
            {
                errorProvider1.SetError(cmbTipoTurno, "Este campo no puede quedar vacio");
                cmbTipoTurno.Focus();
                return;
            }
            errorProvider1.SetError(cmbTipoTurno, "");

            if (cmbDia.Text == "")
            {
                errorProvider1.SetError(cmbDia, "Este campo no puede quedar vacio");
                cmbDia.Focus();
                return;
            }
            errorProvider1.SetError(cmbDia, "");
            LimpiarTurno();
        }

        private void btnCancelarTurno_Click(object sender, EventArgs e)
        {
            LimpiarTurno();
        }

        private void btnBuscarTurno_Click(object sender, EventArgs e)
        {
            LimpiarBusquedaTurno();
        }

        private void btnAsignarHorario_Click(object sender, EventArgs e)
        {

            LimpiarAsignacionHorario();
        }

        private void btnCancelarAsignacionHorario_Click(object sender, EventArgs e)
        {
            LimpiarAsignacionHorario();
        }

        private void btnBuscarHorario_Click(object sender, EventArgs e)
        {
            if (cmbHorNombrePuesto.Text == "")
            {
                errorProvider1.SetError(cmbHorNombrePuesto, "Este campo no puede quedar vacio");
                cmbHorNombrePuesto.Focus();
                return;
            }
            errorProvider1.SetError(cmbHorNombrePuesto, "");

            if (cmbHorDia.Text == "")
            {
                errorProvider1.SetError(cmbHorDia, "Este campo no puede quedar vacio");
                cmbHorDia.Focus();
                return;
            }
            errorProvider1.SetError(cmbHorDia, "");

            if (cmbHorTipoTurno.Text == "")
            {
                errorProvider1.SetError(cmbHorTipoTurno, "Este campo no puede quedar vacio");
                cmbHorTipoTurno.Focus();
                return;
            }
            errorProvider1.SetError(cmbHorTipoTurno, "");


        }
        #endregion


        #region limpieza de controles
        private void limpiarTurno()
        {
            cmbNombrePuesto.Text = "";
            nudSalarioTurno.Value = 0;

        }

        private void LimpiarTurno()
        {
            cmbTipoTurno.Text = "";
            cmbDia.Text = "";
        }

        private void LimpiarBusquedaTurno()
        {
            cmbBuscarTipoTurno.Text = "";
            cmbBusDiaTurno.Text = "";
        }

        private void LimpiarAsignacionHorario()
        {
            cmbHorNombrePuesto.Text = "";
            cmbHorDia.Text = "";
            cmbHorTipoTurno.Text = "";
        }

        private void LimpiarBusquedaHorario()
        {
            cmbHorBusNombrePuesto.Text = "";
            cmbHorBusDia.Text = "";
            cmbHorBusTipoTurno.Text = "";
        }
        #endregion
    }
}
