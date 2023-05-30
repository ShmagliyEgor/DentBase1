namespace DentBase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MainClient")]
    public partial class MainClient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string FIO { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        public DateTime TimeRegister { get; set; }

        public int? AgePacient { get; set; }

        public int? NumberTalon { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cost { get; set; }

        public void UpdateValue(MainClient mc)
        {
            FIO = mc.FIO;
            Description = mc.Description;
            TimeRegister = mc.TimeRegister;
            AgePacient = mc.AgePacient;
            NumberTalon = mc.NumberTalon;
            Cost = mc.Cost;
        }
    }
}
