using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sazonow.Clases.Entityes
{
    public class Sell
    {
        [Key]
        public int SellId { get; set; }
        [Required]
        public DateTime SellDateTime { get; set; }
        [Required]
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User user { get; set; }
    }
}
