using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace ControledeContatos.Models
{
    public class ContatoModel
    {
        public int Id {get; set;}
        
        [Required]
        public string Nome {get;set;}
        
        
        [Required]
        public string Email{get;set;}
        
        
        [Required]
        public string celular{get;set;}
        

    }
}