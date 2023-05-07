using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_App.Models
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string Password { get; set; }
        public virtual ISet<Quiz> Quizes { get; set; }
    }
}
