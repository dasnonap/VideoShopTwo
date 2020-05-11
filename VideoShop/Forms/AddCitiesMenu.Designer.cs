namespace VideoShop.Forms
{
    partial class AddCitiesMenu
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
            this.cityNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Border = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Button();
            this.submitChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityNameBox
            // 
            this.cityNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityNameBox.Location = new System.Drawing.Point(177, 49);
            this.cityNameBox.Name = "cityNameBox";
            this.cityNameBox.Size = new System.Drawing.Size(142, 15);
            this.cityNameBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Име на град: ";
            // 
            // Border
            // 
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(368, 18);
            this.Border.TabIndex = 13;
            this.Border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
            this.Border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Border_MouseMove);
            this.Border.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Border_MouseUp);
            // 
            // Close
            // 
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(235, 93);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(95, 23);
            this.Close.TabIndex = 15;
            this.Close.Text = "Отказ";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // submitChanges
            // 
            this.submitChanges.FlatAppearance.BorderSize = 0;
            this.submitChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitChanges.Location = new System.Drawing.Point(134, 93);
            this.submitChanges.Name = "submitChanges";
            this.submitChanges.Size = new System.Drawing.Size(95, 23);
            this.submitChanges.TabIndex = 14;
            this.submitChanges.Text = "Приложи";
            this.submitChanges.UseVisualStyleBackColor = true;
            this.submitChanges.Click += new System.EventHandler(this.submitChanges_Click);
            // 
            // AddCitiesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 128);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.submitChanges);
            this.Controls.Add(this.Border);
            this.Controls.Add(this.cityNameBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddCitiesMenu";
            this.Text = "AddCitiesMenu";
            this.Load += new System.EventHandler(this.AddCitiesMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cityNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button submitChanges;
    }
}