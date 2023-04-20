using ByteBank;

ContaCorrente contaAndre = new ContaCorrente();
contaAndre.titular = "André Silva";
contaAndre.numero_agencia = 15;
contaAndre.conta = "1010-X";
contaAndre.saldo = 100;


Console.WriteLine("Saldo da conta do André = " + contaAndre.saldo);

ContaCorrente contaMaria = new ContaCorrente();
contaMaria.titular = "Maria Sousa";
contaMaria.numero_agencia = 17;
contaMaria.conta = "1010-5;";
contaMaria.saldo = 330;

Console.WriteLine("Saldo da conta da Maria =" + contaMaria.saldo);

contaAndre.Transferir(50, contaMaria);
Console.WriteLine("Saldo do André = " + contaAndre.saldo);
Console.WriteLine("Saldo da Maria = " + contaMaria.saldo);

ContaCorrente contaPedro = new ContaCorrente();
contaPedro.titular = "Pedro Silva";
Console.WriteLine(contaPedro.titular);
Console.WriteLine(contaPedro.saldo);
Console.WriteLine(contaPedro.numero_agencia);
Console.WriteLine(contaPedro.conta);



