namespace COMP123_S2019_Assignment5_Joyeeta.Views
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.SavedOrderOpenButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OrderComputerHeadingLabel = new System.Windows.Forms.Label();
            this.SelectFormPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SelectFormPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderButton.Location = new System.Drawing.Point(41, 384);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(275, 58);
            this.NewOrderButton.TabIndex = 0;
            this.NewOrderButton.Text = "Start a New Order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // SavedOrderOpenButton
            // 
            this.SavedOrderOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavedOrderOpenButton.Location = new System.Drawing.Point(412, 384);
            this.SavedOrderOpenButton.Name = "SavedOrderOpenButton";
            this.SavedOrderOpenButton.Size = new System.Drawing.Size(275, 58);
            this.SavedOrderOpenButton.TabIndex = 1;
            this.SavedOrderOpenButton.Text = "Open a Saved Order";
            this.SavedOrderOpenButton.UseVisualStyleBackColor = true;
            this.SavedOrderOpenButton.Click += new System.EventHandler(this.SavedOrderOpenButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(235, 464);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(275, 58);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OrderComputerHeadingLabel
            // 
            this.OrderComputerHeadingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderComputerHeadingLabel.Location = new System.Drawing.Point(136, 26);
            this.OrderComputerHeadingLabel.Name = "OrderComputerHeadingLabel";
            this.OrderComputerHeadingLabel.Size = new System.Drawing.Size(525, 66);
            this.OrderComputerHeadingLabel.TabIndex = 3;
            this.OrderComputerHeadingLabel.Text = "Order Your Computer Today";
            this.OrderComputerHeadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectFormPictureBox
            // 
            this.SelectFormPictureBox.Image = global::COMP123_S2019_Assignment5_Joyeeta.Properties.Resources.StartImage;
            this.SelectFormPictureBox.Location = new System.Drawing.Point(246, 117);
            this.SelectFormPictureBox.Name = "SelectFormPictureBox";
            this.SelectFormPictureBox.Size = new System.Drawing.Size(296, 210);
            this.SelectFormPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SelectFormPictureBox.TabIndex = 4;
            this.SelectFormPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.SelectFormPictureBox);
            this.Controls.Add(this.OrderComputerHeadingLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SavedOrderOpenButton);
            this.Controls.Add(this.NewOrderButton);
            this.Name = "StartForm";
            this.Text = "Welcome to Dollar Computers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.SelectFormPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button SavedOrderOpenButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label OrderComputerHeadingLabel;
        private System.Windows.Forms.PictureBox SelectFormPictureBox;
    }
}

