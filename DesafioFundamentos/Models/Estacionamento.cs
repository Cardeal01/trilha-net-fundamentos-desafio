namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

         //Esta função está pedindo para o usuário cadastrar um veículo e guardando na váriavel veículos,do tipo lista.
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add (Console.ReadLine());
        }
        
        //Esta função está pedindo para o usuário informar a placa e armazena na variável placa
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = "";
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                decimal horas = 0;
                decimal valorTotal = 0;

                //Aqui pede a quantidade de horas que o veiculo permanaceu cadastrado e guardao valor na variavel horas
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                horas = Convert.ToDecimal(Console.ReadLine());
                
                /*realizando o calculo para saber o quanto ele irá pagar no veiculo estacionado
                primeiro faz a multiplicação com o preço por hora e depois soma o resultado da multiplicação com o preço inicial*/
                valorTotal = (precoInicial + (precoPorHora * horas));

                // aqui remove o veiculo,caso esteja cadastrado no sistema
                veiculos.Remove (placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                //quando não existe a placa no sistema,informa essa mensagem ao usuario
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                //aqui realiza um laço de repetição para mostrar os veiculos cadastrados
                Console.WriteLine("Os veículos estacionados são:");
                 foreach (var item in veiculos)
                 {
                    Console.WriteLine(item.ToString()+"\n");
                 }
        
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
