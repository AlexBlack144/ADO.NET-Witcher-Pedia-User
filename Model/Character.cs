namespace WindowsFormsWitcher.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Character")]
    public partial class Character
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? Chapter_Id { get; set; }

        public string Description { get; set; }

        public string Gender { get; set; }

        public string Race { get; set; }

        public string Occupation { get; set; }

        public string Affiliation { get; set; }

        public string Death { get; set; }

        public string Image { get; set; }

        public virtual Chapter Chapter { get; set; }
    }
}
