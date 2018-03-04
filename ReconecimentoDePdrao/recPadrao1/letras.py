#!/usr/bin/env python
# -*- coding: utf-8 -*-
import matplotlib.pyplot as plt
import numpy as np

print(61 * "-")
# print()
print("| 1 | THE_VENGEANCE_OF_FELIX_by_J_de_Medeiros_E_Albuquerque |")
print("| 2 | LIFE_by_JM_Machado_de_Assis                           |")
print("| 3 | THE_ATTENDANT_S_CONFESSION_by_JM_Machado_de_Assis     |")
print("| 4 | THE_FORTUNE_TELLER_by_JM_Machado_de_Assis             |")
print("| 5 | THE_PIGEONS_by_Coelho_Netto                           |")
print(61 * "-")
x = int(input("Escoha um numero para carregar o texto"))

if x == 1:
    arq = open('textos/THE_VENGEANCE_OF_FELIX_by_J_de_Medeiros_E_Albuquerque.txt', 'r')
    pass
elif x == 2:
    arq = open('textos/LIFE_by_JM_Machado_de_Assis.txt', 'r')
    pass
elif x == 3:
    arq = open('textos/THE_ATTENDANT_S_CONFESSION_by_JM_Machado_de_Assis.txt', 'r')
    pass
elif x == 4:
    arq = open('textos/THE_FORTUNE_TELLER_by_JM_Machado_de_Assis.txt', 'r')
    pass
elif x == 5:
    arq = open('textos/ THE_PIGEONS_by_Coelho_Netto.txt', 'r')
    pass
else:
    arq = open('textos/ THE_PIGEONS_by_Coelho_Netto.txt', 'r')

texto = arq.read()
texto = texto.lower()  # Tudo para minusculas

texto = texto.replace("\n", " ")
texto = texto.replace(".", " ")
texto = texto.replace("?", " ")
texto = texto.replace("!", " ")
texto = texto.replace(",", " ")
texto = texto.replace(";", " ")

texto = texto.replace("á", "a")
texto = texto.replace("à", "a")
texto = texto.replace("ã", "a")
texto = texto.replace("â", "a")
texto = texto.replace("é", "e")
texto = texto.replace("ê", "e")
texto = texto.replace("í", "i")
texto = texto.replace("ó", "o")
texto = texto.replace("ô", "o")
texto = texto.replace("ú", "u")
texto = texto.replace("ç", "c")


# Conta o total de letras
def contador_letras_total():
    contador = 0
    for i in texto:
        contador = contador + 1
    return contador


# Chama metodo contador geral
somatorio = contador_letras_total()

# Lista com letras
lista = []
# Lista com as letras de a-z
for i in range(ord('a'), ord('z') + 1):
    lista.append(chr(i))
lista.append(' ')


# Conta a quantidade de letras individualmente
def contador_letras(letra):
    contador = 0
    for caracter in texto:
        if caracter in letra:
            contador = contador + 1
    return contador


# Mostra a quantidade de cada letra individualmente
def print_quant_letras(elemento):
    total = contador_letras(elemento)
    print(elemento, " : ", total)
    return total


# Coloca no vetor por par as letras
listaPar = []


def cria_vetor_par_letras():
    for i in range(len(lista)):
        for j in range(len(lista)):
            caracter = lista[i] + lista[j]
            # print caracter
            listaPar.append(caracter)


# Cria vetor com pares de letras
cria_vetor_par_letras()
# print listaPar

# Preenche o vetor pegando de dois a dois o texto
listaDois = []


def coloca_dois_a_dois_texto():
    p = 1
    for h in range(somatorio - 1):
        junto = texto[h] + texto[p]
        listaDois.append(junto)
        p = p + 1


coloca_dois_a_dois_texto()


# Conta a quantidade de pares de letras
def contador_par_letras(par):
    contador = 0
    for f in range(len(listaDois)):
        if listaDois[f] == par:
            contador = contador + 1
    return contador


# Mostra a quantidade de cada par de letra
def print_quant_par_letras(elemento):
    total = contador_par_letras(elemento)
    print(elemento, " : ", total)
    return total


# Cria vetorTamanho = {0,1,2,3...}, vetor porcentagem e vetor
vetorPorcentagem = []
vetorTamanho = []
vetor = []
for j in range(len(lista)):
    recebe = float(print_quant_letras(lista[j]))
    vetorTamanho.append(j)
    porcentagem = recebe / somatorio
    vetorPorcentagem.append((round(porcentagem, 3) * 100))
    vetor.append(recebe)

# Cria vetor tamanho Par= {0,1,2,3...}, vetorPar porcentagem e vetor par
vetorTamanhoPar = []
vetorParPorcentagem = []
vetorPar = []
for w in range(len(listaPar)):
    recebePar = float(print_quant_par_letras((listaPar[w])))
    vetorTamanhoPar.append(w)
    porcentagemPar = recebePar / (len(listaDois))
    vetorParPorcentagem.append(round(porcentagemPar, 3) * 100)
    vetorPar.append(recebePar)


# Método para armazenar probabilidades condicionais

def prob_cond_a_b(posicao, retorno):
    # type: (object, object) -> object
    if vetor[retorno] != 0:
        prob = vetorPar[posicao] / vetor[retorno]
    else:
        prob = 0
    # print par, " : ", prob

    return prob


# Cria vetor condicional
vetorCond = []
l = 0
contador = 0
linha = []
for t in range(len(listaPar)):
    recebeCond = prob_cond_a_b(t, l)
    if l == len(vetor) - 1:
        l = 0
        contador = contador + 1
        linha.append(recebeCond)
        vetorCond.append(linha)
        linha = []
    else:
        l = l + 1
        linha.append(recebeCond)


# print(vetorPorcentagem)


def grafico1():
    color = []
    for c in range(len(lista)):
        color.append('r')

    data = (vetorPorcentagem, color, lista)
    xPositions = np.arange(len(data[0]))
    barWidth = 0.50  # Largura da barra

    _ax = plt.axes()  # Cria axes

    # bar(left, height, width=0.8, bottom=None, hold=None, **kwargs)
    _chartBars = plt.bar(xPositions, data[0], barWidth, color=data[1],
                         yerr=5, align='center')  # Gera barras

    for bars in _chartBars:
        # text(x, y, s, fontdict=None, withdash=False, **kwargs)
        _ax.text(bars.get_x() + (bars.get_width() / 2.0), bars.get_height() + 5,
                 bars.get_height(), ha='center')  # Label acima das barras

    _ax.set_xticks(xPositions)
    _ax.set_xticklabels(data[2])

    plt.title('THE_VENGEANCE_OF_FELIX_by_J_de_Medeiros_E_Albuquerque')
    plt.xlabel('Alfabeto')
    plt.ylabel('Probabilidades')
    plt.grid(True)
    # plt.legend(_chartBars, data[2])

    plt.show()


def grafico2():
    # Print bigramos
    fig = plt.figure()
    ax = fig.add_subplot(1, 1, 1)
    # ax.set_asppect('equal')
    plt.imshow(vetorCond, interpolation='none', cmap=plt.cm.binary)
    # plt.imshow(vetorCond, interpolation='none', cmap='viridis')
    plt.colorbar()
    plt.title('THE_VENGEANCE_OF_FELIX_by_J_de_Medeiros_E_Albuquerque')
    plt.ylabel('Alfabeto')
    plt.xlabel('Alfabeto')
    aux = np.arange(len(lista))
    plt.xticks(aux, lista)
    plt.yticks(aux, lista)
    plt.grid(True)
    plt.show()


print(17 * "-")
print("| 1 | grafico 1 |")
print("| 2 | grafico 2 |")
print(17 * "-")
y = int(input("Escoha qua o grafico"))
if y == 1:
    grafico1()
elif y == 2:
    grafico2()

arq.close()
