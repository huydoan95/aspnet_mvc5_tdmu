using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Views
{
    public class CourseView
    {
        public long ID { get; set; }

        public string Name { get; set; }
        public string CatName { get; set; }
        public DateTime? Date { get; set; }
    }
}
