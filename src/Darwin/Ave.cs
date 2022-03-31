namespace Aula12.Darwin
{

    public class Ave : Animal
    {
        private string corPena;

        public override void locomover()
        {
            Console.WriteLine("Voando");
        }
        public override void alimentar()
        {
            Console.WriteLine("Comendo Frutas");
        }
        public override void emitirsom()
        {
            Console.WriteLine("Som de Ave");
        }
        public void fazerNinho()
        {
            Console.WriteLine("Fazendo Ninho");
        }

        public string getCorPena()
        {
            return corPena;
        }
        public void setCorPena(string cp)
        {
            corPena = cp;
        }
    }
}