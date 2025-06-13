using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDIP_Legado
{
    class ArCondicionado : IDevice
    {
        public State Estado { get; set; }
        public ArCondicionado(State state)
        {
            Estado = state;
        }

        public void Operate()
        {
            if (Estado == State.On)
            {
                Estado = State.Off;
            }
            else
            {
                Estado = State.On;
            }
            Console.WriteLine("Ar " + (Estado == State.On ? "Ligado" : "Desligado"));
        }
    }
}
