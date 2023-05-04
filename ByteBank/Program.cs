using ByteBank;

//ContaCorrente contaAndre = new ContaCorrente();
//contaAndre.titular = "André Silva";
//contaAndre.numero_agencia = 15;
//contaAndre.conta = "1010-X";
//contaAndre.saldo = 100;


//Console.WriteLine("Saldo da conta do André = " + contaAndre.saldo);

//ContaCorrente contaMaria = new ContaCorrente();
//contaMaria.titular = "Maria Sousa";
//contaMaria.numero_agencia = 17;
//contaMaria.conta = "1010-5;";
//contaMaria.saldo = 330;

//Console.WriteLine("Saldo da conta da Maria =" + contaMaria.saldo);

//contaAndre.Transferir(50, contaMaria);
//Console.WriteLine("Saldo do André = " + contaAndre.saldo);
//Console.WriteLine("Saldo da Maria = " + contaMaria.saldo);

//ContaCorrente contaPedro = new ContaCorrente();
//contaPedro.titular = "Pedro Silva";
//Console.WriteLine(contaPedro.titular);
//Console.WriteLine(contaPedro.saldo);
//Console.WriteLine(contaPedro.numero_agencia);
//Console.WriteLine(contaPedro.conta);

Cliente cliente = new Cliente();
cliente.nome = "Andre Silva";
cliente.cpf = "123456789";
cliente.profissao = "Admin";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.conta = "1010-X";
conta.numero_agencia = 15;
conta.saldo = 100;

Console.WriteLine("Titular = "+ conta.titular.nome);
Console.WriteLine("Cpf = " + conta.titular.cpf);
Console.WriteLine("Profissão = " + conta.titular.profissao);
Console.WriteLine("N° Conta = " + conta.conta);
Console.WriteLine("Saldo = " + conta.saldo);
Console.WriteLine("N° Agência = " + conta.numero_agencia);

