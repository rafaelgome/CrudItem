using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudItem.Models
{
    public class Item
    {
        [Key]
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}