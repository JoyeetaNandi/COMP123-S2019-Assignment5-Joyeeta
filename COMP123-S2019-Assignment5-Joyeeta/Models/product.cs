namespace COMP123_S2019_Assignment5_Joyeeta.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Windows.Forms;

    /*
 * Student Name: Joyeeta Nandi
 * Student Id: 300757798
 * Description: This is the Product Class
 */

    public partial class Product
    {
        public short productID { get; set; }

        [Column(TypeName = "money")]
        public decimal? cost { get; set; }

        [StringLength(255)]
        public string manufacturer { get; set; }

        [StringLength(255)]
        public string model { get; set; }

        [StringLength(255)]
        public string RAM_type { get; set; }

        [StringLength(255)]
        public string RAM_size { get; set; }

        [StringLength(255)]
        public string displaytype { get; set; }

        [StringLength(255)]
        public string screensize { get; set; }

        [StringLength(255)]
        public string resolution { get; set; }

        [StringLength(255)]
        public string CPU_Class { get; set; }

        [StringLength(255)]
        public string CPU_brand { get; set; }

        [StringLength(255)]
        public string CPU_type { get; set; }

        [StringLength(255)]
        public string CPU_speed { get; set; }

        [StringLength(255)]
        public string CPU_number { get; set; }

        [StringLength(255)]
        public string condition { get; set; }

        [StringLength(255)]
        public string OS { get; set; }

        [StringLength(255)]
        public string platform { get; set; }

        [StringLength(255)]
        public string HDD_size { get; set; }

        [StringLength(255)]
        public string HDD_speed { get; set; }

        [StringLength(255)]
        public string GPU_Type { get; set; }

        [StringLength(255)]
        public string optical_drive { get; set; }

        [StringLength(255)]
        public string Audio_type { get; set; }

        [StringLength(255)]
        public string LAN { get; set; }

        [StringLength(255)]
        public string WIFI { get; set; }

        [StringLength(255)]
        public string width { get; set; }

        [StringLength(255)]
        public string height { get; set; }

        [StringLength(255)]
        public string depth { get; set; }

        [StringLength(255)]
        public string weight { get; set; }

        [StringLength(255)]
        public string moust_type { get; set; }

        [StringLength(255)]
        public string power { get; set; }

        [StringLength(255)]
        public string webcam { get; set; }
        /// <summary>
        /// This is the the method of LoadRow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void LoadRow(DataGridViewRow currentRow)
        {
            short.TryParse(currentRow.Cells[0].Value.ToString(), out short tempProductID);
            productID = tempProductID;
            condition = currentRow.Cells[14].Value.ToString();
            decimal.TryParse(currentRow.Cells[1].Value.ToString(), out decimal tempCost);
            cost = tempCost;
            //Product Info
            platform = currentRow.Cells[16].Value.ToString();
            OS = currentRow.Cells[15].Value.ToString();
            manufacturer = currentRow.Cells[2].Value.ToString();
            model = currentRow.Cells[3].Value.ToString();
             //Tech Specs
            RAM_size = currentRow.Cells[5].Value.ToString();
            CPU_brand = currentRow.Cells[10].Value.ToString();
            CPU_type = currentRow.Cells[11].Value.ToString();
            screensize = currentRow.Cells[7].Value.ToString();
            CPU_number = currentRow.Cells[13].Value.ToString();
            CPU_speed = currentRow.Cells[12].Value.ToString();
            HDD_size = currentRow.Cells[17].Value.ToString();                   
            GPU_Type = currentRow.Cells[19].Value.ToString();                     
            webcam = currentRow.Cells[30].Value.ToString();            
        }
    }
}
