﻿namespace GAMEMODE
{
    partial class Main_Form
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            button_desktopmode = new Guna.UI2.WinForms.Guna2Button();
            guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(components);
            guna2TaskBarProgress1 = new Guna.UI2.WinForms.Guna2TaskBarProgress(components);
            guna2ProgressBardesktop_mode = new Guna.UI2.WinForms.Guna2ProgressBar();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            button_gamingmode = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            label_activated = new Guna.UI2.WinForms.Guna2HtmlLabel();
            timer = new System.Windows.Forms.Timer(components);
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            button_app_close = new Guna.UI2.WinForms.Guna2Button();
            label_version = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 30;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // button_desktopmode
            // 
            button_desktopmode.Animated = true;
            button_desktopmode.BackColor = Color.Transparent;
            button_desktopmode.BorderColor = Color.DimGray;
            button_desktopmode.BorderRadius = 10;
            button_desktopmode.BorderThickness = 2;
            button_desktopmode.CustomizableEdges = customizableEdges9;
            button_desktopmode.DisabledState.BorderColor = Color.DarkGray;
            button_desktopmode.DisabledState.CustomBorderColor = Color.DarkGray;
            button_desktopmode.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_desktopmode.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_desktopmode.FillColor = SystemColors.ActiveBorder;
            button_desktopmode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_desktopmode.ForeColor = SystemColors.ButtonHighlight;
            button_desktopmode.HoverState.FillColor = Color.Gray;
            button_desktopmode.Image = (Image)resources.GetObject("button_desktopmode.Image");
            button_desktopmode.ImageSize = new Size(50, 50);
            button_desktopmode.Location = new Point(28, 75);
            button_desktopmode.Name = "button_desktopmode";
            button_desktopmode.ShadowDecoration.CustomizableEdges = customizableEdges10;
            button_desktopmode.Size = new Size(228, 70);
            button_desktopmode.TabIndex = 0;
            button_desktopmode.Text = "DESKTOP MODE";
            button_desktopmode.Click += button_desktopmode_Click;
            // 
            // guna2ResizeForm1
            // 
            guna2ResizeForm1.TargetForm = this;
            // 
            // guna2TaskBarProgress1
            // 
            guna2TaskBarProgress1.TargetForm = null;
            // 
            // guna2ProgressBardesktop_mode
            // 
            guna2ProgressBardesktop_mode.AutoRoundedCorners = true;
            guna2ProgressBardesktop_mode.BackColor = Color.Transparent;
            guna2ProgressBardesktop_mode.BorderRadius = 7;
            guna2ProgressBardesktop_mode.CustomizableEdges = customizableEdges1;
            guna2ProgressBardesktop_mode.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            guna2ProgressBardesktop_mode.Location = new Point(28, 208);
            guna2ProgressBardesktop_mode.Maximum = 30;
            guna2ProgressBardesktop_mode.Name = "guna2ProgressBardesktop_mode";
            guna2ProgressBardesktop_mode.ProgressColor = Color.FromArgb(255, 128, 255);
            guna2ProgressBardesktop_mode.ProgressColor2 = Color.FromArgb(192, 0, 192);
            guna2ProgressBardesktop_mode.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ProgressBardesktop_mode.ShadowDecoration.Depth = 60;
            guna2ProgressBardesktop_mode.ShowText = true;
            guna2ProgressBardesktop_mode.Size = new Size(491, 16);
            guna2ProgressBardesktop_mode.Style = ProgressBarStyle.Continuous;
            guna2ProgressBardesktop_mode.TabIndex = 2;
            guna2ProgressBardesktop_mode.Text = "guna2ProgressBar1";
            guna2ProgressBardesktop_mode.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2AnimateWindow1
            // 
            guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_ACTIVATE;
            guna2AnimateWindow1.TargetForm = this;
            // 
            // button_gamingmode
            // 
            button_gamingmode.Animated = true;
            button_gamingmode.BackColor = Color.Transparent;
            button_gamingmode.BorderColor = Color.DimGray;
            button_gamingmode.BorderRadius = 10;
            button_gamingmode.BorderThickness = 2;
            button_gamingmode.CustomizableEdges = customizableEdges7;
            button_gamingmode.DisabledState.BorderColor = Color.DarkGray;
            button_gamingmode.DisabledState.CustomBorderColor = Color.DarkGray;
            button_gamingmode.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_gamingmode.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_gamingmode.FillColor = SystemColors.ActiveBorder;
            button_gamingmode.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_gamingmode.ForeColor = SystemColors.ButtonHighlight;
            button_gamingmode.HoverState.FillColor = Color.Gray;
            button_gamingmode.Image = (Image)resources.GetObject("button_gamingmode.Image");
            button_gamingmode.ImageSize = new Size(50, 50);
            button_gamingmode.Location = new Point(291, 75);
            button_gamingmode.Name = "button_gamingmode";
            button_gamingmode.ShadowDecoration.CustomizableEdges = customizableEdges8;
            button_gamingmode.Size = new Size(228, 70);
            button_gamingmode.TabIndex = 3;
            button_gamingmode.Text = "GAMING MODE";
            button_gamingmode.Click += button_gamingmode_Click;
            // 
            // guna2HtmlToolTip1
            // 
            guna2HtmlToolTip1.AllowLinksHandling = true;
            guna2HtmlToolTip1.MaximumSize = new Size(0, 0);
            // 
            // label_activated
            // 
            label_activated.BackColor = Color.Transparent;
            label_activated.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_activated.ForeColor = SystemColors.ButtonHighlight;
            label_activated.Location = new Point(209, 169);
            label_activated.Name = "label_activated";
            label_activated.Size = new Size(122, 33);
            label_activated.TabIndex = 4;
            label_activated.Text = "XX Seconds";
            label_activated.UseGdiPlusTextRendering = true;
            label_activated.Visible = false;
            // 
            // guna2Button2
            // 
            guna2Button2.Animated = true;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderColor = Color.Gray;
            guna2Button2.BorderRadius = 10;
            guna2Button2.CustomizableEdges = customizableEdges5;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.Transparent;
            guna2Button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.DimGray;
            guna2Button2.HoverState.FillColor = Color.FromArgb(224, 224, 224);
            guna2Button2.Image = (Image)resources.GetObject("guna2Button2.Image");
            guna2Button2.ImageSize = new Size(30, 30);
            guna2Button2.Location = new Point(12, 7);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button2.Size = new Size(36, 39);
            guna2Button2.TabIndex = 5;
            guna2Button2.Click += guna2Button2_Click;
            // 
            // button_app_close
            // 
            button_app_close.Animated = true;
            button_app_close.BackColor = Color.Transparent;
            button_app_close.BorderColor = Color.Gray;
            button_app_close.BorderRadius = 10;
            button_app_close.CustomizableEdges = customizableEdges3;
            button_app_close.DisabledState.BorderColor = Color.DarkGray;
            button_app_close.DisabledState.CustomBorderColor = Color.DarkGray;
            button_app_close.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            button_app_close.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            button_app_close.FillColor = Color.Transparent;
            button_app_close.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_app_close.ForeColor = Color.DimGray;
            button_app_close.HoverState.FillColor = Color.FromArgb(224, 224, 224);
            button_app_close.Image = (Image)resources.GetObject("button_app_close.Image");
            button_app_close.ImageSize = new Size(30, 30);
            button_app_close.Location = new Point(492, 7);
            button_app_close.Name = "button_app_close";
            button_app_close.ShadowDecoration.CustomizableEdges = customizableEdges4;
            button_app_close.Size = new Size(36, 39);
            button_app_close.TabIndex = 6;
            button_app_close.Click += button_app_close_Click;
            // 
            // label_version
            // 
            label_version.BackColor = Color.Transparent;
            label_version.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label_version.ForeColor = SystemColors.ButtonHighlight;
            label_version.Location = new Point(58, 16);
            label_version.Name = "label_version";
            label_version.Size = new Size(50, 19);
            label_version.TabIndex = 7;
            label_version.Text = "Version: ";
            label_version.UseGdiPlusTextRendering = true;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(540, 240);
            Controls.Add(label_version);
            Controls.Add(label_activated);
            Controls.Add(guna2ProgressBardesktop_mode);
            Controls.Add(button_app_close);
            Controls.Add(guna2Button2);
            Controls.Add(button_gamingmode);
            Controls.Add(button_desktopmode);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Form";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button button_desktopmode;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBardesktop_mode;
        private Guna.UI2.WinForms.Guna2TaskBarProgress guna2TaskBarProgress1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Button button_gamingmode;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_activated;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button button_app_close;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_version;
    }
}