﻿using prova_verifica;
using System.Security.Cryptography;

Cassetta_di_sicurezza cas1 = new Cassetta_di_sicurezza("12345", "l,md", "popi", "knd");
Cassetta_di_sicurezza cas2 = new Cassetta_di_sicurezza("12345", "l,md", "popi", "knd");
Cassetta_di_sicurezza cas3 = new Cassetta_di_sicurezza("12345", "l,md", "popi", "knd");
Oggetto_misterioso gioi = new gioielli("ojhdf", 100, "pjodffb");
Oggetto_misterioso docu = new documento("ojhdf", 150, "pjodffb");
Oggetto_misterioso chiave = new chiavi("ojhdf", 100, true);
cas1.InserisciOggetto("12345", gioi);
cas2.InserisciOggetto("12345", docu);
cas3.InserisciOggetto("12345", chiave);
Console.WriteLine(cas1.oggetto.Id + cas1.getPrezzoAssicurato()+" ; " + cas1.oggetto.Prezzo_dichiarato+ cas1.oggetto.gettipo());
Console.WriteLine(cas2.oggetto.Id + cas2.getPrezzoAssicurato() + " ; " + cas2.oggetto.Prezzo_dichiarato+ cas2.oggetto.gettipo());
Console.WriteLine(cas3.oggetto.Id + cas3.getPrezzoAssicurato() + " ; " + cas3.oggetto.Prezzo_dichiarato+ cas3.oggetto.gettipo());
Cassetta_di_sicurezza cas4 = new cassetta_speciale("12345", "l,md", "popi", "knd");
Cassetta_di_sicurezza cas5 = new cassetta_speciale("12345", "l,md", "popi", "knd");
Cassetta_di_sicurezza cas6 = new cassetta_speciale("12345", "l,md", "popi", "knd");
Oggetto_misterioso gioi1 = new gioielli("ojhdf", 100, "pjodffb");
Oggetto_misterioso docu1 = new documento("ojhdf", 150, "pjodffb");
Oggetto_misterioso chiave1 = new chiavi("ojhdf", 100, true);
cas4.InserisciOggetto("12345", gioi1);
cas5.InserisciOggetto("12345", docu1);
cas6.InserisciOggetto("12345", chiave1);
Console.WriteLine(cas4.oggetto.Id + cas4.getPrezzoAssicurato() + " ; " + cas4.oggetto.Prezzo_dichiarato + cas4.oggetto.gettipo());
Console.WriteLine(cas5.oggetto.Id + cas5.getPrezzoAssicurato() + " ; " + cas5.oggetto.Prezzo_dichiarato + cas5.oggetto.gettipo());
Console.WriteLine(cas6.oggetto.Id + cas6.getPrezzoAssicurato() + " ; " + cas6.oggetto.Prezzo_dichiarato + cas6.oggetto.gettipo());