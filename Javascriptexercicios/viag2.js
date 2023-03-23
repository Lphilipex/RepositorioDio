/* Codigo para calcular o cunsumo de gasolina por km   */

const precoGasolina = 5.79;
const precoEtenol = 6.66;
const gastoPorKm = 10;
const distancia = 100;
const tipoCompustivel = 'gasolina';


const consumo = distancia / gastoPorKm; // divide a distancia pelo gasto por km para ter o valor do cunsumo 

if (tipoCompustivel === 'Etanol') {
    const valorGasto = gastoPorKm * precoEtenol; // depois multiplica o consumo pelo preco do combustivel assim obtendo o preco finla gsto por km
    console.log(valorGasto.toFixed(2)); //tofixed converte o valor para texto, colocar 2 casas depois do ponto 
} else {
    const valorGasto = gastoPorKm * precoGasolina
    console.log(valorGasto.toFixed(2)); //tofixed converte o valor para texto, colocar 2 casas depois do ponto 
}








