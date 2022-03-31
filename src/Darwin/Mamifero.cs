namespace Aula12.Darwin
{

    public class Mamifero : Animal
    {
        private string corPelo;
        public override void locomover()
        {
            Console.WriteLine("Correndo");
        }
        public override void alimentar()
        {
            Console.WriteLine("Mamando");
        }
        public override void emitirsom()
        {
            Console.WriteLine("Som de Mamifero");
        }
        public string getCorPelo()
        {
            return corPelo;
        }
        public void setCorPelo(string c)
        {
            corPelo = c;
        }
    }
}