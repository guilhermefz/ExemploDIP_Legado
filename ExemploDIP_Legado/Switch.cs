using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDIP_Legado
{
    class Switch : IDevice
    {
        private readonly IDevice _device;

        public Switch(IDevice device)
        {
            _device = device;
        }

        public void Operate()
        {
            _device.Operate();
        }
    }
}
