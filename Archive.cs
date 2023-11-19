using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using static System.Windows.Forms.LinkLabel;

namespace Lab2_WindowsForms
{
    public partial class Archive : Form
    {
        public Archive()
        {
            InitializeComponent();
        }

        private void GetAllMaterialsInComboBox()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\USER\\Documents\\GitHub\\Lab2_WindowsForms\\XMLFile1.xml");

            XmlElement xRoot = doc.DocumentElement;
            XmlNodeList childNodes = xRoot.SelectNodes("Material");

            for(int i = 0; i < childNodes.Count; i++)
            {
                XmlNode node = childNodes.Item(i);
                AddItems(node);
            }
        }

        private void AddItems(XmlNode n)
        {

            if (!authorNameComboBox.Items.Contains(n.SelectSingleNode("@AuthorName").Value))
                authorNameComboBox.Items.Add(n.SelectSingleNode("@AuthorName").Value);

            if (!nameComboBox.Items.Contains(n.SelectSingleNode("@Name").Value))
                nameComboBox.Items.Add(n.SelectSingleNode("@Name").Value);

            if (!facultyComboBox.Items.Contains(n.SelectSingleNode("@Faculty").Value))
                facultyComboBox.Items.Add(n.SelectSingleNode("@Faculty").Value);

            if (!departmentComboBox.Items.Contains(n.SelectSingleNode("@Department").Value))
                departmentComboBox.Items.Add(n.SelectSingleNode("@Department").Value);

            if (!typeComboBox.Items.Contains(n.SelectSingleNode("@Type").Value))
                typeComboBox.Items.Add(n.SelectSingleNode("@Type").Value);

            if (!creationDateComboBox.Items.Contains(n.SelectSingleNode("@CreationDate").Value))
                creationDateComboBox.Items.Add(n.SelectSingleNode("@CreationDate").Value);
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchMaterials();
        }

        private void searchMaterials()
        {
            showResultRichTextBox.Clear();
            string path = "C:\\Users\\USER\\Documents\\GitHub\\Lab2_WindowsForms\\XMLFile1.xml";
            Material material = new Material();

            if (checkBoxAuthorName.Checked)
                material.AuthorName = authorNameComboBox.SelectedItem?.ToString();

            if (checkBoxMaterialName.Checked)
                material.Name = nameComboBox.SelectedItem?.ToString();

            if (checkBoxFaculty.Checked)
                material.Faculty = facultyComboBox.SelectedItem?.ToString();

            if (checkBoxDepartment.Checked)
                material.Department = departmentComboBox.SelectedItem?.ToString();

            if (checkBoxType.Checked)
                material.Type = typeComboBox.SelectedItem?.ToString();

            if (checkBoxCreationDate.Checked)
                material.CreationDate = creationDateComboBox.SelectedItem?.ToString();

            ISearch searchMethod = new LINQ();

            if (DOM.Checked)
                searchMethod = new DOM();
            if (SAX.Checked)
                searchMethod = new SAX();
            if (LINQ.Checked)
                searchMethod = new LINQ();

            List<Material> materials = searchMethod.Search(material, path);

            foreach (Material m in materials)
            {
                showResultRichTextBox.AppendText(m.AuthorName + "\n");
                showResultRichTextBox.AppendText(m.Name + "\n");
                showResultRichTextBox.AppendText(m.Faculty + "\n");
                showResultRichTextBox.AppendText(m.Department + "\n");
                showResultRichTextBox.AppendText(m.Type + "\n");
                showResultRichTextBox.AppendText(m.CreationDate + "\n\n\n");
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox temp = sender as CheckBox;

            switch(temp.Text)
            {
                case "Author's Name":
                    if (checkBoxAuthorName.CheckState == CheckState.Checked)
                        authorNameComboBox.Enabled = true;
                    else
                    {
                        authorNameComboBox.Enabled = false;
                        authorNameComboBox.Text = null;
                    }
                    break;

                case "Name":
                    if (checkBoxMaterialName.CheckState == CheckState.Checked)
                        nameComboBox.Enabled = true;
                    else
                    {
                        nameComboBox.Enabled = false;
                        nameComboBox.Text = null;
                    }
                    break;

                case "Faculty":
                    if (checkBoxFaculty.CheckState == CheckState.Checked)
                        facultyComboBox.Enabled = true;
                    else
                    {
                        facultyComboBox.Enabled = false;
                        facultyComboBox.Text = null;
                    }
                    break;

                case "Department":
                    if (checkBoxDepartment.CheckState == CheckState.Checked)
                        departmentComboBox.Enabled = true;
                    else
                    {
                        departmentComboBox.Enabled = false;
                        departmentComboBox.Text = null;
                    }
                    break;

                case "Type":
                    if (checkBoxType.CheckState == CheckState.Checked)
                        typeComboBox.Enabled = true;
                    else
                    {
                        typeComboBox.Enabled = false;
                        typeComboBox.Text = null;
                    }
                    break;

                case "Creation Date":
                    if (checkBoxCreationDate.CheckState == CheckState.Checked)
                        creationDateComboBox.Enabled = true;
                    else
                    {
                        creationDateComboBox.Enabled = false;
                        creationDateComboBox.Text = null;
                    }
                    break;
            }   
        }


        private void Clear_Click(object sender, EventArgs e)
        {
            showResultRichTextBox.Text = "";

            checkBoxAuthorName.Checked = false;
            authorNameComboBox.Enabled = false;
            authorNameComboBox.Text = null;

            checkBoxMaterialName.Checked = false;
            nameComboBox.Enabled = false;
            nameComboBox.Text = null;

            checkBoxFaculty.Checked = false;
            facultyComboBox.Enabled = false;
            facultyComboBox.Text = null;

            checkBoxDepartment.Checked = false;
            departmentComboBox.Enabled = false;
            departmentComboBox.Text = null;

            checkBoxType.Checked = false;
            typeComboBox.Enabled = false;
            typeComboBox.Text = null;

            checkBoxCreationDate.Checked = false;
            creationDateComboBox.Enabled = false;
            creationDateComboBox.Text = null;

            /*DOM.Checked = false;
            SAX.Checked = false;
            LINQ.Checked = false;*/
        }

        private void TransformHtml_Click(object sender, EventArgs e)
        {

            XslCompiledTransform xslt = new XslCompiledTransform();

            string xsl = "C:\\Users\\USER\\Documents\\GitHub\\Lab2_WindowsForms\\XSL.xsl";

            xslt.Load(xsl);

            string xml = "C:\\Users\\USER\\Documents\\GitHub\\Lab2_WindowsForms\\XMLFile1.xml";

            string result = @"HtmlResult.html";

            xslt.Transform(xml, result);
        }

        private void exit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the programme?", "Exit confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void Archive_Load(object sender, EventArgs e)
        {
            authorNameComboBox.Enabled = false;
            nameComboBox.Enabled = false;
            facultyComboBox.Enabled = false;
            departmentComboBox.Enabled = false;
            typeComboBox.Enabled = false;
            creationDateComboBox.Enabled = false;

            GetAllMaterialsInComboBox();
        }
    }
}
