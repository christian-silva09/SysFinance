﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysFinance.UI.Base
{
    public partial class frmBaseRelatorio : Form
    {
        public frmBaseRelatorio()
        {
            InitializeComponent();
            lblExibido.Text = "Exibido em: " + DateTime.Now.ToString();
        }

        private void Sair_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
