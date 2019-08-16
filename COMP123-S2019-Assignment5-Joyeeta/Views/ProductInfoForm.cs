using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        //public object ProductOpenFileDialog { get; private set; }

        public ProductInfoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the shared event handler for the CancelButton and exitToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the shared event handler for the selectAnotherProductButton and selectAnotherProductToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectAnotherProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            Hide();
        }
        /// <summary>
        /// This is the event handler for the NextButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        private void ProductInfoFormNextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            //Program.Form[FormName.ORDER_FORM].Show();
            Hide();
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIDDataLabel.Text = Program.product.productID.ToString();
            ConditionDataLabel.Text = Program.product.condition;
            CostDataLabel.Text = "$" + Program.product.cost.ToString();
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
        /// <summary>
        /// This is the event handler for the OpenToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //configure the file dialog

            ProductOpenFileDialog.FileName = "Product.txt";
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = ProductOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    // Open stream to read
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
                    {
                        // Read 
                        try
                        {
                            Program.product.productID = short.Parse(inputStream.ReadLine());
                            Program.product.condition = inputStream.ReadLine();
                            Program.product.cost = decimal.Parse(inputStream.ReadLine());
                            Program.product.platform = inputStream.ReadLine();
                            Program.product.OS = inputStream.ReadLine();
                            Program.product.manufacturer = inputStream.ReadLine();
                            Program.product.model = inputStream.ReadLine();
                            Program.product.RAM_type = inputStream.ReadLine();
                            Program.product.CPU_brand = inputStream.ReadLine();
                            Program.product.CPU_type = inputStream.ReadLine();
                            Program.product.CPU_speed = inputStream.ReadLine();
                            Program.product.CPU_number = inputStream.ReadLine();
                            Program.product.GPU_Type = inputStream.ReadLine();
                            Program.product.webcam = inputStream.ReadLine();

                        }
                        catch(FormatException exception)
                        {
                            MessageBox.Show(exception.ToString());
                        }

                        //cleanup
                        inputStream.Close();
                        inputStream.Dispose();

                        //automatically click next to next form
                        ProductInfoFormNextButton_Click(sender, e);
                    }
                }
                catch (IOException exception)
                {
                    MessageBox.Show("Error: " + exception.Message, "File I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// This method opens a OpenFileDialog.
        /// </summary>
        public void OpenFileDialog()
        {
            //Configure the file dialog
            ProductOpenFileDialog.FileName = "Product.txt";
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.Filter = "Text documents (*.txt)|*.txt| All Files(*.*)|*.*";
            ProductOpenFileDialog.DefaultExt = ".txt";

            //Open file dialog
            var _result = ProductOpenFileDialog.ShowDialog();
            if (_result != DialogResult.Cancel)
            {
                try
                {
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
                    {
                        //Read stuff from the file into the Product object
                        Program.product.productID = short.Parse(inputStream.ReadLine());
                        Program.product.condition = inputStream.ReadLine();
                        Program.product.cost = decimal.Parse(inputStream.ReadLine());
                        Program.product.platform = inputStream.ReadLine();
                        Program.product.OS = inputStream.ReadLine();
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.model = inputStream.ReadLine();
                        Program.product.RAM_size = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.HDD_size = inputStream.ReadLine();
                        Program.product.CPU_brand = inputStream.ReadLine();
                        Program.product.CPU_number = inputStream.ReadLine();
                        Program.product.GPU_Type = inputStream.ReadLine();
                        Program.product.CPU_type = inputStream.ReadLine();
                        Program.product.CPU_speed = inputStream.ReadLine();
                        Program.product.webcam = inputStream.ReadLine();

                        //Cleanup
                        inputStream.Close();
                        inputStream.Dispose();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            PopulateProductInfo();
        }
    

            /// <summary>
            /// This is the event handler for the ProductInfoForm Activated event
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void ProductSaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            PopulateProductInfo();           

        }
        /// <summary>
        /// This is the event handler for the SaveToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog

            ProductSaveFileDialog.FileName = "Product.txt";
            ProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";
            // open file dialog - Modal Form

            var result = ProductSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open file to write
                using (StreamWriter outputStream = new StreamWriter(
                    File.Open(ProductSaveFileDialog.FileName, FileMode.Create)))
                {
                    // write to the file

                    outputStream.WriteLine(Program.product.productID);
                    outputStream.WriteLine(Program.product.condition);
                    outputStream.WriteLine(Program.product.cost);
                    outputStream.WriteLine(Program.product.platform);
                    outputStream.WriteLine(Program.product.OS);
                    outputStream.WriteLine(Program.product.manufacturer);
                    outputStream.WriteLine(Program.product.model);
                    outputStream.WriteLine(Program.product.RAM_size);
                    outputStream.WriteLine(Program.product.screensize);
                    outputStream.WriteLine(Program.product.HDD_size);
                    outputStream.WriteLine(Program.product.CPU_brand);
                    outputStream.WriteLine(Program.product.CPU_number);
                    outputStream.WriteLine(Program.product.GPU_Type);
                    outputStream.WriteLine(Program.product.CPU_type);
                    outputStream.WriteLine(Program.product.CPU_speed);
                    outputStream.WriteLine(Program.product.webcam);

                    // close the file
                    outputStream.Close();

                    // dispose of the memory
                    outputStream.Dispose();
                }
                MessageBox.Show("File Saved", "Saving...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //SaveFileDialog.Text = string.Empty;
                ProductInfoFormNextButton.Enabled = true;
            }
        }
        /// <summary>
        /// This is the event handler for the ProductInfoForm load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            //Disable Next button until form filled
            ProductInfoFormNextButton.Enabled = false;
        }
        /// <summary>
        /// This method populate ProductInfoForm with computer object info 
        /// </summary>
        private void PopulateProductInfo()
        {
            //Fill up fields only when a product (Computer) is selected
            if (Program.product.productID != 0)
            {         
                ProductIDDataLabel.Text = Program.product.productID.ToString();
                ConditionDataLabel.Text = Program.product.condition;
                CostDataLabel.Text = "$" + Program.product.cost.ToString();
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

                //Enabble Next button after form filled
                ProductInfoFormNextButton.Enabled = true;
            }
        }
    }
    
}

