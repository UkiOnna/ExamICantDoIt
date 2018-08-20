using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWorkICantDoIt
{
   public class TextManager
    {
        public BaseFile File { get; set; }

        public TextManager(BaseFile file)
        {
            File = file;
        }

        public void ExecuteCreate()
        {
            File.Create();
        }
        public void ExecuteOpen()
        {
            File.Open();
        }
        public void ExecuteSave()
        {
            File.Save();
        }
        public void ExecuteClose()
        {
            File.Close();
        }
    }
}
