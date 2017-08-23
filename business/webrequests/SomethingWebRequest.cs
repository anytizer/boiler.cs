using data.repositories;
using dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business.webrequests
{
    public class SomethingWebRequest
    {
        public SomethingDTO get(Guid id)
        {
            DTORepository repo = new DTORepository();
            return repo.getSomething(id);
        }
    }
}
