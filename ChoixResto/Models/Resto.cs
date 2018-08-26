﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChoixResto.Models
{
    [Table("Resto")]
    public class Resto
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Telephone { get; set; }
    }
}