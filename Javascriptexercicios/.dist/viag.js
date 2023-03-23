/* Codigo para calcular o cunsumo de gasolina por km   */

const precoCombust = 5.79; 

const gastoPorKm = 9.5; 

const distancia = 100;


const consumo = distancia / gastoPorKm; // divide a distancia pelo gasto por km para ter o valor do cunsumo 

const precoFinal = consumo * precoCombust; // depois multiplica o consumo pelo preco do combustivel assim obtendo o preco finla gsto por km
 
console.log(precoFinal);


