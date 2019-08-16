using COMP123_S2019_Assignment5_Joyeeta.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Student Name: Joyeeta Nandi
 * Student Id: 300757798
 * Description: This is the SelectForm Class
 */

namespace COMP123_S2019_Assignment5_Joyeeta.Views
{
    public partial class SelectForm : Form
    {
        int rowIndex;
        DataGridViewRow currentRow;
        public SelectForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the SelectForm load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

            NextToProductInfoFormButton.Enabled = false;

        }
        /// <summary>
        /// This is the event handler for the CancelButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the SelectForm closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the NextButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void NextToProductInfoFormButton_Click(object sender, EventArgs e)
        {
            Program.product.LoadRow(currentRow);
            Program.productInfoForm.Show();
            Hide();
        }
        /// <summary>
        /// This is the event handler for the ProductsDataGridView SelectionChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            
            currentRow = ProductDataGridView.Rows[rowIndex];

            var cost = currentRow.Cells[1].Value.ToString();
            var manufacturer = currentRow.Cells[2].Value.ToString();
            var model = currentRow.Cells[3].Value.ToString();
            
           
            string outpurString = manufacturer + " " + model + $" {cost:C2}";

            SelectionLabel.Text = outpurString;
            NextToProductInfoFormButton.Enabled = true;
        }
    }
}
