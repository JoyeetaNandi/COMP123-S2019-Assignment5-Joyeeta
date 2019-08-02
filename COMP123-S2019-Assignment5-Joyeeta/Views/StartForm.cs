using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Image source: https://ca.images.search.yahoo.com/search/images;_ylt=AwrJ5sxPu0RdVJsA4DztFAx.;
 * _ylu=X3oDMTBsZ29xY3ZzBHNlYwNzZWFyY2gEc2xrA2J1dHRvbg--;_ylc=X1MDMjExNDcyMTAwNQRfcgMyBGFjdG4DY2xrBGNzcmNwdmlkA2
 * ZGdzNfVEV3TGpJcVg4aVdYU25GbmdFOU1UazVMZ0FBQUFBREpNaDcEZnIDbWNhZmVlBGZyMgNzYS1ncARncHJpZANkdFh0eURpaVJ4YWdicUkzNk5ZTU
 * JBBG5fc3VnZwM1BG9yaWdpbgNjYS5pbWFnZXMuc2VhcmNoLnlhaG9vLmNvbQRwb3MDMARwcXN0cgMEcHFzdHJsAwRxc3RybAMxNgRxdWVyeQNjb21wdXRlc
 * iUyMGltYWdlBHRfc3RtcAMxNTY0Nzg1NTUw?p=computer+image&fr=mcafee&fr2=sb-top-ca.images.search&ei=UTF-8&n=60&x=wrt#id=104&iurl=
 * https%3A%2F%2Fcdn.pixabay.
 * com%2Fphoto%2F2017%2F09%2F13%2F17%2F45%2Flaptop-2746336_640.png&action=click */
namespace COMP123_S2019_Assignment5_Joyeeta.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void SavedOrderOpenButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
