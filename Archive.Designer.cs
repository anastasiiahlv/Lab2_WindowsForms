namespace Lab2_WindowsForms
{
    partial class Archive
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
            this.checkBoxAuthorName = new System.Windows.Forms.CheckBox();
            this.checkBoxMaterialName = new System.Windows.Forms.CheckBox();
            this.checkBoxFaculty = new System.Windows.Forms.CheckBox();
            this.checkBoxDepartment = new System.Windows.Forms.CheckBox();
            this.checkBoxType = new System.Windows.Forms.CheckBox();
            this.checkBoxCreationDate = new System.Windows.Forms.CheckBox();
            this.authorNameComboBox = new System.Windows.Forms.ComboBox();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.facultyComboBox = new System.Windows.Forms.ComboBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.creationDateComboBox = new System.Windows.Forms.ComboBox();
            this.DOM = new System.Windows.Forms.RadioButton();
            this.SAX = new System.Windows.Forms.RadioButton();
            this.LINQ = new System.Windows.Forms.RadioButton();
            this.showResultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.HtmlButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxAuthorName
            // 
            this.checkBoxAuthorName.AutoSize = true;
            this.checkBoxAuthorName.Location = new System.Drawing.Point(34, 21);
            this.checkBoxAuthorName.Name = "checkBoxAuthorName";
            this.checkBoxAuthorName.Size = new System.Drawing.Size(117, 20);
            this.checkBoxAuthorName.TabIndex = 0;
            this.checkBoxAuthorName.Text = "Author\'s Name";
            this.checkBoxAuthorName.UseVisualStyleBackColor = true;
            this.checkBoxAuthorName.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxMaterialName
            // 
            this.checkBoxMaterialName.AutoSize = true;
            this.checkBoxMaterialName.Location = new System.Drawing.Point(34, 59);
            this.checkBoxMaterialName.Name = "checkBoxMaterialName";
            this.checkBoxMaterialName.Size = new System.Drawing.Size(66, 20);
            this.checkBoxMaterialName.TabIndex = 1;
            this.checkBoxMaterialName.Text = "Name";
            this.checkBoxMaterialName.UseVisualStyleBackColor = true;
            this.checkBoxMaterialName.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxFaculty
            // 
            this.checkBoxFaculty.AutoSize = true;
            this.checkBoxFaculty.Location = new System.Drawing.Point(34, 96);
            this.checkBoxFaculty.Name = "checkBoxFaculty";
            this.checkBoxFaculty.Size = new System.Drawing.Size(72, 20);
            this.checkBoxFaculty.TabIndex = 2;
            this.checkBoxFaculty.Text = "Faculty";
            this.checkBoxFaculty.UseVisualStyleBackColor = true;
            this.checkBoxFaculty.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxDepartment
            // 
            this.checkBoxDepartment.AutoSize = true;
            this.checkBoxDepartment.Location = new System.Drawing.Point(34, 131);
            this.checkBoxDepartment.Name = "checkBoxDepartment";
            this.checkBoxDepartment.Size = new System.Drawing.Size(99, 20);
            this.checkBoxDepartment.TabIndex = 3;
            this.checkBoxDepartment.Text = "Department";
            this.checkBoxDepartment.UseVisualStyleBackColor = true;
            this.checkBoxDepartment.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxType
            // 
            this.checkBoxType.AutoSize = true;
            this.checkBoxType.Location = new System.Drawing.Point(34, 168);
            this.checkBoxType.Name = "checkBoxType";
            this.checkBoxType.Size = new System.Drawing.Size(61, 20);
            this.checkBoxType.TabIndex = 4;
            this.checkBoxType.Text = "Type";
            this.checkBoxType.UseVisualStyleBackColor = true;
            this.checkBoxType.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkBoxCreationDate
            // 
            this.checkBoxCreationDate.AutoSize = true;
            this.checkBoxCreationDate.Location = new System.Drawing.Point(34, 203);
            this.checkBoxCreationDate.Name = "checkBoxCreationDate";
            this.checkBoxCreationDate.Size = new System.Drawing.Size(111, 20);
            this.checkBoxCreationDate.TabIndex = 5;
            this.checkBoxCreationDate.Text = "Creation Date";
            this.checkBoxCreationDate.UseVisualStyleBackColor = true;
            this.checkBoxCreationDate.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // authorNameComboBox
            // 
            this.authorNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorNameComboBox.FormattingEnabled = true;
            this.authorNameComboBox.Location = new System.Drawing.Point(178, 17);
            this.authorNameComboBox.Name = "authorNameComboBox";
            this.authorNameComboBox.Size = new System.Drawing.Size(121, 24);
            this.authorNameComboBox.TabIndex = 6;
            // 
            // nameComboBox
            // 
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(178, 55);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(121, 24);
            this.nameComboBox.TabIndex = 7;
            // 
            // facultyComboBox
            // 
            this.facultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyComboBox.FormattingEnabled = true;
            this.facultyComboBox.Location = new System.Drawing.Point(178, 92);
            this.facultyComboBox.Name = "facultyComboBox";
            this.facultyComboBox.Size = new System.Drawing.Size(121, 24);
            this.facultyComboBox.TabIndex = 8;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(178, 127);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(121, 24);
            this.departmentComboBox.TabIndex = 9;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(178, 164);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 24);
            this.typeComboBox.TabIndex = 10;
            // 
            // creationDateComboBox
            // 
            this.creationDateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creationDateComboBox.FormattingEnabled = true;
            this.creationDateComboBox.Location = new System.Drawing.Point(178, 199);
            this.creationDateComboBox.Name = "creationDateComboBox";
            this.creationDateComboBox.Size = new System.Drawing.Size(121, 24);
            this.creationDateComboBox.TabIndex = 11;
            // 
            // DOM
            // 
            this.DOM.AutoSize = true;
            this.DOM.Location = new System.Drawing.Point(34, 292);
            this.DOM.Name = "DOM";
            this.DOM.Size = new System.Drawing.Size(59, 20);
            this.DOM.TabIndex = 12;
            this.DOM.TabStop = true;
            this.DOM.Text = "DOM";
            this.DOM.UseVisualStyleBackColor = true;
            this.DOM.CheckedChanged += new System.EventHandler(this.SearchButton_Click);
            // 
            // SAX
            // 
            this.SAX.AutoSize = true;
            this.SAX.Location = new System.Drawing.Point(125, 292);
            this.SAX.Name = "SAX";
            this.SAX.Size = new System.Drawing.Size(54, 20);
            this.SAX.TabIndex = 13;
            this.SAX.TabStop = true;
            this.SAX.Text = "SAX";
            this.SAX.UseVisualStyleBackColor = true;
            this.SAX.CheckedChanged += new System.EventHandler(this.SearchButton_Click);
            // 
            // LINQ
            // 
            this.LINQ.AutoSize = true;
            this.LINQ.Location = new System.Drawing.Point(206, 292);
            this.LINQ.Name = "LINQ";
            this.LINQ.Size = new System.Drawing.Size(101, 20);
            this.LINQ.TabIndex = 14;
            this.LINQ.TabStop = true;
            this.LINQ.Text = "LINQ to XML";
            this.LINQ.UseVisualStyleBackColor = true;
            this.LINQ.CheckedChanged += new System.EventHandler(this.SearchButton_Click);
            // 
            // showResultRichTextBox
            // 
            this.showResultRichTextBox.Location = new System.Drawing.Point(338, 17);
            this.showResultRichTextBox.Name = "showResultRichTextBox";
            this.showResultRichTextBox.ReadOnly = true;
            this.showResultRichTextBox.Size = new System.Drawing.Size(450, 421);
            this.showResultRichTextBox.TabIndex = 15;
            this.showResultRichTextBox.TabStop = false;
            this.showResultRichTextBox.Text = "";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(34, 350);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // HtmlButton
            // 
            this.HtmlButton.Location = new System.Drawing.Point(125, 350);
            this.HtmlButton.Name = "HtmlButton";
            this.HtmlButton.Size = new System.Drawing.Size(75, 23);
            this.HtmlButton.TabIndex = 17;
            this.HtmlButton.Text = "HTML";
            this.HtmlButton.UseVisualStyleBackColor = true;
            this.HtmlButton.Click += new System.EventHandler(this.TransformHtml_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(215, 350);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 18;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.HtmlButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.showResultRichTextBox);
            this.Controls.Add(this.LINQ);
            this.Controls.Add(this.SAX);
            this.Controls.Add(this.DOM);
            this.Controls.Add(this.creationDateComboBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.facultyComboBox);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.authorNameComboBox);
            this.Controls.Add(this.checkBoxCreationDate);
            this.Controls.Add(this.checkBoxType);
            this.Controls.Add(this.checkBoxDepartment);
            this.Controls.Add(this.checkBoxFaculty);
            this.Controls.Add(this.checkBoxMaterialName);
            this.Controls.Add(this.checkBoxAuthorName);
            this.Name = "Archive";
            this.Text = "Archive";
            this.Load += new System.EventHandler(this.Archive_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxAuthorName;
        private System.Windows.Forms.CheckBox checkBoxMaterialName;
        private System.Windows.Forms.CheckBox checkBoxFaculty;
        private System.Windows.Forms.CheckBox checkBoxDepartment;
        private System.Windows.Forms.CheckBox checkBoxType;
        private System.Windows.Forms.CheckBox checkBoxCreationDate;
        private System.Windows.Forms.ComboBox authorNameComboBox;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.ComboBox facultyComboBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox creationDateComboBox;
        private System.Windows.Forms.RadioButton DOM;
        private System.Windows.Forms.RadioButton SAX;
        private System.Windows.Forms.RadioButton LINQ;
        private System.Windows.Forms.RichTextBox showResultRichTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button HtmlButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

