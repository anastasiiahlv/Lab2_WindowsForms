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

        public void GetAllMaterials()
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

        public void AddItems(XmlNode n)
        {

            if (!authorNameBox.Items.Contains(n.SelectSingleNode("@AuthorName").Value))
                authorNameBox.Items.Add(n.SelectSingleNode("@AuthorName").Value);

            if (!nameBox.Items.Contains(n.SelectSingleNode("@Name").Value))
                nameBox.Items.Add(n.SelectSingleNode("@Name").Value);

            if (!facultyBox.Items.Contains(n.SelectSingleNode("@Faculty").Value))
                facultyBox.Items.Add(n.SelectSingleNode("@Faculty").Value);

            if (!departmentBox.Items.Contains(n.SelectSingleNode("@Department").Value))
                departmentBox.Items.Add(n.SelectSingleNode("@Department").Value);

            if (!typeBox.Items.Contains(n.SelectSingleNode("@Type").Value))
                typeBox.Items.Add(n.SelectSingleNode("@Type").Value);

            if (!creationDateBox.Items.Contains(n.SelectSingleNode("@CreationDate").Value))
                creationDateBox.Items.Add(n.SelectSingleNode("@CreationDate").Value);
        }
        public void SearchButton_Click(object sender, EventArgs e)
        {
            searchMaterials();
        }

        private void searchMaterials()
        {
            string path = "C:\\Users\\USER\\Documents\\GitHub\\Lab2_WindowsForms\\XMLFile1.xml";
            showResultBox.Clear();
            Material material = new Material();

            if (checkAuthorName.Checked)
                material.AuthorName = authorNameBox.SelectedItem.ToString();

            if (checkMaterialName.Checked)
                material.Name = nameBox.SelectedItem.ToString();

            if (checkFaculty.Checked)
                material.Faculty = facultyBox.SelectedItem.ToString();

            if (checkDepartment.Checked)
                material.Department = departmentBox.SelectedItem.ToString();

            if (checkType.Checked)
                material.Type = typeBox.SelectedItem.ToString();

            if (checkCreationDate.Checked)
                material.CreationDate = creationDateBox.SelectedItem.ToString();

            ISearch search = new LINQ();

            if (DOM.Checked)
                search = new DOM();
            if (SAX.Checked)
                search = new SAX();
            if (LINQ.Checked)
                search = new LINQ();

            List<Material> materials = search.Search(material, path);

            foreach (Material m in materials)
            {
                showResultBox.AppendText(m.AuthorName + "\n");
                showResultBox.AppendText(m.Name + "\n");
                showResultBox.AppendText(m.Faculty + "\n");
                showResultBox.AppendText(m.Department + "\n");
                showResultBox.AppendText(m.Type + "\n");
                showResultBox.AppendText(m.CreationDate + "\n\n\n");
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox temp = sender as CheckBox;

            switch(temp.Text)
            {
                case "Author's Name":
                    if (checkAuthorName.CheckState == CheckState.Checked)
                        authorNameBox.Enabled = true;
                    else
                    {
                        authorNameBox.Enabled = false;
                        authorNameBox.Text = null;
                    }
                    break;

                case "Name":
                    if (checkMaterialName.CheckState == CheckState.Checked)
                        nameBox.Enabled = true;
                    else
                    {
                        nameBox.Enabled = false;
                        nameBox.Text = null;
                    }
                    break;

                case "Faculty":
                    if (checkFaculty.CheckState == CheckState.Checked)
                        facultyBox.Enabled = true;
                    else
                    {
                        facultyBox.Enabled = false;
                        facultyBox.Text = null;
                    }
                    break;

                case "Department":
                    if (checkDepartment.CheckState == CheckState.Checked)
                        departmentBox.Enabled = true;
                    else
                    {
                        departmentBox.Enabled = false;
                        departmentBox.Text = null;
                    }
                    break;

                case "Type":
                    if (checkType.CheckState == CheckState.Checked)
                        typeBox.Enabled = true;
                    else
                    {
                        typeBox.Enabled = false;
                        typeBox.Text = null;
                    }
                    break;

                case "Creation Date":
                    if (checkCreationDate.CheckState == CheckState.Checked)
                        creationDateBox.Enabled = true;
                    else
                    {
                        creationDateBox.Enabled = false;
                        creationDateBox.Text = null;
                    }
                    break;
            }   
        }


        private void Clear_Click(object sender, EventArgs e)
        {
            showResultBox.Text = "";

            checkAuthorName.Checked = false;
            authorNameBox.Enabled = false;
            authorNameBox.Text = null;

            checkMaterialName.Checked = false;
            nameBox.Enabled = false;
            nameBox.Text = null;

            checkFaculty.Checked = false;
            facultyBox.Enabled = false;
            facultyBox.Text = null;

            checkDepartment.Checked = false;
            departmentBox.Enabled = false;
            departmentBox.Text = null;

            checkType.Checked = false;
            typeBox.Enabled = false;
            typeBox.Text = null;

            checkCreationDate.Checked = false;
            creationDateBox.Enabled = false;
            creationDateBox.Text = null;

            DOM.Checked = false;
            SAX.Checked = false;
            LINQ.Checked = false;
        }

        private void Archive_Load(object sender, EventArgs e)
        {
            authorNameBox.Enabled = false;
            nameBox.Enabled = false;
            facultyBox.Enabled = false;
            departmentBox.Enabled = false;
            typeBox.Enabled = false;
            creationDateBox.Enabled = false;

            GetAllMaterials();
        }

        private void TransformHtml_Click(object sender, EventArgs e)
        {

            XslCompiledTransform xslt = new XslCompiledTransform();

            string f1 = "C:\\Users\\USER\\Documents\\GitHub\\Lab2_WindowsForms\\XSL.xsl";

            xslt.Load(f1);

            string xml = "C:\\Users\\USER\\Documents\\GitHub\\Lab2_WindowsForms\\XMLFile1.xml";

            string result = @"HtmlResult.html";

            xslt.Transform(xml, result);
        }
    }
}
