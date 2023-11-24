using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o seu login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite sua senha")]
        public string Senha { get; set; }
    }
}
