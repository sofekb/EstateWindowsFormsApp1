namespace EstateWindowsFormsApp1.GUI
{
    partial class FormInstitutional
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.institutionNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.governTypeComboBox = new System.Windows.Forms.ComboBox();
            this.institutionContainer = new System.Windows.Forms.SplitContainer();
            this.maxCapacityLabel = new System.Windows.Forms.Label();
            this.maxCapacityTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hospitalContainer = new System.Windows.Forms.SplitContainer();
            this.estateContainer = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.legalFormComboBox = new System.Windows.Forms.ComboBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.institutionContainer)).BeginInit();
            this.institutionContainer.Panel1.SuspendLayout();
            this.institutionContainer.Panel2.SuspendLayout();
            this.institutionContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalContainer)).BeginInit();
            this.hospitalContainer.Panel1.SuspendLayout();
            this.hospitalContainer.Panel2.SuspendLayout();
            this.hospitalContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estateContainer)).BeginInit();
            this.estateContainer.Panel1.SuspendLayout();
            this.estateContainer.Panel2.SuspendLayout();
            this.estateContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select which type of building:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Hospital",
            "School",
            "University"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hospital",
            "School",
            "University"});
            this.comboBox1.Location = new System.Drawing.Point(101, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name of institution:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // institutionNameTextBox
            // 
            this.institutionNameTextBox.Location = new System.Drawing.Point(3, 12);
            this.institutionNameTextBox.Name = "institutionNameTextBox";
            this.institutionNameTextBox.Size = new System.Drawing.Size(147, 20);
            this.institutionNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Govern type:";
            // 
            // governTypeComboBox
            // 
            this.governTypeComboBox.FormattingEnabled = true;
            this.governTypeComboBox.Items.AddRange(new object[] {
            "Private",
            "Public"});
            this.governTypeComboBox.Location = new System.Drawing.Point(3, 37);
            this.governTypeComboBox.Name = "governTypeComboBox";
            this.governTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.governTypeComboBox.TabIndex = 5;
            this.governTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // institutionContainer
            // 
            this.institutionContainer.Location = new System.Drawing.Point(101, 223);
            this.institutionContainer.Name = "institutionContainer";
            // 
            // institutionContainer.Panel1
            // 
            this.institutionContainer.Panel1.Controls.Add(this.label3);
            this.institutionContainer.Panel1.Controls.Add(this.label2);
            // 
            // institutionContainer.Panel2
            // 
            this.institutionContainer.Panel2.Controls.Add(this.governTypeComboBox);
            this.institutionContainer.Panel2.Controls.Add(this.institutionNameTextBox);
            this.institutionContainer.Size = new System.Drawing.Size(357, 74);
            this.institutionContainer.SplitterDistance = 119;
            this.institutionContainer.TabIndex = 8;
            this.institutionContainer.Visible = false;
            // 
            // maxCapacityLabel
            // 
            this.maxCapacityLabel.AutoSize = true;
            this.maxCapacityLabel.Location = new System.Drawing.Point(3, 11);
            this.maxCapacityLabel.Name = "maxCapacityLabel";
            this.maxCapacityLabel.Size = new System.Drawing.Size(70, 13);
            this.maxCapacityLabel.TabIndex = 5;
            this.maxCapacityLabel.Text = "Max capacity";
            this.maxCapacityLabel.Visible = false;
            this.maxCapacityLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // maxCapacityTextBox
            // 
            this.maxCapacityTextBox.Location = new System.Drawing.Point(3, 4);
            this.maxCapacityTextBox.Name = "maxCapacityTextBox";
            this.maxCapacityTextBox.Size = new System.Drawing.Size(68, 20);
            this.maxCapacityTextBox.TabIndex = 6;
            this.maxCapacityTextBox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add building";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hospitalContainer
            // 
            this.hospitalContainer.Location = new System.Drawing.Point(101, 303);
            this.hospitalContainer.Name = "hospitalContainer";
            // 
            // hospitalContainer.Panel1
            // 
            this.hospitalContainer.Panel1.Controls.Add(this.maxCapacityLabel);
            // 
            // hospitalContainer.Panel2
            // 
            this.hospitalContainer.Panel2.Controls.Add(this.maxCapacityTextBox);
            this.hospitalContainer.Size = new System.Drawing.Size(357, 57);
            this.hospitalContainer.SplitterDistance = 119;
            this.hospitalContainer.TabIndex = 10;
            // 
            // estateContainer
            // 
            this.estateContainer.Location = new System.Drawing.Point(101, 72);
            this.estateContainer.Name = "estateContainer";
            // 
            // estateContainer.Panel1
            // 
            this.estateContainer.Panel1.Controls.Add(this.label9);
            this.estateContainer.Panel1.Controls.Add(this.label8);
            this.estateContainer.Panel1.Controls.Add(this.label7);
            this.estateContainer.Panel1.Controls.Add(this.label6);
            this.estateContainer.Panel1.Controls.Add(this.label4);
            this.estateContainer.Panel1.Controls.Add(this.label5);
            // 
            // estateContainer.Panel2
            // 
            this.estateContainer.Panel2.Controls.Add(this.legalFormComboBox);
            this.estateContainer.Panel2.Controls.Add(this.countryComboBox);
            this.estateContainer.Panel2.Controls.Add(this.cityTextBox);
            this.estateContainer.Panel2.Controls.Add(this.zipCodeTextBox);
            this.estateContainer.Panel2.Controls.Add(this.streetTextBox);
            this.estateContainer.Panel2.Controls.Add(this.idTextBox);
            this.estateContainer.Size = new System.Drawing.Size(354, 157);
            this.estateContainer.SplitterDistance = 118;
            this.estateContainer.TabIndex = 11;
            this.estateContainer.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Legal form";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Zip code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Street";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Id";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // legalFormComboBox
            // 
            this.legalFormComboBox.FormattingEnabled = true;
            this.legalFormComboBox.Location = new System.Drawing.Point(4, 124);
            this.legalFormComboBox.Name = "legalFormComboBox";
            this.legalFormComboBox.Size = new System.Drawing.Size(121, 21);
            this.legalFormComboBox.TabIndex = 10;
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(4, 94);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(121, 21);
            this.countryComboBox.TabIndex = 9;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(3, 71);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(147, 20);
            this.cityTextBox.TabIndex = 8;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(3, 47);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(93, 20);
            this.zipCodeTextBox.TabIndex = 7;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(3, 25);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(147, 20);
            this.streetTextBox.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(3, 0);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(86, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(200, 381);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // FormInstitutional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.estateContainer);
            this.Controls.Add(this.hospitalContainer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.institutionContainer);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormInstitutional";
            this.Text = "FormInstitutional";
            this.institutionContainer.Panel1.ResumeLayout(false);
            this.institutionContainer.Panel1.PerformLayout();
            this.institutionContainer.Panel2.ResumeLayout(false);
            this.institutionContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.institutionContainer)).EndInit();
            this.institutionContainer.ResumeLayout(false);
            this.hospitalContainer.Panel1.ResumeLayout(false);
            this.hospitalContainer.Panel1.PerformLayout();
            this.hospitalContainer.Panel2.ResumeLayout(false);
            this.hospitalContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalContainer)).EndInit();
            this.hospitalContainer.ResumeLayout(false);
            this.estateContainer.Panel1.ResumeLayout(false);
            this.estateContainer.Panel1.PerformLayout();
            this.estateContainer.Panel2.ResumeLayout(false);
            this.estateContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estateContainer)).EndInit();
            this.estateContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox institutionNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox governTypeComboBox;
        private System.Windows.Forms.SplitContainer institutionContainer;
        private System.Windows.Forms.Label maxCapacityLabel;
        private System.Windows.Forms.TextBox maxCapacityTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SplitContainer hospitalContainer;
        private System.Windows.Forms.SplitContainer estateContainer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox legalFormComboBox;
        private System.Windows.Forms.Button backButton;
    }
}