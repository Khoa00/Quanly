using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thuctap_Share.Models;

namespace Thuctap_Share.Services
{
    public interface IQuanlyhocphi
    {
    }   
    public class QuanlyhocphiSvc
    {
        protected DataBaseContext _context;

        public QuanlyhocphiSvc(DataBaseContext context)
        {
            _context = context;
        }
    }
}
