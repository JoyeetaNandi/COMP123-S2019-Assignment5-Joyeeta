using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* Student Name: Joyeeta Nandi
 * Student Id: 300757798
 * Description: This is the SplashForm Class  
 * Created on: July 22, 2019.
 * Last modified on: August 16, 2019. 
  Image sourse: https://ca.images.search.yahoo.com/search/images;_ylt=AwrJ5syYu0RdhXwAe3ntFAx.;
  */
namespace COMP123_S2019_Assignment5_Joyeeta.Views
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the SplashTimer tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;

            Program.startForm.Show();
            this.Hide();
        }

        /// <summary>
        /// This is the event handler for the SplashScreen load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
    }
}
