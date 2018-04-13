using EntityGeneratorForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnOpenFolder.Hide();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = string.Empty;
                string NamespaceName = txtNamespace.Text;
                string ServerName = txtServerName.Text;
                string DbName = cmbDBNames.Text;
                string EntityLocation = txtEntityLocation.Text;

                if (NamespaceName == string.Empty || ServerName == string.Empty || DbName == string.Empty || EntityLocation == string.Empty)
                {
                    MessageBox.Show("All Fileds are mandatory");
                    return;
                }

                string conStr = @"Data Source=" + ServerName + ";Initial Catalog=" + DbName + ";Integrated Security=true";
                EntityCreator entityCreator = new EntityCreator(conStr, NamespaceName, EntityLocation);
                btnOpenFolder.Show();
                lblError.Text = "Entity Created succesfully at :'" + EntityLocation + "'";
            }
            catch (Exception ex)
            {


            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(txtEntityLocation.Text);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        public void ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtEntityLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNamespace.Text = string.Empty;
            txtServerName.Text = string.Empty;
            cmbDBNames.Text = string.Empty;
            txtEntityLocation.Text = string.Empty;
        }


        private void txtServerName_Leave(object sender, EventArgs e)
        {
            try
            {
                string ServerName = txtServerName.Text;
                if (string.IsNullOrEmpty(ServerName))
                    return;

                string conStr = @"Data Source=" + ServerName + ";Initial Catalog=" + "master" + ";Integrated Security=true";
                DatabaseHelper databaseHelper = new DatabaseHelper(conStr);
                cmbDBNames.DataSource = databaseHelper.GetListOfDatabase();
                lblError.Text = string.Empty;
            }
            catch (Exception ex)
            {
                lblError.Text = "Server name might be incorrect! please try again";
                Clear();
            }

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtNamespace.Text = string.Empty;
            txtServerName.Text = string.Empty;
            cmbDBNames.Text = string.Empty;
            txtEntityLocation.Text = string.Empty;
            lblError.Text = string.Empty;
            btnOpenFolder.Hide();
        }
    }
}
