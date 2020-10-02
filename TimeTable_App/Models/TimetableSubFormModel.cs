﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using TimeTable_App.Global;

/*
 *      Class Name      -   TimeSlotSubFormModel
 *      Author          -   Dimuthu Abeysinghe
 *      Date            -   20/08/2020
 *      Description     -   Handle the details about the Time slots. 
 *      
 *      Version Control
 *          * [Dimuthu Abeysinghe]
 *              Implement the class to handle Time slots.
 *      
 */

namespace TimeTable_App.Models
{
    public class TimetableSubFormModel
    {
        [Key]
        public string Time { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }

        public dynamic GetFormData(TimeTableDbContext _dbContext, string type)
        {
            if (type == "TimeTable")
            {
                return _dbContext.TimeTable.AsNoTracking().ToList();
            }

            return null;
        }
    }
}
