using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]//ограничивает набор допустимых для ввода символов
        [Required]//свойство должно иметь значение,может свободно вводить пробелы
        [StringLength(30)]//max или min длина строкового свойства
        public string Genre { get; set; }

        [Range(1, 100)]//ограничивает значения указанным диапазоном
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]//значение "PG-13" допустимо для Rating
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }
    }
}
