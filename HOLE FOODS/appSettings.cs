using System;
using System.IO;

/**
 *
 * ------------- MODEL ----------------
 *
 * La classe Chemins gère encapsule les opérations liées à l'obtention des chemins d'accès des fichiers utilisés par l'application
 * 
 */

namespace HOLE_FOODS
{
    public static class AppSettings
    {
        private static String ticketsPath;
        private static String csvFile;
        private static int numTicket;

        public static void checkPaths()
        {
            // Vérifie que tous les chemins d'accès sont disponibles et que les fichiers existent, sinon on demandera à l'utilisateur de les renseigner

            // ticketsPath
            if (Properties.Settings.Default.ticketsPath == null || !Directory.Exists(Properties.Settings.Default.ticketsPath.ToString()))
            {
                Properties.Settings.Default.ticketsPath = FenetresDialogue.setPath("Selectionnez le chemin d'accès au répertoire ou seront stockés les tickets");
            }
            ticketsPath = Properties.Settings.Default.ticketsPath.ToString();

            // csvFile
            if (Properties.Settings.Default.csvFile == null || !File.Exists(Properties.Settings.Default.csvFile.ToString()))
            {
                Properties.Settings.Default.csvFile = FenetresDialogue.setFile("Selectionnez le fichier CSV contenant la liste des produits", "CSV Files (*.csv)|*.csv");
            }
            csvFile = Properties.Settings.Default.csvFile.ToString();

            //!\\ Ne pas oublier de sauvegarder les propriétés une fois modifiées!
            Properties.Settings.Default.Save();
        }

        public static void resetSettings()
        {

            // On demande confirmation à l'utilisateur avant de réinitialiser
            if (FenetresDialogue.userVerification("Êtes vous sûr de vouloir réinitialiser les paramètres de l'application?"))
            {
                Properties.Settings.Default.ticketsPath = "";
                Properties.Settings.Default.csvFile = "";
                Properties.Settings.Default.Save();
            }
        }

        // Les getters utilisés pour extraire les chemins 
        public static String getTicketPath()
        {
            return ticketsPath;
        }

        public static String getCsvFilePath()
        {
            return csvFile;
        }

        public static void setNumTicket(int newNumTicket)
        {
            numTicket = newNumTicket;
            Properties.Settings.Default.numTicket = newNumTicket.ToString();
        }

        public static int getNumTicket()
        {
            // On essaie de retrouver le numéro de ticket, en cas d'achec on l'initialise à 0
            if (!int.TryParse(Properties.Settings.Default.numTicket.ToString(), out numTicket))
            {
                numTicket = 0;
                Properties.Settings.Default.numTicket = "0";
            }

            return numTicket;
        }
    }
}