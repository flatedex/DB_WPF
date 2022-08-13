using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_WPF
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        bool hideFormHello = false;
        #region


        #endregion

        private void Aboutload(object sender, PaintEventArgs e)
        {
            if (hideFormHello)
                Close();
        }
    }
}
