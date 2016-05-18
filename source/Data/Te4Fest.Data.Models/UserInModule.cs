﻿namespace Te4Fest.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Te4Fest.Data.Contracts;
    using Te4Fest.Data.Contracts.Models;

    public class UserInModule : DeletableEntity, IEntity
    {
        [Key]
        [Column(Order = 1)]
        public string UserId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ModuleId { get; set; }

        public virtual User User { get; set; }

        public virtual Module Module { get; set; }
    }
}
