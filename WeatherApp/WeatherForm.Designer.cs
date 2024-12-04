namespace WeatherApp
{
    partial class WeatherForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForm));
			label1 = new Label();
			TBCity = new TextBox();
			btnSearch = new Button();
			labCondition = new Label();
			labDetails = new Label();
			label3 = new Label();
			labSunrise = new Label();
			labSunset = new Label();
			label6 = new Label();
			labPressure = new Label();
			label8 = new Label();
			labWindSpeed = new Label();
			label10 = new Label();
			picIcon = new PictureBox();
			labHumidity = new Label();
			label15 = new Label();
			pictureBox1 = new PictureBox();
			labTemperature = new Label();
			((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Transparent;
			label1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(121, 164);
			label1.Name = "label1";
			label1.Size = new Size(68, 35);
			label1.TabIndex = 0;
			label1.Text = "City:";
			// 
			// TBCity
			// 
			TBCity.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			TBCity.Location = new Point(193, 165);
			TBCity.Name = "TBCity";
			TBCity.Size = new Size(301, 36);
			TBCity.TabIndex = 1;
			// 
			// btnSearch
			// 
			btnSearch.BackColor = Color.Transparent;
			btnSearch.FlatStyle = FlatStyle.Flat;
			btnSearch.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnSearch.ForeColor = Color.White;
			btnSearch.Location = new Point(511, 162);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(108, 41);
			btnSearch.TabIndex = 3;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = false;
			btnSearch.Click += btnSearch_Click;
			// 
			// labCondition
			// 
			labCondition.AutoSize = true;
			labCondition.BackColor = Color.Transparent;
			labCondition.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			labCondition.ForeColor = Color.White;
			labCondition.Location = new Point(121, 345);
			labCondition.Name = "labCondition";
			labCondition.Size = new Size(128, 35);
			labCondition.TabIndex = 4;
			labCondition.Text = "Condition";
			// 
			// labDetails
			// 
			labDetails.AutoSize = true;
			labDetails.BackColor = Color.Transparent;
			labDetails.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labDetails.ForeColor = Color.White;
			labDetails.Location = new Point(121, 422);
			labDetails.Name = "labDetails";
			labDetails.Size = new Size(91, 35);
			labDetails.TabIndex = 5;
			labDetails.Text = "Details";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.Transparent;
			label3.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.White;
			label3.Location = new Point(121, 497);
			label3.Name = "label3";
			label3.Size = new Size(108, 35);
			label3.TabIndex = 6;
			label3.Text = "Sunrise:";
			// 
			// labSunrise
			// 
			labSunrise.AutoSize = true;
			labSunrise.BackColor = Color.Transparent;
			labSunrise.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labSunrise.ForeColor = Color.White;
			labSunrise.Location = new Point(234, 497);
			labSunrise.Name = "labSunrise";
			labSunrise.Size = new Size(59, 35);
			labSunrise.TabIndex = 7;
			labSunrise.Text = "N/A";
			// 
			// labSunset
			// 
			labSunset.AutoSize = true;
			labSunset.BackColor = Color.Transparent;
			labSunset.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labSunset.ForeColor = Color.White;
			labSunset.Location = new Point(235, 556);
			labSunset.Name = "labSunset";
			labSunset.Size = new Size(59, 35);
			labSunset.TabIndex = 9;
			labSunset.Text = "N/A";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.BackColor = Color.Transparent;
			label6.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.White;
			label6.Location = new Point(122, 556);
			label6.Name = "label6";
			label6.Size = new Size(101, 35);
			label6.TabIndex = 8;
			label6.Text = "Sunset:";
			// 
			// labPressure
			// 
			labPressure.AutoSize = true;
			labPressure.BackColor = Color.Transparent;
			labPressure.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labPressure.ForeColor = Color.White;
			labPressure.Location = new Point(640, 407);
			labPressure.Name = "labPressure";
			labPressure.Size = new Size(59, 35);
			labPressure.TabIndex = 13;
			labPressure.Text = "N/A";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.BackColor = Color.Transparent;
			label8.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label8.ForeColor = Color.White;
			label8.Location = new Point(512, 407);
			label8.Name = "label8";
			label8.Size = new Size(123, 35);
			label8.TabIndex = 12;
			label8.Text = "Pressure:";
			// 
			// labWindSpeed
			// 
			labWindSpeed.AutoSize = true;
			labWindSpeed.BackColor = Color.Transparent;
			labWindSpeed.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labWindSpeed.ForeColor = Color.White;
			labWindSpeed.Location = new Point(678, 348);
			labWindSpeed.Name = "labWindSpeed";
			labWindSpeed.Size = new Size(59, 35);
			labWindSpeed.TabIndex = 11;
			labWindSpeed.Text = "N/A";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.BackColor = Color.Transparent;
			label10.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label10.ForeColor = Color.White;
			label10.Location = new Point(511, 348);
			label10.Name = "label10";
			label10.Size = new Size(162, 35);
			label10.TabIndex = 10;
			label10.Text = "Wind Speed:";
			// 
			// picIcon
			// 
			picIcon.BackColor = Color.Transparent;
			picIcon.Location = new Point(122, 220);
			picIcon.Name = "picIcon";
			picIcon.Size = new Size(143, 109);
			picIcon.SizeMode = PictureBoxSizeMode.Zoom;
			picIcon.TabIndex = 15;
			picIcon.TabStop = false;
			// 
			// labHumidity
			// 
			labHumidity.AutoSize = true;
			labHumidity.BackColor = Color.Transparent;
			labHumidity.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labHumidity.ForeColor = Color.White;
			labHumidity.Location = new Point(640, 468);
			labHumidity.Name = "labHumidity";
			labHumidity.Size = new Size(59, 35);
			labHumidity.TabIndex = 17;
			labHumidity.Text = "N/A";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.BackColor = Color.Transparent;
			label15.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label15.ForeColor = Color.White;
			label15.Location = new Point(512, 468);
			label15.Name = "label15";
			label15.Size = new Size(131, 35);
			label15.TabIndex = 16;
			label15.Text = "Humidity:";
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.Transparent;
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(317, 247);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(48, 55);
			pictureBox1.TabIndex = 18;
			pictureBox1.TabStop = false;
			// 
			// labTemperature
			// 
			labTemperature.AutoSize = true;
			labTemperature.BackColor = Color.Transparent;
			labTemperature.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			labTemperature.ForeColor = Color.White;
			labTemperature.Location = new Point(371, 258);
			labTemperature.Name = "labTemperature";
			labTemperature.Size = new Size(59, 35);
			labTemperature.TabIndex = 19;
			labTemperature.Text = "N/A";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
			BackgroundImageLayout = ImageLayout.Stretch;
			ClientSize = new Size(1159, 738);
			Controls.Add(labTemperature);
			Controls.Add(pictureBox1);
			Controls.Add(labHumidity);
			Controls.Add(label15);
			Controls.Add(picIcon);
			Controls.Add(labPressure);
			Controls.Add(label8);
			Controls.Add(labWindSpeed);
			Controls.Add(label10);
			Controls.Add(labSunset);
			Controls.Add(label6);
			Controls.Add(labSunrise);
			Controls.Add(label3);
			Controls.Add(labDetails);
			Controls.Add(labCondition);
			Controls.Add(btnSearch);
			Controls.Add(TBCity);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox TBCity;
		private Button btnSearch;
		private Label labCondition;
		private Label labDetails;
		private Label label3;
		private Label labSunrise;
		private Label labSunset;
		private Label label6;
		private Label labPressure;
		private Label label8;
		private Label labWindSpeed;
		private Label label10;
		private PictureBox picIcon;
		private Label labHumidity;
		private Label label15;
		private PictureBox pictureBox1;
		private Label labTemperature;
	}
}
