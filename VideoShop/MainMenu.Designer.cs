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
            this.citiesRecords = new System.Windows.Forms.ComboBox();
            this.changeName = new System.Windows.Forms.TextBox();
            this.changeRecord = new System.Windows.Forms.Button();
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
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(228, 763);
            this.menuPanel.TabIndex = 0;
            // 
            // showOptionRadio
            // 
            this.showOptionRadio.AutoSize = true;
            this.showOptionRadio.FlatAppearance.BorderSize = 0;
            this.showOptionRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showOptionRadio.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showOptionRadio.Location = new System.Drawing.Point(4, 340);
            this.showOptionRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showOptionRadio.Name = "showOptionRadio";
            this.showOptionRadio.Size = new System.Drawing.Size(136, 41);
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
            this.showSeriesRadio.Location = new System.Drawing.Point(0, 278);
            this.showSeriesRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showSeriesRadio.Name = "showSeriesRadio";
            this.showSeriesRadio.Size = new System.Drawing.Size(171, 41);
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
            this.showCatRadio.Location = new System.Drawing.Point(0, 212);
            this.showCatRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showCatRadio.Name = "showCatRadio";
            this.showCatRadio.Size = new System.Drawing.Size(198, 41);
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
            this.showLibRadio.Location = new System.Drawing.Point(0, 153);
            this.showLibRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showLibRadio.Name = "showLibRadio";
            this.showLibRadio.Size = new System.Drawing.Size(216, 41);
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
            this.showBegginingRadio.Location = new System.Drawing.Point(4, 94);
            this.showBegginingRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showBegginingRadio.Name = "showBegginingRadio";
            this.showBegginingRadio.Size = new System.Drawing.Size(149, 41);
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
            this.userNameLabel.Location = new System.Drawing.Point(63, 49);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(83, 18);
            this.userNameLabel.TabIndex = 5;
            this.userNameLabel.Text = "userName";
            // 
            // userInfoButton
            // 
            this.userInfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userInfoButton.BackgroundImage")));
            this.userInfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userInfoButton.FlatAppearance.BorderSize = 0;
            this.userInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userInfoButton.Location = new System.Drawing.Point(68, 2);
            this.userInfoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userInfoButton.Name = "userInfoButton";
            this.userInfoButton.Size = new System.Drawing.Size(80, 43);
            this.userInfoButton.TabIndex = 4;
            this.userInfoButton.UseVisualStyleBackColor = true;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.exitButton);
            this.topPanel.Controls.Add(this.minButton);
            this.topPanel.Location = new System.Drawing.Point(227, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1103, 69);
            this.topPanel.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(1032, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(63, 22);
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
            this.minButton.Location = new System.Drawing.Point(961, 0);
            this.minButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(63, 22);
            this.minButton.TabIndex = 2;
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // beginingPanel
            // 
            this.beginingPanel.Controls.Add(this.changeRecord);
            this.beginingPanel.Controls.Add(this.changeName);
            this.beginingPanel.Controls.Add(this.citiesRecords);
            this.beginingPanel.Controls.Add(this.label1);
            this.beginingPanel.Location = new System.Drawing.Point(237, 76);
            this.beginingPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.beginingPanel.Name = "beginingPanel";
            this.beginingPanel.Size = new System.Drawing.Size(1075, 672);
            this.beginingPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "start menu";
            // 
            // libraryPanel
            // 
            this.libraryPanel.Controls.Add(this.label2);
            this.libraryPanel.Location = new System.Drawing.Point(255, 94);
            this.libraryPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.libraryPanel.Name = "libraryPanel";
            this.libraryPanel.Size = new System.Drawing.Size(1057, 655);
            this.libraryPanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "library view";
            // 
            // catPanel
            // 
            this.catPanel.Controls.Add(this.label3);
            this.catPanel.Location = new System.Drawing.Point(241, 80);
            this.catPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.catPanel.Name = "catPanel";
            this.catPanel.Size = new System.Drawing.Size(1071, 665);
            this.catPanel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "category";
            // 
            // citiesRecords
            // 
            this.citiesRecords.FormattingEnabled = true;
            this.citiesRecords.Location = new System.Drawing.Point(343, 73);
            this.citiesRecords.Name = "citiesRecords";
            this.citiesRecords.Size = new System.Drawing.Size(192, 24);
            this.citiesRecords.TabIndex = 1;
            // 
            // changeName
            // 
            this.changeName.Location = new System.Drawing.Point(343, 136);
            this.changeName.Name = "changeName";
            this.changeName.Size = new System.Drawing.Size(195, 22);
            this.changeName.TabIndex = 2;
            // 
            // changeRecord
            // 
            this.changeRecord.Location = new System.Drawing.Point(389, 202);
            this.changeRecord.Name = "changeRecord";
            this.changeRecord.Size = new System.Drawing.Size(75, 23);
            this.changeRecord.TabIndex = 3;
            this.changeRecord.Text = "button1";
            this.changeRecord.UseVisualStyleBackColor = true;
            this.changeRecord.Click += new System.EventHandler(this.changeRecord_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 763);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.beginingPanel);
            this.Controls.Add(this.catPanel);
            this.Controls.Add(this.libraryPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button changeRecord;
        private System.Windows.Forms.TextBox changeName;
        private System.Windows.Forms.ComboBox citiesRecords;
    }
}