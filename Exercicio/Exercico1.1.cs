using Exercicio;

Pessoas pessoas = new Pessoas();

pessoas.nome = "Marcelo do Hipoglós";
pessoas.altura = 1.75;
pessoas.peso = 65;
pessoas.idade = 27;

Console.WriteLine(pessoas.nome);
Console.WriteLine("Seu peso é de " + pessoas.peso + "Kg");
Console.WriteLine("Você tem " + pessoas.idade + " anos");
Console.WriteLine("e tem " + pessoas.altura + "m de altura.");
