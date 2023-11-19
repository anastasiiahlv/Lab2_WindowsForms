using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_WindowsForms
{
    internal interface ISearch
    {
        List<Material> Search(Material material, string path);
    }
}
