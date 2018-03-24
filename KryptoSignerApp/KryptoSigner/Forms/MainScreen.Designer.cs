namespace KryptoSignerApp.KryptoSigner.Forms
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.logoContainerPanel = new System.Windows.Forms.Panel();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.statusBarPanel = new System.Windows.Forms.Panel();
            this.subscriptionPanel = new System.Windows.Forms.Panel();
            this.settingsContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.websiteAddress = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.statusIndicatorText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.borderbottom = new System.Windows.Forms.Panel();
            this.yourecurrentlyon = new System.Windows.Forms.Label();
            this.currentPlan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.logoContainerPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.subscriptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1165, 633);
            this.mainPanel.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftPanel.Controls.Add(this.borderbottom);
            this.leftPanel.Controls.Add(this.panel2);
            this.leftPanel.Controls.Add(this.panel1);
            this.leftPanel.Controls.Add(this.statusBarPanel);
            this.leftPanel.Controls.Add(this.navigationPanel);
            this.leftPanel.Controls.Add(this.logoContainerPanel);
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(856, 633);
            this.leftPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.settingsContainer);
            this.rightPanel.Controls.Add(this.subscriptionPanel);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(855, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(310, 633);
            this.rightPanel.TabIndex = 1;
            // 
            // logoContainerPanel
            // 
            this.logoContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(229)))));
            this.logoContainerPanel.Controls.Add(this.websiteAddress);
            this.logoContainerPanel.Controls.Add(this.pictureBox1);
            this.logoContainerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.logoContainerPanel.Name = "logoContainerPanel";
            this.logoContainerPanel.Size = new System.Drawing.Size(856, 103);
            this.logoContainerPanel.TabIndex = 0;
            // 
            // navigationPanel
            // 
            this.navigationPanel.Controls.Add(this.statusIndicatorText);
            this.navigationPanel.Controls.Add(this.ProgressBar);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.navigationPanel.Location = new System.Drawing.Point(0, 103);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(253, 530);
            this.navigationPanel.TabIndex = 1;
            // 
            // statusBarPanel
            // 
            this.statusBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusBarPanel.Location = new System.Drawing.Point(253, 596);
            this.statusBarPanel.Name = "statusBarPanel";
            this.statusBarPanel.Size = new System.Drawing.Size(603, 37);
            this.statusBarPanel.TabIndex = 2;
            // 
            // subscriptionPanel
            // 
            this.subscriptionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(195)))), ((int)(((byte)(134)))));
            this.subscriptionPanel.Controls.Add(this.label1);
            this.subscriptionPanel.Controls.Add(this.currentPlan);
            this.subscriptionPanel.Controls.Add(this.yourecurrentlyon);
            this.subscriptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.subscriptionPanel.Location = new System.Drawing.Point(0, 0);
            this.subscriptionPanel.Name = "subscriptionPanel";
            this.subscriptionPanel.Size = new System.Drawing.Size(310, 103);
            this.subscriptionPanel.TabIndex = 0;
            // 
            // settingsContainer
            // 
            this.settingsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsContainer.Location = new System.Drawing.Point(0, 103);
            this.settingsContainer.Name = "settingsContainer";
            this.settingsContainer.Size = new System.Drawing.Size(310, 530);
            this.settingsContainer.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 73);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // websiteAddress
            // 
            this.websiteAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.websiteAddress.Font = new System.Drawing.Font("Roboto", 8F);
            this.websiteAddress.ForeColor = System.Drawing.Color.White;
            this.websiteAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.websiteAddress.Location = new System.Drawing.Point(617, 9);
            this.websiteAddress.Name = "websiteAddress";
            this.websiteAddress.Size = new System.Drawing.Size(198, 88);
            this.websiteAddress.TabIndex = 1;
            this.websiteAddress.Text = "www.kryptosigner.com";
            this.websiteAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(251)))));
            this.ProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(154)))), ((int)(((byte)(251)))));
            this.ProgressBar.Location = new System.Drawing.Point(12, 476);
            this.ProgressBar.MarqueeAnimationSpeed = 18;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(235, 3);
            this.ProgressBar.Step = 0;
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.Value = 100;
            // 
            // statusIndicatorText
            // 
            this.statusIndicatorText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusIndicatorText.Font = new System.Drawing.Font("Roboto Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusIndicatorText.Location = new System.Drawing.Point(3, 493);
            this.statusIndicatorText.Name = "statusIndicatorText";
            this.statusIndicatorText.Size = new System.Drawing.Size(244, 28);
            this.statusIndicatorText.TabIndex = 1;
            this.statusIndicatorText.Text = "No tasks running";
            this.statusIndicatorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(253, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 530);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(853, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 530);
            this.panel2.TabIndex = 4;
            // 
            // borderbottom
            // 
            this.borderbottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borderbottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(229)))));
            this.borderbottom.Location = new System.Drawing.Point(256, 594);
            this.borderbottom.Name = "borderbottom";
            this.borderbottom.Size = new System.Drawing.Size(598, 2);
            this.borderbottom.TabIndex = 5;
            // 
            // yourecurrentlyon
            // 
            this.yourecurrentlyon.AutoSize = true;
            this.yourecurrentlyon.Font = new System.Drawing.Font("Roboto", 11F);
            this.yourecurrentlyon.ForeColor = System.Drawing.Color.White;
            this.yourecurrentlyon.Location = new System.Drawing.Point(8, 4);
            this.yourecurrentlyon.Name = "yourecurrentlyon";
            this.yourecurrentlyon.Size = new System.Drawing.Size(163, 23);
            this.yourecurrentlyon.TabIndex = 0;
            this.yourecurrentlyon.Text = "You\'re currently on";
            // 
            // currentPlan
            // 
            this.currentPlan.Font = new System.Drawing.Font("Roboto", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.currentPlan.ForeColor = System.Drawing.Color.White;
            this.currentPlan.Location = new System.Drawing.Point(6, 27);
            this.currentPlan.Margin = new System.Windows.Forms.Padding(0);
            this.currentPlan.Name = "currentPlan";
            this.currentPlan.Size = new System.Drawing.Size(286, 45);
            this.currentPlan.TabIndex = 1;
            this.currentPlan.Text = "Pay as you go";
            this.currentPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Font Awesome 5 Free", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1165, 633);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.mainPanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.logoContainerPanel.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.subscriptionPanel.ResumeLayout(false);
            this.subscriptionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel statusBarPanel;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Panel logoContainerPanel;
        private System.Windows.Forms.Panel settingsContainer;
        private System.Windows.Forms.Panel subscriptionPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label websiteAddress;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label statusIndicatorText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel borderbottom;
        private System.Windows.Forms.Label yourecurrentlyon;
        private System.Windows.Forms.Label currentPlan;
        private System.Windows.Forms.Label label1;
    }
}