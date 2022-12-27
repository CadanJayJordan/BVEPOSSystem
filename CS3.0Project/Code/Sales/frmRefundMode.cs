﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3._0Project.Code.Sales {
    public partial class frmRefundMode : Form {

        private Size screenSize;
        private int loginCode;

        public frmRefundMode(Size screenSize, int loginCode) {
            InitializeComponent();
            this.screenSize = screenSize;
            this.loginCode = loginCode;
        }

        private void frmRefundMode_Shown(object sender, EventArgs e) {
            this.Size = screenSize;
        }

        private void btnHome_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
