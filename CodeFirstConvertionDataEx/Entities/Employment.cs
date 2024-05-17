﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConvertionDataEx.Entities
{
    public class Employment
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        [Required]
        public string Position { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
