function calcularViagem(gastoCombustivel, distancia, precoCombustivel) {
  valorLitros = distancia / gastoCombustivel
  valorLitrosConvertido = Math.round(valorLitros)
  return valorLitrosConvertido * precoCombustivel
}

console.log(calcularViagem(12, 400, 4.5))

function imparPar(numero) {
  var resultado = ''
  if (numero % 2 === 0) {
    resultado = 'Par'
  } else {
    resultado = 'Impar'
  }
  return resultado
}

console.log(imparPar(3))

function calcularViagemNovo(gastoCombustivel, distancia, combustivel) {
  var precoCombustivelEtanol = 4.5
  var precoCombustivelGasolina = 6.1
  valorLitros = distancia / gastoCombustivel

  if (combustivel == 'g' || combustivel == 'G') {
    return (valorLitros * precoCombustivelGasolina).toFixed(2)
  }
  if (combustivel == 'e' || combustivel == 'E') {
    return (valorLitros * precoCombustivelEtanol).toFixed(2)
  }
}

console.log(calcularViagemNovo(12, 400, 'g'))
console.log(calcularViagemNovo(12, 400, 'e'))
