namespace TranfBCPopularCouder
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.panelFooter = new System.Windows.Forms.Panel();
            this.lblCurrentVersion = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMenu2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelFooter.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.SteelBlue;
            this.panelFooter.Controls.Add(this.lblCurrentVersion);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 579);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(802, 20);
            this.panelFooter.TabIndex = 0;
            this.panelFooter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelFooter_MouseDown);
            this.panelFooter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelFooter_MouseMove);
            this.panelFooter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelFooter_MouseUp);
            // 
            // lblCurrentVersion
            // 
            this.lblCurrentVersion.AutoSize = true;
            this.lblCurrentVersion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentVersion.Location = new System.Drawing.Point(3, 3);
            this.lblCurrentVersion.Name = "lblCurrentVersion";
            this.lblCurrentVersion.Size = new System.Drawing.Size(66, 15);
            this.lblCurrentVersion.TabIndex = 0;
            this.lblCurrentVersion.Text = "Versión 1.0";
            this.lblCurrentVersion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCurrentVersion_MouseDown);
            this.lblCurrentVersion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblCurrentVersion_MouseMove);
            this.lblCurrentVersion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblCurrentVersion_MouseUp);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelMenu.Controls.Add(this.btnMenu2);
            this.panelMenu.Controls.Add(this.btnMenu1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 104);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(185, 475);
            this.panelMenu.TabIndex = 2;
            // 
            // btnMenu2
            // 
            this.btnMenu2.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.btnMenu2.BackColor = System.Drawing.Color.DarkGray;
            this.btnMenu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenu2.BorderRadius = 0;
            this.btnMenu2.ButtonText = "Configuraciones";
            this.btnMenu2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu2.DisabledColor = System.Drawing.Color.LightSteelBlue;
            this.btnMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu2.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenu2.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenu2.Iconimage")));
            this.btnMenu2.Iconimage_right = null;
            this.btnMenu2.Iconimage_right_Selected = null;
            this.btnMenu2.Iconimage_Selected = null;
            this.btnMenu2.IconMarginLeft = 0;
            this.btnMenu2.IconMarginRight = 0;
            this.btnMenu2.IconRightVisible = true;
            this.btnMenu2.IconRightZoom = 0D;
            this.btnMenu2.IconVisible = true;
            this.btnMenu2.IconZoom = 90D;
            this.btnMenu2.IsTab = false;
            this.btnMenu2.Location = new System.Drawing.Point(0, 52);
            this.btnMenu2.Name = "btnMenu2";
            this.btnMenu2.Normalcolor = System.Drawing.Color.DarkGray;
            this.btnMenu2.OnHovercolor = System.Drawing.Color.Gray;
            this.btnMenu2.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenu2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMenu2.selected = false;
            this.btnMenu2.Size = new System.Drawing.Size(185, 52);
            this.btnMenu2.TabIndex = 4;
            this.btnMenu2.Text = "Configuraciones";
            this.btnMenu2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu2.Textcolor = System.Drawing.Color.White;
            this.btnMenu2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu2.Click += new System.EventHandler(this.btnMenu2_Click);
            // 
            // btnMenu1
            // 
            this.btnMenu1.Activecolor = System.Drawing.Color.LightSteelBlue;
            this.btnMenu1.BackColor = System.Drawing.Color.DarkGray;
            this.btnMenu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenu1.BorderRadius = 0;
            this.btnMenu1.ButtonText = "Codificar";
            this.btnMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu1.DisabledColor = System.Drawing.Color.LightSteelBlue;
            this.btnMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu1.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenu1.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenu1.Iconimage")));
            this.btnMenu1.Iconimage_right = null;
            this.btnMenu1.Iconimage_right_Selected = null;
            this.btnMenu1.Iconimage_Selected = null;
            this.btnMenu1.IconMarginLeft = 0;
            this.btnMenu1.IconMarginRight = 0;
            this.btnMenu1.IconRightVisible = true;
            this.btnMenu1.IconRightZoom = 0D;
            this.btnMenu1.IconVisible = true;
            this.btnMenu1.IconZoom = 90D;
            this.btnMenu1.IsTab = false;
            this.btnMenu1.Location = new System.Drawing.Point(0, 0);
            this.btnMenu1.Name = "btnMenu1";
            this.btnMenu1.Normalcolor = System.Drawing.Color.DarkGray;
            this.btnMenu1.OnHovercolor = System.Drawing.Color.Gray;
            this.btnMenu1.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMenu1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMenu1.selected = false;
            this.btnMenu1.Size = new System.Drawing.Size(185, 52);
            this.btnMenu1.TabIndex = 3;
            this.btnMenu1.Text = "Codificar";
            this.btnMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu1.Textcolor = System.Drawing.Color.White;
            this.btnMenu1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu1.Click += new System.EventHandler(this.btnMenu1_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.SteelBlue;
            this.panelHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHeader.BackgroundImage")));
            this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.bunifuThinButton21);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(802, 104);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.panelHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Gray;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.SteelBlue;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "--";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.Location = new System.Drawing.Point(716, 13);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(41, 28);
            this.bunifuThinButton21.TabIndex = 3;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 1;
            this.btnClose.ActiveCornerRadius = 20;
            this.btnClose.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnClose.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = "X";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnClose.IdleForecolor = System.Drawing.Color.Black;
            this.btnClose.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(754, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 599);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenu1;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenu2;
        private System.Windows.Forms.Label lblCurrentVersion;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
    }
}

