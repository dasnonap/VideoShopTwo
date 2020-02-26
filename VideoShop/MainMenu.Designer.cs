namespace VideoShop
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.showOptionRadio = new System.Windows.Forms.RadioButton();
            this.showSeriesRadio = new System.Windows.Forms.RadioButton();
            this.showCatRadio = new System.Windows.Forms.RadioButton();
            this.showLibRadio = new System.Windows.Forms.RadioButton();
            this.showBegginingRadio = new System.Windows.Forms.RadioButton();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userInfoButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.beginingPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.libraryPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.catPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.beginingPanel.SuspendLayout();
            this.libraryPanel.SuspendLayout();
            this.catPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.showOptionRadio);
            this.menuPanel.Controls.Add(this.showSeriesRadio);
            this.menuPanel.Controls.Add(this.showCatRadio);
            this.menuPanel.Controls.Add(this.showLibRadio);
            this.menuPanel.Controls.Add(this.showBegginingRadio);
            this.menuPanel.Controls.Add(this.userNameLabel);
            this.menuPanel.Controls.Add(this.userInfoButton);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(171, 620);
            this.menuPanel.TabIndex = 0;
            // 
            // showOptionRadio
            // 
            this.showOptionRadio.AutoSize = true;
            this.showOptionRadio.FlatAppearance.BorderSize = 0;
            this.showOptionRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showOptionRadio.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showOptionRadio.Location = new System.Drawing.Point(3, 276);
            this.showOptionRadio.Name = "showOptionRadio";
            this.showOptionRadio.Size = new System.Drawing.Size(107, 32);
            this.showOptionRadio.TabIndex = 9;
            this.showOptionRadio.TabStop = true;
            this.showOptionRadio.Text = "Опции";
            this.showOptionRadio.UseVisualStyleBackColor = true;
            // 
            // showSeriesRadio
            // 
            this.showSeriesRadio.AutoSize = true;
            this.showSeriesRadio.FlatAppearance.BorderSize = 0;
            this.showSeriesRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSeriesRadio.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSeriesRadio.Location = new System.Drawing.Point(0, 226);
            this.showSeriesRadio.Name = "showSeriesRadio";
            this.showSeriesRadio.Size = new System.Drawing.Size(136, 32);
            this.showSeriesRadio.TabIndex = 8;
            this.showSeriesRadio.TabStop = true;
            this.showSeriesRadio.Text = "Сериали";
            this.showSeriesRadio.UseVisualStyleBackColor = true;
            // 
            // showCatRadio
            // 
            this.showCatRadio.AutoSize = true;
            this.showCatRadio.FlatAppearance.BorderSize = 0;
            this.showCatRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showCatRadio.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showCatRadio.Location = new System.Drawing.Point(0, 172);
            this.showCatRadio.Name = "showCatRadio";
            this.showCatRadio.Size = new System.Drawing.Size(157, 32);
            this.showCatRadio.TabIndex = 7;
            this.showCatRadio.TabStop = true;
            this.showCatRadio.Text = "Категории";
            this.showCatRadio.UseVisualStyleBackColor = true;
            this.showCatRadio.CheckedChanged += new System.EventHandler(this.showCatRadio_CheckedChanged);
            // 
            // showLibRadio
            // 
            this.showLibRadio.AutoSize = true;
            this.showLibRadio.FlatAppearance.BorderSize = 0;
            this.showLibRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showLibRadio.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showLibRadio.Location = new System.Drawing.Point(0, 124);
            this.showLibRadio.Name = "showLibRadio";
            this.showLibRadio.Size = new System.Drawing.Size(172, 32);
            this.showLibRadio.TabIndex = 6;
            this.showLibRadio.TabStop = true;
            this.showLibRadio.Text = "Библиотека";
            this.showLibRadio.UseVisualStyleBackColor = true;
            this.showLibRadio.CheckedChanged += new System.EventHandler(this.showLibRadio_CheckedChanged);
            // 
            // showBegginingRadio
            // 
            this.showBegginingRadio.AutoSize = true;
            this.showBegginingRadio.FlatAppearance.BorderSize = 0;
            this.showBegginingRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showBegginingRadio.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBegginingRadio.Location = new System.Drawing.Point(3, 76);
            this.showBegginingRadio.Name = "showBegginingRadio";
            this.showBegginingRadio.Size = new System.Drawing.Size(118, 32);
            this.showBegginingRadio.TabIndex = 0;
            this.showBegginingRadio.TabStop = true;
            this.showBegginingRadio.Text = "Начало";
            this.showBegginingRadio.UseVisualStyleBackColor = true;
            this.showBegginingRadio.CheckedChanged += new System.EventHandler(this.showBegginingRadio_CheckedChanged);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(47, 40);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(68, 16);
            this.userNameLabel.TabIndex = 5;
            this.userNameLabel.Text = "userName";
            // 
            // userInfoButton
            // 
            this.userInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userInfoButton.BackgroundImage")));
            this.userInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userInfoButton.FlatAppearance.BorderSize = 0;
            this.userInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userInfoButton.Location = new System.Drawing.Point(51, 2);
            this.userInfoButton.Name = "userInfoButton";
            this.userInfoButton.Size = new System.Drawing.Size(60, 35);
            this.userInfoButton.TabIndex = 4;
            this.userInfoButton.UseVisualStyleBackColor = true;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Controls.Add(this.minButton);
            this.topPanel.Location = new System.Drawing.Point(170, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(827, 56);
            this.topPanel.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(774, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(47, 18);
            this.exitButton.TabIndex = 3;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // minButton
            // 
            this.minButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minButton.BackgroundImage")));
            this.minButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minButton.FlatAppearance.BorderSize = 0;
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Location = new System.Drawing.Point(721, 0);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(47, 18);
            this.minButton.TabIndex = 2;
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // beginingPanel
            // 
            this.beginingPanel.Controls.Add(this.label1);
            this.beginingPanel.Location = new System.Drawing.Point(178, 62);
            this.beginingPanel.Name = "beginingPanel";
            this.beginingPanel.Size = new System.Drawing.Size(806, 546);
            this.beginingPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "start menu";
            // 
            // libraryPanel
            // 
            this.libraryPanel.Controls.Add(this.label2);
            this.libraryPanel.Location = new System.Drawing.Point(191, 76);
            this.libraryPanel.Name = "libraryPanel";
            this.libraryPanel.Size = new System.Drawing.Size(793, 532);
            this.libraryPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "library view";
            // 
            // catPanel
            // 
            this.catPanel.Controls.Add(this.label3);
            this.catPanel.Location = new System.Drawing.Point(181, 65);
            this.catPanel.Name = "catPanel";
            this.catPanel.Size = new System.Drawing.Size(803, 540);
            this.catPanel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "category";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 620);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.beginingPanel);
            this.Controls.Add(this.catPanel);
            this.Controls.Add(this.libraryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.beginingPanel.ResumeLayout(false);
            this.beginingPanel.PerformLayout();
            this.libraryPanel.ResumeLayout(false);
            this.libraryPanel.PerformLayout();
            this.catPanel.ResumeLayout(false);
            this.catPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button userInfoButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Panel beginingPanel;
        private System.Windows.Forms.RadioButton showBegginingRadio;
        private System.Windows.Forms.RadioButton showOptionRadio;
        private System.Windows.Forms.RadioButton showSeriesRadio;
        private System.Windows.Forms.RadioButton showCatRadio;
        private System.Windows.Forms.RadioButton showLibRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel libraryPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel catPanel;
        private System.Windows.Forms.Label label3;
    }
}