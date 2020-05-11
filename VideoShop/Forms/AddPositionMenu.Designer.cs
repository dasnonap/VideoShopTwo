namespace VideoShop.Forms
{
    partial class AddPositionMenu
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
            this.dataBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.submitChanges = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.Location = new System.Drawing.Point(-2, -1);
            this.Border.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(402, 24);
            this.Border.TabIndex = 21;
            this.Border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
            this.Border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Border_MouseMove);
            this.Border.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Border_MouseUp);
            // 
            // dataBox
            // 
            this.dataBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataBox.Location = new System.Drawing.Point(175, 52);
            this.dataBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(207, 22);
            this.dataBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Име на длъжността";
            // 
            // Close
            // 
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Location = new System.Drawing.Point(272, 116);
            this.Close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(111, 30);
            this.Close.TabIndex = 18;
            this.Close.Text = "Отказ";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // submitChanges
            // 
            this.submitChanges.FlatAppearance.BorderSize = 0;
            this.submitChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitChanges.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitChanges.Location = new System.Drawing.Point(154, 116);
            this.submitChanges.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.submitChanges.Name = "submitChanges";
            this.submitChanges.Size = new System.Drawing.Size(111, 30);
            this.submitChanges.TabIndex = 17;
            this.submitChanges.Text = "Приложи";
            this.submitChanges.UseVisualStyleBackColor = true;
            this.submitChanges.Click += new System.EventHandler(this.submitChanges_Click);
            // 
            // AddPositionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 150);
            this.Controls.Add(this.Border);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.submitChanges);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddPositionMenu";
            this.Text = "AddPositionMenu";
            this.Load += new System.EventHandler(this.AddPositionMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.TextBox dataBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button submitChanges;
    }
}