using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploDIP_Legado 
{
    class Lamp : IDevice
    {
        public State Estado { get; set; }
        public Lamp (State state)
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
            Console.WriteLine("Luz " + (Estado == State.On ? "Ligada" : "Desligada"));
        }
    }
}
