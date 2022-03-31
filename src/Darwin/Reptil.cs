namespace Aula12.Darwin
{

    public class Reptil : Animal
    {
        private string corEscama;

        public override void locomover()
        {
            Console.WriteLine("Rastejando");
        }
        public override void alimentar()
        {
            Console.WriteLine("Comendo Vegetais");
        }
        public override void emitirsom()
        {
            Console.WriteLine("Som de Reptil");
        }
        public string getCorEscama()
        {
            return corEscama;
        }
        public void setCorEscama(string ce)
        {
            corEscama = ce;
        }
    }
}