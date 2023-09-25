namespace Models
{
    public class pessoa
    {
        //atributos da nossa classe pessoa
        private string nome { get; set; }

        private int idade { get; set; }

        private string email { get; set; }

        private int anoNascimento { get; set; }

        //medodo construtor da classe pessoa
        public pessoa(string nomePessoa, int idadePessoa, string email)
        {
            this.nome = nomePessoa;
            this.idade = idadePessoa;
            this.email = email;
            this.anoNascimento = DateTime.Now.Year - idadePessoa;
        }
        //metodo da classe pessoa
        public void Cantar()
        {
            Console.WriteLine($"{nome} esta cantando");
        }

        public void informaçoes()
        {
            Console.WriteLine($"{nome} tem o email {email}, nasceu em {anoNascimento} e tem {idade} anos");
        }


    }
}