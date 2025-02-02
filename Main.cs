using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrystisDesktopNet
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void OpenBasic()
        {
            panelFrame.Controls.Clear();
            frmBasic childForm = new frmBasic();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFrame.Controls.Add(childForm);
            childForm.Show();

            btnBasic.Font = new Font(btnBasic.Font, FontStyle.Underline);
            btnInvoice.Font = new Font(btnInvoice.Font, FontStyle.Regular);
            btnFull.Font = new Font(btnBasic.Font, FontStyle.Regular);
        }

        private void OpenFull()
        {
            panelFrame.Controls.Clear();
            frmFull childForm = new frmFull();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFrame.Controls.Add(childForm);
            childForm.Show();

            btnFull.Font = new Font(btnBasic.Font, FontStyle.Underline);
            btnInvoice.Font = new Font(btnInvoice.Font, FontStyle.Regular);
            btnBasic.Font = new Font(btnBasic.Font, FontStyle.Regular);
        }

        private void OpenInvoice()
        {
            panelFrame.Controls.Clear();
            frmInvoice childForm = new frmInvoice();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFrame.Controls.Add(childForm);
            childForm.Show();

            btnBasic.Font = new Font(btnBasic.Font, FontStyle.Regular);
            btnInvoice.Font = new Font(btnInvoice.Font, FontStyle.Underline);
            btnFull.Font = new Font(btnBasic.Font, FontStyle.Regular);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            OpenBasic();
        }

        private void btnBasic_Click(object sender, EventArgs e)
        {
            OpenBasic();
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            OpenFull();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            OpenInvoice();
        }

    }
}
