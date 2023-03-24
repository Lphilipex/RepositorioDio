function escrevaNome(nome) {
    return ('meu nome é ' + nome);
}

console.log(escrevaNome('philipe'));
console.log(escrevaNome('philipe'));

function verificarIdade(idade) {
    if (idade >= 18) {
        return ' maior';
    } else {
        return 'menor';
    }
}

console.log(verificarIdade(24));

verificarIdade(15);