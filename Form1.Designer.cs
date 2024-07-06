namespace weather
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
            this.siticoneGradientPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.search = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.location = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneGradientPanel2 = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            this.selper = new System.Windows.Forms.Label();
            this.selmoon = new System.Windows.Forms.Label();
            this.selhumidity = new System.Windows.Forms.Label();
            this.selwind = new System.Windows.Forms.Label();
            this.seltemp = new System.Windows.Forms.Label();
            this.selweather = new System.Windows.Forms.Label();
            this.selloc = new System.Windows.Forms.Label();
            this.siticoneGradientPanel1.SuspendLayout();
            this.siticoneGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.AutoRoundedCorners = true;
            this.siticoneGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGradientPanel1.BorderRadius = 43;
            this.siticoneGradientPanel1.Controls.Add(this.search);
            this.siticoneGradientPanel1.Controls.Add(this.location);
            this.siticoneGradientPanel1.FillColor = System.Drawing.SystemColors.GrayText;
            this.siticoneGradientPanel1.FillColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.siticoneGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(13, 12);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(776, 88);
            this.siticoneGradientPanel1.TabIndex = 0;
            // 
            // search
            // 
            this.search.Animated = true;
            this.search.AutoRoundedCorners = true;
            this.search.BorderRadius = 26;
            this.search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.search.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(546, 15);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(162, 55);
            this.search.TabIndex = 1;
            this.search.Text = "Search";
            this.search.UseTransparentBackground = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // location
            // 
            this.location.Animated = true;
            this.location.BorderRadius = 15;
            this.location.BorderThickness = 2;
            this.location.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.location.DefaultText = "";
            this.location.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.location.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.location.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.location.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.location.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.location.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.location.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.location.Location = new System.Drawing.Point(38, 15);
            this.location.Name = "location";
            this.location.PasswordChar = '\0';
            this.location.PlaceholderText = "Location";
            this.location.SelectedText = "";
            this.location.Size = new System.Drawing.Size(477, 55);
            this.location.TabIndex = 1;
            // 
            // siticoneGradientPanel2
            // 
            this.siticoneGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGradientPanel2.BorderRadius = 20;
            this.siticoneGradientPanel2.Controls.Add(this.selper);
            this.siticoneGradientPanel2.Controls.Add(this.selmoon);
            this.siticoneGradientPanel2.Controls.Add(this.selhumidity);
            this.siticoneGradientPanel2.Controls.Add(this.selwind);
            this.siticoneGradientPanel2.Controls.Add(this.seltemp);
            this.siticoneGradientPanel2.Controls.Add(this.selweather);
            this.siticoneGradientPanel2.Controls.Add(this.selloc);
            this.siticoneGradientPanel2.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.siticoneGradientPanel2.FillColor = System.Drawing.SystemColors.GrayText;
            this.siticoneGradientPanel2.FillColor2 = System.Drawing.SystemColors.GradientActiveCaption;
            this.siticoneGradientPanel2.Font = new System.Drawing.Font("Reem Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneGradientPanel2.Location = new System.Drawing.Point(12, 106);
            this.siticoneGradientPanel2.Name = "siticoneGradientPanel2";
            this.siticoneGradientPanel2.Size = new System.Drawing.Size(776, 470);
            this.siticoneGradientPanel2.TabIndex = 1;
            this.siticoneGradientPanel2.UseTransparentBackground = true;
            // 
            // selper
            // 
            this.selper.AutoSize = true;
            this.selper.Font = new System.Drawing.Font("Reem Kufi", 14F, System.Drawing.FontStyle.Bold);
            this.selper.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.selper.Location = new System.Drawing.Point(33, 372);
            this.selper.Name = "selper";
            this.selper.Size = new System.Drawing.Size(130, 35);
            this.selper.TabIndex = 6;
            this.selper.Text = "Precipitation";
            // 
            // selmoon
            // 
            this.selmoon.AutoSize = true;
            this.selmoon.Font = new System.Drawing.Font("Reem Kufi", 14F, System.Drawing.FontStyle.Bold);
            this.selmoon.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.selmoon.Location = new System.Drawing.Point(33, 317);
            this.selmoon.Name = "selmoon";
            this.selmoon.Size = new System.Drawing.Size(133, 35);
            this.selmoon.TabIndex = 5;
            this.selmoon.Text = "Moon phase ?";
            this.selmoon.Click += new System.EventHandler(this.selmoon_Click);
            // 
            // selhumidity
            // 
            this.selhumidity.AutoSize = true;
            this.selhumidity.Font = new System.Drawing.Font("Reem Kufi", 14F, System.Drawing.FontStyle.Bold);
            this.selhumidity.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.selhumidity.Location = new System.Drawing.Point(33, 265);
            this.selhumidity.Name = "selhumidity";
            this.selhumidity.Size = new System.Drawing.Size(107, 35);
            this.selhumidity.TabIndex = 4;
            this.selhumidity.Text = "Humidity ?";
            // 
            // selwind
            // 
            this.selwind.AutoSize = true;
            this.selwind.Font = new System.Drawing.Font("Reem Kufi", 14F, System.Drawing.FontStyle.Bold);
            this.selwind.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.selwind.Location = new System.Drawing.Point(33, 210);
            this.selwind.Name = "selwind";
            this.selwind.Size = new System.Drawing.Size(73, 35);
            this.selwind.TabIndex = 3;
            this.selwind.Text = "Wind ?";
            // 
            // seltemp
            // 
            this.seltemp.AutoSize = true;
            this.seltemp.Font = new System.Drawing.Font("Reem Kufi", 14F, System.Drawing.FontStyle.Bold);
            this.seltemp.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.seltemp.Location = new System.Drawing.Point(33, 148);
            this.seltemp.Name = "seltemp";
            this.seltemp.Size = new System.Drawing.Size(142, 35);
            this.seltemp.TabIndex = 2;
            this.seltemp.Text = "Temperature ?";
            // 
            // selweather
            // 
            this.selweather.AutoSize = true;
            this.selweather.Font = new System.Drawing.Font("Reem Kufi", 14F, System.Drawing.FontStyle.Bold);
            this.selweather.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.selweather.Location = new System.Drawing.Point(33, 93);
            this.selweather.Name = "selweather";
            this.selweather.Size = new System.Drawing.Size(103, 35);
            this.selweather.TabIndex = 1;
            this.selweather.Text = "Weather ?";
            // 
            // selloc
            // 
            this.selloc.AutoSize = true;
            this.selloc.Font = new System.Drawing.Font("Reem Kufi", 14F, System.Drawing.FontStyle.Bold);
            this.selloc.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.selloc.Location = new System.Drawing.Point(317, 10);
            this.selloc.Name = "selloc";
            this.selloc.Size = new System.Drawing.Size(172, 35);
            this.selloc.TabIndex = 0;
            this.selloc.Text = "Selected Location";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 588);
            this.Controls.Add(this.siticoneGradientPanel2);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.siticoneGradientPanel2.ResumeLayout(false);
            this.siticoneGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox location;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton search;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel2;
        private System.Windows.Forms.Label selloc;
        private System.Windows.Forms.Label selhumidity;
        private System.Windows.Forms.Label selwind;
        private System.Windows.Forms.Label seltemp;
        private System.Windows.Forms.Label selweather;
        private System.Windows.Forms.Label selper;
        private System.Windows.Forms.Label selmoon;
    }
}

