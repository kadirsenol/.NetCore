using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Contrib_ORM_ObjectRelationalMapping_.Models
{
    [Table("Filmler")]
    public class Film
    {
        [Key] // pkey information
        public int Id { get; set; }
        public string? FilmAdi { get; set; }
        public string? Aciklama { get; set; }
        public int? Sure { get; set; }
    }
}
