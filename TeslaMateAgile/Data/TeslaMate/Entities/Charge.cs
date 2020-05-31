﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeslaMateAgile.Data.TeslaMate.Entities
{
    [Table("charges")]
    public class Charge
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        [ForeignKey("charging_process_id")]
        public ChargingProcess ChargingProcess { get; set; }
    }
}
