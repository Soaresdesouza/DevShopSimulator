using System.ComponentModel.DataAnnotations;

namespace DSS.Identidade.API.Models
{
    public class UsuarioRegistrado
    {
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage ="O campo {0} está em formato inválido")]
        public string Email { get; set; }
        [Required(ErrorMessage ="O Campo {0} é obrigatório")]
        [StringLength(20, ErrorMessage ="O campo {0} precisa ter entre {2} e {1}", MinimumLength = 6)]
        public string Senha { get; set; }
        [Compare("Senha", ErrorMessage ="As senhas não conferem.")]
        public string ConfirmacaoSenha { get; set; }
    }

    public class UsuarioLogin
    {
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(20, ErrorMessage = "O campo {0} precisa ter entre {2} e {1}", MinimumLength = 6)]
        public string Senha { get; set; }
    }
}
