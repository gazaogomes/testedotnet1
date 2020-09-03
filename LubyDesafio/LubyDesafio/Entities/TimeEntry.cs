using LubyDesafio.Entidades;
using System;

namespace LubyDesafio.Entities
{
    public class TimeEntry : EntityBase
    {
        public TimeEntry(DateTime dateBegin, DateTime dateEnd, Guid developeId, double totalHours)
        {
            DateBegin = dateBegin;
            DateEnd = dateEnd;
            DevelopeId = developeId;
            TotalHours = totalHours;
        }

        protected TimeEntry()
        {

        }

        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public Guid DevelopeId { get; set; }
        public double TotalHours { get; set; } 
        public Developer  Developer{ get; set; }
}
}
