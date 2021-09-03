using System.Windows.Forms;

namespace SamsunSpaceSystems
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.BtnTelemetries = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ıconPictureBox6 = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHome = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMap = new Guna.UI2.WinForms.Guna2Button();
            this.BtnOverview = new Guna.UI2.WinForms.Guna2Button();
            this.BtnGraphhics = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSimCam = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.srlPortGelen = new System.IO.Ports.SerialPort(this.components);
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtSbtPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSbtPort2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.ıconPictureBox8 = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ıconPictureBox9 = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPaNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.ıconPictureBox10 = new FontAwesome.Sharp.IconPictureBox();
            this.txtSbtSpeed = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ıconPictureBox11 = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.overview1 = new SamsunSpaceSystems.Overview();
            this.telemetries1 = new SamsunSpaceSystems.Telemetries();
            this.home1 = new SamsunSpaceSystems.Home();
            this.graphics1 = new SamsunSpaceSystems.Graphics();
            this.simCam1 = new SamsunSpaceSystems.SimCam();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox11)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2CirclePictureBox1, "guna2CirclePictureBox1");
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // BtnTelemetries
            // 
            this.BtnTelemetries.Animated = true;
            this.BtnTelemetries.AnimatedGIF = true;
            this.BtnTelemetries.AutoRoundedCorners = true;
            this.BtnTelemetries.BackColor = System.Drawing.Color.Transparent;
            this.BtnTelemetries.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnTelemetries.BorderRadius = 36;
            this.BtnTelemetries.Checked = true;
            this.BtnTelemetries.CheckedState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnTelemetries.CheckedState.CustomBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnTelemetries.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.BtnTelemetries.CheckedState.ForeColor = System.Drawing.Color.GhostWhite;
            this.BtnTelemetries.CheckedState.Parent = this.BtnTelemetries;
            this.BtnTelemetries.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnTelemetries.CustomImages.Parent = this.BtnTelemetries;
            this.BtnTelemetries.FillColor = System.Drawing.Color.DarkSlateBlue;
            resources.ApplyResources(this.BtnTelemetries, "BtnTelemetries");
            this.BtnTelemetries.ForeColor = System.Drawing.Color.White;
            this.BtnTelemetries.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnTelemetries.HoverState.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.BtnTelemetries.HoverState.Parent = this.BtnTelemetries;
            this.BtnTelemetries.Name = "BtnTelemetries";
            this.BtnTelemetries.PressedColor = System.Drawing.Color.SlateBlue;
            this.BtnTelemetries.ShadowDecoration.Parent = this.BtnTelemetries;
            this.BtnTelemetries.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnTelemetries.Click += new System.EventHandler(this.BtnTelemetries_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel1, "guna2HtmlLabel1");
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Yellow;
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2HtmlLabel2, "guna2HtmlLabel2");
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Yellow;
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            // 
            // ıconPictureBox6
            // 
            this.ıconPictureBox6.BackColor = System.Drawing.Color.Indigo;
            this.ıconPictureBox6.ForeColor = System.Drawing.Color.Gold;
            this.ıconPictureBox6.IconChar = FontAwesome.Sharp.IconChar.MapMarkerAlt;
            this.ıconPictureBox6.IconColor = System.Drawing.Color.Gold;
            this.ıconPictureBox6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox6.IconSize = 42;
            resources.ApplyResources(this.ıconPictureBox6, "ıconPictureBox6");
            this.ıconPictureBox6.Name = "ıconPictureBox6";
            this.ıconPictureBox6.TabStop = false;
            // 
            // ıconPictureBox5
            // 
            this.ıconPictureBox5.BackColor = System.Drawing.Color.Indigo;
            this.ıconPictureBox5.ForeColor = System.Drawing.Color.Gold;
            this.ıconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.ıconPictureBox5.IconColor = System.Drawing.Color.Gold;
            this.ıconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox5.IconSize = 36;
            resources.ApplyResources(this.ıconPictureBox5, "ıconPictureBox5");
            this.ıconPictureBox5.Name = "ıconPictureBox5";
            this.ıconPictureBox5.TabStop = false;
            // 
            // ıconPictureBox4
            // 
            this.ıconPictureBox4.BackColor = System.Drawing.Color.Indigo;
            this.ıconPictureBox4.ForeColor = System.Drawing.Color.Gold;
            this.ıconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.ıconPictureBox4.IconColor = System.Drawing.Color.Gold;
            this.ıconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox4.IconSize = 36;
            resources.ApplyResources(this.ıconPictureBox4, "ıconPictureBox4");
            this.ıconPictureBox4.Name = "ıconPictureBox4";
            this.ıconPictureBox4.TabStop = false;
            // 
            // ıconPictureBox3
            // 
            this.ıconPictureBox3.BackColor = System.Drawing.Color.Indigo;
            this.ıconPictureBox3.ForeColor = System.Drawing.Color.Gold;
            this.ıconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Rocket;
            this.ıconPictureBox3.IconColor = System.Drawing.Color.Gold;
            this.ıconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox3.IconSize = 38;
            resources.ApplyResources(this.ıconPictureBox3, "ıconPictureBox3");
            this.ıconPictureBox3.Name = "ıconPictureBox3";
            this.ıconPictureBox3.TabStop = false;
            // 
            // ıconPictureBox2
            // 
            this.ıconPictureBox2.BackColor = System.Drawing.Color.Indigo;
            this.ıconPictureBox2.ForeColor = System.Drawing.Color.Gold;
            this.ıconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Server;
            this.ıconPictureBox2.IconColor = System.Drawing.Color.Gold;
            this.ıconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox2.IconSize = 41;
            resources.ApplyResources(this.ıconPictureBox2, "ıconPictureBox2");
            this.ıconPictureBox2.Name = "ıconPictureBox2";
            this.ıconPictureBox2.TabStop = false;
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.Indigo;
            this.ıconPictureBox1.ForeColor = System.Drawing.Color.Gold;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ıconPictureBox1.IconColor = System.Drawing.Color.Gold;
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 38;
            resources.ApplyResources(this.ıconPictureBox1, "ıconPictureBox1");
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Name = "label1";
            // 
            // BtnHome
            // 
            this.BtnHome.Animated = true;
            this.BtnHome.AnimatedGIF = true;
            this.BtnHome.AutoRoundedCorners = true;
            this.BtnHome.BackColor = System.Drawing.Color.Transparent;
            this.BtnHome.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnHome.BorderRadius = 37;
            this.BtnHome.Checked = true;
            this.BtnHome.CheckedState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnHome.CheckedState.CustomBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnHome.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.BtnHome.CheckedState.ForeColor = System.Drawing.Color.GhostWhite;
            this.BtnHome.CheckedState.Parent = this.BtnHome;
            this.BtnHome.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnHome.CustomImages.Parent = this.BtnHome;
            this.BtnHome.FillColor = System.Drawing.Color.DarkSlateBlue;
            resources.ApplyResources(this.BtnHome, "BtnHome");
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnHome.HoverState.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.BtnHome.HoverState.Parent = this.BtnHome;
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.PressedColor = System.Drawing.Color.SlateBlue;
            this.BtnHome.ShadowDecoration.Parent = this.BtnHome;
            this.BtnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnHome.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // BtnMap
            // 
            this.BtnMap.Animated = true;
            this.BtnMap.AnimatedGIF = true;
            this.BtnMap.AutoRoundedCorners = true;
            this.BtnMap.BackColor = System.Drawing.Color.Transparent;
            this.BtnMap.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnMap.BorderRadius = 33;
            this.BtnMap.Checked = true;
            this.BtnMap.CheckedState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnMap.CheckedState.CustomBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnMap.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.BtnMap.CheckedState.ForeColor = System.Drawing.Color.GhostWhite;
            this.BtnMap.CheckedState.Parent = this.BtnMap;
            this.BtnMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnMap.CustomImages.Parent = this.BtnMap;
            this.BtnMap.FillColor = System.Drawing.Color.DarkSlateBlue;
            resources.ApplyResources(this.BtnMap, "BtnMap");
            this.BtnMap.ForeColor = System.Drawing.Color.White;
            this.BtnMap.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnMap.HoverState.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.BtnMap.HoverState.Parent = this.BtnMap;
            this.BtnMap.Name = "BtnMap";
            this.BtnMap.PressedColor = System.Drawing.Color.SlateBlue;
            this.BtnMap.ShadowDecoration.Parent = this.BtnMap;
            this.BtnMap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnMap.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // BtnOverview
            // 
            this.BtnOverview.Animated = true;
            this.BtnOverview.AnimatedGIF = true;
            this.BtnOverview.AutoRoundedCorners = true;
            this.BtnOverview.BackColor = System.Drawing.Color.Transparent;
            this.BtnOverview.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnOverview.BorderRadius = 36;
            this.BtnOverview.Checked = true;
            this.BtnOverview.CheckedState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnOverview.CheckedState.CustomBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnOverview.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.BtnOverview.CheckedState.ForeColor = System.Drawing.Color.GhostWhite;
            this.BtnOverview.CheckedState.Parent = this.BtnOverview;
            this.BtnOverview.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnOverview.CustomImages.Parent = this.BtnOverview;
            this.BtnOverview.FillColor = System.Drawing.Color.DarkSlateBlue;
            resources.ApplyResources(this.BtnOverview, "BtnOverview");
            this.BtnOverview.ForeColor = System.Drawing.Color.White;
            this.BtnOverview.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnOverview.HoverState.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.BtnOverview.HoverState.Parent = this.BtnOverview;
            this.BtnOverview.Name = "BtnOverview";
            this.BtnOverview.PressedColor = System.Drawing.Color.SlateBlue;
            this.BtnOverview.ShadowDecoration.Parent = this.BtnOverview;
            this.BtnOverview.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnOverview.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // BtnGraphhics
            // 
            this.BtnGraphhics.Animated = true;
            this.BtnGraphhics.AnimatedGIF = true;
            this.BtnGraphhics.AutoRoundedCorners = true;
            this.BtnGraphhics.BackColor = System.Drawing.Color.Transparent;
            this.BtnGraphhics.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnGraphhics.BorderRadius = 38;
            this.BtnGraphhics.Checked = true;
            this.BtnGraphhics.CheckedState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnGraphhics.CheckedState.CustomBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnGraphhics.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.BtnGraphhics.CheckedState.ForeColor = System.Drawing.Color.GhostWhite;
            this.BtnGraphhics.CheckedState.Parent = this.BtnGraphhics;
            this.BtnGraphhics.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnGraphhics.CustomImages.Parent = this.BtnGraphhics;
            this.BtnGraphhics.FillColor = System.Drawing.Color.DarkSlateBlue;
            resources.ApplyResources(this.BtnGraphhics, "BtnGraphhics");
            this.BtnGraphhics.ForeColor = System.Drawing.Color.White;
            this.BtnGraphhics.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnGraphhics.HoverState.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.BtnGraphhics.HoverState.Parent = this.BtnGraphhics;
            this.BtnGraphhics.Name = "BtnGraphhics";
            this.BtnGraphhics.PressedColor = System.Drawing.Color.SlateBlue;
            this.BtnGraphhics.ShadowDecoration.Parent = this.BtnGraphhics;
            this.BtnGraphhics.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnGraphhics.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // BtnSimCam
            // 
            this.BtnSimCam.Animated = true;
            this.BtnSimCam.AnimatedGIF = true;
            this.BtnSimCam.AutoRoundedCorners = true;
            this.BtnSimCam.BackColor = System.Drawing.Color.Transparent;
            this.BtnSimCam.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnSimCam.BorderRadius = 36;
            this.BtnSimCam.Checked = true;
            this.BtnSimCam.CheckedState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnSimCam.CheckedState.CustomBorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnSimCam.CheckedState.FillColor = System.Drawing.Color.Indigo;
            this.BtnSimCam.CheckedState.ForeColor = System.Drawing.Color.GhostWhite;
            this.BtnSimCam.CheckedState.Parent = this.BtnSimCam;
            this.BtnSimCam.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnSimCam.CustomImages.Parent = this.BtnSimCam;
            this.BtnSimCam.FillColor = System.Drawing.Color.DarkSlateBlue;
            resources.ApplyResources(this.BtnSimCam, "BtnSimCam");
            this.BtnSimCam.ForeColor = System.Drawing.Color.White;
            this.BtnSimCam.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnSimCam.HoverState.CustomBorderColor = System.Drawing.Color.SlateBlue;
            this.BtnSimCam.HoverState.Parent = this.BtnSimCam;
            this.BtnSimCam.Name = "BtnSimCam";
            this.BtnSimCam.PressedColor = System.Drawing.Color.SlateBlue;
            this.BtnSimCam.ShadowDecoration.Parent = this.BtnSimCam;
            this.BtnSimCam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnSimCam.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ıconPictureBox6);
            this.panel1.Controls.Add(this.ıconPictureBox5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ıconPictureBox4);
            this.panel1.Controls.Add(this.ıconPictureBox3);
            this.panel1.Controls.Add(this.ıconPictureBox2);
            this.panel1.Controls.Add(this.BtnMap);
            this.panel1.Controls.Add(this.BtnTelemetries);
            this.panel1.Controls.Add(this.BtnGraphhics);
            this.panel1.Controls.Add(this.BtnSimCam);
            this.panel1.Controls.Add(this.BtnOverview);
            this.panel1.Controls.Add(this.ıconPictureBox1);
            this.panel1.Controls.Add(this.BtnHome);
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // srlPortGelen
            // 
            this.srlPortGelen.PortName = "COM7";
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Enabled = true;
            this.tmrRefresh.Interval = 1000;
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Name = "label3";
            // 
            // txtSbtPort
            // 
            this.txtSbtPort.Animated = true;
            this.txtSbtPort.BorderThickness = 0;
            this.txtSbtPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSbtPort.DefaultText = "";
            this.txtSbtPort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSbtPort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSbtPort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSbtPort.DisabledState.Parent = this.txtSbtPort;
            this.txtSbtPort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSbtPort.FillColor = System.Drawing.Color.LemonChiffon;
            this.txtSbtPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSbtPort.FocusedState.Parent = this.txtSbtPort;
            resources.ApplyResources(this.txtSbtPort, "txtSbtPort");
            this.txtSbtPort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSbtPort.HoverState.Parent = this.txtSbtPort;
            this.txtSbtPort.Name = "txtSbtPort";
            this.txtSbtPort.PasswordChar = '\0';
            this.txtSbtPort.PlaceholderText = "";
            this.txtSbtPort.SelectedText = "";
            this.txtSbtPort.ShadowDecoration.Parent = this.txtSbtPort;
            // 
            // txtSbtPort2
            // 
            this.txtSbtPort2.Animated = true;
            this.txtSbtPort2.BorderThickness = 0;
            this.txtSbtPort2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSbtPort2.DefaultText = "";
            this.txtSbtPort2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSbtPort2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSbtPort2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSbtPort2.DisabledState.Parent = this.txtSbtPort2;
            this.txtSbtPort2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSbtPort2.FillColor = System.Drawing.Color.LemonChiffon;
            this.txtSbtPort2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSbtPort2.FocusedState.Parent = this.txtSbtPort2;
            resources.ApplyResources(this.txtSbtPort2, "txtSbtPort2");
            this.txtSbtPort2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSbtPort2.HoverState.Parent = this.txtSbtPort2;
            this.txtSbtPort2.Name = "txtSbtPort2";
            this.txtSbtPort2.PasswordChar = '\0';
            this.txtSbtPort2.PlaceholderText = "";
            this.txtSbtPort2.SelectedText = "";
            this.txtSbtPort2.ShadowDecoration.Parent = this.txtSbtPort2;
            // 
            // ıconPictureBox8
            // 
            this.ıconPictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.ıconPictureBox8.ForeColor = System.Drawing.Color.Gold;
            this.ıconPictureBox8.IconChar = FontAwesome.Sharp.IconChar.TachometerAlt;
            this.ıconPictureBox8.IconColor = System.Drawing.Color.Gold;
            this.ıconPictureBox8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            resources.ApplyResources(this.ıconPictureBox8, "ıconPictureBox8");
            this.ıconPictureBox8.Name = "ıconPictureBox8";
            this.ıconPictureBox8.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Name = "label4";
            // 
            // ıconPictureBox9
            // 
            this.ıconPictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.ıconPictureBox9.ForeColor = System.Drawing.Color.Gold;
            this.ıconPictureBox9.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp;
            this.ıconPictureBox9.IconColor = System.Drawing.Color.Gold;
            this.ıconPictureBox9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            resources.ApplyResources(this.ıconPictureBox9, "ıconPictureBox9");
            this.ıconPictureBox9.Name = "ıconPictureBox9";
            this.ıconPictureBox9.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Name = "label6";
            // 
            // txtPaNo
            // 
            this.txtPaNo.Animated = true;
            this.txtPaNo.BorderThickness = 0;
            this.txtPaNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPaNo.DefaultText = "";
            this.txtPaNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPaNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPaNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaNo.DisabledState.Parent = this.txtPaNo;
            this.txtPaNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPaNo.FillColor = System.Drawing.Color.LemonChiffon;
            this.txtPaNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaNo.FocusedState.Parent = this.txtPaNo;
            resources.ApplyResources(this.txtPaNo, "txtPaNo");
            this.txtPaNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPaNo.HoverState.Parent = this.txtPaNo;
            this.txtPaNo.Name = "txtPaNo";
            this.txtPaNo.PasswordChar = '\0';
            this.txtPaNo.PlaceholderText = "";
            this.txtPaNo.SelectedText = "";
            this.txtPaNo.ShadowDecoration.Parent = this.txtPaNo;
            // 
            // ıconPictureBox10
            // 
            this.ıconPictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.ıconPictureBox10.ForeColor = System.Drawing.Color.Gold;
            this.ıconPictureBox10.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.ıconPictureBox10.IconColor = System.Drawing.Color.Gold;
            this.ıconPictureBox10.IconFont = FontAwesome.Sharp.IconFont.Auto;
            resources.ApplyResources(this.ıconPictureBox10, "ıconPictureBox10");
            this.ıconPictureBox10.Name = "ıconPictureBox10";
            this.ıconPictureBox10.TabStop = false;
            // 
            // txtSbtSpeed
            // 
            this.txtSbtSpeed.Animated = true;
            this.txtSbtSpeed.BorderThickness = 0;
            this.txtSbtSpeed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSbtSpeed.DefaultText = "";
            this.txtSbtSpeed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSbtSpeed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSbtSpeed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSbtSpeed.DisabledState.Parent = this.txtSbtSpeed;
            this.txtSbtSpeed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSbtSpeed.FillColor = System.Drawing.Color.LemonChiffon;
            this.txtSbtSpeed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSbtSpeed.FocusedState.Parent = this.txtSbtSpeed;
            resources.ApplyResources(this.txtSbtSpeed, "txtSbtSpeed");
            this.txtSbtSpeed.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSbtSpeed.HoverState.Parent = this.txtSbtSpeed;
            this.txtSbtSpeed.Name = "txtSbtSpeed";
            this.txtSbtSpeed.PasswordChar = '\0';
            this.txtSbtSpeed.PlaceholderText = "";
            this.txtSbtSpeed.SelectedText = "";
            this.txtSbtSpeed.ShadowDecoration.Parent = this.txtSbtSpeed;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.guna2Button1, "guna2Button1");
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.BorderRadius = 0;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Name = "label5";
            // 
            // ıconPictureBox11
            // 
            this.ıconPictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.ıconPictureBox11.ForeColor = System.Drawing.Color.Gold;
            this.ıconPictureBox11.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp;
            this.ıconPictureBox11.IconColor = System.Drawing.Color.Gold;
            this.ıconPictureBox11.IconFont = FontAwesome.Sharp.IconFont.Auto;
            resources.ApplyResources(this.ıconPictureBox11, "ıconPictureBox11");
            this.ıconPictureBox11.Name = "ıconPictureBox11";
            this.ıconPictureBox11.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.ıconPictureBox11);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.guna2Button1);
            this.panel3.Controls.Add(this.txtSbtSpeed);
            this.panel3.Controls.Add(this.ıconPictureBox10);
            this.panel3.Controls.Add(this.txtPaNo);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.ıconPictureBox9);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.ıconPictureBox8);
            this.panel3.Controls.Add(this.txtSbtPort2);
            this.panel3.Controls.Add(this.txtSbtPort);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Name = "panel3";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // overview1
            // 
            resources.ApplyResources(this.overview1, "overview1");
            this.overview1.Name = "overview1";
            // 
            // telemetries1
            // 
            this.telemetries1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.telemetries1, "telemetries1");
            this.telemetries1.Name = "telemetries1";
            // 
            // home1
            // 
            this.home1.BackColor = System.Drawing.Color.MediumSlateBlue;
            resources.ApplyResources(this.home1, "home1");
            this.home1.Name = "home1";
            // 
            // graphics1
            // 
            resources.ApplyResources(this.graphics1, "graphics1");
            this.graphics1.Name = "graphics1";
            // 
            // simCam1
            // 
            resources.ApplyResources(this.simCam1, "simCam1");
            this.simCam1.Name = "simCam1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Controls.Add(this.overview1);
            this.Controls.Add(this.telemetries1);
            this.Controls.Add(this.home1);
            this.Controls.Add(this.graphics1);
            this.Controls.Add(this.simCam1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox11)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button BtnTelemetries;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button BtnHome;
        private Guna.UI2.WinForms.Guna2Button BtnMap;
        private Guna.UI2.WinForms.Guna2Button BtnOverview;
        private Guna.UI2.WinForms.Guna2Button BtnGraphhics;
        private Guna.UI2.WinForms.Guna2Button BtnSimCam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox6;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox5;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer tmrRefresh;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtSbtPort;
        private Guna.UI2.WinForms.Guna2TextBox txtSbtPort2;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox8;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox9;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtPaNo;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox10;
        private Guna.UI2.WinForms.Guna2TextBox txtSbtSpeed;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox11;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private SimCam simCam1;
        private Graphics graphics1;
        private Home home1;
        private Telemetries telemetries1;
        private Overview overview1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        public System.IO.Ports.SerialPort srlPortGelen;
    }
}

