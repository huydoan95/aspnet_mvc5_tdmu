namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Department
    {
        public long ID { get; set; }

        public long? Cat_ID { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(1500)]
        public string Description { get; set; }

        [Column(TypeName = "ntext")]
        public string Detail { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        public DateTime? Date { get; set; }

        [StringLength(250)]
        public string CreateBy { get; set; }

        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(250)]
        public string Url { get; set; }

        [Column("Description-google")]
        [StringLength(1500)]
        public string Description_google { get; set; }

        [StringLength(500)]
        public string Keyword { get; set; }

        public bool? Status { get; set; }

        [StringLength(10)]
        public string lang { get; set; }
    }
}
