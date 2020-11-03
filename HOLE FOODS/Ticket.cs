using System;
using System.Globalization;
using System.IO;

/*
 * 
 * ------------- MODEL ----------------
 * 
* La classe Ticket contient toutes les méthods liées à l'écriture dans les fichiers textes qui seront utilisés comme des tickets.
*/


namespace HOLE_FOODS
{
    public class Ticket
    {
        private String ticketsPath;

        // Le StreamWriter qui sera utilisé pour écrire dans le fichier tampon est un attribut de l'objet car ouvert lors de l'instanciation de l'objet
        private StreamWriter sw;

        // Compteur (statique) qui permet d'obtenir le numero de ticket actuel
        private int numTicket;

        public Ticket(String ticketsPath)
        {
            // On ouvre le fichier tampon à la création du ticket, on incrémente aussi le numéro de ticker.

            this.ticketsPath = ticketsPath;
            this.sw = new StreamWriter(this.ticketsPath + "tampon.txt");
            sw.Write(getBeginOfTicket());
        }

        public void ajouterLigne(String ligne)
        {
            // Si le fichier est disponible en écriture, on y écrit la ligne passée en argument.
            if (this.sw.BaseStream != null)
            {
                this.sw.WriteLine(ligne);
            }
            else
            {
                Console.WriteLine("Fichier non ouvert " + this.ticketsPath + "tampon.txt");
            }
        }

        public String genererTicket(double total)
        {
            // La "génération" du ticket se contente de copier le ticket tampon sous un nouveau nom.

            // Vient chercher le numéro de ticket dans les fichier windows puis l'incrémente 
            if(!int.TryParse(Properties.Settings.Default.numTicket.ToString(), out numTicket))
            {
                numTicket = 0;
            }
            Properties.Settings.Default.numTicket = (numTicket+1).ToString();
             
           sw.Write(getEndOfTicket(total));
            this.sw.Close(); // On libère le buffer du ticket tampon

            String fileName = "undefined";
            // Le nom du ticket à le path suivant:
            //  C:\Users\"John Doe"\Documents\Ticket N°35 -- 161020 - 14:10:00
            try
            {
                fileName =  this.ticketsPath + "Ticket N" + numTicket + " --  " + DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss") + ".txt";
                System.IO.File.Copy(ticketsPath + "tampon.txt", fileName);
            }
            catch (Exception e)
            {
                Console.WriteLine("Impossible d'écrire sur le fichier " +  fileName + "Erreur : " + e);
            }

            return fileName;

        }

        public void razTicketTampon()
        {
            // La réinitialisation du ticket tampon se fait en l'effaçant, il sera recréé lors de la création d'un nouveau panier
            sw.Close();
            File.Delete(ticketsPath + "tampon.txt");  
        }

        private String getBeginOfTicket()
        {
            // Pour générer le début du ticket, on utilise l'heure de DateTime avec le IFormatSpecifier adapté
            return  "--------------------------------\n"+
                    "Primeur de la côte\n"+
                    "Avenue de beaurivage\n"+
                    "64200 Biarritz\n"+
                    "\n"+
                    "le "+ DateTime.Now.ToString("dd/MM/yyyy") +"\n" +  // JJ / MM / AAAA
                    "à "+ DateTime.Now.ToString("HH:mm") +"\n" +        // HH / mm
                    "\n";
        }

        private String getEndOfTicket(double total)
        {
            // Pour générer la fin du ticket on à besoin du prix total et de sa TVA au bon format
            const double TVA_RATIO = 0.2;
            const String I_FORMAT_SPECIFIER = "N"; // Le "P" correspond à la notation "Numeric" avec deux décimales

            const String REGIONAL_SPECIFIER = "fr-CA"; // Préciser le format Français permet de supprimer le "." entre les milliers
            CultureInfo culture = CultureInfo.CreateSpecificCulture(REGIONAL_SPECIFIER);

            return "\n" +
                    "TOTAL TTC : " + total.ToString(I_FORMAT_SPECIFIER) + " €\n" +
                    "TVA: " + (total * TVA_RATIO).ToString(I_FORMAT_SPECIFIER,culture) + " €\n" +
                    "\n" +
                    "Merci de votre visite et...\n" +
                    "... Gardez la pêche!\n" +
                    "---------------------------------\n";
        }
    }
}