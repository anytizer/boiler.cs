using data.converters;
using dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.repositories
{
    public class DTORepository
    {
        public SomethingDTO getSomething(Guid id)
        {
            EntityFrameworkRepository repo = new EntityFrameworkRepository();
            SomethingEF ef = repo.getSomething();
            SomethingDTO something = repo.getSomething(SomethingConverter.ToDTO(ef));

            return something;
        }
    }
}
