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

namespace COMP123_S2019_Assignment5_Joyeeta.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void NextToProductInfoFormButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            Hide();
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            
            var currentRow = ProductDataGridView.Rows[rowIndex];

            var cost = ProductDataGridView.CurrentRow.Cells[1].Value.ToString();
            var manufacturer = ProductDataGridView.CurrentRow.Cells[2].Value.ToString();
            var model = ProductDataGridView.CurrentRow.Cells[3].Value.ToString();

            string outpurString = manufacturer + " " + model + $" {cost:C2}";

            SelectionLabel.Text = outpurString;            

        }
    }
}
