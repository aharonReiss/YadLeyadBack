using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Fields
    {
        [Key]
        public int FieldId { get; set; }
        public int FieldType { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }
        public string PlaceHolder { get; set; }
        public bool? Reqired { get; set; }
        public string Title { get; set; }
    }
}
