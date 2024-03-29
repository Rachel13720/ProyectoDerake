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
    public partial class FrmInformacion : Form
    {
        public FrmInformacion()
        {
            InitializeComponent();
        }

        //Método que permite regresar al formulario principal 
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Locales.ObjetosGlobales.MiFormPrincipal.Show();
            this.Hide();
        }

        //Método que carga los métodos
        //este muestra el texto desactivado para poder leerlo y no editarlo
        private void FrmInformacion_Load(object sender, EventArgs e)
        {
            TxtInfo.Enabled = false;
        }
    }
}
