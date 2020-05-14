using RPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Services
{
    public class Game
    {
        private readonly SessionStorage _ss;
        public List<Location> locations = new List<Location>();
        public Game(SessionStorage ss)
        {
            _ss = ss;
            locations.Add(new Location(0, new int[] { 1, 14 }, "Jít na louku", "Nacházíš se na hlavním ostrově. Zde se nachází vesnice, farma, Železné doly, les a hřbitov."));
            locations.Add(new Location(1, new int[] { 0, 2, 5, 11 }, "Jít na náměstí.", "Nacházíš se ve vesnici. Z vesnice se můžeš dostat na jakékoli místo na hlavním ostrově."));
            locations.Add(new Location(2, new int[] { 1, 3, 4 }, "Jít na farmu. ", "Nacházíš se na farmě. Odtud je možné dostat na ostrov, kde se nachází Stodola."));
            locations.Add(new Location(3, new int[] { 2 }, "Pokračovat do stodoly", "Bučí na tebe kráva a blbě na tebe kouká kůň."));
            locations.Add(new Location(4, new int[] { 2 }, "Pokračovat na pole s divným strašákem", "Tenhle strašák by nevystrašil ani vránu..."));
            locations.Add(new Location(5, new int[] { 1, 6, 8 }, "Jít do dolů", "Nacházíš se v Železných dolech. Odtud je možné se dostat na ostrov s doly."));
            locations.Add(new Location(6, new int[] { 5, 7 }, "Jít si prohlédnout zlaté sošky", "Koukáš na ty zlatý sošky a jak si jednu chceš vzít do ruky, pohneš s nějakou pákou a otevře se ti tajný vstup za vitrinou"));
            locations.Add(new Location(7, new int[] { 6 }, "Jít do zadní místnosti", "Koukáš na zeď a vidíš že by do ní mělo něco pasovat. Vypadá to jako kosternatá ruka"));
            locations.Add(new Location(8, new int[] { 5, 9, 10 }, "Jít k mostu na ostrov s doly", "Nacházíš se na ostrově s doly.Zde se nachází Zlaté doly a hluboký vrt."));
            locations.Add(new Location(9, new int[] { 8 }, "Jít do Zlatých dolů", "Porozhlédneš se tu, ale na nic zajímavého si nenarazil."));
            locations.Add(new Location(10, new int[] { 8 }, "Jít do Hlubokého vrtu", "Přes plůtek na kraji obrovské jámy se koukneš dolů do propasti... Není vidět na dno."));
            locations.Add(new Location(11, new int[] { 1, 12, 13 }, "Jít do lesa", "Nacházíš se v lese. Odtud se lze dostat klikatou cestičkou na zalesněné Létající ostrovy nebo na hřbitov."));
            locations.Add(new Location(12, new int[] { 11 }, "Jít na hřbitov", "Nacházíš se na hřbitově. Až na divný hrob s hnátou koukající skrz hlínu zde není nic divného"));
            locations.Add(new Location(13, new int[] { 11 }, "Pokračovat po klikaté cestičce dál.", "Před tebou se najednou objevil mohutný a svalnatý dřevorubec Marek. Od něj se dozvíš, že za každý pokácený strom ti přibude kousek zdraví"));
            locations.Add(new Location(14, new int[] { 0 }, "Pokračovat ve spaní na louce", "Spal si už dost dlouho jako!"));
        }
    }
}
