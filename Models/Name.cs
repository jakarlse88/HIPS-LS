using System;
using System.Collections.Generic;

#nullable disable

namespace HIPS_LS.Models
{
    public partial class Name
    {
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string Designation { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual Language Language { get; set; }
    }
}
