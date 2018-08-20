using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWorkICantDoIt
{
  public  class BaseFile
    {
        public string Name { get; set; }
        public string Extension { get; set; }//расширение
        public int Size { get; set; }
        public string FilePath { get; set; }
        public byte[] Data { get; set; }

        public BaseFile(string name,string extension,int size,string filepath,byte[]data)
        {
           
        }

        public virtual void  Open()
        {

        }

        public virtual void Create()
        {

        }

        public virtual void Save()
        {

        }

        public virtual void Close()
        {

        }

    }
}
