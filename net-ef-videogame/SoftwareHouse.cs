using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    [Table("softwarehouses")]
    public class SoftwareHouse
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        [Required]
        [MaxLength(32)]
        public string? Name { get; set; }

        [Column("city")]
        [Required]
        [MaxLength (64)]
        public string? City { get; set; }  
        
        public List<Videogame>? Videogames { get; set; }

    }
}
