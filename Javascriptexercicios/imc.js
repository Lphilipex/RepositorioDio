//calcculadora de imc


function calcularImc(peso, altura) {
    return peso / (altura * altura);
}// função para fazer o calculo do imc 

function clsassificarImc(imc) {
    if (imc < 18.5) {
        return 'abaixo do peso ';
    } else if (imc >= 18.5 && imc < 25) {
        return 'normal';
    } else if (imc >= 25 && imc <= 30) {
        return 'acima do peso';
    } else if (imc >= 30 && imc <= 40) {
        return 'obeso ';
    } else if (imc > 40) {
        return ' obesidade grave ';
    }
} // funcao para classificar o imc 


(function () {
    const peso = 110;
    const altura = 1.75;

    const imc = calcularImc(peso, altura)
    console.log('seu imc e :', imc.toFixed(2), 'voce esta classificado como', clsassificarImc(imc));
})();// função primcipal a função esta dentro dos parenteses por que assim nao e preciso chamar e essa funcao so funciona dentro desse parentese qunado se quer execuatr somente uma vez 


/*

function main() {
    const peso = 110;
    const altura = 1.75;

    const imc = calcularImc(peso, altura)
    console.log('seu imc e :',imc.toFixed(2), 'você esta classificado como', clsassificarImc(imc));
}

*/