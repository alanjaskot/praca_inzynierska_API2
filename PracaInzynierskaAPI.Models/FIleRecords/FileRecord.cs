using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInzynierskaAPI.Models.FIleRecords
{
    public class FileRecord
    {
        public string FileName { get; set; }
        public string FileFormat { get; set; }
        public string FileType { get; set; }
        public string FileContent { get; set; }
        public string FilePath { get; set; }
    }
}
