using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2_WindowsForms
{
    internal class LINQ: ISearch
    {
        public List<Material> Search(Material material, string path)
        {
            List<Material> result = new List<Material>();
            XDocument xDoc = XDocument.Load(path);

            List<XElement> searchedMaterials = (from obj in xDoc.Descendants("Material")
                                    where
                                    (
                                    (obj.Attribute("AuthorName").Value == material.AuthorName || material.AuthorName == null) &&
                                    (obj.Attribute("Name").Value == material.Name || material.Name == null) &&
                                    (obj.Attribute("Faculty").Value == material.Faculty || material.Faculty == null) &&
                                    (obj.Attribute("Department").Value == material.Department || material.Department == null) &&
                                    (obj.Attribute("Type").Value == material.Type || material.Type == null) &&
                                    (obj.Attribute("CreationDate").Value == material.CreationDate || material.CreationDate == null)
                                    )
                                    select obj).ToList();

            foreach (XElement m in searchedMaterials)
            {
                Material myMaterial = new Material();

                myMaterial.AuthorName = m.Attribute("AuthorName").Value;
                myMaterial.Name = m.Attribute("Name").Value; 
                myMaterial.Faculty = m.Attribute("Faculty").Value;
                myMaterial.Department = m.Attribute("Department").Value;
                myMaterial.Type = m.Attribute("Type").Value;
                myMaterial.CreationDate = m.Attribute("CreationDate").Value;


                result.Add(myMaterial);
            }
            return result;
        }
    }
}
