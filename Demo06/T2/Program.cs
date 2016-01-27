/* 
 * Created: 27.1.2016 
 * Authors: Albert Kuusjärvi 
 *Tehtävä 2 Kotitehtävä
Aikaisemmissa demoissa tehtiin CD-luokka, joka sisälsi CD:lle yleisesti kuuluvia ominaisuuksia. 
Muuta/tee toteutus, jossa CD:n sisällä olevien biisien määrää ei ole rajattu. Käsittele CD:n osalta ainakin seuraavat tiedot: nimi, artisti ja biisit.
Ohjelmoi suunnittelemasi CD-luokka. Toteuta pääohjelmassa CD-olio. Tiedot voit keksiä itse, niitä ei tarvitse kysyä käyttäjältä. 
Tulosta ruudulle CD:n tietoja.          
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            CD Cd1 = new CD { Name = "Battle Metal", Artist = "Turisas" };
            Song song1 = new Song { SongName = "Victoriae & triumphi dominus", SongLength = 1.27 };
            Song song2 = new Song { SongName = "As Torches Rise", SongLength = 4.51 };
            Song song3 = new Song { SongName = "Battle Metal", SongLength = 4.23 };
            Song song4 = new Song { SongName = "The Land of Hope and Glory", SongLength = 6.22 };
            CD Cd2 =new CD { Name = "Varangian Way", Artist = "Turisas"};
            Song song5 = new Song { SongName = "To Holmgard and Beyond", SongLength = 5.17 };
            Song song6 = new Song { SongName = "A Portage to the Unknown", SongLength = 4.50 };
            Song song7 = new Song { SongName = "Cursed Be Iron", SongLength = 5.03 };
            Song song8 = new Song { SongName = "Fields of Gold", SongLength = 4.34 };
            //add songs to a CD
            Cd2.AddSong(song5);
            Cd2.AddSong(song6);
            Cd2.AddSong(song7);
            Cd2.AddSong(song8);

            Cd1.AddSong(song1);
            Cd1.AddSong(song2);
            Cd1.AddSong(song3);
            Cd1.AddSong(song4);

            //print collection
            Console.WriteLine(Cd1);
            Cd1.PrintCollection();
            Console.WriteLine(" ");
            Console.WriteLine(Cd2);
            Cd2.PrintCollection();
            Console.WriteLine(" ");
        }
    }
}
