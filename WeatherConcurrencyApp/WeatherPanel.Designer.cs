
namespace WeatherConcurrencyApp
{
    partial class WeatherPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCity = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWeather = new System.Windows.Forms.Label();
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            this.dtwLon = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwLat = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwTempMax = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwTempMin = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwPressure = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwHumidity = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwSpeed = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwSunrise = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwSunset = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwFeelsLike = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwTimeZone = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwVisibility = new WeatherConcurrencyApp.DetailsWeather();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flpContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCity.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(3, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(501, 59);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTemperature.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(3, 59);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(501, 59);
            this.lblTemperature.TabIndex = 1;
            this.lblTemperature.Text = "30";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 497F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblTemperature, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCity, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblWeather, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(507, 138);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeather.Location = new System.Drawing.Point(3, 118);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(501, 20);
            this.lblWeather.TabIndex = 2;
            this.lblWeather.Text = "lblWeather";
            this.lblWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpContent
            // 
            this.flpContent.Controls.Add(this.dtwLon);
            this.flpContent.Controls.Add(this.dtwLat);
            this.flpContent.Controls.Add(this.dtwTempMax);
            this.flpContent.Controls.Add(this.dtwTempMin);
            this.flpContent.Controls.Add(this.dtwPressure);
            this.flpContent.Controls.Add(this.dtwHumidity);
            this.flpContent.Controls.Add(this.dtwSpeed);
            this.flpContent.Controls.Add(this.dtwSunrise);
            this.flpContent.Controls.Add(this.dtwSunset);
            this.flpContent.Controls.Add(this.dtwFeelsLike);
            this.flpContent.Controls.Add(this.dtwTimeZone);
            this.flpContent.Controls.Add(this.dtwVisibility);
            this.flpContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpContent.Location = new System.Drawing.Point(0, 233);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(507, 318);
            this.flpContent.TabIndex = 3;
            // 
            // dtwLon
            // 
            this.dtwLon.Location = new System.Drawing.Point(3, 3);
            this.dtwLon.Name = "dtwLon";
            this.dtwLon.Size = new System.Drawing.Size(120, 90);
            this.dtwLon.TabIndex = 0;
            // 
            // dtwLat
            // 
            this.dtwLat.Location = new System.Drawing.Point(129, 3);
            this.dtwLat.Name = "dtwLat";
            this.dtwLat.Size = new System.Drawing.Size(118, 90);
            this.dtwLat.TabIndex = 1;
            // 
            // dtwTempMax
            // 
            this.dtwTempMax.Location = new System.Drawing.Point(253, 3);
            this.dtwTempMax.Name = "dtwTempMax";
            this.dtwTempMax.Size = new System.Drawing.Size(120, 90);
            this.dtwTempMax.TabIndex = 2;
            // 
            // dtwTempMin
            // 
            this.dtwTempMin.Location = new System.Drawing.Point(379, 3);
            this.dtwTempMin.Name = "dtwTempMin";
            this.dtwTempMin.Size = new System.Drawing.Size(125, 90);
            this.dtwTempMin.TabIndex = 3;
            // 
            // dtwPressure
            // 
            this.dtwPressure.Location = new System.Drawing.Point(3, 99);
            this.dtwPressure.Name = "dtwPressure";
            this.dtwPressure.Size = new System.Drawing.Size(120, 90);
            this.dtwPressure.TabIndex = 4;
            // 
            // dtwHumidity
            // 
            this.dtwHumidity.Location = new System.Drawing.Point(129, 99);
            this.dtwHumidity.Name = "dtwHumidity";
            this.dtwHumidity.Size = new System.Drawing.Size(118, 90);
            this.dtwHumidity.TabIndex = 5;
            // 
            // dtwSpeed
            // 
            this.dtwSpeed.Location = new System.Drawing.Point(253, 99);
            this.dtwSpeed.Name = "dtwSpeed";
            this.dtwSpeed.Size = new System.Drawing.Size(120, 90);
            this.dtwSpeed.TabIndex = 6;
            // 
            // dtwSunrise
            // 
            this.dtwSunrise.Location = new System.Drawing.Point(379, 99);
            this.dtwSunrise.Name = "dtwSunrise";
            this.dtwSunrise.Size = new System.Drawing.Size(125, 90);
            this.dtwSunrise.TabIndex = 7;
            // 
            // dtwSunset
            // 
            this.dtwSunset.Location = new System.Drawing.Point(3, 195);
            this.dtwSunset.Name = "dtwSunset";
            this.dtwSunset.Size = new System.Drawing.Size(120, 90);
            this.dtwSunset.TabIndex = 8;
            // 
            // dtwFeelsLike
            // 
            this.dtwFeelsLike.Location = new System.Drawing.Point(129, 195);
            this.dtwFeelsLike.Name = "dtwFeelsLike";
            this.dtwFeelsLike.Size = new System.Drawing.Size(118, 90);
            this.dtwFeelsLike.TabIndex = 9;
            // 
            // dtwTimeZone
            // 
            this.dtwTimeZone.Location = new System.Drawing.Point(253, 195);
            this.dtwTimeZone.Name = "dtwTimeZone";
            this.dtwTimeZone.Size = new System.Drawing.Size(120, 90);
            this.dtwTimeZone.TabIndex = 10;
            // 
            // dtwVisibility
            // 
            this.dtwVisibility.Location = new System.Drawing.Point(379, 195);
            this.dtwVisibility.Name = "dtwVisibility";
            this.dtwVisibility.Size = new System.Drawing.Size(125, 90);
            this.dtwVisibility.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(204, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 83);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // WeatherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flpContent);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WeatherPanel";
            this.Size = new System.Drawing.Size(507, 551);
            this.Load += new System.EventHandler(this.WeatherPanel_Load_1);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flpContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpContent;
        public DetailsWeather dtwLon;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblCity;
        public System.Windows.Forms.Label lblTemperature;
        public System.Windows.Forms.Label lblWeather;
        public DetailsWeather dtwLat;
        public DetailsWeather dtwTempMax;
        public DetailsWeather dtwTempMin;
        public DetailsWeather dtwPressure;
        public DetailsWeather dtwHumidity;
        public DetailsWeather dtwSpeed;
        public DetailsWeather dtwSunrise;
        public DetailsWeather dtwSunset;
        public DetailsWeather dtwFeelsLike;
        public DetailsWeather dtwTimeZone;
        public DetailsWeather dtwVisibility;
    }
}
