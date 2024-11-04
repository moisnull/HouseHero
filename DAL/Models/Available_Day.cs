﻿using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{

    public enum Day
    {
       السبت , 
       الاحد,
       الاثنين,
       الثلاثاء,
       الاربعاء,
       الخميس,
       الجمعة
      
    }

    public class Available_Day:ModelBase
    {
        public int Id {  get; set; }
        public int ProviderId {  get; set; }
        public Day Day { get; set; }
        public TimeOnly Start_Time { get; set; }
        public TimeOnly End_Time { get; set; }
        
        public Provider Provider { get; set; } = null!;
    }
}
