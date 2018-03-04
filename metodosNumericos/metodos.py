import math

def metodoDaBisercao():
    F = lambda x: (8-4.5*(x-math.sin(x)))
    a = 2
    b = 3
    imax = 20
    tol = 0.001
    Fa = F(a);
    Fb = F(b)
    if Fa*Fb >0:
        print('Erro:A função tem o mesmo sinal nos pontos a e b')
    else:
        print('--------------------------------------------------------')
        print('|iteration | a | b | (xNS)Solução | f(xNS) | tolerancia|')

    for i in range(1, imax):
        xNS = (a+b)/2
        toli = (b-a)/2
        FxNS = F(xNS)
        print('--------------------------------------------------------')
        print('|  {}  | {} | {} |  {}   |   {}   | {}  |\n'.format(i, a, b, xNS, FxNS, toli))
        if FxNS == 0:
            print('Uma solução exata x={} foi obtida'.format(xNS))
            break
        if toli < tol:
            break
        if i == imax:
            print('Solução não obtida em {} iterações'.format(imax))
            break
        if F(a)*FxNS < 0:
            b = xNS
        else:
            a = xNS

def RegulaFalsi(F, xl, xr, errto=0.01, imax=1000):
    """
    Return the root of a function using Regula Falsi
 
    RegulaFalsi(fun, xl, xr, imax, errto)
 
    * fun: Function where find the roots
    * xl: left bound of interval
    * xr: right bound of interval
    * imax: max of iterations allowed
    * errto: tolerated error
 
    Author: Pedro Garcia [sawp@sawp.com.br]
    License: Creative Commons
 
    """
    x = 0
    iterCount = 0
    errno = 1
    fl = F(xl)
    while errno &gt; errto and iterCount &lt; imax:
        xold = x
        iterCount = iterCount + 1
        fr = F(xr)
        x = xr - fr * (xl - xr) / (fl - fr)
        fx = F(x)
        if x != 0:
            errno = fabs((x - xold) / x)
        test = fl * fx
        if test < 0:
            xr = x         
        elif test > 0:
            xl = x
            fl = fx
        else:
            errno = 0
    return x

def RegulaFalsi_O2(F, xl, xr, errto=0.01, imax=1000):
    """
    Return the root of a function using Regula Falsi
 
    RegulaFalsi_O2(fun, xl, xr, imax, errto)
 
    * fun: Function where find the roots
    * xl: left bound of interval
    * xr: right bound of interval
    * imax: max of iterations allowed
    * errto: tolerated error ( for aprox. ), in percents
 
    Author: Pedro Garcia [sawp@sawp.com.br]
    License: Creative Commons
 
    """
    x = 0
    iterCount = 0
    errno = 1
    fl = F(xl)
    leftCount = 0 # O2
    rightCount = 0 # O2
    while errno >= errto and iterCount < = imax:
        xold = x
        iterCount = iterCount + 1
        fr = F(xr)
        # x = (xl+xr)/2.l ponto onde modifica a Bisseccao
        x = xr - fr * (xl - xr) / (fl - fr)
        fx = F(x)
        if x != 0:
            errno = fabs((x - xold) / x)
        test = fl * fx
        if test < 0: 
            xr = x 
            fr = fx # O2
            rightCount = 0 # O2
            leftCount += 1 # O2
            if leftCount >= 2:
                fl = fl / 2 # O2
        elif test > 0:
            xl = x
            fl = fx
            fl = F(xl) # O2
            leftCount = 0 # O2
            rightCount += 1 #O2
            if rightCount >= 2:
                fr = fr / 2 # O2
        else:
            errno = 0
    return x
