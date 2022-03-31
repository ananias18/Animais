namespace Aula12.Darwin
{

    public abstract class Animal
    {
        protected float peso;
        protected int idade;
        protected int membros;

        public abstract void locomover();
        public abstract void alimentar();
        public abstract void emitirsom();

        public float getPeso()
        {
            return peso;
        }
        public void setPeso(float p)
        {
            peso = p;
        }
        public int getIdade()
        {
            return idade;
        }
        public void setIdade(int i)
        {
            idade = i;
        }
        public int getMembros()
        {
            return membros;
        }
        public void setMembros(int m)
        {
            membros = m;
        }

    }
}