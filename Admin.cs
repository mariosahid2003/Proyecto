﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxis
{
    public partial class Admin : Form
    {
        public Admin(string nombre )
        {
            InitializeComponent();
            lblmensajeAdmin.Text = nombre;
        }
    }
}
