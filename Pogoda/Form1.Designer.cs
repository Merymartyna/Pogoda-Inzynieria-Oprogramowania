
namespace Pogoda
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.labTemp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labTempWA = new System.Windows.Forms.Label();
            this.labWindWA = new System.Windows.Forms.Label();
            this.labPressWA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.switchTo2 = new System.Windows.Forms.Button();
            this.labMaxTemp = new System.Windows.Forms.Label();
            this.labWindSpeedMax = new System.Windows.Forms.Label();
            this.labWindSpeedMin = new System.Windows.Forms.Label();
            this.labMinTemp = new System.Windows.Forms.Label();
            this.labSrTemp = new System.Windows.Forms.Label();
            this.labWindSpeedSr = new System.Windows.Forms.Label();
            this.labPressureMax = new System.Windows.Forms.Label();
            this.labPressureMin = new System.Windows.Forms.Label();
            this.labPressureSr = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(332, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Miasto:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBCity
            // 
            this.TBCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TBCity.Location = new System.Drawing.Point(466, 14);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(186, 38);
            this.TBCity.TabIndex = 1;
            // 
            // buttonS
            // 
            this.buttonS.BackColor = System.Drawing.Color.Transparent;
            this.buttonS.Location = new System.Drawing.Point(-1645, 460);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(75, 23);
            this.buttonS.TabIndex = 2;
            this.buttonS.Text = "button1";
            this.buttonS.UseVisualStyleBackColor = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.ForeColor = System.Drawing.Color.Black;
            this.buttonSearch.Location = new System.Drawing.Point(695, 14);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(126, 38);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1616, 585);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Miasto";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labDetails.ForeColor = System.Drawing.Color.White;
            this.labDetails.Location = new System.Drawing.Point(23, 154);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(145, 32);
            this.labDetails.TabIndex = 6;
            this.labDetails.Text = "Szczegóły";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(232, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Wschód słońca";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labSunrise.ForeColor = System.Drawing.Color.White;
            this.labSunrise.Location = new System.Drawing.Point(468, 109);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(39, 32);
            this.labSunrise.TabIndex = 8;
            this.labSunrise.Text = "...";
            this.labSunrise.Click += new System.EventHandler(this.labSunrise_Click);
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labSunset.ForeColor = System.Drawing.Color.White;
            this.labSunset.Location = new System.Drawing.Point(800, 109);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(39, 32);
            this.labSunset.TabIndex = 10;
            this.labSunset.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(553, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "Zachód słońca";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labPressure.ForeColor = System.Drawing.Color.White;
            this.labPressure.Location = new System.Drawing.Point(343, 414);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(39, 32);
            this.labPressure.TabIndex = 14;
            this.labPressure.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(44, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ciśnienie";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labWindSpeed.ForeColor = System.Drawing.Color.White;
            this.labWindSpeed.Location = new System.Drawing.Point(343, 350);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(39, 32);
            this.labWindSpeed.TabIndex = 12;
            this.labWindSpeed.Text = "...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(44, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 32);
            this.label10.TabIndex = 11;
            this.label10.Text = "Prędkość wiatru";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(29, 20);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(83, 58);
            this.picIcon.TabIndex = 15;
            this.picIcon.TabStop = false;
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.BackColor = System.Drawing.Color.Transparent;
            this.labTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTemp.ForeColor = System.Drawing.Color.White;
            this.labTemp.Location = new System.Drawing.Point(343, 295);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(39, 32);
            this.labTemp.TabIndex = 16;
            this.labTemp.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 32);
            this.label3.TabIndex = 17;
            this.label3.Text = "Temperatura";
            // 
            // labTempWA
            // 
            this.labTempWA.AutoSize = true;
            this.labTempWA.BackColor = System.Drawing.Color.Transparent;
            this.labTempWA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labTempWA.ForeColor = System.Drawing.Color.White;
            this.labTempWA.Location = new System.Drawing.Point(565, 295);
            this.labTempWA.Name = "labTempWA";
            this.labTempWA.Size = new System.Drawing.Size(39, 32);
            this.labTempWA.TabIndex = 18;
            this.labTempWA.Text = "...";
            // 
            // labWindWA
            // 
            this.labWindWA.AutoSize = true;
            this.labWindWA.BackColor = System.Drawing.Color.Transparent;
            this.labWindWA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labWindWA.ForeColor = System.Drawing.Color.White;
            this.labWindWA.Location = new System.Drawing.Point(565, 350);
            this.labWindWA.Name = "labWindWA";
            this.labWindWA.Size = new System.Drawing.Size(39, 32);
            this.labWindWA.TabIndex = 19;
            this.labWindWA.Text = "...";
            // 
            // labPressWA
            // 
            this.labPressWA.AutoSize = true;
            this.labPressWA.BackColor = System.Drawing.Color.Transparent;
            this.labPressWA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labPressWA.ForeColor = System.Drawing.Color.White;
            this.labPressWA.Location = new System.Drawing.Point(565, 414);
            this.labPressWA.Name = "labPressWA";
            this.labPressWA.Size = new System.Drawing.Size(39, 32);
            this.labPressWA.TabIndex = 20;
            this.labPressWA.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(235, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 34);
            this.label5.TabIndex = 21;
            this.label5.Text = "OpenWeatherMap";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(513, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 34);
            this.label7.TabIndex = 22;
            this.label7.Text = "WeatherAPI";
            // 
            // switchTo2
            // 
            this.switchTo2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.switchTo2.Location = new System.Drawing.Point(839, 573);
            this.switchTo2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.switchTo2.Name = "switchTo2";
            this.switchTo2.Size = new System.Drawing.Size(171, 34);
            this.switchTo2.TabIndex = 23;
            this.switchTo2.Text = "Przejdź do porównania";
            this.switchTo2.UseVisualStyleBackColor = false;
            this.switchTo2.Click += new System.EventHandler(this.switchTo2_Click);
            // 
            // labMaxTemp
            // 
            this.labMaxTemp.AutoSize = true;
            this.labMaxTemp.BackColor = System.Drawing.Color.Transparent;
            this.labMaxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labMaxTemp.ForeColor = System.Drawing.Color.White;
            this.labMaxTemp.Location = new System.Drawing.Point(757, 295);
            this.labMaxTemp.Name = "labMaxTemp";
            this.labMaxTemp.Size = new System.Drawing.Size(39, 32);
            this.labMaxTemp.TabIndex = 24;
            this.labMaxTemp.Text = "...";
            // 
            // labWindSpeedMax
            // 
            this.labWindSpeedMax.AutoSize = true;
            this.labWindSpeedMax.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeedMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labWindSpeedMax.ForeColor = System.Drawing.Color.White;
            this.labWindSpeedMax.Location = new System.Drawing.Point(757, 350);
            this.labWindSpeedMax.Name = "labWindSpeedMax";
            this.labWindSpeedMax.Size = new System.Drawing.Size(39, 32);
            this.labWindSpeedMax.TabIndex = 25;
            this.labWindSpeedMax.Text = "...";
            // 
            // labWindSpeedMin
            // 
            this.labWindSpeedMin.AutoSize = true;
            this.labWindSpeedMin.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeedMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labWindSpeedMin.ForeColor = System.Drawing.Color.White;
            this.labWindSpeedMin.Location = new System.Drawing.Point(855, 350);
            this.labWindSpeedMin.Name = "labWindSpeedMin";
            this.labWindSpeedMin.Size = new System.Drawing.Size(39, 32);
            this.labWindSpeedMin.TabIndex = 26;
            this.labWindSpeedMin.Text = "...";
            // 
            // labMinTemp
            // 
            this.labMinTemp.AutoSize = true;
            this.labMinTemp.BackColor = System.Drawing.Color.Transparent;
            this.labMinTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labMinTemp.ForeColor = System.Drawing.Color.White;
            this.labMinTemp.Location = new System.Drawing.Point(855, 295);
            this.labMinTemp.Name = "labMinTemp";
            this.labMinTemp.Size = new System.Drawing.Size(39, 32);
            this.labMinTemp.TabIndex = 27;
            this.labMinTemp.Text = "...";
            // 
            // labSrTemp
            // 
            this.labSrTemp.AutoSize = true;
            this.labSrTemp.BackColor = System.Drawing.Color.Transparent;
            this.labSrTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labSrTemp.ForeColor = System.Drawing.Color.White;
            this.labSrTemp.Location = new System.Drawing.Point(935, 295);
            this.labSrTemp.Name = "labSrTemp";
            this.labSrTemp.Size = new System.Drawing.Size(39, 32);
            this.labSrTemp.TabIndex = 28;
            this.labSrTemp.Text = "...";
            // 
            // labWindSpeedSr
            // 
            this.labWindSpeedSr.AutoSize = true;
            this.labWindSpeedSr.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeedSr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labWindSpeedSr.ForeColor = System.Drawing.Color.White;
            this.labWindSpeedSr.Location = new System.Drawing.Point(935, 350);
            this.labWindSpeedSr.Name = "labWindSpeedSr";
            this.labWindSpeedSr.Size = new System.Drawing.Size(39, 32);
            this.labWindSpeedSr.TabIndex = 29;
            this.labWindSpeedSr.Text = "...";
            // 
            // labPressureMax
            // 
            this.labPressureMax.AutoSize = true;
            this.labPressureMax.BackColor = System.Drawing.Color.Transparent;
            this.labPressureMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labPressureMax.ForeColor = System.Drawing.Color.White;
            this.labPressureMax.Location = new System.Drawing.Point(757, 414);
            this.labPressureMax.Name = "labPressureMax";
            this.labPressureMax.Size = new System.Drawing.Size(39, 32);
            this.labPressureMax.TabIndex = 30;
            this.labPressureMax.Text = "...";
            // 
            // labPressureMin
            // 
            this.labPressureMin.AutoSize = true;
            this.labPressureMin.BackColor = System.Drawing.Color.Transparent;
            this.labPressureMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labPressureMin.ForeColor = System.Drawing.Color.White;
            this.labPressureMin.Location = new System.Drawing.Point(855, 414);
            this.labPressureMin.Name = "labPressureMin";
            this.labPressureMin.Size = new System.Drawing.Size(39, 32);
            this.labPressureMin.TabIndex = 31;
            this.labPressureMin.Text = "...";
            // 
            // labPressureSr
            // 
            this.labPressureSr.AutoSize = true;
            this.labPressureSr.BackColor = System.Drawing.Color.Transparent;
            this.labPressureSr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labPressureSr.ForeColor = System.Drawing.Color.White;
            this.labPressureSr.Location = new System.Drawing.Point(935, 414);
            this.labPressureSr.Name = "labPressureSr";
            this.labPressureSr.Size = new System.Drawing.Size(39, 32);
            this.labPressureSr.TabIndex = 32;
            this.labPressureSr.Text = "...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(743, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Maximum";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(848, 477);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Minimum";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(938, 477);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "Średnia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pogoda.Properties.Resources.wall2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 617);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labPressureSr);
            this.Controls.Add(this.labPressureMin);
            this.Controls.Add(this.labPressureMax);
            this.Controls.Add(this.labWindSpeedSr);
            this.Controls.Add(this.labSrTemp);
            this.Controls.Add(this.labMinTemp);
            this.Controls.Add(this.labWindSpeedMin);
            this.Controls.Add(this.labWindSpeedMax);
            this.Controls.Add(this.labMaxTemp);
            this.Controls.Add(this.switchTo2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labPressWA);
            this.Controls.Add(this.labWindWA);
            this.Controls.Add(this.labTempWA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labTemp);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labWindSpeed);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labSunset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labSunrise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label labTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labTempWA;
        private System.Windows.Forms.Label labWindWA;
        private System.Windows.Forms.Label labPressWA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button switchTo2;
        private System.Windows.Forms.Label labMaxTemp;
        private System.Windows.Forms.Label labWindSpeedMax;
        private System.Windows.Forms.Label labWindSpeedMin;
        private System.Windows.Forms.Label labMinTemp;
        private System.Windows.Forms.Label labSrTemp;
        private System.Windows.Forms.Label labWindSpeedSr;
        private System.Windows.Forms.Label labPressureMax;
        private System.Windows.Forms.Label labPressureMin;
        private System.Windows.Forms.Label labPressureSr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

