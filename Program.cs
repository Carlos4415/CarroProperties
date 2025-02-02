// Este projeto implementa uma classe que modela um carro.  
// A classe possui os seguintes atributos e métodos:  
// - Atributos: podem incluir modelo, marca, ano, cor e velocidade atual.  
// - Métodos:  
//   - Acelerar: aumenta a velocidade do carro.  
//   - Frear: reduz a velocidade do carro.  
//   - Buzinar: emite um som característico de buzina.  
// O objetivo é simular o comportamento básico de um carro, permitindo interações simples como acelerar, frear e buzinar.  
Carro carro = new Carro();
carro.Fabricante = "Honda";
carro.Modelo = "Civic";
carro.Ano = 2020;
carro.QuantidadePortas = 4;

carro.exibirInformacoes();
Console.WriteLine($"\n{carro.DescricaoDetalhada}");
carro.acelerar();
Console.WriteLine($"\nVelocidade: {carro.Velocidade}");
carro.frear();
Console.WriteLine($"\nVelocidade: {carro.Velocidade}");
carro.buzinar();