﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDerake.Formularios
{
    public partial class FrmCalcularSalario : Form
    {
        public FrmCalcularSalario()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Realizar SP para calcular el salario
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Locales.ObjetosGlobales.MiFormPrincipal.Show();
            this.Hide();
        }
    }
}
