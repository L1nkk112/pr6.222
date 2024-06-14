using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr6._22
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            Process.Start("https://accounts.google.com/InteractiveLogin/signinchooser?continue=https%3A%2F%2Fmail.google.com%2Fmail%2Fu%2F0%2F&emr=1&followup=https%3A%2F%2Fmail.google.com%2Fmail%2Fu%2F0%2F&osid=1&passive=1209600&service=mail&ifkv=AaSxoQxl66FBnpXw-t2rU0KMersPYyaquv-TTlNQVvA6ogm0FH9V4aA_T3J-QbfQkS4yJbETAuxxHA&theme=mn&ddm=0&flowName=GlifWebSignIn&flowEntry=ServiceLogin");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
