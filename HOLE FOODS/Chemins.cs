using System;
using System.Configuration;
using System.IO;

namespace HOLE_FOODS
{
    public class Chemins
    {
        private String ticketsPath;
        private String csvFile;

        public Chemins()
        {
            checkPaths();
        }

        public void checkPaths()
        {
            // Vérifie que les chemins d'accès aux fichiers sont valides
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

        public void resetSettings()
        {
            if (FenetresDialogue.userVerification("Êtes vous sûr de vouloir réinitialiser les paramètres de l'application?"))
            {
                Properties.Settings.Default.ticketsPath = "";
                Properties.Settings.Default.csvFile = "";
                Properties.Settings.Default.Save();
            }
        }

        public void setTicketPath(String ticketPath)
        {
            this.ticketsPath = ticketPath;
        }

        public String getTicketPath()
        {
            return this.ticketsPath;
        }

        public String getCsvFilePath()
        {
            return this.csvFile;
        }

        public void setCsvFilePath(string csvFilePath)
        {
            this.csvFile = csvFilePath;
        }
    }
}