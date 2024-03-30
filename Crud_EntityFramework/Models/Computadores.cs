using System.ComponentModel.DataAnnotations;

namespace Crud_EntityFramework.Models
{
    public class Computadores
    {
        [Key]
        public int Id { get; set; }
        public string Marca { get; set;}
        public string Processador { get; set; }
        public string Placa_Mae { get; set; }
        public string Memória { get; set; }
        public string HD { get; set; }
        [Required]
        public int NumeroPratrimonio { get; set; }
        public DateTime Data_compra { get; set; }
    }
}
