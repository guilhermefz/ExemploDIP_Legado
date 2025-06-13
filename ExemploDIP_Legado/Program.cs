namespace ExemploDIP_Legado
{
    class program
    {
        static void Main()
        {
            var lampada = new Lamp(State.On);
            var meuSwitch = new Switch(lampada);
            var ar = new ArCondicionado(State.Off);
            var meuSwitchAr = new Switch(ar);
            meuSwitch.Operate();
            meuSwitch.Operate();
            meuSwitchAr.Operate();
        }
    }
}