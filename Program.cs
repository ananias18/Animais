using Aula12.Darwin;

public class program
{
    public static void Main(string[] args)
    {
        Mamifero m = new Mamifero();
        Reptil r = new Reptil();
        Peixe p = new Peixe();
        Ave a = new Ave();

        Canguru c = new Canguru();
        Cachorro k = new Cachorro();
        Cobra j = new Cobra();
        Tartaruga t = new Tartaruga();
        Goldfish g = new Goldfish();
        Arara o = new Arara();

        
        k.reagir("olá");
        k.reagir("Toma comida");
        k.reagir(true);
        k.reagir(2, 12.5f);
        k.reagir(17, 4.5f);
        k.reagir(11, 45);
        k.reagir(21, 00);
    }
}
