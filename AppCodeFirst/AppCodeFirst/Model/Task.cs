﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCodeFirst.Model
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsComplete { get; set; }
        public  User AssignedTo { get; set; }

        public override string ToString()
        {
            return $"Task id={TaskId}, title={Title}, datetim={DueDate}, iscomplete={IsComplete}";            
        }
    }
}