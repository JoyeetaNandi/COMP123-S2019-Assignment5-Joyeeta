using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Student Name: Joyeeta Nandi
 * Student Id: 300757798
 * Description: This is the OrderForm Class
 */

namespace COMP123_S2019_Assignment5_Joyeeta.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
            Hide();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            Hide();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(this, "Thank you for your business, " +
                "\r\nYour order will be processed within seven business days", "Info", buttons);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }            
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {           
            ConditionDataLabel.Text = Program.product.condition;
            PriceDataLabel.Text = "$" + Program.product.cost.ToString();
            PlatformDataLabel.Text = Program.product.platform;
            OSDataLabel.Text = Program.product.OS;
            ModelDataLabel.Text = Program.product.model;
            MemoryDataLabel.Text = Program.product.RAM_size;
            LCDSizeDataLAbel.Text = Program.product.screensize;         
            HDDDataLabel.Text = Program.product.HDD_size;
            CPUBrandDataLabel.Text = Program.product.CPU_brand;
            CPUNumberDataLabel.Text = Program.product.CPU_number;
            GPUTypeDataLabel.Text = Program.product.GPU_Type;
            CPUTypeDataLabel.Text = Program.product.CPU_type;
            CPUSpeedDataLabel.Text = Program.product.CPU_speed;
            WebCamDataLabel.Text = Program.product.webcam;
        }
    }
}
