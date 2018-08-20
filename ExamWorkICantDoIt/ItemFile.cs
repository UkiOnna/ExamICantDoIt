using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWorkICantDoIt
{
    public class ItemFile
    {
        public string FileName { get; set; }
        public string Text { get; set; }
        public bool isChanged { get; set; }

        public ItemFile(string fileName)
        {
            FileName = fileName;
        }
    }
}
