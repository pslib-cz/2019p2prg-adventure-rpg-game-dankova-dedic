﻿using RPG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Services
{
    public class Game
    {
        public List<Location> locations = new List<Location>();

        public Game()
        {
            locations.Add(new Location(0, "Vůbec nevíš kde jsi a jak si se tu ocitl. Jediný co si pamatuješ je, že si včera večer usnul s nohama na stole, když jsi sledoval hokej. Při snaze vstát se ti divně klepou nohy...",  new List<Path>() { new Path() { IDofPath = 1, DescriptionofPath = "Porozhlédnot se kolem" } } ));
            locations.Add(new Location(1, "Hmmmmm... V dáli spatříš vesncici - starou a středověkou. Rozhodneš se do ní jít...",  new List<Path>() { new Path() { IDofPath = 2, DescriptionofPath = "Zajít do vesnice" } } ));
            locations.Add(new Location(2, "Pomalu procházíš vesnicí. Dojdeš až na náměstí,je liduprázdné a vedle kašny je stará mapa. Pozorně se na ni podíváš a vidíš nějaké divné ostrovy ve vzduchu... Co to sakra je???",  new List<Path>() { new Path() { IDofPath = 3, DescriptionofPath = "Prozkoumat mapu" } }));
            locations.Add(new Location(3, ",,Nacházíš se na hlavním ostrově. Zde se nachází vesnice, farma, Železné doly, les a hřbitov.´´ říká mapa. V zápětí ti dojde co bylo s tvýma nohama, když jsi se pokusil vstát - je tu jiná gravitace a jsi ve vzduchu na nějakém podivném ostrově!",  new List<Path>() { new Path() { IDofPath = 4, DescriptionofPath = "..." } } ));
            locations.Add(new Location(4, "Stále nerozumíš tomu co se děje a jak jsi se tu ocitl. Pro jistotu se štípneš do ramene... bez výsledku, neprobudil ses. Najednou zezadu slyšíš hlasité 'Hej ty! Jo ty! Co tu sakra děláš v tuhle hodinu?? To se nebojíš draků?'",  new List<Path>() { new Path() { IDofPath = 5, DescriptionofPath = "Draků?" }, new Path() { IDofPath = 6, DescriptionofPath = "Já se nebojím chlape" } }));
            locations.Add(new Location(5, "'Jo, draků' odpoví vesničan. 'Předevčírem se tu jeden objevil a ukradl nám všechna zvířata z pastvin a zapálil stodolu'",  new List<Path>() { new Path() { IDofPath = 7, DescriptionofPath = "Nabídnout pomocnou ruku" }, new Path() { IDofPath = 8, DescriptionofPath = "Těmhle povídačkám nevěřím" } } ));
            locations.Add(new Location(6, "'Oooo, tak to pozooor, pán je ze zdola, tak si hned myslí, že je nesmrtelnej... Tady seš v Létákově brácho, tady machry házet nebudeš. Běž raději do hospody, tam patříš drzoto'",  new List<Path>() { new Path() { IDofPath = 9, DescriptionofPath = "Jít do hospody" } } ));
            locations.Add(new Location(7, "(V hlavě se ti vybavuje jak jsi kolil bestie v Metinu a zvýší se ti lehce ego) 'Rád bych vám tu pomohl se toho draka zbavit', odpovíš vesničanovi",  new List<Path>() { new Path() { IDofPath = 10, DescriptionofPath = "..." } } ));
            locations.Add(new Location(8, "Vysměješ se mu do obličeje a v koutku oka spatříš poutací ceduli s pivem... Konečně, pivo už ti chybělo!",  new List<Path>() { new Path() { IDofPath = 9, DescriptionofPath = "Jít do hospody" } } ));
            locations.Add(new Location(9, "Vlezeš do staré knajpy a usadíš se k volnému stolu v rohu.Za chvíli k tobě přijde mladá pohledná slečna a zeptá se tě, co bys rád.",  new List<Path>() { new Path() { IDofPath = 11, DescriptionofPath = "Slyšel jsem o drakovi co šikanuje vesnici... co je na tom pravda?" }, new Path() { IDofPath = 12, DescriptionofPath = "Pívo prosím!" } } ));
            locations.Add(new Location(10, "Hmmmm, dobře, tak jdi tamhle do hospody a zeptej se tam ty hrdino, řeknou ti víc",  new List<Path>() { new Path() { IDofPath = 9, DescriptionofPath = "Jít do hospody" } } ));
            locations.Add(new Location(11, "'Lítá tu drak a moc se ho bojíme. Celé pole je zničené a zvířata jsou taky pryč. Prý má doupě někde v horách... Hrdinovi co ho zabije a zachrání vesnici, naše hospoda naleje vždy zdarma... A tobě fešáku... tobě bych za to i ňadro ukázala 😉'",  new List<Path>() { new Path() { IDofPath = 13, DescriptionofPath = "Nelze odmítnout!" } } ));
            locations.Add(new Location(12, "Sáhneš do kapsy a... ejhle... nemáš ani groš 😞. Servírka si toho všimne a řekne ti, že je tu možnost jak mít všechno pívo zdarma!",  new List<Path>() { new Path() { IDofPath = 11, DescriptionofPath = "Jsem jedno ucho" } } ));
            locations.Add(new Location(13, "Tak to... to je ta nejlepší nabídka! Jsi ve snu, máš pívo zadáčo a k tomu bonus... musíš draka skonat, ihned!",  new List<Path>() { new Path() { IDofPath = 14, DescriptionofPath = "Porozhlédnout se po hospodě" }, new Path() { IDofPath = 15, DescriptionofPath = "Vydat se ven z hospody" } } ));
            locations.Add(new Location(14, "Nemůžeš ale odejít bez zbraně. A tamhleten ožrala jednu má... starej dřevěnej meč...",  new List<Path>() { new Path() { IDofPath = 16, DescriptionofPath = "Ukrást ho a zmizet" } } ));
            locations.Add(new Location(15, "Vyjdeš cen a mezitím už se setmělo... jdeš podél hospody a najednou... ",  new List<Path>() { new Path() { IDofPath = 17, DescriptionofPath = "..." } } ));
            locations.Add(new Location(16, "Povedlo se! Ani si tě nevšiml a ty tak můžeš pokračovat dál cestou necestou k zabití draka...",  new List<Path>() { new Path() { IDofPath = 18, DescriptionofPath = "Jít k horám" } } ));
            locations.Add(new Location(17, "Napadne tě banda chuligánů a ty nemáš jak se bránit... hups... Ani nemáš šanci se bránit...",  new List<Path>() { new Path() { IDofPath = 19, DescriptionofPath = "..." } } ));
            locations.Add(new Location(18, "Dobrá tedy... máš vše, co potřebuješ. Teď už jenom dojít po cestě k horám",  new List<Path>() { new Path() { IDofPath = 20, DescriptionofPath = "Vydat se klikatou cestičkou dál" } } ));
            locations.Add(new Location(19, "Víš... Ne každý příběh končí skvěle... jako třeba ten tvůj... unluko... V kaluži vlastní krve z tebe mizí veškerý život a ty se už jen v bolesti a agónii modlíš, aby ses probudil...",  new List<Path>() { new Path() { IDofPath = 0, DescriptionofPath = "Hrát znovu!" } } ));   // Dead 1
            locations.Add(new Location(20, "Vydáváš se podél temného lesíka směrem k horám... jde vidět, že tu dlouho nikdo nebyl. Cesta je zarostlá a ty pochybuješ, že v tom lese něco žije... Najednou se před tebou objeví rozcestí... kudma asi půjdeš?",  new List<Path>() { new Path() { IDofPath = 21, DescriptionofPath = "Jít doleva" }, new Path() { IDofPath = 22, DescriptionofPath = "Jít doprostřed" }, new Path() { IDofPath = 29, DescriptionofPath = "Vydat se doprava" } } )); 
            
            locations.Add(new Location(21, "Pokračuješ cestičkou dál a najednou vidíš, že cesta končí... Otočíš se, ale co to??! Cesta za tebou zarostla a porost tě pomalu obkličuje... Trny se ti zařezávají do krve a...",  new List<Path>() { new Path() { IDofPath = 19, DescriptionofPath = "..." } } ));
           
            locations.Add(new Location(22, "Pokračuješ klikatou cestičkou dál a dojdeš až k hnusné jeskyni, plné pavučin a pavouků... Za tebou zmizela cesta,ten tajemný les si roste jak chce, otočíš se zpátky směrem k jeskyni a stojí před ní obrovský pavouk",  new List<Path>() { new Path() { IDofPath = 23, DescriptionofPath = "Bojovat s ním" }, new Path() { IDofPath = 24, DescriptionofPath = "Vyjednávat" } } ));
            locations.Add(new Location(23, "Boj s pavoukem", new List<Path>() { new Path() { IDofPath = 25, DescriptionofPath = "Použít meč" }, new Path() { IDofPath = 26, DescriptionofPath = "Použít svou mysl a pokusit se přechytračit pavouka" } } ));
            locations.Add(new Location(24, "No... co si budem... Vyjednávání s pavoukem není moc chytré... kor když nemluví.. Kousl tě, zamotá se ti hlava a... zbytek znáš, je to přeci jen jedovatej pavouk ne?",  new List<Path>() { new Path() { IDofPath = 0, DescriptionofPath = "Hrát znovu!" } } ));  // Dead 2 
            locations.Add(new Location(25, "Použil jsi meč, ale pavouk tě kousl do nohy.... a ještě k tomu ti zničil meč",  new List<Path>() { new Path() { IDofPath = 27, DescriptionofPath = "Pokračovat v tůře přes jeskyni" } } ));
            locations.Add(new Location(26, "No... jako... nevím co chceš v lese na paloučku dělat.... schovat se za kámen? (xd) Zkus to třeba příště 😞",  new List<Path>() { new Path() { IDofPath = 0, DescriptionofPath = "Hrát znovu!" } } ));  // Dead 3
            locations.Add(new Location(27, "Vejdeš do jeskyně a proplahočíš se tím vším pavoučím hnusem až na druhou stranu",  new List<Path>() { new Path() { IDofPath = 28, DescriptionofPath = "Jít dál" } } ));
            
            locations.Add(new Location(28, "Snad sis vybral správně... před sebou vidíš cestičku... yay",  new List<Path>() { new Path() { IDofPath = 30, DescriptionofPath = "Jít dál svou cestou necestou" } } ));
            locations.Add(new Location(29, "Po cestičce pokračuješ dál a nalevo vidíš východ z jeskyně... fuj... tam snad nikdy nebudeš muset jít",  new List<Path>() { new Path() { IDofPath = 30, DescriptionofPath = "Jít dál svou cestou necestou" } } ));
            locations.Add(new Location(30, "Došels až na konec lesa a vidíš před sebou obrovskou horu... sakra... Je zde stará a opuštěná hornická osada a vede z ní cestička až k zdárnému vrcholu... Je tu ale taky na první pohled víc nebezpečná cesta skrz šachtu.",  new List<Path>() { new Path() { IDofPath = 31, DescriptionofPath = "Jít šachtou" }, new Path() { IDofPath = 32, DescriptionofPath = "Jít cestičkou" } } ));
            locations.Add(new Location(31, "Vlezeš do temné šachty a plahočíš se dál na vrchol. Po cestě si našel starej výtah a tak do něj nasedneš a pohodlně se svezeš do posledního patra šachet. Na konci cesty vidíš východ.",  new List<Path>() { new Path() { IDofPath = 37, DescriptionofPath = "Vyjít ze šachty" } } ));
            locations.Add(new Location(32, "Vydal ses po stráni směrem k vrcholu... Najednou však slyšíš strašlivý řev draka: AAAAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH (představ si zvuk draka)",  new List<Path>() { new Path() { IDofPath = 33, DescriptionofPath = "Schovat se za kámen" }, new Path() { IDofPath = 34, DescriptionofPath = "Vyřvat si na draka hlasivky" } } ));
            locations.Add(new Location(33, "Rychle se schováš za kámen a v tu chvíli nad tebou přeletí drak... naštěstí si tě nevšiml a ty vidíš, jak letí směrem k vrcholu - tam kde má své hnízdo.",  new List<Path>() { new Path() { IDofPath = 35, DescriptionofPath = "Pokračovat na horu" } } ));
            locations.Add(new Location(34, "Drak se na tebe ze vzduchu podívá a sešlehne tě plameny... To nebyl dobrý nápad..",  new List<Path>() { new Path() { IDofPath = 0, DescriptionofPath = "Hrát znovu!" } } ));  // Dead 4
            locations.Add(new Location(35, "Drak odlétl a ty tak můžeš jít dál směrem k hnízdu...",  new List<Path>() { new Path() { IDofPath = 36, DescriptionofPath = "Vyšplhat už skoro poslední převis" } } ));
            locations.Add(new Location(36, "Dokázal jsi to... jsi skoro na vrcholu, teď už jen poslední kopa šutrů a jsi u něj",  new List<Path>() { new Path() { IDofPath = 37, DescriptionofPath = "Dojít ke hnízdu" } } ));
            locations.Add(new Location(37, "Došel jsi úspěšně ke hnízdu, drak vypadá že spí... Teď co s tím?",  new List<Path>() { new Path() { IDofPath = 38, DescriptionofPath = "Vzít meč a podříznout ho" }, new Path() { IDofPath = 38, DescriptionofPath = "Vzít meč a vyříznout mu srdce" }, new Path() { IDofPath = 43, DescriptionofPath = "Udusit ho (máš velké ruce)" }, new Path() { IDofPath = 38, DescriptionofPath = "Uříznout mu ocas, křídla a pomalu ho nechat vykrvácet" }, new Path() { IDofPath = 41, DescriptionofPath = "Osedlat si draka (možnost pouze pro Káťu, jelikož jí přišlo moje story morbidní)" } } ));
           
            locations.Add(new Location(38, "Drak ani neudělal ble a je po něm. Huráááááá!",  new List<Path>() { new Path() { IDofPath = 39, DescriptionofPath = "Vydat se nazpátek do vesnice" } } ));
            locations.Add(new Location(39, "Tak jsi to dokázal... Zabil jsi toho draka... Teď už jen hurá do vesnice... Pro tu odměnu",  new List<Path>() { new Path() { IDofPath = 40, DescriptionofPath = "Vydat se pro odměnu" } } ));
            locations.Add(new Location(40, "Znenadání se ti však začnou zavírat oči... blouzníš a spadneš na zem... probouzíš se u svého stolu, doma a s hokejem v telce.... zvláštní to sen...",  new List<Path>() { new Path() { IDofPath = 0, DescriptionofPath = "Hrát znovu!" } } ));    // Win 1 :)
            locations.Add(new Location(41, "Osedlal sis draka a teď jste nejlepší kamarádi... Jsi v podstatě Oslík ze Shreka :)",  new List<Path>() { new Path() { IDofPath = 0, DescriptionofPath = "Hrát znovu!" } } ));
            
            locations.Add(new Location(42, "Však... nemáš meč... :/... Achju... To jsi asi mrtvej, co?", new List<Path>() { new Path() { IDofPath = 0, DescriptionofPath = "Hrát znovu!" } }));
            locations.Add(new Location(43, "Drak ani neudělal ble a je po něm. Huráááááá!", new List<Path>() { new Path() { IDofPath = 39, DescriptionofPath = "Vydat se nazpátek do vesnice" } }));

        }
    }
}
