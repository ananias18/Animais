namespace Aula12.Darwin
{

    public class Peixe : Animal
    {
        private string corEscama;

        public void soltarBolhas()
        {
            Console.WriteLine("Soltando Bolhas");
        }


        public override void locomover()
        {
            Console.WriteLine("Nadando");
        }
        public override void alimentar()
        {
            Console.WriteLine("Comendo substancias");
        }
        public override void emitirsom()
        {
            Console.WriteLine("Som de Peixe");
        }
        public string getCorEscama()
        {
            return corEscama;
        }
        public void setCorEscama(string cm)
        {
            corEscama = cm;
        }
    }
}