﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;


using clases.RecursosHumanos;

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace forms.RecursosHumanos
{
    public partial class rptEmpleado : DevExpress.XtraReports.UI.XtraReport
    {
        public rptEmpleado()
        {
            InitializeComponent();
        }

        public void loadReport(List<clsReporte> datos)
        {
            try
            {
                this.DataSource = datos;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}