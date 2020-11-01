using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

/*
* La classe Ticker contient toutes les méthods liées à l'écriture dans les fichiers textes qui seront utilisés comme des tickets.
*/


namespace HOLE_FOODS
{
    public class Ticket
    {

        // Le StreamWriter qui sera utilisé pour écrire dans le fichier tampon est un attribut de l'objet car ouvert lors de l'instanciation de l'objet
        private StreamWriter sw;

        // Compteur (statique) qui permet d'obtenir le numero de ticket actuel
        private static int numTicket = 0;

        public Ticket(String ticketsPath)
        {
            // On ouvre le fichier tampon à la création du ticket, on incrémente aussi le numéro de ticker.
            sw = new StreamWriter(ticketsPath + "tampon.txt");
            numTicket++;
        }

        public void ajouterLigne(String ligne)
        {
            // Si le fichier est disponible en écriture, on y écrit la ligne passée en argument.
            if (sw.BaseStream != null)
            {
                sw.WriteLine(ligne);
            }
            else
            {
                Console.WriteLine("[TickeT:ERROR] Fichier non ouvert " + ticketsPath + "tampon.txt");
            }
        }

        public void genererTicket(String ticketsPath)
        {
            // La "génération" du ticket se contente de copier le ticket tampon sous un nouveau non.
            sw.Close();
            // Le nom du ticket à le path suivant:
            //  C:\Users\"John Doe"\Documents\Ticket N°35 -- 161020 - 141000
            System.IO.File.Copy(ticketsPath + "tampon.txt", ticketsPath + "Ticket N° " + numTicket + " --  " + DateTime.Now.ToString("ddmmyy - HHMMSS")); razTicketTampon();
        }

        public void razTicketTampon()
        {
            // La réinitialisation du ticket tampon écrit un caractère vide sur la totalité du fichier.
            System.IO.File.WriteAllText(ticketsPath + "tampon.txt", string.Empty);

        }
    }
}