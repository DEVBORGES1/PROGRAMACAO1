namespace AULA01.Models
{
    public class variaveis
    {
        // Tipos implicitos 
        // var teste = 10;
        
        // Anotação de tipos
        public int userCount = 10;

        // Uma variavel pode ser declarada 
        // e não inicializada 
        public int totalCount;

        public const int interestRate = 10;



        // o metodo construtor é invocado 
        // na instanciação do objeto por meio
        // da palavra reservada new 
        // por regra, o construtor sempre tem 
        // o mesmo nome da classe 
        public variaveis()
        {
            totalCount = 0;

            // TIPO IMPLICITO 
            // A PALAVRA CHAVE VAR SE ENCARREGA 
            // DE DEFINIR O TIPO DA VARIAVEL 
            // NA INSTRUÇÃO DE ATRIBUIÇÃO

            var signalStrength = 22;
            var companyName = "ACME";

        }

    }
}
