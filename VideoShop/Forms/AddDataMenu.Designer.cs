namespace VideoShop.Forms
{
    partial class AddDataMenu
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
            this.Close = new System.Windows.Forms.Button();
            this.submitChanges = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataBox = new System.Windows.Forms.TextBox();
            this.Border = new System.Windows.Forms.Panel();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(252, 130);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(95, 23);
            this.Close.TabIndex = 13;
            this.Close.Text = "Отказ";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // submitChanges
            // 
            this.submitChanges.FlatAppearance.BorderSize = 0;
            this.submitChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitChanges.Location = new System.Drawing.Point(151, 130);
            this.submitChanges.Name = "submitChanges";
            this.submitChanges.Size = new System.Drawing.Size(95, 23);
            this.submitChanges.TabIndex = 12;
            this.submitChanges.Text = "Приложи";
            this.submitChanges.UseVisualStyleBackColor = true;
            this.submitChanges.Click += new System.EventHandler(this.submitChanges_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // dataBox
            // 
            this.dataBox.Location = new System.Drawing.Point(169, 50);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(178, 23);
            this.dataBox.TabIndex = 15;
            // 
            // Border
            // 
            this.Border.Location = new System.Drawing.Point(2, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(345, 18);
            this.Border.TabIndex = 16;
            this.Border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
            this.Border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Border_MouseMove);
            this.Border.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Border_MouseUp);
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(169, 88);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(178, 23);
            this.priceBox.TabIndex = 18;
            this.priceBox.Visible = false;
            this.priceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceBox_KeyPress);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(18, 88);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(124, 17);
            this.priceLabel.TabIndex = 17;
            this.priceLabel.Text = "Цена на Услугата";
            this.priceLabel.Visible = false;
            // 
            // AddDataMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 162);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.Border);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.submitChanges);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddDataMenu";
            this.Text = "AddDataMenu";
            this.Load += new System.EventHandler(this.AddDataMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button submitChanges;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dataBox;
        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label priceLabel;
    }
}