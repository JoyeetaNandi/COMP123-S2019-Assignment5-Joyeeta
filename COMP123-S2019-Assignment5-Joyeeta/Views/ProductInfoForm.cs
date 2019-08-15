using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Student Name: Joyeeta Nandi
 * Student Id: 300757798
 * Description: This is the ProductInfoFrom Class
 */

namespace COMP123_S2019_Assignment5_Joyeeta.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            Hide();
        }

        private void ProductInfoFormNextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            Hide();
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIDDataLabel.Text = Program.product.productID.ToString();
            ConditionDataLabel.Text = Program.product.condition;
            CostDataLabel.Text = "$"+Program.product.cost.ToString();
            PlatformDataLabel.Text = Program.product.platform;
            OSDataLabel.Text = Program.product.OS;
            ManufacturerDataLabel.Text = Program.product.manufacturer;
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
