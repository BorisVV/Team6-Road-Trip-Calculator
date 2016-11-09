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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInputMPG
            // 
            this.txtInputMPG.Location = new System.Drawing.Point(280, 209);
            this.txtInputMPG.Name = "txtInputMPG";
            this.txtInputMPG.Size = new System.Drawing.Size(129, 20);
            this.txtInputMPG.TabIndex = 0;
            // 
            // txtDistTraveled
            // 
            this.txtDistTraveled.Location = new System.Drawing.Point(280, 349);
            this.txtDistTraveled.Name = "txtDistTraveled";
            this.txtDistTraveled.ReadOnly = true;
            this.txtDistTraveled.Size = new System.Drawing.Size(129, 20);
            this.txtDistTraveled.TabIndex = 1;
            // 
            // txtFuelPrice
            // 
            this.txtFuelPrice.Location = new System.Drawing.Point(280, 298);
            this.txtFuelPrice.Name = "txtFuelPrice";
            this.txtFuelPrice.ReadOnly = true;
            this.txtFuelPrice.Size = new System.Drawing.Size(129, 20);
            this.txtFuelPrice.TabIndex = 2;
            // 
            // txtTripCost
            // 
            this.txtTripCost.Location = new System.Drawing.Point(280, 394);
            this.txtTripCost.Name = "txtTripCost";
            this.txtTripCost.ReadOnly = true;
            this.txtTripCost.Size = new System.Drawing.Size(129, 20);
            this.txtTripCost.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Boris Valle, Carlos Melendez, Mike Fox / Team 6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fuel Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 216);
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
            this.cboFuelType.Location = new System.Drawing.Point(280, 55);
            this.cboFuelType.Name = "cboFuelType";
            this.cboFuelType.Size = new System.Drawing.Size(129, 21);
            this.cboFuelType.TabIndex = 11;
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
            this.cboStartLoc.Location = new System.Drawing.Point(280, 105);
            this.cboStartLoc.Name = "cboStartLoc";
            this.cboStartLoc.Size = new System.Drawing.Size(129, 21);
            this.cboStartLoc.TabIndex = 12;
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
            this.cboDestination.Location = new System.Drawing.Point(280, 164);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(129, 21);
            this.cboDestination.TabIndex = 13;
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
            this.label5.Location = new System.Drawing.Point(157, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fuel Price Per Gallon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Display Distance Traveled";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(214, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Trip Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(190, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Start Location";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Destination";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 153);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TripCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 455);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}

