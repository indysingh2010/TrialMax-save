using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

using FTI.Shared;
using FTI.Shared.Trialmax;
using System.Collections.Generic;
using FTI.Trialmax.Forms;

namespace FTI.Trialmax.Panes
{
    public partial class RegistrationPane : FTI.Trialmax.Panes.CBasePane
    {
        private CFRegProgress m_regForm;

        public RegistrationPane()
        {
            InitializeComponent();
            m_regForm = new CFRegProgress();
            m_regForm.TopLevel = false;
            this.panel1.Controls.Add(m_regForm);
            //m_regForm.Size = new Size(m_regForm.Size.Width, m_regForm.Size.Height);
            //m_regForm.Dock = DockStyle.Fill;
            //m_regForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            m_regForm.ControlBox = false;
            m_regForm.Text = String.Empty;
            m_regForm.Show();
        }

        public CFRegProgress RegForm
        {
            get { return m_regForm; }
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
                //listBox1.Items.Add(s);
            }
        }

    }
}
