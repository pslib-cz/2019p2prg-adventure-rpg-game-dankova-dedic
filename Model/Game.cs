using RPG.Model;
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
            locations.Add(new Location(0, new int[] { 1 }, "Hrát znovu!", "Vůbec nevíš kde jsi a jak si se tu ocitl. Jediný co si pamatuješ je, že si včera večer usnul s nohama na stole, když jsi sledoval hokej. Při snaze vstát se ti divně klepou nohy..."));
            locations.Add(new Location(1, new int[] { 2 }, "Porozhlédnot se kolem", "Hmmmmm... V dáli spatříš vesncici - starou a středověkou. Rozhodneš se do ní jít..."));
            locations.Add(new Location(2, new int[] { 3 }, "Zajít do vesnice", "Pomalu procházíš vesnicí. Dojdeš až na náměstí,je liduprázdné a vedle kašny je stará mapa. Pozorně se na ni podíváš a vidíš nějaké divné ostrovy ve vzduchu... Co to sakra je???"));
            locations.Add(new Location(3, new int[] { 4 }, "Prozkoumat mapu", " ,,Nacházíš se na hlavním ostrově. Zde se nachází vesnice, farma, Železné doly, les a hřbitov.´´ říká mapa. V zápětí ti dojde co bylo s tvýma nohama, když jsi se pokusil vstát - je tu jiná gravitace a jsi ve vzduchu na nějakém podivném ostrově!"));
            locations.Add(new Location(4, new int[] { 5, 6 }, "...", "Stále nerozumíš tomu co se děje a jak jsi se tu ocitl. Pro jistotu se štípneš do ramene... bez výsledku, neprobudil ses. Najednou zezadu slyšíš hlasité 'Hej ty! Jo ty! Co tu sakra děláš v tuhle hodinu?? To se nebojíš draků?'"));
            locations.Add(new Location(5, new int[] { 7, 8 }, "Draků?", "'Jo, draků' odpoví vesničan. 'Předevčírem se tu jeden objevil a ukradl nám všechna zvířata z pastvin a zapálil stodolu'"));
            locations.Add(new Location(6, new int[] { 9 }, "Já se nebojím chlape", "'Oooo, tak to pozooor, pán je ze zdola, tak si hned myslí, že je nesmrtelnej... Tady seš v Létákově brácho, tady machry házet nebudeš. Běž raději do hospody, tam patříš drzoto'"));
            locations.Add(new Location(7, new int[] { 10 }, "Nabídnout pomocnou ruku", "(V hlavě se ti vybavuje jak jsi kolil bestie v Metinu a zvýší se ti lehce ego) 'Rád bych vám tu pomohl se toho draka zbavit', odpovíš vesničanovi"));
            locations.Add(new Location(8, new int[] { 9 }, "Těmhle povídačkám nevěřím", "Vysměješ se mu do obličeje a v koutku oka spatříš poutací ceduli s pivem... Konečně, pivo už ti chybělo!"));
            locations.Add(new Location(9, new int[] { 11, 12 }, "Jít do hospody", "Vlezeš do staré knajpy a usadíš se k volnému stolu v rohu. Za chvíli k tobě přijde mladá pohledná slečna a zeptá se tě, co bys rád."));
            locations.Add(new Location(10, new int[] { 9 }, "...", "Hmmmm, dobře, tak jdi tamhle do hospody a zeptej se tam ty hrdino, řeknou ti víc"));
            locations.Add(new Location(11, new int[] { 14 }, "Slyšel jsem o drakovi co šikanuje vesnici... co je na tom pravda?", "'Lítá tu drak a moc se ho bojíme. Celé pole je zničené a zvířata jsou taky pryč. Prý má doupě někde v horách... Hrdinovi co ho zabije a zachrání vesnici, naše hospoda naleje vždy zdarma... A tobě fešáku... tobě bych za to i ňadro ukázala 😉'"));
            locations.Add(new Location(12, new int[] { 13 }, "Pívo prosím!", "Sáhneš do kapsy a... ejhle... nemáš ani groš 😞. Servírka si toho všimne a řekne ti, že je tu možnost jak mít všechno pívo zdarma!"));
            locations.Add(new Location(13, new int[] { 14 }, "Jsem jedno ucho", "'Lítá tu drak a moc se ho bojíme. Celé pole je zničené a zvířata jsou taky pryč. Prý má doupě někde v horách... Hrdinovi co ho zabije a zachrání vesnici, naše hospoda naleje vždy zdarma... A tobě fešáku... tobě bych za to i ňadro ukázala 😉'"));
            locations.Add(new Location(14, new int[] { 15, 16 }, "Nelze odmítnout!", "Tak to... to je ta nejlepší nabídka! Jsi ve snu, máš pívo zadáčo a k tomu bonus... musíš draka skonat, ihned!"));
            locations.Add(new Location(15, new int[] { 17 }, "Porozhlédnout se po hospodě", "Nemůžeš ale odejít bez zbraně. A tamhleten ožrala jednu má... starej dřevěnej meč..."));
            locations.Add(new Location(16, new int[] { 18 }, "Vydat se ven z hospody", "Vyjdeš cen a mezitím už se setmělo... jdeš podél hospody a najednou... "));
            locations.Add(new Location(17, new int[] { 19 }, "Ukrást ho a zmizet", "Povedlo se! Ani si tě nevšiml a ty tak můžeš pokračovat dál cestou necestou k zabití draka..."));
            locations.Add(new Location(18, new int[] { 20 }, "...", "Napadne tě banda chuligánů a ty nemáš jak se bránit... hups... Ani nemáš šanci se bránit..."));
            locations.Add(new Location(19, new int[] { 21 }, "Jít k horám", "Dobrá tedy... máš vše, co potřebuješ. Teď už jenom dojít po cestě k horám"));
            locations.Add(new Location(20, new int[] { 0 }, "...", "Víš... Ne každý příběh končí skvěle... jako třeba ten tvůj... unluko... V kaluži vlastní krve z tebe mizí veškerý život a ty se už jen v bolesti a agónii modlíš, aby ses probudil..."));   //dead 1
            locations.Add(new Location(21, new int[] { 22, 23, 30 }, "Vydat se klikatou cestičkou dál", "Vydáváš se podél temného lesíka směrem k horám... jde vidět, že tu dlouho nikdo nebyl. Cesta je zarostlá a ty pochybuješ, že v tom lese něco žije... Najednou se před tebou objeví rozcestí... kudma asi půjdeš?"));
            locations.Add(new Location(22, new int[] { 20 }, "Jít doleva", "Pokračuješ cestičkou dál a najednou vidíš, že cesta končí... Otočíš se, ale co to??! Cesta za tebou zarostla a porost tě pomalu obkličuje... Trny se ti zařezávají do krve a..."));

            locations.Add(new Location(23, new int[] { 24, 25 }, "Jít doprostřed", "Pokračuješ klikatou cestičkou dál a dojdeš až k hnusné jeskyni, plné pavučin a pavouků... Za tebou zmizela cesta,ten tajemný les si roste jak chce, otočíš se zpátky směrem k jeskyni a stojí před ní obrovský pavouk"));
            locations.Add(new Location(24, new int[] { 26, 27 }, "Bojovat s ním", "Boj s pavoukem"));
            locations.Add(new Location(25, new int[] { 0 }, "Vyjednávat", "No... co si budem... Vyjednávání s pavoukem není moc chytré... kor když nemluví.. Kousl tě, zamotá se ti hlava a... zbytek znáš, je to přeci jen jedovatej pavouk ne?"));
            locations.Add(new Location(26, new int[] { 28 }, "Použít meč", "Použil jsi meč a pavouka jsi zabil. Jsi fakt najetej"));
            locations.Add(new Location(27, new int[] { 0 }, "Použít svou mysl a pokusit se přechytračit pavouka", "No... jako... nevím co chceš v lese na paloučku dělat.... schovat se za kámen? (xd) Zkus to třeba příště 😞"));   //dead 2
            locations.Add(new Location(28, new int[] { 29 },"Pokračovat v tůře přes jeskyni", "Vejdeš do jeskyně a proplahočíš se tím vším pavoučím hnusem až na druhou stranu"));
            locations.Add(new Location(29, new int[] { 31 }, "Jít dál", "Snad sis vybral správně... před sebou vidíš cestičku... yay"));

            locations.Add(new Location(30, new int[] { 31 }, "Vydat se doprava", "Po cestičce pokračuješ dál a nalevo vidíš východ z jeskyně... fuj... tam snad nikdy nebudeš muset jít"));
            locations.Add(new Location(31, new int[] { 32, 33 }, "Jít dál svou cestou necestou", "Došels až na konec lesa a vidíš před sebou obrovskou horu... sakra... Je zde stará a opuštěná hornická osada a vede z ní cestička až k zdárnému vrcholu... Je tu ale taky na první pohled víc nebezpečná cesta skrz šachtu."));
            locations.Add(new Location(32, new int[] { 38 }, "Jít šachtou", "Vlezeš do temné šachty a plahočíš se dál na vrchol. Po cestě si našel starej výtah a tak do něj nasedneš a pohodlně se svezeš do posledního patra šachet. Na konci cestx vidíš východ."));
            locations.Add(new Location(33, new int[] { 34, 35 }, "Jít cestičkou", "Vydal ses po stráni směrem k vrcholu... Najednou však slyšíš strašlivý řev draka: AAAAAAAAAAAAAAAAAAAAAAAAHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH (představ si zvuk draka)"));
            locations.Add(new Location(34, new int[] { 36 }, "Schovat se za kámen", "Rychle se schováš za kámen a v tu chvíli nad tebou přeletí drak... naštěstí si tě nevšiml a ty vidíš, jak letí směrem k vrcholu - tam kde má své hnízdo."));
            locations.Add(new Location(35, new int[] { 0 }, "Vyřvat si na draka hlasivky", "Drak se na tebe ze vzduchu podívá a sešlehne tě plameny... To nebyl dobrý nápad.."));
            locations.Add(new Location(36, new int[] { 37 }, "Pokračovat na horu", "Drak odlétl a ty tak můžeš jít dál směrem k hnízdu..."));
            locations.Add(new Location(37, new int[] { 39 }, "Vyšplhat už skoro poslední převis", "Dokázal jsi to... jsi skoro na vrcholu, teď už jen poslední kopa šutrů a jsi u něj"));
            locations.Add(new Location(38, new int[] { 39 }, "Vyjít ze šachty", "Dokázal jsi to... jsi skoro na vrcholu, teď už jen poslední kopa šutrů a jsi u něj"));
            locations.Add(new Location(39, new int[] { 40, 41, 42, 43, 46 }, "Dojít ke hnízdu", "Došel jsi úspěšně ke hnízdu, drak vypadá že spí... Teď co s tím?"));
            locations.Add(new Location(40, new int[] { 44 }, "Vzít meč a podříznout ho", " Drak ani neudělal ble a je po něm. Huráááááá!"));
            locations.Add(new Location(41, new int[] { 44 }, "Vzít meč a vyříznout mu srdce", "Drak ani neudělal ble a je po něm. Huráááááá!"));
            locations.Add(new Location(42, new int[] { 44 }, "Uškrtit ho (máš velké ruce)", "Drak ani neudělal ble a je po něm. Huráááááá!"));
            locations.Add(new Location(43, new int[] { 44 }, "Uříznout mu ocas, křídla a pomalu ho nechat vykrvácet", "Drak ani neudělal ble a je po něm. Huráááááá!"));
            locations.Add(new Location(44, new int[] { 45 }, "Vydat se nazpátek do vesnice", "Tak jsi to dokázal... Zabil jsi toho draka... Teď už jen hurá do vesnice... Pro tu odměnu"));
            locations.Add(new Location(45, new int[] { 0 }, "Vydat se pro odměnu", "Znenadání se ti však začnou zavírat oči... blouzníš a spadneš na zem... probouzíš se u svého stolu, doma a s hokejem v telce.... zvláštní to sen..."));
            locations.Add(new Location(46, new int[] { 0 }, "Osedlat si draka (možnost pouze pro Káťu, jelikož jí přišlo moje story morbidní)", "Osedlal sis draka a teď jste nejlepší kamarádi... Jsi v podstatě Oslík ze Shreka :)"));
        }
    }
}
