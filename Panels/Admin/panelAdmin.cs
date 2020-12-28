﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_App.Panels.Admin;
using DBMS_App.Panels;

namespace DBMS_App
{
    public partial class panelAdmin : UserControl
    {
       


        public panelAdmin()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            TabPage tb = new TabPage();
            tb.Text = "New Tab(" + Convert.ToString(Program.tabControl1.TabCount + 1) + ")";
            tb.Controls.Add(new panelLog());
            Program.tabControl1.TabPages.Add(tb);
            Program.tabControl1.SelectedIndex = Program.tabControl1.TabCount - 1;
        }

        private void panelAdmin_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            panelAdmin_Main main = new panelAdmin_Main();
            main.Dock = DockStyle.Fill;
            this.Controls.Add(main);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.tabControl1.TabPages.Count > 1)
            {
                Program.tabControl1.TabPages.Remove(Program.tabControl1.SelectedTab);
            }
        }
    }
}
