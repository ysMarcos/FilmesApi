using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O titulo do filme é obrigatório")]
        public string Titulo { get; set; }
        
        [Required(ErrorMessage = "O titulo do filme é obrigatório")]
        public string Genero { get; set; }
        
        [Required(ErrorMessage = "A duração do filme é obritória")]
        [Range(70, 600, ErrorMessage = "A duração do filme deve estar entre 70 e 600")]
        public int Duracao { get; set; }
        
    }
}