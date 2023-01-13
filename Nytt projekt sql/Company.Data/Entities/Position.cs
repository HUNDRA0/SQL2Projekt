﻿using Company.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Data.Entities
{
    public class Position : IEntity
    {
        public int Id { get; set; }
        [MaxLength(80), Required]
        public string? PositionName { get; set; }
        public virtual ICollection<Employee_Position>? Employee_Positions  { get; set; }
    }
}