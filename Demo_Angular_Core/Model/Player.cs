using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_Angular_Core.Model
{
    public enum PlayerPosition
    {
        Goalkeeper,
        Defender,
        Midfielder,
        Forward,
        Striker
    }

    public class Player
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int ShirtNo { get; set; }

        public int Goals { get; set; }

        public int Appearances { get; set; }

        public PlayerPosition Position { get; set; }

        [NotMapped]
        public string PositionName => Position.ToString();
        [NotMapped]
        public decimal GoalsPerMatch => Math.Round((decimal)Goals / (decimal)Appearances ,2);
    }
}   

