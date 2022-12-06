using System.Diagnostics;
using System.Windows.Forms;

namespace distribution
{
    public partial class FormDistribution : Form
    {
        public FormDistribution()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.google.ru/");
        }
    }
}