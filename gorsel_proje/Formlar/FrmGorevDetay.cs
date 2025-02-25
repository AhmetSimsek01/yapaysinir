﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gorsel_proje.Entity;

namespace gorsel_proje.Formlar
{
    public partial class FrmGorevDetay : Form
    {
        public FrmGorevDetay()
        {
            InitializeComponent();
        }
        DbistakipEntities db = new DbistakipEntities();
        private void FrmGorevDetay_Load(object sender, EventArgs e)
        {
            db.TblGorevDetaylar.Load();
            bindingSource1.DataSource = db.TblGorevDetaylar.Local;
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void gorevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
