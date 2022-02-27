string filePath = "file0";
int NPANINI = 18, NBEVANDE = 6, CLT = 100, NCOUPON = 5;
int[] panini = new int[NPANINI];
int[] bevande = new int[NBEVANDE];
float[] cosPanini = new float[] { 6.40f, 8.10f, 8.60f, 8.60f, 8.60f, 6.70f, 2.90f, 1.80f, 1.30f, 4.50f, 6.40f, 2.90f, 1.80f, 2.40f, 2.90f, 1.80f, 1.90f, 5.60f };
float[] cosBevande = new float[] { 1.50f, 2.80f, 0.55f, 2.80f, 2.80f, 1.90f };
string[] nomPanini = new string[]
{
    "Big Mac",
    "Gran Crispy",
    "Chicken Asiago",
    "Montasio & Pancetta",
    "BBQ",
    "Crispy McBacon",
    "Double Cheeseburger",
    "Cheeseburger",
    "Hamburger",
    "Gluten Free Burger",
    "McChicken Originale",
    "Double Chicken BBQ",
    "Chickenburger",
    "McMuffin Bacon Egg",
    "Filet O Fish",
    "McToast",
    "Patatine",
    "6 Chicken Nuggets"
};
string[] nomBevande = new string[]
{
    "Acqua",
    "Coca Cola",
    "Pepsi",
    "Fanta",
    "Sprite",
    "Mountain Dew"
};
float[] clienti = new float[CLT];
int numClienti = 0;
float profitto = 0;
int[] carrello = new int[NPANINI + NBEVANDE];
string[] couponList = new string[]
{
    "MCDONALD5",
    "MCDONALD10",
    "MCDONALD15",
    "MCDONALD20",
    "MCDONALD25"
};
float[] couponSconto = new float[] { 0.05f, 0.10f, 0.15f, 0.20f, 0.25f };
int[] couponScelto = new int[NCOUPON];
bool couponBool = false;
createFile();
readFromTxt(new StreamReader(filePath));
main();

void main()
{
    do
    {
        switch (inizio())
        {
            case 1:
                comprare();
                break;
            case 2:
                switch (staff())
                {
                    case 1:
                        scorte();
                        break;
                    case 2:
                        chiudere();
                        break;
                    case 3: break;
                }
                break;
            default:
                Console.WriteLine("Inserisci un altro numero");
                break;
        }
    } while (true);
}


int inizio()
{
    int scelta;
    Console.Clear();
    Console.WriteLine("Benvenuto a McDonald. Cosa vuoi fare?\n[1]Compra [2]Staff Only");
    scelta = Convert.ToInt32(Console.ReadLine());
    return scelta;
}
int staff()
{
    int scelta;
    Console.Clear();
    Console.WriteLine("Cosa vuoi fare?\n[1]Aggiungi Scorte [2]Spegni il totem [3]Torna indietro");
    scelta = Convert.ToInt32(Console.ReadLine());
    return scelta;
}
int scorte()
{
    int scelta;
    int numAgg = 1;
    do
    {
        Console.Clear();
        Console.WriteLine("Quale vuoi aggiungere?");
        for (int i = 0; i < NPANINI; i++)
        {
            Console.WriteLine("[" + i + "]" + nomPanini[i]);
        }
        for (int i = 0; i < NBEVANDE; i++)
        {
            int j = i;
            i += 18;
            Console.WriteLine("[" + i + "]" + nomBevande[j]);
            i -= 18;
        }
        Console.WriteLine("[24]Modifica il numero da aggiungere(" + numAgg + ")\n[25]Esci");
        scelta = Convert.ToInt32(Console.ReadLine());
        if (scelta == 24)
        {
            numAgg = modNum();
        }
        else if (scelta < 18)
        {
            panini[scelta] += numAgg;
        }
        else if (scelta >= 18 && scelta < 25)
        {
            bevande[scelta - 18] += numAgg;
        }
    } while (scelta != 25);
    writeToTxt(new StreamWriter(filePath));
    return 0;
}
int modNum()
{
    Console.Clear();
    int scelta;
    int num = 1;
    Console.WriteLine("Quale numero vuoi aggiungere?\n[1]1\n[2]2\n[3]5\n[4]10\n[5]Scegli te il numero");
    scelta = Convert.ToInt32(Console.ReadLine());
    switch (scelta)
    {
        case 1:
            num = 1;
            break;
        case 2:
            num = 2;
            break;
        case 3:
            num = 5;
            break;
        case 4:
            num = 10;
            break;
        case 5:
            num = Convert.ToInt32(Console.ReadLine());
            break;
        default:
            break;
    }
    return num;
}
int comprare()
{
    readFromTxt(new StreamReader(filePath));
    int scelta;
    do
    {
        Console.Clear();
        Console.WriteLine("Quale vuoi comprare?");
        for (int i = 0; i < NPANINI; i++)
        {
            if (panini[i] > 0)
            {
                Console.WriteLine("[" + i + "]" + nomPanini[i] + "(" + panini[i] + ") = " + cosPanini[i]);
            }
        }
        for (int i = 0; i < NBEVANDE; i++)
        {
            if (bevande[i] > 0)
            {
                int j = i;
                i += 18;
                Console.WriteLine("[" + i + "]" + nomBevande[j] + "(" + bevande[j] + ") = " + cosBevande[j]);
                i -= 18;
            }
        }
        Console.WriteLine("[24]Termina");
        scelta = Convert.ToInt32(Console.ReadLine());
        if (scelta < 24)
        {
            if (scelta < 18 && panini[scelta] > 0)
            {
                panini[scelta] -= 1;
                carrello[scelta] += 1;
            }
            else if (scelta >= 18 && bevande[scelta - 18] > 0)
            {
                bevande[scelta - 18] -= 1;
                carrello[scelta] += 1;
            }
            else
            {
                Console.WriteLine("Scegli un altro alimento, questo non e disponibile");
            }
        }
        else if (scelta == 24)
        {
            scontrino();
        }
    } while (scelta != 24);
    return 0;
}
int chiudere()
{
    int i = 0;
    float media;
    Console.Clear();
    while (clienti[i] > 0)
    {
        profitto += clienti[i];
        i++;
    }
    media = mediaf(clienti);
    Console.WriteLine("Numero di clienti: " + i);
    Console.WriteLine("Profitto totale: " + profitto);
    if (media > 0)
    {
        Console.WriteLine("Media degli importi: " + media);
    }
    writeToTxt(new StreamWriter(filePath));
    Console.ReadKey();
    Environment.Exit(0);
    return 0;
}
int scontrino()
{
    Console.Clear();
    Console.WriteLine("Ecco lo scontrino");
    for (int i = 0; i < NBEVANDE + NPANINI; i++)
    {
        if (carrello[i] > 0)
        {
            if (i < 18)
            {
                Console.WriteLine("(" + carrello[i] + ")" + nomPanini[i] + " = " + cosPanini[i]);
            }
            else if (i >= 18)
            {
                Console.WriteLine("(" + carrello[i] + ")" + nomBevande[i - 18] + " = " + cosBevande[i - 18]);
            }
        }
    }
    for (int i = 0; i < NBEVANDE + NPANINI; i++)
    {
        if (carrello[i] > 0)
        {
            if (i < 18)
            {
                clienti[numClienti] += cosPanini[i] * carrello[i];
            }
            else if (i >= 18)
            {
                clienti[numClienti] += cosBevande[i - 18] * carrello[i];
            }
        }
    }
    sconto();
    if (couponBool)
    {
        for (int i = 0; i < NCOUPON; i++)
        {
            if (couponScelto[i] > 0)
            {
                clienti[numClienti] = clienti[numClienti] - (couponScelto[i] * clienti[numClienti]);
            }
        }
    }
    Console.WriteLine("Costo totale: " + clienti[numClienti]);
    numClienti += 1;
    for (int i = 0; i < 24; i++)
    {
        carrello[i] = 0;
    }
    Console.ReadKey();
    writeToTxt(new StreamWriter(filePath));
    return 0;
}
float mediaf(float[] arr)
{
    float avg;
    float sum = 0;
    int i = 0;
    while (arr[i] > 0)
    {
        sum += arr[i];
        i++;
    }
    avg = sum / i;
    return avg;
}
bool sconto()
{
    Console.WriteLine("Se hai un coupon inseriscilo (Se non hai un coupon scrivi 0)");
    string couponInp = new(Console.ReadLine());
    for (int i = 0; i < NCOUPON; i++)
    {
        if (String.Equals(couponList[i], couponInp))
        {
            couponScelto[i] += 1;
            couponBool = true;
            return true;
        }
        else
        {
            couponBool = false;
        }
    }
    return false;
}
void writeToTxt(StreamWriter sw)
{
    try
    {
        for (int i = 0; i < NPANINI; i++)
        {
            sw.WriteLine(panini[i]);
        }
        for (int i = 0; i < NBEVANDE; i++)
        {
            sw.WriteLine(bevande[i]);
        }
        sw.Close();
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
    }
    return;
}
void readFromTxt(StreamReader sr)
{
    try
    {
        for (int i = 0; i < NPANINI; i++)
        {
            panini[i] = Convert.ToInt32(sr.ReadLine());
        }
        for (int i = 0; i < NBEVANDE; i++)
        {
            bevande[i] = Convert.ToInt32(sr.ReadLine());
        }
        sr.Close();
    }
    catch (Exception e)
    {
        Console.WriteLine("Exception: " + e.Message);
    }
    finally
    {
    }
    return;
}
void createFile()
{
    try
    {
        if (File.Exists(filePath))
        {
            return;
        }
        else
        {
            using FileStream fs = File.Create(filePath);
        }
    }
    catch (Exception Ex)
    {
        Console.WriteLine("Exception: " + Ex.Message);
    }
}