namespace RoadTripCalculator
{
    partial class TripCalc
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
            this.txtInputMPG = new System.Windows.Forms.TextBox();
            this.txtDistTraveled = new System.Windows.Forms.TextBox();
            this.txtFuelPrice = new System.Windows.Forms.TextBox();
            this.txtTripCost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFuelType = new System.Windows.Forms.ComboBox();
            this.cboStartLoc = new System.Windows.Forms.ComboBox();
            this.cboDestination = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInputMPG
            // 
            this.txtInputMPG.Location = new System.Drawing.Point(140, 140);
            this.txtInputMPG.Name = "txtInputMPG";
            this.txtInputMPG.Size = new System.Drawing.Size(72, 20);
            this.txtInputMPG.TabIndex = 3;
            // 
            // txtDistTraveled
            // 
            this.txtDistTraveled.Location = new System.Drawing.Point(140, 233);
            this.txtDistTraveled.Name = "txtDistTraveled";
            this.txtDistTraveled.ReadOnly = true;
            this.txtDistTraveled.Size = new System.Drawing.Size(72, 20);
            this.txtDistTraveled.TabIndex = 1;
            this.txtDistTraveled.TabStop = false;
            // 
            // txtFuelPrice
            // 
            this.txtFuelPrice.Location = new System.Drawing.Point(140, 205);
            this.txtFuelPrice.Name = "txtFuelPrice";
            this.txtFuelPrice.ReadOnly = true;
            this.txtFuelPrice.Size = new System.Drawing.Size(72, 20);
            this.txtFuelPrice.TabIndex = 2;
            this.txtFuelPrice.TabStop = false;
            // 
            // txtTripCost
            // 
            this.txtTripCost.Location = new System.Drawing.Point(140, 259);
            this.txtTripCost.Name = "txtTripCost";
            this.txtTripCost.ReadOnly = true;
            this.txtTripCost.Size = new System.Drawing.Size(72, 20);
            this.txtTripCost.TabIndex = 3;
            this.txtTripCost.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Boris Valle, Carlos Melendez, Mike Fox / Team 6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fuel Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "MPG";
            // 
            // cboFuelType
            // 
            this.cboFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFuelType.FormattingEnabled = true;
            this.cboFuelType.Items.AddRange(new object[] {
            "Gas",
            "Diesel",
            "E85"});
            this.cboFuelType.Location = new System.Drawing.Point(140, 55);
            this.cboFuelType.Name = "cboFuelType";
            this.cboFuelType.Size = new System.Drawing.Size(129, 21);
            this.cboFuelType.TabIndex = 0;
            this.cboFuelType.SelectedIndexChanged += new System.EventHandler(this.cboFuelType_SelectedIndexChanged);
            // 
            // cboStartLoc
            // 
            this.cboStartLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartLoc.FormattingEnabled = true;
            this.cboStartLoc.Items.AddRange(new object[] {
            "New York",
            "Los Angeles",
            "Chicago",
            "Minneapolis",
            "Washington DC",
            "Seattle"});
            this.cboStartLoc.Location = new System.Drawing.Point(140, 86);
            this.cboStartLoc.Name = "cboStartLoc";
            this.cboStartLoc.Size = new System.Drawing.Size(129, 21);
            this.cboStartLoc.TabIndex = 1;
            // 
            // cboDestination
            // 
            this.cboDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDestination.FormattingEnabled = true;
            this.cboDestination.Items.AddRange(new object[] {
            "New York",
            "Los Angeles",
            "Chicago",
            "Minneapolis",
            "Washington DC",
            "Seattle"});
            this.cboDestination.Location = new System.Drawing.Point(140, 113);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(129, 21);
            this.cboDestination.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fuel Price (Per Gallon)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Trip Milage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Trip Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Start Location";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Destination";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(275, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 153);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculate.Location = new System.Drawing.Point(271, 284);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(80, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(357, 284);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // TripCalc
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(444, 317);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboDestination);
            this.Controls.Add(this.cboStartLoc);
            this.Controls.Add(this.cboFuelType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTripCost);
            this.Controls.Add(this.txtFuelPrice);
            this.Controls.Add(this.txtDistTraveled);
            this.Controls.Add(this.txtInputMPG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TripCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Road Trip Calculator";
            this.Load += new System.EventHandler(this.TripCalc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputMPG;
        private System.Windows.Forms.TextBox txtDistTraveled;
        private System.Windows.Forms.TextBox txtFuelPrice;
        private System.Windows.Forms.TextBox txtTripCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFuelType;
        private System.Windows.Forms.ComboBox cboStartLoc;
        private System.Windows.Forms.ComboBox cboDestination;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

