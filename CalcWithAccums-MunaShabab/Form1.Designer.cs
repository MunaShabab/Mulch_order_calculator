namespace CalcWithAccums_MunaShabab
{
    partial class Form1
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
            this.lengthLable = new System.Windows.Forms.Label();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.widthLable = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.CrrntOrdGroupBox = new System.Windows.Forms.GroupBox();
            this.crrntOrderPriceLabel = new System.Windows.Forms.Label();
            this.crrntOrderPriceDesLabel = new System.Windows.Forms.Label();
            this.crrntCubicYrdLabel = new System.Windows.Forms.Label();
            this.crrntCubicYrdDesLabel = new System.Windows.Forms.Label();
            this.crrntCubicFtLabel = new System.Windows.Forms.Label();
            this.crrntCubicFtDesLabel = new System.Windows.Forms.Label();
            this.totalGroupBox = new System.Windows.Forms.GroupBox();
            this.ordersCntLabel = new System.Windows.Forms.Label();
            this.ordersCntDesLabel = new System.Windows.Forms.Label();
            this.ttlCostLabel = new System.Windows.Forms.Label();
            this.ttlCostDesLabel = new System.Windows.Forms.Label();
            this.ttlCubicYrdLabel = new System.Windows.Forms.Label();
            this.ttlCubicYrdDesLabel = new System.Windows.Forms.Label();
            this.ttlCubicFtLabel = new System.Windows.Forms.Label();
            this.TtlCubicFtDesLabel = new System.Windows.Forms.Label();
            this.trkCapDesLabel = new System.Windows.Forms.Label();
            this.trkCapLabel = new System.Windows.Forms.Label();
            this.oderedCbYrdDesLabel = new System.Windows.Forms.Label();
            this.orderedCbYrdLabel = new System.Windows.Forms.Label();
            this.remTrkCapDesLabel = new System.Windows.Forms.Label();
            this.remTrkCapLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.companyLabel = new System.Windows.Forms.Label();
            this.CrrntOrdGroupBox.SuspendLayout();
            this.totalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lengthLable
            // 
            this.lengthLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLable.Location = new System.Drawing.Point(67, 40);
            this.lengthLable.Name = "lengthLable";
            this.lengthLable.Size = new System.Drawing.Size(116, 23);
            this.lengthLable.TabIndex = 0;
            this.lengthLable.Text = "Enter Length (ft):";
            this.lengthLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(189, 40);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.lengthTextBox.TabIndex = 1;
            // 
            // widthLable
            // 
            this.widthLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLable.Location = new System.Drawing.Point(67, 74);
            this.widthLable.Name = "widthLable";
            this.widthLable.Size = new System.Drawing.Size(116, 23);
            this.widthLable.TabIndex = 2;
            this.widthLable.Text = "Enter Length (ft):";
            this.widthLable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(189, 74);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 20);
            this.widthTextBox.TabIndex = 3;
            // 
            // heightLabel
            // 
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(67, 111);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(112, 23);
            this.heightLabel.TabIndex = 4;
            this.heightLabel.Text = "Enter Height (ft):";
            this.heightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(189, 111);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 5;
            // 
            // calcButton
            // 
            this.calcButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcButton.Location = new System.Drawing.Point(110, 150);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(133, 32);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // CrrntOrdGroupBox
            // 
            this.CrrntOrdGroupBox.Controls.Add(this.crrntOrderPriceLabel);
            this.CrrntOrdGroupBox.Controls.Add(this.crrntOrderPriceDesLabel);
            this.CrrntOrdGroupBox.Controls.Add(this.crrntCubicYrdLabel);
            this.CrrntOrdGroupBox.Controls.Add(this.crrntCubicYrdDesLabel);
            this.CrrntOrdGroupBox.Controls.Add(this.crrntCubicFtLabel);
            this.CrrntOrdGroupBox.Controls.Add(this.crrntCubicFtDesLabel);
            this.CrrntOrdGroupBox.Location = new System.Drawing.Point(45, 191);
            this.CrrntOrdGroupBox.Name = "CrrntOrdGroupBox";
            this.CrrntOrdGroupBox.Size = new System.Drawing.Size(221, 183);
            this.CrrntOrdGroupBox.TabIndex = 7;
            this.CrrntOrdGroupBox.TabStop = false;
            this.CrrntOrdGroupBox.Text = "Current Order";
            // 
            // crrntOrderPriceLabel
            // 
            this.crrntOrderPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crrntOrderPriceLabel.Location = new System.Drawing.Point(121, 119);
            this.crrntOrderPriceLabel.Name = "crrntOrderPriceLabel";
            this.crrntOrderPriceLabel.Size = new System.Drawing.Size(72, 23);
            this.crrntOrderPriceLabel.TabIndex = 5;
            this.crrntOrderPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // crrntOrderPriceDesLabel
            // 
            this.crrntOrderPriceDesLabel.Location = new System.Drawing.Point(26, 116);
            this.crrntOrderPriceDesLabel.Name = "crrntOrderPriceDesLabel";
            this.crrntOrderPriceDesLabel.Size = new System.Drawing.Size(59, 26);
            this.crrntOrderPriceDesLabel.TabIndex = 4;
            this.crrntOrderPriceDesLabel.Text = "@$ Price";
            this.crrntOrderPriceDesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // crrntCubicYrdLabel
            // 
            this.crrntCubicYrdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crrntCubicYrdLabel.Location = new System.Drawing.Point(121, 77);
            this.crrntCubicYrdLabel.Name = "crrntCubicYrdLabel";
            this.crrntCubicYrdLabel.Size = new System.Drawing.Size(72, 23);
            this.crrntCubicYrdLabel.TabIndex = 3;
            this.crrntCubicYrdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // crrntCubicYrdDesLabel
            // 
            this.crrntCubicYrdDesLabel.Location = new System.Drawing.Point(26, 77);
            this.crrntCubicYrdDesLabel.Name = "crrntCubicYrdDesLabel";
            this.crrntCubicYrdDesLabel.Size = new System.Drawing.Size(59, 23);
            this.crrntCubicYrdDesLabel.TabIndex = 2;
            this.crrntCubicYrdDesLabel.Text = "Cubic Yard";
            this.crrntCubicYrdDesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // crrntCubicFtLabel
            // 
            this.crrntCubicFtLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crrntCubicFtLabel.Location = new System.Drawing.Point(121, 35);
            this.crrntCubicFtLabel.Name = "crrntCubicFtLabel";
            this.crrntCubicFtLabel.Size = new System.Drawing.Size(72, 23);
            this.crrntCubicFtLabel.TabIndex = 1;
            this.crrntCubicFtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // crrntCubicFtDesLabel
            // 
            this.crrntCubicFtDesLabel.Location = new System.Drawing.Point(26, 35);
            this.crrntCubicFtDesLabel.Name = "crrntCubicFtDesLabel";
            this.crrntCubicFtDesLabel.Size = new System.Drawing.Size(100, 23);
            this.crrntCubicFtDesLabel.TabIndex = 0;
            this.crrntCubicFtDesLabel.Text = "Cubic Feet";
            this.crrntCubicFtDesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalGroupBox
            // 
            this.totalGroupBox.Controls.Add(this.ordersCntLabel);
            this.totalGroupBox.Controls.Add(this.ordersCntDesLabel);
            this.totalGroupBox.Controls.Add(this.ttlCostLabel);
            this.totalGroupBox.Controls.Add(this.ttlCostDesLabel);
            this.totalGroupBox.Controls.Add(this.ttlCubicYrdLabel);
            this.totalGroupBox.Controls.Add(this.ttlCubicYrdDesLabel);
            this.totalGroupBox.Controls.Add(this.ttlCubicFtLabel);
            this.totalGroupBox.Controls.Add(this.TtlCubicFtDesLabel);
            this.totalGroupBox.Location = new System.Drawing.Point(313, 191);
            this.totalGroupBox.Name = "totalGroupBox";
            this.totalGroupBox.Size = new System.Drawing.Size(266, 183);
            this.totalGroupBox.TabIndex = 8;
            this.totalGroupBox.TabStop = false;
            this.totalGroupBox.Text = "Total Of All Orders";
            // 
            // ordersCntLabel
            // 
            this.ordersCntLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ordersCntLabel.Location = new System.Drawing.Point(159, 146);
            this.ordersCntLabel.Name = "ordersCntLabel";
            this.ordersCntLabel.Size = new System.Drawing.Size(75, 23);
            this.ordersCntLabel.TabIndex = 7;
            this.ordersCntLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ordersCntDesLabel
            // 
            this.ordersCntDesLabel.Location = new System.Drawing.Point(19, 146);
            this.ordersCntDesLabel.Name = "ordersCntDesLabel";
            this.ordersCntDesLabel.Size = new System.Drawing.Size(100, 23);
            this.ordersCntDesLabel.TabIndex = 6;
            this.ordersCntDesLabel.Text = "Number Of Orders";
            this.ordersCntDesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ttlCostLabel
            // 
            this.ttlCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ttlCostLabel.Location = new System.Drawing.Point(159, 112);
            this.ttlCostLabel.Name = "ttlCostLabel";
            this.ttlCostLabel.Size = new System.Drawing.Size(74, 23);
            this.ttlCostLabel.TabIndex = 5;
            this.ttlCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ttlCostDesLabel
            // 
            this.ttlCostDesLabel.Location = new System.Drawing.Point(25, 112);
            this.ttlCostDesLabel.Name = "ttlCostDesLabel";
            this.ttlCostDesLabel.Size = new System.Drawing.Size(100, 23);
            this.ttlCostDesLabel.TabIndex = 4;
            this.ttlCostDesLabel.Text = "Cost (All Orders)";
            this.ttlCostDesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ttlCubicYrdLabel
            // 
            this.ttlCubicYrdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ttlCubicYrdLabel.Location = new System.Drawing.Point(159, 67);
            this.ttlCubicYrdLabel.Name = "ttlCubicYrdLabel";
            this.ttlCubicYrdLabel.Size = new System.Drawing.Size(74, 23);
            this.ttlCubicYrdLabel.TabIndex = 3;
            this.ttlCubicYrdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ttlCubicYrdDesLabel
            // 
            this.ttlCubicYrdDesLabel.Location = new System.Drawing.Point(19, 67);
            this.ttlCubicYrdDesLabel.Name = "ttlCubicYrdDesLabel";
            this.ttlCubicYrdDesLabel.Size = new System.Drawing.Size(121, 23);
            this.ttlCubicYrdDesLabel.TabIndex = 2;
            this.ttlCubicYrdDesLabel.Text = "Cubic Yards (All Orders)";
            this.ttlCubicYrdDesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ttlCubicFtLabel
            // 
            this.ttlCubicFtLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ttlCubicFtLabel.Location = new System.Drawing.Point(159, 25);
            this.ttlCubicFtLabel.Name = "ttlCubicFtLabel";
            this.ttlCubicFtLabel.Size = new System.Drawing.Size(74, 23);
            this.ttlCubicFtLabel.TabIndex = 1;
            this.ttlCubicFtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TtlCubicFtDesLabel
            // 
            this.TtlCubicFtDesLabel.Location = new System.Drawing.Point(19, 25);
            this.TtlCubicFtDesLabel.Name = "TtlCubicFtDesLabel";
            this.TtlCubicFtDesLabel.Size = new System.Drawing.Size(121, 23);
            this.TtlCubicFtDesLabel.TabIndex = 0;
            this.TtlCubicFtDesLabel.Text = "Cubic Feet (All Orders)";
            this.TtlCubicFtDesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trkCapDesLabel
            // 
            this.trkCapDesLabel.Location = new System.Drawing.Point(42, 388);
            this.trkCapDesLabel.Name = "trkCapDesLabel";
            this.trkCapDesLabel.Size = new System.Drawing.Size(100, 46);
            this.trkCapDesLabel.TabIndex = 9;
            this.trkCapDesLabel.Text = "Empty Truck Capacity\r\n (Cubic Yard)";
            this.trkCapDesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trkCapLabel
            // 
            this.trkCapLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.trkCapLabel.Location = new System.Drawing.Point(148, 400);
            this.trkCapLabel.Name = "trkCapLabel";
            this.trkCapLabel.Size = new System.Drawing.Size(82, 23);
            this.trkCapLabel.TabIndex = 10;
            this.trkCapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oderedCbYrdDesLabel
            // 
            this.oderedCbYrdDesLabel.Location = new System.Drawing.Point(269, 387);
            this.oderedCbYrdDesLabel.Name = "oderedCbYrdDesLabel";
            this.oderedCbYrdDesLabel.Size = new System.Drawing.Size(100, 47);
            this.oderedCbYrdDesLabel.TabIndex = 11;
            this.oderedCbYrdDesLabel.Text = "Less: \r\nOrdered \r\n(Cubic Yards)\r\n";
            this.oderedCbYrdDesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderedCbYrdLabel
            // 
            this.orderedCbYrdLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orderedCbYrdLabel.Location = new System.Drawing.Point(357, 400);
            this.orderedCbYrdLabel.Name = "orderedCbYrdLabel";
            this.orderedCbYrdLabel.Size = new System.Drawing.Size(81, 28);
            this.orderedCbYrdLabel.TabIndex = 12;
            this.orderedCbYrdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // remTrkCapDesLabel
            // 
            this.remTrkCapDesLabel.Location = new System.Drawing.Point(479, 387);
            this.remTrkCapDesLabel.Name = "remTrkCapDesLabel";
            this.remTrkCapDesLabel.Size = new System.Drawing.Size(100, 46);
            this.remTrkCapDesLabel.TabIndex = 13;
            this.remTrkCapDesLabel.Text = "Equals:\r\nTruck Capacity\r\nRemaining\r\n";
            this.remTrkCapDesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remTrkCapLabel
            // 
            this.remTrkCapLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.remTrkCapLabel.Location = new System.Drawing.Point(573, 395);
            this.remTrkCapLabel.Name = "remTrkCapLabel";
            this.remTrkCapLabel.Size = new System.Drawing.Size(82, 28);
            this.remTrkCapLabel.TabIndex = 14;
            this.remTrkCapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(272, 451);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 36);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click_1);
            // 
            // companyLabel
            // 
            this.companyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyLabel.Location = new System.Drawing.Point(198, 1);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(293, 35);
            this.companyLabel.TabIndex = 16;
            this.companyLabel.Text = "Muna Shabab Landscaping Company";
            this.companyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 510);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.remTrkCapLabel);
            this.Controls.Add(this.remTrkCapDesLabel);
            this.Controls.Add(this.orderedCbYrdLabel);
            this.Controls.Add(this.oderedCbYrdDesLabel);
            this.Controls.Add(this.trkCapLabel);
            this.Controls.Add(this.trkCapDesLabel);
            this.Controls.Add(this.totalGroupBox);
            this.Controls.Add(this.CrrntOrdGroupBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.widthLable);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.lengthLable);
            this.Name = "Form1";
            this.Text = "Mulch Calculator";
            this.CrrntOrdGroupBox.ResumeLayout(false);
            this.totalGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lengthLable;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label widthLable;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.GroupBox CrrntOrdGroupBox;
        private System.Windows.Forms.Label crrntOrderPriceLabel;
        private System.Windows.Forms.Label crrntOrderPriceDesLabel;
        private System.Windows.Forms.Label crrntCubicYrdLabel;
        private System.Windows.Forms.Label crrntCubicYrdDesLabel;
        private System.Windows.Forms.Label crrntCubicFtLabel;
        private System.Windows.Forms.Label crrntCubicFtDesLabel;
        private System.Windows.Forms.GroupBox totalGroupBox;
        private System.Windows.Forms.Label ordersCntLabel;
        private System.Windows.Forms.Label ordersCntDesLabel;
        private System.Windows.Forms.Label ttlCostLabel;
        private System.Windows.Forms.Label ttlCostDesLabel;
        private System.Windows.Forms.Label ttlCubicYrdLabel;
        private System.Windows.Forms.Label ttlCubicYrdDesLabel;
        private System.Windows.Forms.Label ttlCubicFtLabel;
        private System.Windows.Forms.Label TtlCubicFtDesLabel;
        private System.Windows.Forms.Label trkCapDesLabel;
        private System.Windows.Forms.Label trkCapLabel;
        private System.Windows.Forms.Label oderedCbYrdDesLabel;
        private System.Windows.Forms.Label orderedCbYrdLabel;
        private System.Windows.Forms.Label remTrkCapDesLabel;
        private System.Windows.Forms.Label remTrkCapLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label companyLabel;
    }
}

