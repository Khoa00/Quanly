using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thuctap_Share.Models;

namespace Thuctap_Share.Services
{
    public interface IMuchocphi
    {
    }
    public class MuchocphiSvc
    {
        protected DataBaseContext _context;

        public MuchocphiSvc(DataBaseContext context)
        {
            _context = context;

        }
    }
}
