using System.ComponentModel.DataAnnotations;

namespace L01P02_2020LM650_2020PF601.Models
{
    public class motoristas
    {
        [Key]
        public int motoristaId { get; set; }
        public string? nombreMotorista { get; set; }
    }
}
