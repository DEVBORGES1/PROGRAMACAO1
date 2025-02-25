namespace AULA01.Models
{
    public class variaveis
    {
        // Tipos implicitos 
        // var teste = 10;
        
        // Anotação de tipos
        public int userCount = 10;
        public byte MinValue = 0;
        public byte MaxValue = 255;
        public short MinshortValue = -32768;
        public short MaxshortValue = 32767;
        public int MinintValue = -2147483648;
        public int MaxintValue = 2147483647;
        public uint MinuintValue = 0;
        public uint MaxuintValue = 4294967295;
        public long MinlongValue = -9223372036854775808;
        public long MaxlongValue = 9223372036854775807;


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
