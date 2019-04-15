namespace XMLWeather
{
    partial class CurrentScreen
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentScreen));
			this.cityOutput = new System.Windows.Forms.Label();
			this.maxOutput = new System.Windows.Forms.Label();
			this.maxLabel = new System.Windows.Forms.Label();
			this.minOutput = new System.Windows.Forms.Label();
			this.minLabel = new System.Windows.Forms.Label();
			this.currentOutput = new System.Windows.Forms.Label();
			this.tempLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.forecastLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.clockRefresh = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// cityOutput
			// 
			this.cityOutput.BackColor = System.Drawing.Color.Transparent;
			this.cityOutput.Font = new System.Drawing.Font("Microsoft YaHei Light", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cityOutput.ForeColor = System.Drawing.Color.White;
			this.cityOutput.Location = new System.Drawing.Point(13, 10);
			this.cityOutput.Name = "cityOutput";
			this.cityOutput.Size = new System.Drawing.Size(455, 64);
			this.cityOutput.TabIndex = 22;
			this.cityOutput.Text = "City";
			// 
			// maxOutput
			// 
			this.maxOutput.BackColor = System.Drawing.Color.Transparent;
			this.maxOutput.Font = new System.Drawing.Font("Microsoft YaHei Light", 34.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maxOutput.ForeColor = System.Drawing.Color.White;
			this.maxOutput.Location = new System.Drawing.Point(66, 278);
			this.maxOutput.Name = "maxOutput";
			this.maxOutput.Size = new System.Drawing.Size(165, 54);
			this.maxOutput.TabIndex = 32;
			this.maxOutput.Text = "0";
			// 
			// maxLabel
			// 
			this.maxLabel.AutoSize = true;
			this.maxLabel.BackColor = System.Drawing.Color.Transparent;
			this.maxLabel.Font = new System.Drawing.Font("Microsoft YaHei Light", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maxLabel.ForeColor = System.Drawing.Color.White;
			this.maxLabel.Location = new System.Drawing.Point(22, 278);
			this.maxLabel.Name = "maxLabel";
			this.maxLabel.Size = new System.Drawing.Size(45, 23);
			this.maxLabel.TabIndex = 31;
			this.maxLabel.Text = "Max";
			// 
			// minOutput
			// 
			this.minOutput.BackColor = System.Drawing.Color.Transparent;
			this.minOutput.Font = new System.Drawing.Font("Microsoft YaHei Light", 34.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minOutput.ForeColor = System.Drawing.Color.White;
			this.minOutput.Location = new System.Drawing.Point(66, 203);
			this.minOutput.Name = "minOutput";
			this.minOutput.Size = new System.Drawing.Size(165, 48);
			this.minOutput.TabIndex = 30;
			this.minOutput.Text = "0";
			// 
			// minLabel
			// 
			this.minLabel.AutoSize = true;
			this.minLabel.BackColor = System.Drawing.Color.Transparent;
			this.minLabel.Font = new System.Drawing.Font("Microsoft YaHei Light", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minLabel.ForeColor = System.Drawing.Color.White;
			this.minLabel.Location = new System.Drawing.Point(21, 203);
			this.minLabel.Name = "minLabel";
			this.minLabel.Size = new System.Drawing.Size(42, 23);
			this.minLabel.TabIndex = 29;
			this.minLabel.Text = "Min";
			// 
			// currentOutput
			// 
			this.currentOutput.BackColor = System.Drawing.Color.Transparent;
			this.currentOutput.Font = new System.Drawing.Font("Microsoft YaHei UI", 18.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentOutput.ForeColor = System.Drawing.Color.White;
			this.currentOutput.Location = new System.Drawing.Point(471, 10);
			this.currentOutput.Name = "currentOutput";
			this.currentOutput.Size = new System.Drawing.Size(126, 44);
			this.currentOutput.TabIndex = 28;
			this.currentOutput.Text = "00:00:00";
			// 
			// tempLabel
			// 
			this.tempLabel.AutoSize = true;
			this.tempLabel.BackColor = System.Drawing.Color.Transparent;
			this.tempLabel.Font = new System.Drawing.Font("Microsoft YaHei Light", 42.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tempLabel.ForeColor = System.Drawing.Color.White;
			this.tempLabel.Location = new System.Drawing.Point(42, 74);
			this.tempLabel.Name = "tempLabel";
			this.tempLabel.Size = new System.Drawing.Size(183, 75);
			this.tempLabel.TabIndex = 26;
			this.tempLabel.Text = "Temp";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(395, 354);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 28);
			this.label3.TabIndex = 40;
			this.label3.Text = "Today";
			// 
			// forecastLabel
			// 
			this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
			this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forecastLabel.ForeColor = System.Drawing.Color.White;
			this.forecastLabel.Location = new System.Drawing.Point(500, 354);
			this.forecastLabel.Name = "forecastLabel";
			this.forecastLabel.Size = new System.Drawing.Size(83, 28);
			this.forecastLabel.TabIndex = 41;
			this.forecastLabel.Text = "6 Day";
			this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(379, 364);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 27);
			this.label5.TabIndex = 42;
			this.label5.Text = "____________________________";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// clockRefresh
			// 
			this.clockRefresh.Enabled = true;
			this.clockRefresh.Interval = 10;
			this.clockRefresh.Tick += new System.EventHandler(this.clockRefresh_Tick);
			// 
			// CurrentScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.forecastLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cityOutput);
			this.Controls.Add(this.maxOutput);
			this.Controls.Add(this.maxLabel);
			this.Controls.Add(this.minOutput);
			this.Controls.Add(this.minLabel);
			this.Controls.Add(this.currentOutput);
			this.Controls.Add(this.tempLabel);
			this.Controls.Add(this.label5);
			this.DoubleBuffered = true;
			this.Name = "CurrentScreen";
			this.Size = new System.Drawing.Size(600, 400);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Timer clockRefresh;
	}
}
