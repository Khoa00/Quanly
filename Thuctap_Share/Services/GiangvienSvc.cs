using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thuctap_Share.Models;

namespace Thuctap_Share.Services
{
    public interface IGiangvien
    {
    }
    public class GiangvienSvc
    {
        protected DataBaseContext _context;

        public GiangvienSvc(DataBaseContext context)
        {
            _context = context;
            
        }
    }
}
