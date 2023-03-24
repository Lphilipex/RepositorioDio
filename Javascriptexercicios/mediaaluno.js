
const nota1 = 7;
const nota2 = 8;
const nota3 = 7;
const media = (nota1 + nota2 + nota3) / 3; // calculo para obter a media 


if (media < 5) {
    console.log('sua media :', media.toFixed(2), 'reprovado') // se a media for menor que 5 reprovado 
} else if (media >= 5 && media <= 7) {
    console.log('sua media :', media.toFixed(2), 'recuperacao') // se a media for maior ou igua a 5 ou igual menor a 7 recuperação 
} else {
    console.log('sua media : ', media.toFixed(2), 'passou de semestre') // se a media for mair que 7 passo de semestre 
}




