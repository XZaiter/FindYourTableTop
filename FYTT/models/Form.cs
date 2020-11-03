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
        [Display(Name = "Ролевая система")]
        public string RoleSystem { get; set; }
        [Display(Name = "Имя игрока")]
        public string PlayerName { get; set; }
        [Display(Name = "Желаемое время игры")]
        [DataType(DataType.Date)]
        public DateTime ExpectedPlayingTime { get; set; }
        [Display(Name = "Опыт в ролевой системе(в годах)")]
        public decimal NumberOfPlayers { get; set; }
    }
}
