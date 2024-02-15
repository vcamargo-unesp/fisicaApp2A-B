int Menu()
{
    Console.WriteLine("====== fisicaApp ======");
    Console.WriteLine("1- Velocidade");
    Console.WriteLine("2- Aceleração");
    Console.WriteLine("3- Movimento Uniforme");
    Console.WriteLine("4- Toricelli");
    Console.WriteLine("0- Sair");
    Console.WriteLine();
    Console.WriteLine("Opção: ");
    string? op = "";
    op = Console.ReadLine();
    int o = 0;
    Int32.TryParse(op, out o);
    return o;
}

double VelocidadeMedia()
{
    double s, t;
    string? i = "";

    Console.WriteLine("Espaço: ");
    i = Console.ReadLine();
    Double.TryParse(i, out s);
    Console.WriteLine("Tempo: ");
    i = Console.ReadLine();
    Double.TryParse(i, out t);

    return s / t;
}

double Aceleracao()
{
    double v, t;
    string? i = "";

    Console.WriteLine("Velocidade: ");
    i = Console.ReadLine();
    Double.TryParse(i, out v);
    Console.WriteLine("Tempo: ");
    i = Console.ReadLine();
    Double.TryParse(i, out t);

    return v / t;
}

double MovimentoUniforme()
{
    double s0, v, t;
    string? i = "";

    Console.WriteLine("Espaço inicial: ");
    i = Console.ReadLine();
    Double.TryParse(i, out s0);
    Console.WriteLine("Velocidade: ");
    i = Console.ReadLine();
    Double.TryParse(i, out v);
    Console.WriteLine("Tempo: ");
    i = Console.ReadLine();
    Double.TryParse(i, out t);
    return s0 + v * t;
}

double Torricelli()
{
    double v0, a, s;
    string? i = "";

    Console.WriteLine("Velocidade inicial: ");
    i = Console.ReadLine();
    Double.TryParse(i, out v0);
    Console.WriteLine("Aceleração: ");
    i = Console.ReadLine();
    Double.TryParse(i, out a);
    Console.WriteLine("Espaço: ");
    i = Console.ReadLine();
    Double.TryParse(i, out s);

    return Math.Sqrt(Math.Pow(v0, 2) + 2 * a * s);
}

int escolha = 0;
do
{
    escolha = Menu();

    if(escolha == 1) // velocidade media
    {
        double v = VelocidadeMedia();
        Console.WriteLine("Velocidade média: " + v);
    }
    else if (escolha == 2) // aceleracao
    {
        double a = Aceleracao();
        Console.WriteLine("Aceleração: " + a);
    }else if(escolha == 3) // movimento uniforme
    {
        double s = MovimentoUniforme();
        Console.WriteLine("Espaço final: " + s);
    }else if(escolha == 4) // torricelli
    {
        double v = Torricelli();
        Console.WriteLine("Velocidade final: " + v);
    }

}while(escolha != 0); // não for sair
