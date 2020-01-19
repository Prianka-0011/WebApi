using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAngularWhithApi.Models
{
    public class TodoTask
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public string Date { get; set; }
    }
}
