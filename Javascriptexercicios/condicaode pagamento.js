const precoEtiqueta =  100;
const condicaoPagamento = 3;


if(condicaoPagamento === 1){
    precoFinal = precoEtiqueta - (precoEtiqueta * 0.10 );
    console.log('debito voce pagara :',precoFinal.toFixed(2)); 
}else if (condicaoPagamento === 2){
    precoFinal = precoEtiqueta - (precoEtiqueta * 0.15);
    console.log('dinheiro ou pix voce pagara:', precoFinal.toFixed(2));
}else if(condicaoPagamento === 3 ){ 
    console.log('duas vezes voce pagara : ', precoEtiqueta.toFixed(2));
}else {
    precoFinal = precoEtiqueta + (precoEtiqueta * 0.10);
    console.log('acima de 2 vezes voce pagara : ', precoFinal.toFixed(2));
}

