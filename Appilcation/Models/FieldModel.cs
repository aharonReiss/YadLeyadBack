using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appilcation.Models
{
    public class FieldModel
    {
        public int FieldType { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string PlaceHolder { get; set; }
        public bool? Required { get; set; }
        public List<OptionsModel>? Options { get; set; }
    }
}
