namespace VideoShop.Forms
{
    partial class AddSubscMenu
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
            this.Border = new System.Windows.Forms.Panel();
            this.serLabel = new System.Windows.Forms.Label();
            this.serviceBox = new System.Windows.Forms.ComboBox();
            this.startTimeBox = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.submitChanges = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(414, 18);
            this.Border.TabIndex = 19;
            this.Border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
            this.Border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Border_MouseMove);
            this.Border.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Border_MouseUp);
            // 
            // serLabel
            // 
            this.serLabel.AutoSize = true;
            this.serLabel.Location = new System.Drawing.Point(33, 60);
            this.serLabel.Name = "serLabel";
            this.serLabel.Size = new System.Drawing.Size(108, 17);
            this.serLabel.TabIndex = 17;
            this.serLabel.Text = "Тип на услугата : ";
            // 
            // serviceBox
            // 
            this.serviceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceBox.FormattingEnabled = true;
            this.serviceBox.IntegralHeight = false;
            this.serviceBox.Location = new System.Drawing.Point(173, 57);
            this.serviceBox.Name = "serviceBox";
            this.serviceBox.Size = new System.Drawing.Size(226, 25);
            this.serviceBox.TabIndex = 32;
            this.serviceBox.TextChanged += new System.EventHandler(this.serviceBox_TextChanged);
            // 
            // startTimeBox
            // 
            this.startTimeBox.Location = new System.Drawing.Point(173, 111);
            this.startTimeBox.Name = "startTimeBox";
            this.startTimeBox.Size = new System.Drawing.Size(226, 22);
            this.startTimeBox.TabIndex = 33;
            this.startTimeBox.ValueChanged += new System.EventHandler(this.startTimeBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Дата на започване : ";
            // 
            // Close
            // 
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(283, 180);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(95, 23);
            this.Close.TabIndex = 36;
            this.Close.Text = "Отказ";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // submitChanges
            // 
            this.submitChanges.FlatAppearance.BorderSize = 0;
            this.submitChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitChanges.Location = new System.Drawing.Point(182, 180);
            this.submitChanges.Name = "submitChanges";
            this.submitChanges.Size = new System.Drawing.Size(95, 23);
            this.submitChanges.TabIndex = 35;
            this.submitChanges.Text = "Приложи";
            this.submitChanges.UseVisualStyleBackColor = true;
            this.submitChanges.Click += new System.EventHandler(this.submitChanges_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(33, 180);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(40, 17);
            this.priceLabel.TabIndex = 37;
            this.priceLabel.Text = "Цена";
            // 
            // AddSubscMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 219);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.submitChanges);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startTimeBox);
            this.Controls.Add(this.serviceBox);
            this.Controls.Add(this.Border);
            this.Controls.Add(this.serLabel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddSubscMenu";
            this.Text = "AddSubscMenu";
            this.Load += new System.EventHandler(this.AddSubscMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.Label serLabel;
        private System.Windows.Forms.ComboBox serviceBox;
        private System.Windows.Forms.DateTimePicker startTimeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button submitChanges;
        private System.Windows.Forms.Label priceLabel;
    }
}