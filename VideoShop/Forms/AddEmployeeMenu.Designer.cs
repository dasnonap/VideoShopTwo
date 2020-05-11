namespace VideoShop.Forms
{
    partial class AddEmployeeMenu
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
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Button();
            this.submitChanges = new System.Windows.Forms.Button();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.salaryBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.positionBox = new System.Windows.Forms.ComboBox();
            this.citiesBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.Location = new System.Drawing.Point(0, 0);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(429, 18);
            this.Border.TabIndex = 17;
            this.Border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Border_MouseDown);
            this.Border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Border_MouseMove);
            this.Border.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Border_MouseUp);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.firstNameBox.Location = new System.Drawing.Point(194, 67);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(203, 23);
            this.firstNameBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(33, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Име на служителя: ";
            // 
            // Close
            // 
            this.Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(307, 366);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(109, 23);
            this.Close.TabIndex = 21;
            this.Close.Text = "Отказ";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // submitChanges
            // 
            this.submitChanges.FlatAppearance.BorderSize = 0;
            this.submitChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitChanges.Location = new System.Drawing.Point(192, 366);
            this.submitChanges.Name = "submitChanges";
            this.submitChanges.Size = new System.Drawing.Size(109, 23);
            this.submitChanges.TabIndex = 20;
            this.submitChanges.Text = "Приложи";
            this.submitChanges.UseVisualStyleBackColor = true;
            this.submitChanges.Click += new System.EventHandler(this.submitChanges_Click);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lastNameBox.Location = new System.Drawing.Point(196, 111);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(203, 23);
            this.lastNameBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(35, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Фамилия на служителя: ";
            // 
            // salaryBox
            // 
            this.salaryBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.salaryBox.Location = new System.Drawing.Point(196, 151);
            this.salaryBox.Name = "salaryBox";
            this.salaryBox.Size = new System.Drawing.Size(203, 23);
            this.salaryBox.TabIndex = 25;
            this.salaryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salaryBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(33, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Заплата: ";
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phoneBox.Location = new System.Drawing.Point(196, 198);
            this.phoneBox.MaxLength = 10;
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(203, 23);
            this.phoneBox.TabIndex = 27;
            this.phoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(35, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Телефонен номер: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(35, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Длъжност: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.Location = new System.Drawing.Point(35, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Град:  ";
            // 
            // positionBox
            // 
            this.positionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionBox.FormattingEnabled = true;
            this.positionBox.IntegralHeight = false;
            this.positionBox.Location = new System.Drawing.Point(194, 248);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(205, 25);
            this.positionBox.TabIndex = 31;
            // 
            // citiesBox
            // 
            this.citiesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.citiesBox.FormattingEnabled = true;
            this.citiesBox.Location = new System.Drawing.Point(194, 291);
            this.citiesBox.Name = "citiesBox";
            this.citiesBox.Size = new System.Drawing.Size(205, 25);
            this.citiesBox.TabIndex = 32;
            // 
            // AddEmployeeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 404);
            this.Controls.Add(this.citiesBox);
            this.Controls.Add(this.positionBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salaryBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.submitChanges);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Border);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddEmployeeMenu";
            this.Text = "AddEmployeeMenu";
            this.Load += new System.EventHandler(this.AddEmployeeMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Border;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button submitChanges;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salaryBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox positionBox;
        private System.Windows.Forms.ComboBox citiesBox;
    }
}