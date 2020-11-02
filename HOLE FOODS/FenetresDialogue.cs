using System;
using System.Windows.Forms;

namespace HOLE_FOODS
{
    public static class FenetresDialogue
    {
        public static String setPath(String dialogName)
        {
            MessageBox.Show(dialogName);
            
            String outputPath = null;
            FolderBrowserDialog dirEntry = new FolderBrowserDialog();

            dirEntry.Description = dialogName;

            DialogResult result = dirEntry.ShowDialog();
            if (result == DialogResult.OK)
            {
                outputPath = dirEntry.SelectedPath;
            }
            return outputPath;
        }

        public static String setFile(String dialogName, String filter)
        {
            MessageBox.Show(dialogName);

            String outputFilePath = null;
            OpenFileDialog fileEntry = new OpenFileDialog();

            fileEntry.Title = dialogName;
            fileEntry.Filter = filter;
                
            DialogResult result = fileEntry.ShowDialog();
            if (result == DialogResult.OK)
            {
                outputFilePath = fileEntry.FileName;
            }
            return outputFilePath;
        }

        public static Boolean userVerification(String dialogName)
        {
            DialogResult dialogResult = MessageBox.Show(dialogName, "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}