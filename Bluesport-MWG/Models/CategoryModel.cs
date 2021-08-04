using System.Collections.Generic;

namespace Bluesport_MWG.Models
{
    public class CategoryModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public List<CategoryModel> subCate { get; set; }
    }
}