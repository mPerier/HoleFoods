using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HOLE_FOODS
{
    public class Chemins
    {
        private String ticketPath;
        private String csvFilePath;

        public void setTicketPath(String ticketPath)
        {
            this.ticketPath = ticketPath;
        }

        public String getTicketPath()
        {
            return this.ticketPath;
        }

        public String getCsvFilePath()
        {
            return this.csvFilePath;
        }

        public void setCsvFilePath(string csvFilePath)
        {
            this.csvFilePath = csvFilePath;
        }
    }
}