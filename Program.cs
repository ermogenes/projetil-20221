Console.WriteLine("-- Projétil --\n");

Console.Write("Entre com a velocidade, em m/s..: ");
double velocidadeInicial = Convert.ToDouble(Console.ReadLine());

Console.Write("Entre com o ângulo, em graus....: ");
double anguloEmGraus = Convert.ToDouble(Console.ReadLine());

double anguloEmRadianos = anguloEmGraus * (Math.PI / 180);
const double gravidade = 9.80665;

double altura = (Math.Pow(velocidadeInicial * Math.Sin(anguloEmRadianos), 2)) / (2 * gravidade);
double alcance = (Math.Pow(velocidadeInicial, 2) * Math.Sin(2 * anguloEmRadianos)) / gravidade;

Console.WriteLine($"\nAlcance........: {alcance:N2} m");
Console.WriteLine($"Altura máxima..: {altura:N2} m");
