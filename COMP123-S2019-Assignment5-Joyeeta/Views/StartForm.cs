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
 * */
namespace COMP123_S2019_Assignment5_Joyeeta.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the StarForm closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the NewOrderButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }
        /// <summary>
        /// This is the event handler for the SavedOrderButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavedOrderOpenButton_Click(object sender, EventArgs e)
        {
            var loadInfoForm = Program.productInfoForm as ProductInfoForm;
            loadInfoForm.Show();
            loadInfoForm.openToolStripMenuItem_Click(sender, e);
            Hide();
        }
        /// <summary>
        /// This is the event handler for the ExitButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
