using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задачи
{
    internal class Tasks
    {
        public string Task { get; set; }
        public bool Status { get; set; }
        public Tasks(string task, bool status)
        {
            Task = task;
            Status = status;
        }
    }
}
