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
            this.checkAuthorName = new System.Windows.Forms.CheckBox();
            this.checkMaterialName = new System.Windows.Forms.CheckBox();
            this.checkFaculty = new System.Windows.Forms.CheckBox();
            this.checkDepartment = new System.Windows.Forms.CheckBox();
            this.checkType = new System.Windows.Forms.CheckBox();
            this.checkCreationDate = new System.Windows.Forms.CheckBox();
            this.authorNameBox = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.ComboBox();
            this.facultyBox = new System.Windows.Forms.ComboBox();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.creationDateBox = new System.Windows.Forms.ComboBox();
            this.DOM = new System.Windows.Forms.RadioButton();
            this.SAX = new System.Windows.Forms.RadioButton();
            this.LINQ = new System.Windows.Forms.RadioButton();
            this.showResultBox = new System.Windows.Forms.RichTextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.HtmlButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkAuthorName
            // 
            this.checkAuthorName.AutoSize = true;
            this.checkAuthorName.Location = new System.Drawing.Point(34, 21);
            this.checkAuthorName.Name = "checkAuthorName";
            this.checkAuthorName.Size = new System.Drawing.Size(117, 20);
            this.checkAuthorName.TabIndex = 0;
            this.checkAuthorName.Text = "Author\'s Name";
            this.checkAuthorName.UseVisualStyleBackColor = true;
            this.checkAuthorName.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkMaterialName
            // 
            this.checkMaterialName.AutoSize = true;
            this.checkMaterialName.Location = new System.Drawing.Point(34, 59);
            this.checkMaterialName.Name = "checkMaterialName";
            this.checkMaterialName.Size = new System.Drawing.Size(66, 20);
            this.checkMaterialName.TabIndex = 1;
            this.checkMaterialName.Text = "Name";
            this.checkMaterialName.UseVisualStyleBackColor = true;
            this.checkMaterialName.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkFaculty
            // 
            this.checkFaculty.AutoSize = true;
            this.checkFaculty.Location = new System.Drawing.Point(34, 96);
            this.checkFaculty.Name = "checkFaculty";
            this.checkFaculty.Size = new System.Drawing.Size(72, 20);
            this.checkFaculty.TabIndex = 2;
            this.checkFaculty.Text = "Faculty";
            this.checkFaculty.UseVisualStyleBackColor = true;
            this.checkFaculty.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkDepartment
            // 
            this.checkDepartment.AutoSize = true;
            this.checkDepartment.Location = new System.Drawing.Point(34, 131);
            this.checkDepartment.Name = "checkDepartment";
            this.checkDepartment.Size = new System.Drawing.Size(99, 20);
            this.checkDepartment.TabIndex = 3;
            this.checkDepartment.Text = "Department";
            this.checkDepartment.UseVisualStyleBackColor = true;
            this.checkDepartment.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkType
            // 
            this.checkType.AutoSize = true;
            this.checkType.Location = new System.Drawing.Point(34, 168);
            this.checkType.Name = "checkType";
            this.checkType.Size = new System.Drawing.Size(61, 20);
            this.checkType.TabIndex = 4;
            this.checkType.Text = "Type";
            this.checkType.UseVisualStyleBackColor = true;
            this.checkType.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // checkCreationDate
            // 
            this.checkCreationDate.AutoSize = true;
            this.checkCreationDate.Location = new System.Drawing.Point(34, 203);
            this.checkCreationDate.Name = "checkCreationDate";
            this.checkCreationDate.Size = new System.Drawing.Size(111, 20);
            this.checkCreationDate.TabIndex = 5;
            this.checkCreationDate.Text = "Creation Date";
            this.checkCreationDate.UseVisualStyleBackColor = true;
            this.checkCreationDate.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // authorNameBox
            // 
            this.authorNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.authorNameBox.FormattingEnabled = true;
            this.authorNameBox.Location = new System.Drawing.Point(178, 17);
            this.authorNameBox.Name = "authorNameBox";
            this.authorNameBox.Size = new System.Drawing.Size(121, 24);
            this.authorNameBox.TabIndex = 6;
            // 
            // nameBox
            // 
            this.nameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameBox.FormattingEnabled = true;
            this.nameBox.Location = new System.Drawing.Point(178, 55);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(121, 24);
            this.nameBox.TabIndex = 7;
            // 
            // facultyBox
            // 
            this.facultyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyBox.FormattingEnabled = true;
            this.facultyBox.Location = new System.Drawing.Point(178, 92);
            this.facultyBox.Name = "facultyBox";
            this.facultyBox.Size = new System.Drawing.Size(121, 24);
            this.facultyBox.TabIndex = 8;
            // 
            // departmentBox
            // 
            this.departmentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Location = new System.Drawing.Point(178, 127);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(121, 24);
            this.departmentBox.TabIndex = 9;
            // 
            // typeBox
            // 
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(178, 164);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(121, 24);
            this.typeBox.TabIndex = 10;
            // 
            // creationDateBox
            // 
            this.creationDateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creationDateBox.FormattingEnabled = true;
            this.creationDateBox.Location = new System.Drawing.Point(178, 199);
            this.creationDateBox.Name = "creationDateBox";
            this.creationDateBox.Size = new System.Drawing.Size(121, 24);
            this.creationDateBox.TabIndex = 11;
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
            // showResultBox
            // 
            this.showResultBox.Location = new System.Drawing.Point(338, 17);
            this.showResultBox.Name = "showResultBox";
            this.showResultBox.ReadOnly = true;
            this.showResultBox.Size = new System.Drawing.Size(450, 421);
            this.showResultBox.TabIndex = 15;
            this.showResultBox.TabStop = false;
            this.showResultBox.Text = "";
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
            this.Controls.Add(this.showResultBox);
            this.Controls.Add(this.LINQ);
            this.Controls.Add(this.SAX);
            this.Controls.Add(this.DOM);
            this.Controls.Add(this.creationDateBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.facultyBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.authorNameBox);
            this.Controls.Add(this.checkCreationDate);
            this.Controls.Add(this.checkType);
            this.Controls.Add(this.checkDepartment);
            this.Controls.Add(this.checkFaculty);
            this.Controls.Add(this.checkMaterialName);
            this.Controls.Add(this.checkAuthorName);
            this.Name = "Archive";
            this.Text = "Archive";
            this.Load += new System.EventHandler(this.Archive_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkAuthorName;
        private System.Windows.Forms.CheckBox checkMaterialName;
        private System.Windows.Forms.CheckBox checkFaculty;
        private System.Windows.Forms.CheckBox checkDepartment;
        private System.Windows.Forms.CheckBox checkType;
        private System.Windows.Forms.CheckBox checkCreationDate;
        private System.Windows.Forms.ComboBox authorNameBox;
        private System.Windows.Forms.ComboBox nameBox;
        private System.Windows.Forms.ComboBox facultyBox;
        private System.Windows.Forms.ComboBox departmentBox;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.ComboBox creationDateBox;
        private System.Windows.Forms.RadioButton DOM;
        private System.Windows.Forms.RadioButton SAX;
        private System.Windows.Forms.RadioButton LINQ;
        private System.Windows.Forms.RichTextBox showResultBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button HtmlButton;
        private System.Windows.Forms.Button ClearButton;
    }
}

