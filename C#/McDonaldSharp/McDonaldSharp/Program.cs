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
    int scelta = 0;
    Console.Clear();
    Console.WriteLine("Benvenuto a McDonald. Cosa vuoi fare?\n[1]Compra [2]Staff Only");
    scelta = Convert.ToInt32(Console.ReadLine());
    return scelta;
}
int staff()
{
    int scelta = 0;
    Console.Clear();
    Console.WriteLine("Cosa vuoi fare?\n[1]Aggiungi Scorte [2]Spegni il totem [3]Torna indietro");
    scelta = Convert.ToInt32(Console.ReadLine());
    return scelta;
}
int scorte()
{
    int scelta = 1;
    int numAgg = 1;
    do
    {
        Console.Clear();
        Console.WriteLine("Quale vuoi aggiungere?");
        for(int i = 0; i < NPANINI; i++)
        {
            Console.WriteLine("[" + i + "]" + nomPanini[i]);
        }
        for(int i = 0;i < NBEVANDE; i++)
        {
            Console.WriteLine("[" + i + "]" + nomBevande[i]);
        }
        Console.WriteLine("[24]Modifica il numero da aggiungere(" + numAgg + ")\n[25]Esci");
        scelta = Convert.ToInt32(Console.ReadLine());
        if(scelta == 24)
        {
            numAgg = modNum();
        }
        else if(scelta < 18)
        {
            panini[scelta] += numAgg;
        }
        else if(scelta >= 18)
        {
            bevande[scelta - 18] += numAgg;
        }
    }while (scelta != 25);
    return 0;
}
int modNum()
{
    Console.Clear();
    int scelta = 0;
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
    return 0;
}
int chiudere()
{
    return 0;
}
int scontrino()
{
    return 0;
}
float mediaf()
{
    return 0f;
}
bool sconto()
{
    return true;
}