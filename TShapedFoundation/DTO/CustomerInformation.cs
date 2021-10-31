using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShapedFoundation.DTO
{
    public class CustomerInformation
    {
        public PersonalInformation PersonalInformation { get; set; }
        public AddressInformation AddressInformation { get; set; }
    }
}
