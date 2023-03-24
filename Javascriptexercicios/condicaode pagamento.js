

function aplicarDesconto(valor, desconto) {
    return (valor - (valor * (desconto / 100))) // forma de calcular desconto 
}

function aplicarAcresicmo(valor, acresimo) {
    return (valor + (valor * (acresimo / 100))) // formula de calcular juros 
}

const precoEtiqueta = 100;
const condicaoPagamento = 4;


if (condicaoPagamento === 1) {
    console.log('debito voce pagara : ' + aplicarDesconto(precoEtiqueta, 10).toFixed(2));
} else if (condicaoPagamento === 2) {
    console.log('dinheiro ou pix voce pagara: ' + aplicarDesconto(precoEtiqueta, 15).toFixed(2));
} else if (condicaoPagamento === 3) {
    console.log('duas vezes voce pagara : ' + precoEtiqueta.toFixed(2));
} else {
    console.log('acima de 2 vezes voce pagara : ' + aplicarAcresicmo(precoEtiqueta, 10).toFixed(2));
}




/*  codigo sem funcao 
const precoEtiqueta = 100;
const condicaoPagamento = 3;



if (condicaoPagamento === 1) {
    precoFinal = precoEtiqueta - (precoEtiqueta * 0.10);
    console.log('debito voce pagara :', precoFinal.toFixed(2));
} else if (condicaoPagamento === 2) {
    precoFinal = precoEtiqueta - (precoEtiqueta * 0.15);
    console.log('dinheiro ou pix voce pagara:', precoFinal.toFixed(2));
} else if (condicaoPagamento === 3) {
    console.log('duas vezes voce pagara : ', precoEtiqueta.toFixed(2));
} else {
    precoFinal = precoEtiqueta + (precoEtiqueta * 0.10);
    console.log('acima de 2 vezes voce pagara : ', precoFinal.toFixed(2));
}

*/

