using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame
{
    [Table("videogames")]
    public class Videogame
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        [Required]
        [MaxLength(64)]
        public string? Name { get; set; }

        [Column("overview")]
        [Required]
        [MaxLength(500)]
        public string? Overview { get; set; }
        [Column("release_date")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        [ForeignKey("SoftwareHouse")] 
        [Column("software_house_id")]
        [Required]

        public int SoftwareHouseId { get; set; }
        public SoftwareHouse? SoftwareHouse { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Overview: {Overview}");
            Console.WriteLine($"Release Date: {ReleaseDate:dd/MM/yyyy}");
            Console.WriteLine($"Software House: {SoftwareHouse?.Name ?? "Unknown"}");
        }
    }
}
