using Microsoft.AspNetCore.Mvc;

namespace AULA01.Controllers
{
    public class Result
    {
        public string Texto { get; set; } = string.Empty;
    }

    public class TesteController : Controller
    {
        private readonly ILogger<TesteController> _logger;

        public TesteController(ILogger<TesteController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Result());
        }

        [HttpPost]
        public IActionResult Index(string Texto)
        {
            Result resultado = new Result();
            resultado.Texto = CifraDeCesar(Texto.ToUpper(),5); // Usando um deslocamento de 5
            return View(resultado);
        }

        // Método para criptografar o texto com a Cifra de César
        private string CifraDeCesar(string texto, int deslocamento)
        {
            var resultado = new System.Text.StringBuilder();

            foreach (char c in texto)
            {
                if (char.IsLetter(c)) 
                {
                    char a = char.IsLower(c) ? 'a' : 'A';
                    char letraCriptografada = (char)(((c - a + deslocamento) % 26) + a);
                    resultado.Append(letraCriptografada);
                }
                else
                {
                    resultado.Append(c);
                }
            }

            return resultado.ToString();
        }
    }
}
