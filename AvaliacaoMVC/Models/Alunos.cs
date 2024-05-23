using System.ComponentModel.DataAnnotations;

namespace AvaliacaoMVC.Models
{
    public class Alunos
    {
        public int AlunosId { get; set; }

        [Display(Name ="Nome do Aluno")]
        [Required(ErrorMessage ="Informe o nome do aluno")]
        [StringLength(100, ErrorMessage = "Até 100 caracteres (min 5 caracteres)",MinimumLength =5)]
        public string? Nome { get; set; }

        [Range(3,70,ErrorMessage ="Idade entre 3 e 70 anos")]
        [Required(ErrorMessage = "Informe a idade do aluno")]
        public int Idade { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Informe o endereço do aluno")]
        [StringLength(100)]
        public string? Endereco { get; set; }

        [Required(ErrorMessage = "Informe o CEP do aluno")]
        [StringLength(8,ErrorMessage ="CEP deve conter 8 numeros (sem traços ou espaços)")]
        public string? CEP { get; set; }

        [Required(ErrorMessage = "Informe a Turma do aluno")]
        [StringLength(20, ErrorMessage = "Até 50 carateres",MinimumLength =1)]
        public string? Turma { get; set; }

        [Display(Name = "Dia Pagamento")]
        public int DiaPagamento { get; set; }

        
        public double Mensalidade { get; set; }
    }
}
