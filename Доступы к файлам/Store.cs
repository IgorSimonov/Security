using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Доступы_к_файлам
{
    public class Store
    {
        private List<File> _files;

        public Store()
        {
            _files = new List<File>
            {
                new File
                {
                    Name = "File 1", Access = new List<FileAccess>
                    {
                        new FileAccess{UserLogin = "Admin",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 1",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 2",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 3",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 4",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 5",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 6",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 7",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 8",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 9",Access = "Полный доступ"},
                    },
                },
                
                new File
                {
                    Name = "File 1", Access = new List<FileAccess>
                    {
                        new FileAccess{UserLogin = "Admin",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 1",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 2",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 3",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 4",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 5",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 6",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 7",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 8",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 9",Access = "Полный доступ"},
                    },
                },
                
                new File
                {
                    Name = "File 1", Access = new List<FileAccess>
                    {
                        new FileAccess{UserLogin = "Admin",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 1",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 2",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 3",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 4",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 5",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 6",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 7",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 8",Access = "Полный доступ"},
                        new FileAccess{UserLogin = "User 9",Access = "Полный доступ"},
                    },
                },
            };
        }

        public List<File> GetFiles()
        {
            return _files;
        }
    }
}
