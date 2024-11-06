using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets_Consert_System.Data.Models
{
    public class Venue : Entity
    {
        public string Name {  get; set; }
        public string Address { get; set; }
        public int NumberOfRows {  get; set; }
        public int NumberOfPlacesInRow { get; set; }

        public override string ToString()
        {
            string result = "Name: " + Name + 
                "; Address: " + Address + 
                "; Number of rows: " + NumberOfRows.ToString() + 
                "; Number of places in row: " + NumberOfPlacesInRow.ToString();
            return result;
        }
    }
}
