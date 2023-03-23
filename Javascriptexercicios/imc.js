//calculo de imc

const peso = 110;
const altura = 1.75;

const imc = peso /(altura * altura);
console.log(imc);

if (imc < 18.5){
    console.log('abaixo do peso ');
}else if (imc >= 18.5 && imc < 25){
    console.log('normal')
}else if (imc >= 25 && imc <= 30){
    console.log('acima do peso');
} else if (imc >= 30 && imc <= 40){
    console.log('obeso ');
} else if (imc > 40){
    console.log(' obesidade grave ');
}