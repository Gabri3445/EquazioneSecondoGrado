import string


filePath = "file0"
panini: int = []
bevande: int = []
cosPanini: float = [
    6.40,
    8.10,
    8.60,
    8.60,
    8.60,
    6.70,
    2.90,
    1.80,
    1.30,
    4.50,
    6.40,
    2.90,
    1.80,
    2.40,
    2.90,
    1.80,
    1.90,
    5.60,
]
cosBevande: float = [1.50, 2.80, 0.55, 2.80, 2.80, 1.90]
nomPanini: string = [
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
    "6 Chicken Nuggets",
]
nomBevande: string = ["Acqua", "Coca Cola", "Pepsi", "Fanta", "Sprite", "Mountain Dew"]
clienti: float = []
numClienti: int = 0
profitto: float = 0
carrello: int = []
couponList: string = [
    "MCDONALD5",
    "MCDONALD10",
    "MCDONALD15",
    "MCDONALD20",
    "MCDONALD25",
]
couponSconto: float = [0.05, 0.10, 0.15, 0.20, 0.25]
couponScelto: int = 0
couponBool: bool = False
for i in range (len(nomPanini)):
    panini.append(0)
for i in range (len(nomBevande)):
    bevande.append(0)
for i in range (100):
    clienti.append(0)
for i in range (len(nomBevande) + len(nomPanini)):
    carrello.append(0)