using Hospedagem.Models;

//Reservando Suíte
Suite suite = new Suite("Premium", 4, 30);//<- INSIRA A SUITE

//Cria dias de reserva
Reserva reserva = new Reserva(10);//<- INSIRA A QUANTIDADE DE DIAS DA RESERVA
reserva.Hospedes = new List<Pessoa>();

//Criando Hóspedes
Pessoa pessoa1 = new Pessoa("Willian", "Domingues");
Pessoa pessoa2 = new Pessoa("Bianca", "Domingues");

//Adicionando Hóspedes
reserva.cadastrarHospedes(pessoa1);
reserva.cadastrarHospedes(pessoa2);

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Mostrando a saída
Console.WriteLine("SOLICITAÇÃO DE RESERVA: ");
reserva.obterQuantidade();
Console.WriteLine("****************************************************************************************************");
reserva.mostrarHospedes();
Console.WriteLine("****************************************************************************************************");
reserva.cadastrarSuite(suite);
Console.WriteLine("****************************************************************************************************");
reserva.calcularValorDiaria();
