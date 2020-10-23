using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HOLE_FOODS
{
    public class Ticket
    {
        private static String tamponTxtPath = (@"C:\Users\c.janisse\source\repos\HOLE FOODS\HOLE FOODS\Logs\");
        private StreamWriter sw;
        private int numTicket;
        public Ticket()
        {
            sw = new StreamWriter(tamponTxtPath+"tampon.txt");
            numTicket++;
        }

        public void ajouterLigne(String ligne)
        {
            if (sw.BaseStream != null)
            {
                sw.WriteLine(ligne);
            }
            else
            {
                Console.WriteLine("[TickeT:ERROR] Fichier non ouvert " + tamponTxtPath + "tampon.txt");
            }
        }

        public void genererTicket()
        {
            sw.Close();
            System.IO.File.Copy(tamponTxtPath + "tampon.txt", tamponTxtPath + "Ticket N° " + numTicket + " --  "+ DateTime.Now.ToString("yymmdd - HHMMSS"));
        }

        public void razTicketTampon()
        {
            System.IO.File.WriteAllText(tamponTxtPath + "tampon.txt",string.Empty);

        }
    }
}