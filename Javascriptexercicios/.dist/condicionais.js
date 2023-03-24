/* condicionais 
    verificar se o numero e par 

    = atribuicao 
    == iguadade ignorando o tipo de variavel ele converte para fazer a comparção 
    === igualdade

*/

const numero = 10;

const eNumeroPar = (numero % 2) === 0;

if (eNumeroPar) {
    console.log('par');
} else {
    console.log('impar')
}
// se a condicional que estiver nos () for vedadeira ele executa o codigo que esta nas {}

/* if (!eNumeroPar) {
    console.log('impar')
}// ! faz o sentido de negação converte o  boleano para o oposto 
*/

const numero2 = 0;
const numeroDivisivelPor5 = (numero2 % 5) === 0;

if (numero2 === 0) {
    console.log('o numero e invalido')
} else if (numeroDivisivelPor5) { // pode emendar o if dentro do else 
    console.log('sim')
} else {
    console.log('nao')
}





