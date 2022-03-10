import os
from time import sleep
from variables import *


def inizio():
    scelta = 0
    clear()
    print("Benvenuto a McDonald. Cosa vuoi fare?\n[1]Compra [2]Staff Only")
    scelta = int(input())
    return scelta


def staff():
    scelta = 0
    clear()
    print("Cosa vuoi fare?\n[1]Aggiungi Scorte [2]Spegni il totem [3]Torna indietro")
    scelta = int(input())
    return scelta


def scorte():
    scelta: int = 0
    numAgg: int = 1
    while True:
        clear()
        print("Cosa vuoi aggiungere?")
        for i in range(len(nomPanini)):
            print("[%d]%s" % (i, nomPanini[i]))
        for i in range(len(nomBevande)):
            print("[%d]%s" % (i + len(nomPanini), nomBevande[i]))
        print("[24]Modifica il numero da aggiungere(%d)\n[25]Esci" % numAgg)
        scelta = int(input())
        if scelta == 24:
            numAgg = modNum()
        elif scelta < 18:
            panini[scelta] += numAgg
        elif scelta >= 18 and scelta < 24:
            bevande[scelta - 18] += numAgg
        if not scelta != 25:
            break
    write()
    return


def modNum():
    clear()
    scelta = 0
    num = 1
    print(
        "Quale numero vuoi aggiungere?\n[1]1\n[2]2\n[3]5\n[4]10\n[5]Scegli te il numero"
    )
    scelta = int(input())
    match scelta:
        case 1:
            num = 1
        case 2:
            num = 2
        case 3:
            num = 5
        case 4:
            num = 10
        case 5:
            num = int(input())
    return num


def comprare():
    read()
    scelta = 1
    while True:
        clear()
        print("Quale vuoi comprare")
        for i in range(len(nomPanini)):
            if (panini[i]) > 0:
                print("[%d]%s(%d) = %.2f" % (i, nomPanini[i], panini[i], cosPanini[i]))
        for i in range(len(nomBevande)):
            if bevande[i] > 0:
                print(
                    "[%d]%s(%d) = %.2f"
                    % (i + len(nomPanini), nomBevande[i], bevande[i], cosBevande[i])
                )
        print("[24]Termina")
        scelta = int(input())
        if scelta < 24:
            if scelta < 18 and panini[scelta] > 0:
                panini[scelta] -= 1
                carrello[scelta] += 1
            elif scelta >= 18 and bevande[scelta - 18] > 0:
                bevande[scelta - 18] -= 1
                carrello[scelta] += 1
            else:
                print("Scegli un altro alimento, questo non é disponibile")
        elif scelta == 24:
            scontrino()
        if not scelta != 24:
            break
    return


def chiudere():
    i = 0
    profitto = 0
    media: float = 0
    clear()
    while clienti[i] > 0:
        profitto += clienti[i]
        i += 1
    if profitto > 0:
        media = profitto / i
    print("Numero di clienti: %d" % i)
    print("Profitto totale: %.2f" % profitto)
    print("Media del profitto: %.2f" % media)
    write()
    sleep(3)
    quit()


def scontrino():
    clear()
    for i in range(len(nomPanini) + len(nomBevande)):
        if carrello[i] > 0:
            if i < 18:
                print("(%d)%s = %.2f" % (carrello[i], nomPanini[i], cosPanini[i]))
            elif i >= 18:
                print(
                    "(%d)%s = %.2f"
                    % (carrello[i], nomBevande[i - 18], cosBevande[i - 18])
                )
    for i in range(len(nomPanini) + len(nomBevande)):
        if carrello[i] > 0:
            if i < 18:
                clienti[numClienti] += cosPanini[i] * carrello[i]
            elif i >= 18:
                clienti[numClienti] += cosBevande[i - 18] * carrello[i]
    if clienti[numClienti] > 0:
        print("Ecco lo scontrino")
        sconto()
        if couponBool == True:
            for i in range(len(couponList)):
                if couponScelto[i] > 0:
                    clienti[numClienti] = clienti[numClienti] - (
                        couponSconto[i] * clienti[numClienti]
                    )
        print("Costo totale %.2f" % clienti[numClienti])
        numClienti += 1
        sleep(5)
    for i in range(len(nomPanini) + len(nomBevande)):
        carrello[i] = 0
    write()
    return


def sconto():
    couponInp = ""
    print("Se hai un coupon inseriscilo (Se non hai un coupon scrivi 0)")
    couponInp = input()
    for i in range(len(couponList)):
        if couponInp == couponList[i]:
            couponScelto[i] += 1
            couponBool = True
            break
    return


def clear():
    os.system("cls")


def write():
    f = open(filePath, "w")
    for i in range(len(nomPanini)):
        f.write(str(panini[i]))
        f.write("\n")
    for i in range(len(nomBevande)):
        f.write(str(bevande[i]))
        f.write("\n")
    f.close()


def read():
    cont = 0
    f = open(filePath, "r")
    for line in f:
        if cont < 18:
            panini[cont] = int(line.strip())
        elif cont >= 18:
            bevande[cont - 18] = int(line.strip())
        cont += 1
    f.close()


def createFile():
    f = open(filePath, "a")
    f.close()
