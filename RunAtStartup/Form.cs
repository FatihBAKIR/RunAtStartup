using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//Required namespace to access registry functions
using Microsoft.Win32;

namespace RunAtStartup
{
    /// <summary>
    /// Copyright 2011 FatihBAKIR.net
    /// </summary>
    public partial class form : Form
    {
        public form(string[] args)
        {
            InitializeComponent();

            if (args.Length > 0)
            {
                exepath.Text = args[0];
                appname.Text = System.IO.Path.GetFileNameWithoutExtension(args[0]);
            }
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(appname.Text) && !string.IsNullOrEmpty(exepath.Text) && exepath.Text.ToLower() != "click to select")
            {
                RegistryKey key;

                if (startup.Checked)
                    key = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                else if (startuponce.Checked)
                    key = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\RunOnce", true);
                else if (whenilogin.Checked)
                    key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                else if (wheniloginonce.Checked)
                    key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\RunOnce", true);
                else
                    key = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

                //If Key Exists We Proceed
                if (key != null)
                {
                    key.SetValue(appname.Text, "\"" + exepath.Text + "\"", RegistryValueKind.String);
                    //Save key changes.
                    key.Flush();
                }

                //We Close Key Object
                key.Close();

                //Close Program
                //System.Diagnostics.Process.GetCurrentProcess().Kill();
                refresh_list();
                listaddbutton.PerformClick();

                appname.Text = "";
                exepath.Text = "Click To Select";
                startup.Checked = true;
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void listaddbutton_Click(object sender, EventArgs e)
        {
            if (list_panel.Visible)
            {
                list_panel.Visible = false;
                add_panel.Visible = true;
                listaddbutton.Text = "List";
            }
            else
            {
                list_panel.Visible = true;
                add_panel.Visible = false;
                listaddbutton.Text = "Add";
                refresh_list();
            }
        }

        private void refresh_list()
        {
            exelist.Items.Clear();

            RegistryKey key;

            key = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

            foreach (string item in key.GetValueNames())
            {
                exelist.Items.Add(item);
                exelist.Items[exelist.Items.Count - 1].SubItems.Add(key.GetValue(item).ToString());
                exelist.Items[exelist.Items.Count - 1].SubItems.Add("On Startup");
                if ((exelist.Items.Count - 1) % 2 == 0)
                    exelist.Items[exelist.Items.Count - 1].BackColor = Color.LightGray;
                else
                    exelist.Items[exelist.Items.Count - 1].BackColor = Color.White;
            }

            key = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\RunOnce", true);

            foreach (string item in key.GetValueNames())
            {
                exelist.Items.Add(item);
                exelist.Items[exelist.Items.Count - 1].SubItems.Add(key.GetValue(item).ToString());
                exelist.Items[exelist.Items.Count - 1].SubItems.Add("On Startup (Once)");
                if ((exelist.Items.Count - 1) % 2 == 0)
                    exelist.Items[exelist.Items.Count - 1].BackColor = Color.LightGray;
                else
                    exelist.Items[exelist.Items.Count - 1].BackColor = Color.White;
            }

            key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

            foreach (string item in key.GetValueNames())
            {
                exelist.Items.Add(item);
                exelist.Items[exelist.Items.Count - 1].SubItems.Add(key.GetValue(item).ToString());
                exelist.Items[exelist.Items.Count - 1].SubItems.Add("When I Log In");
                if ((exelist.Items.Count - 1) % 2 == 0)
                    exelist.Items[exelist.Items.Count - 1].BackColor = Color.LightGray;
                else
                    exelist.Items[exelist.Items.Count - 1].BackColor = Color.White;
            }

            key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\RunOnce", true);

            foreach (string item in key.GetValueNames())
            {
                exelist.Items.Add(item);
                exelist.Items[exelist.Items.Count - 1].SubItems.Add(key.GetValue(item).ToString());
                exelist.Items[exelist.Items.Count - 1].SubItems.Add("When I Log In (Once)");
                if ((exelist.Items.Count - 1) % 2 == 0)
                    exelist.Items[exelist.Items.Count - 1].BackColor = Color.LightGray;
                else
                    exelist.Items[exelist.Items.Count - 1].BackColor = Color.White;
            }

            key.Close();
        }

        int totalwidth, headerwidth1, headerwidth2, headerwidth3;
        bool ignore_change;

        private void form_ResizeBegin(object sender, EventArgs e)
        {
            
        }

        private void form_ResizeEnd(object sender, EventArgs e)
        {
            ignore_change = true;
            exelist.Columns[0].Width = (int)(((float)headerwidth1 / totalwidth) * exelist.Width);
            exelist.Columns[1].Width = (int)(((float)headerwidth2 / totalwidth) * exelist.Width);
            exelist.Columns[2].Width = (int)(((float)headerwidth3 / totalwidth) * exelist.Width);
            ignore_change = false;
        }

        private void form_Resize(object sender, EventArgs e)
        {
            ignore_change = true;
            exelist.Columns[0].Width = (int)(((float)headerwidth1 / totalwidth) * exelist.Width);
            exelist.Columns[1].Width = (int)(((float)headerwidth2 / totalwidth) * exelist.Width);
            exelist.Columns[2].Width = (int)(((float)headerwidth3 / totalwidth) * exelist.Width);
            ignore_change = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RegistryKey key;

            if (exelist.SelectedItems[0].SubItems[2].Text == "On Startup")
                key = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            else if (exelist.SelectedItems[0].SubItems[2].Text == "On Startup (Once)")
                key = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\RunOnce", true);
            else if (exelist.SelectedItems[0].SubItems[2].Text == "When I Log In")
                key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            else if (exelist.SelectedItems[0].SubItems[2].Text == "When I Log In (Once)")
                key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\RunOnce", true);
            else
                key = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

            if (key != null)
            {
                key.DeleteValue(exelist.SelectedItems[0].Text);
                key.Flush();
            }

            key.Close();

            refresh_list();
        }

        private void exepath_Click(object sender, EventArgs e)
        {
            if (exepath.Text.ToLower() == "click to select")
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Executable Files (*.exe)|*.exe|All files (*.*)|*.*";
                dialog.FilterIndex = 0;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    exepath.Text = dialog.FileName;
                    appname.Text = System.IO.Path.GetFileNameWithoutExtension(dialog.FileName);
                    resetfile.Visible = true;
                }
            }
        }

        private void resetfile_Click(object sender, EventArgs e)
        {
            appname.Text = "";
            exepath.Text = "Click To Select";
            resetfile.Visible = false;
        }

        private void exelist_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            if (!ignore_change)
            {
                totalwidth = exelist.Width;
                headerwidth1 = exelist.Columns[0].Width;
                headerwidth2 = exelist.Columns[1].Width;
                headerwidth3 = exelist.Columns[2].Width;
            }
        }

        private void form_Load(object sender, EventArgs e)
        {
            totalwidth = exelist.Width;
            headerwidth1 = exelist.Columns[0].Width;
            headerwidth2 = exelist.Columns[1].Width;
            headerwidth3 = exelist.Columns[2].Width;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.fatihbakir.net/");
        }
    }
}
