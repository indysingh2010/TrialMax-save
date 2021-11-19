using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using FTI.Shared;
using FTI.Shared.Trialmax;
using System.Collections.Generic;

namespace FTI.Trialmax.Panes
{
    public partial class RegistrationPane : FTI.Trialmax.Panes.CBasePane
    {
        public RegistrationPane()
        {
            InitializeComponent();
        }

        private void RegistrationPane_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        private void RegistrationPane_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            //string s = string.Join(",", files);
            //MessageBox.Show("RegistrationPane_DragDrop: " + s);
            foreach (string s in files)
            {
                listBox1.Items.Add(s);
            }
        }
    }
}
