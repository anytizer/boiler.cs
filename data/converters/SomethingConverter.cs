using dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.converters
{
    public class SomethingConverter
    {
        public static SomethingDTO ToDTO(SomethingEF ef)
        {
            SomethingDTO dto = new SomethingDTO();
            return dto;
        }

        public static SomethingEF ToEF(SomethingDTO dto)
        {
            SomethingEF ef = new SomethingEF();
            return ef;
        }
    }
}
