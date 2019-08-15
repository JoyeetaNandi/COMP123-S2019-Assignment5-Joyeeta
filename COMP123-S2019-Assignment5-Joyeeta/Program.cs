using COMP123_S2019_Assignment5_Joyeeta.Models;
using COMP123_S2019_Assignment5_Joyeeta.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Student Name: Joyeeta Nandi
 * Student Id: 300757798
 * Description: This is the Program Class
 */
namespace COMP123_S2019_Assignment5_Joyeeta
{
    public static class Program
    {
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;        
        public static AboutForm aboutForm;

        public static Product product;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Instantiate all forms here
            splashForm = new SplashForm();
            startForm = new StartForm();            
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            aboutForm = new AboutForm();

            product = new Product();

            Application.Run(splashForm);
        }

        
    }
}
