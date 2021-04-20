using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LAB01_2530019_1203819.Models
{
    public class Player
    {
        
        public int Id { get; set; }
        [Required]
        public string Club { get; set; }
        [Required]
        public string Last_name { get; set; }
        [Required]
        public string First_name { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public double Base_salary { get; set; }
        [Required]
        public double Guaranteed_compensation { get; set; }
        
        public static int Compare_First_Name (Player x, Player y) //Funcion del delegado
        {
            int r = x.First_name.CompareTo(y.First_name);
            return r;
        }
        public static int Compare2(Player x, int y) //Funcion del delegado
        {
            int r = x.Id.CompareTo(y);
            return r;
        }
        public static int Compare_id(Player x, Player y) //Funcion del delegado
        {
            int r = x.Id.CompareTo(y.Id);
            return r;
        }
        public static int Compare_Last_Name(Player x, Player y) //Funcion del delegado
        {
            int r = x.Last_name.CompareTo(y.Last_name);
            return r;
        }
        public static int Compare_Position(Player x, Player y) //Funcion del delegado
        {
            int r = x.Position.CompareTo(y.Position);
            return r;
        }
        public static int Compare_Base_Salary(Player x, Player y) //Funcion del delegado
        {
            int r = x.Base_salary.CompareTo(y.Base_salary);
            return r;
        }
        public static int Compare_Base_Salary_Upper(Player x, Player y) //Funcion del delegado
        {
            int r = x.Base_salary.CompareTo(y.Base_salary);
            if (r > 0) return 0;
            return -1;
        }
        public static int Compare_Base_Salary_Lower(Player x, Player y) //Funcion del delegado
        {
            int r = x.Base_salary.CompareTo(y.Base_salary);
            if (r < 0) return 0;
            return 1;
        }
        public static int Compare_Club(Player x, Player y) //Funcion del delegado
        {
            int r = x.Club.CompareTo(y.Club);
            return r;
        }




    }
}
