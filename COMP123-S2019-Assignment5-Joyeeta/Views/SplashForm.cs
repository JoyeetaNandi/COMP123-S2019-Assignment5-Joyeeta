using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Image sourse: https://ca.images.search.yahoo.com/search/images;_ylt=AwrJ5syYu0RdhXwAe3ntFAx.;
 * _ylu=X3oDMTBsZ29xY3ZzBHNlYwNzZWFyY2gEc2xrA2J1dHRvbg--;_ylc=X1MDMjExNDcyMTAwNQRfcgMyBGFjdG4DY2xrBGNzcmNwdmlk
 * A3dndXI0REV3TGpJcVg4aVdYU25GbmdNQU1UazVMZ0FBQUFBSGdEQnoEZnIDbWNhZmVlBGZyMgNzYS1ncARncHJpZAN1T1poM1ZOTlRiaW9Dc3h
 * TY0lhQWtBBG5fc3VnZwM2BG9yaWdpbgNjYS5pbWFnZXMuc2VhcmNoLnlhaG9vLmNvbQRwb3MDMARwcXN0cgMEcHFzdHJsAwRxc3RybAMxMQRxdWVyeQNkb2x
 * sYXJpbWFnZQR0X3N0bXADMTU2NDc4NTYyMg--?p=dollarimage&fr=mcafee&fr2=sb-top-ca.images.search&ei=UTF-8&n=60&x=wrt#id=32&iurl=
 * https%3A%2F%2Fcdn.pixabay.com%
 * 2Fphoto%2F2015%2F02%2F13%2F09%2F47%2Ffinance-634901_640.png&action=click */
namespace COMP123_S2019_Assignment5_Joyeeta.Views
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }        

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;

            Program.startForm.Show();
            this.Hide();
        }

        
        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
    }
}
