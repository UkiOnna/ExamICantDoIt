using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWorkICantDoIt
{
    public class TxtFile : BaseFile
    {
        public TxtFile(string name, string extension, int size, string filepath, byte[] data) : base(name, extension, size, filepath, data)
        {
            
        }

        public override void Close()
        {
            base.Close();
        }

        public override void Create()
        {
            base.Create();
        }

        public override void Open()
        {
            base.Open();
        }

        public override void Save()
        {
            base.Save();
        }


    }
}
