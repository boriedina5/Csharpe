using System;
using System.Collections.Generic;
using System.Text;

namespace FutasConsoleApp
{
    public class Futas
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int RunningTime { get; set; }

        public Futas(string row) { 
            string[] rowDatas = row.Split(";");
            Name = rowDatas[0];
            City = rowDatas[1];
            RunningTime = int.Parse(rowDatas[2]);
        }
    }
}
