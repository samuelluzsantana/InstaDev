using System.IO;
using InstaDev.Interfaces;
namespace InstaDev.Models


{
    public class Usuario : InstadevBase , IUsuario
    {
        public int idUsuario { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
        public string DataDeNascimento { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Senha { get; set; }

        public const string PATH = "Database/usuario.csv";

        public string PrepararLinha(Usuario u) 
        { return $"{u.idUsuario};{u.Nome};{u.Foto};{u.DataDeNascimento};{u.Email};{u.UserName};{u.Senha}";}

        public void Cadastrar(Usuario user)
        {
           string[]linhas = {PrepararLinha(user)};
           File.AppendAllLines(PATH, linhas);
        }
    }
}