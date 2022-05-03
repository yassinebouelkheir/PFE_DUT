﻿namespace RPi
{
    partial class RPI_Main
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.Charts = new System.Windows.Forms.Button();
            this.Charges = new System.Windows.Forms.Button();
            this.Meteorologie = new System.Windows.Forms.Button();
            this.Eolienne = new System.Windows.Forms.Button();
            this.Courant_Fort = new System.Windows.Forms.Button();
            this.Courant_Faible = new System.Windows.Forms.Button();
            this.Right_Btn = new System.Windows.Forms.Button();
            this.Left_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.paramTitle = new System.Windows.Forms.Label();
            this.paramValue = new System.Windows.Forms.Label();
            this.updateParams = new System.Windows.Forms.Timer(this.components);
            this.updateCharts = new System.Windows.Forms.Timer(this.components);
            this.Sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.Transparent;
            this.Sidebar.Controls.Add(this.Charts);
            this.Sidebar.Controls.Add(this.Charges);
            this.Sidebar.Controls.Add(this.Meteorologie);
            this.Sidebar.Controls.Add(this.Eolienne);
            this.Sidebar.Controls.Add(this.Courant_Fort);
            this.Sidebar.Controls.Add(this.Courant_Faible);
            this.Sidebar.Location = new System.Drawing.Point(-2, 194);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(469, 89);
            this.Sidebar.TabIndex = 0;
            // 
            // Charts
            // 
            this.Charts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(90)))));
            this.Charts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Charts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Charts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Charts.ForeColor = System.Drawing.Color.White;
            this.Charts.Location = new System.Drawing.Point(5, 4);
            this.Charts.Name = "Charts";
            this.Charts.Size = new System.Drawing.Size(457, 25);
            this.Charts.TabIndex = 9;
            this.Charts.Text = "Passer en mode graphique";
            this.Charts.UseVisualStyleBackColor = false;
            this.Charts.Click += new System.EventHandler(this.Charts_Click);
            // 
            // Charges
            // 
            this.Charges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(90)))));
            this.Charges.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Charges.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Charges.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Charges.ForeColor = System.Drawing.Color.White;
            this.Charges.Image = global::RPi.Properties.Resources.th_solid;
            this.Charges.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Charges.Location = new System.Drawing.Point(372, 30);
            this.Charges.Name = "Charges";
            this.Charges.Size = new System.Drawing.Size(90, 54);
            this.Charges.TabIndex = 8;
            this.Charges.Text = "Charges";
            this.Charges.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Charges.UseVisualStyleBackColor = false;
            this.Charges.Click += new System.EventHandler(this.Charges_Click);
            // 
            // Meteorologie
            // 
            this.Meteorologie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(90)))));
            this.Meteorologie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Meteorologie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Meteorologie.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Meteorologie.ForeColor = System.Drawing.Color.White;
            this.Meteorologie.Image = global::RPi.Properties.Resources.snowflake_solid;
            this.Meteorologie.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Meteorologie.Location = new System.Drawing.Point(280, 30);
            this.Meteorologie.Name = "Meteorologie";
            this.Meteorologie.Size = new System.Drawing.Size(90, 54);
            this.Meteorologie.TabIndex = 8;
            this.Meteorologie.Text = "Météorologie";
            this.Meteorologie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Meteorologie.UseVisualStyleBackColor = false;
            this.Meteorologie.Click += new System.EventHandler(this.Meteorologie_Click);
            // 
            // Eolienne
            // 
            this.Eolienne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(90)))));
            this.Eolienne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Eolienne.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eolienne.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Eolienne.ForeColor = System.Drawing.Color.White;
            this.Eolienne.Image = global::RPi.Properties.Resources.fan_solid;
            this.Eolienne.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eolienne.Location = new System.Drawing.Point(188, 30);
            this.Eolienne.Name = "Eolienne";
            this.Eolienne.Size = new System.Drawing.Size(90, 54);
            this.Eolienne.TabIndex = 8;
            this.Eolienne.Text = "Éolienne";
            this.Eolienne.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eolienne.UseVisualStyleBackColor = false;
            this.Eolienne.Click += new System.EventHandler(this.Eolienne_Click);
            // 
            // Courant_Fort
            // 
            this.Courant_Fort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(90)))));
            this.Courant_Fort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Courant_Fort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Courant_Fort.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Courant_Fort.ForeColor = System.Drawing.Color.White;
            this.Courant_Fort.Image = global::RPi.Properties.Resources.bolt_solid;
            this.Courant_Fort.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Courant_Fort.Location = new System.Drawing.Point(97, 30);
            this.Courant_Fort.Name = "Courant_Fort";
            this.Courant_Fort.Size = new System.Drawing.Size(90, 54);
            this.Courant_Fort.TabIndex = 7;
            this.Courant_Fort.Text = "Courant Fort";
            this.Courant_Fort.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Courant_Fort.UseVisualStyleBackColor = false;
            this.Courant_Fort.Click += new System.EventHandler(this.Courant_Fort_Click);
            // 
            // Courant_Faible
            // 
            this.Courant_Faible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(103)))), ((int)(((byte)(60)))));
            this.Courant_Faible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Courant_Faible.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Courant_Faible.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Courant_Faible.ForeColor = System.Drawing.Color.White;
            this.Courant_Faible.Image = global::RPi.Properties.Resources.charging_station_solid;
            this.Courant_Faible.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Courant_Faible.Location = new System.Drawing.Point(5, 30);
            this.Courant_Faible.Name = "Courant_Faible";
            this.Courant_Faible.Size = new System.Drawing.Size(91, 54);
            this.Courant_Faible.TabIndex = 6;
            this.Courant_Faible.Text = "Courant Faible";
            this.Courant_Faible.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Courant_Faible.UseVisualStyleBackColor = false;
            this.Courant_Faible.Click += new System.EventHandler(this.Courant_Faible_Click);
            // 
            // Right_Btn
            // 
            this.Right_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(90)))));
            this.Right_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Right_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Right_Btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Right_Btn.ForeColor = System.Drawing.Color.White;
            this.Right_Btn.Image = global::RPi.Properties.Resources.arrow_right_solid;
            this.Right_Btn.Location = new System.Drawing.Point(434, 29);
            this.Right_Btn.Name = "Right_Btn";
            this.Right_Btn.Size = new System.Drawing.Size(26, 153);
            this.Right_Btn.TabIndex = 10;
            this.Right_Btn.UseVisualStyleBackColor = false;
            this.Right_Btn.Click += new System.EventHandler(this.Right_Btn_Click);
            // 
            // Left_Btn
            // 
            this.Left_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(90)))));
            this.Left_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Left_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Left_Btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Left_Btn.ForeColor = System.Drawing.Color.White;
            this.Left_Btn.Image = global::RPi.Properties.Resources.arrow_left_solid;
            this.Left_Btn.Location = new System.Drawing.Point(3, 29);
            this.Left_Btn.Name = "Left_Btn";
            this.Left_Btn.Size = new System.Drawing.Size(26, 153);
            this.Left_Btn.TabIndex = 11;
            this.Left_Btn.UseVisualStyleBackColor = false;
            this.Left_Btn.Click += new System.EventHandler(this.Left_Btn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "ESTS LASTIMI - Data Logger v2.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cartesianChart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.paramTitle);
            this.panel1.Controls.Add(this.paramValue);
            this.panel1.Location = new System.Drawing.Point(35, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 153);
            this.panel1.TabIndex = 13;
            // 
            // cartesianChart
            // 
            this.cartesianChart.Location = new System.Drawing.Point(4, 24);
            this.cartesianChart.Name = "cartesianChart";
            this.cartesianChart.Size = new System.Drawing.Size(385, 126);
            this.cartesianChart.TabIndex = 24;
            this.cartesianChart.Text = "cartesianChart";
            this.cartesianChart.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Panneau de contrôle des charges";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(90)))));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::RPi.Properties.Resources.lightbulb_regular;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.Location = new System.Drawing.Point(300, 96);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 54);
            this.button8.TabIndex = 22;
            this.button8.Text = "Charge 8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(90)))));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Image = global::RPi.Properties.Resources.lightbulb_regular;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.Location = new System.Drawing.Point(204, 96);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 54);
            this.button7.TabIndex = 21;
            this.button7.Text = "Charge 7";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(90)))));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::RPi.Properties.Resources.lightbulb_regular;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(99, 96);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 54);
            this.button6.TabIndex = 20;
            this.button6.Text = "Charge 6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(90)))));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::RPi.Properties.Resources.lightbulb_regular;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(3, 96);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 54);
            this.button5.TabIndex = 19;
            this.button5.Text = "Charge 5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(90)))));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::RPi.Properties.Resources.lightbulb_regular;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(300, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 54);
            this.button4.TabIndex = 18;
            this.button4.Text = "Charge 4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(90)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::RPi.Properties.Resources.lightbulb_regular;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(204, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 54);
            this.button3.TabIndex = 17;
            this.button3.Text = "Charge 3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(90)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::RPi.Properties.Resources.lightbulb_regular;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(99, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 54);
            this.button2.TabIndex = 16;
            this.button2.Text = "Charge 2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(155)))), ((int)(((byte)(90)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::RPi.Properties.Resources.lightbulb_regular;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(3, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 54);
            this.button1.TabIndex = 15;
            this.button1.Text = "Charge 1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // paramTitle
            // 
            this.paramTitle.BackColor = System.Drawing.Color.Transparent;
            this.paramTitle.Font = new System.Drawing.Font("Dubai", 15F, System.Drawing.FontStyle.Bold);
            this.paramTitle.ForeColor = System.Drawing.Color.Black;
            this.paramTitle.Location = new System.Drawing.Point(3, 0);
            this.paramTitle.Name = "paramTitle";
            this.paramTitle.Size = new System.Drawing.Size(159, 153);
            this.paramTitle.TabIndex = 13;
            this.paramTitle.Text = "Flux Lumineux :";
            this.paramTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paramValue
            // 
            this.paramValue.BackColor = System.Drawing.Color.Transparent;
            this.paramValue.Font = new System.Drawing.Font("Dubai", 26.25F, System.Drawing.FontStyle.Bold);
            this.paramValue.ForeColor = System.Drawing.Color.Maroon;
            this.paramValue.Location = new System.Drawing.Point(151, 0);
            this.paramValue.Name = "paramValue";
            this.paramValue.Size = new System.Drawing.Size(242, 153);
            this.paramValue.TabIndex = 14;
            this.paramValue.Text = "9999.9 KM/H";
            this.paramValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateParams
            // 
            this.updateParams.Enabled = true;
            this.updateParams.Tick += new System.EventHandler(this.updateParams_Tick);
            // 
            // updateCharts
            // 
            this.updateCharts.Enabled = true;
            this.updateCharts.Interval = 60000;
            this.updateCharts.Tick += new System.EventHandler(this.updateCharts_Tick);
            // 
            // RPI_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RPi.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Left_Btn);
            this.Controls.Add(this.Right_Btn);
            this.Controls.Add(this.Sidebar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RPI_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Logger v2.0";
            this.Load += new System.EventHandler(this.RPI_Main_Load);
            this.Sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Button Charts;
        private System.Windows.Forms.Button Charges;
        private System.Windows.Forms.Button Meteorologie;
        private System.Windows.Forms.Button Eolienne;
        private System.Windows.Forms.Button Courant_Fort;
        private System.Windows.Forms.Button Courant_Faible;
        private System.Windows.Forms.Button Right_Btn;
        private System.Windows.Forms.Button Left_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label paramValue;
        private System.Windows.Forms.Label paramTitle;
        private System.Windows.Forms.Timer updateParams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private LiveCharts.WinForms.CartesianChart cartesianChart;
        private System.Windows.Forms.Timer updateCharts;
    }
}