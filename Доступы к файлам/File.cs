using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Доступы_к_файлам
{
    public class File
    {
        public string Name { get; set; }
        public List<FileAccess> Access { get; set; }
    }
}
