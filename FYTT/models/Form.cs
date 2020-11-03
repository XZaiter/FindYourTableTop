using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace FYTT.models
{
    public class Form
    {
        public int ID { get; set; }
        public string RoleSystem { get; set; }
        public string PlayerName { get; set; }
        [DataType(DataType.Date)]
        public DateTime ExpectedPlayingTime { get; set; }
        public decimal NumberOfPlayers { get; set; }
    }
}
