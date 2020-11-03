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
    public class Chemins
    {
        private String ticketsPath;
        private String csvFile;

        public Chemins()
        {
            // Lors de l'instanciation de Chemins, on s'assure de la présence de tous les chemins d'accès
            checkPaths();
        }

        public void checkPaths()
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

        public void resetSettings()
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
        public String getTicketPath()
        {
            return this.ticketsPath;
        }

        public String getCsvFilePath()
        {
            return this.csvFile;
        }
    }
}