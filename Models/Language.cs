using System;
using System.Collections.Generic;

#nullable disable

namespace HIPS_LS.Models
{
    public partial class Language
    {
        public Language()
        {
            Names = new HashSet<Name>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string NameLocal { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual ICollection<Name> Names { get; set; }
    }
}
