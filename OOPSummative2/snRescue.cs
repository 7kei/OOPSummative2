﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSummative2
{
    public partial class snRescue : Form
    {
        Session session;
        public snRescue(Session session)
        {
            InitializeComponent();
            this.session = session;
        }
    }
}
