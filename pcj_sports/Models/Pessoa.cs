using System.ComponentModel.DataAnnotations.Schema;

namespace pcj_sports.Models
{
    [Table("pessoa", Schema ="public")]
    public class Pessoa
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string? Nome { get; set; }
        [Column("telefone")]
        public string? Telefone { get; set; }
        [Column("dataNascimento")]
        public DateTime? DataNascimento { get; set; }
        [Column("cpf")]
        public string? Cpf { get; set; }
    }

}
