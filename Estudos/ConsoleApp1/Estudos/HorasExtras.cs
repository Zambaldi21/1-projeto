using ConsoleApp1.Utils;
namespace ConsoleApp1.Estudos
{
    public class HorasExtras
    {
        public static void Processar()
        {
            //inputs
            var dadosIo = new DadosIo();

            Console.WriteLine("Considere minutos at� 59.");
            var solicitaHorarioColaborador = dadosIo.SolicitarValorInteiroAoUsuario("Digite se voc� � 4 horas ou 6 horas: ");
            var solicitaHoraEntrada = dadosIo.SolicitarValorInteiroAoUsuario("Digite a hora que voc� entrou: ");
            var solicitaMinutoEntrada = dadosIo.SolicitarValorInteiroAoUsuario("Digite o minuto que voc� entrou: ", 59);
            var solicitaHoraSaida = dadosIo.SolicitarValorInteiroAoUsuario("Digite a hora que voc� saiu: ");
            var solicitaMinutoSaida = dadosIo.SolicitarValorInteiroAoUsuario("Digite o minuto que voc� saiu: ", 59);

            //process
            var converteMinutoHoraEntrada = solicitaMinutoEntrada / 60;
            var converteMinutoHoraSaida = solicitaMinutoSaida / 60;
            var calcula = (solicitaHoraEntrada + converteMinutoHoraEntrada) - (solicitaHoraSaida + converteMinutoHoraSaida);

            if (solicitaHorarioColaborador == 4)
            {
                var resultado = calcula - 4;
            }
            else if (solicitaHorarioColaborador == 6)
            {
                var resultado = calcula - 6;
            }
            else if (solicitaHorarioColaborador <= 4 || solicitaHorarioColaborador <= 6)
            {
                Console.WriteLine("Voc� n�o possui horas extras.");
            }
            //output
            Console.WriteLine("Voce");
        }
    }
}
