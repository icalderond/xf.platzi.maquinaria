using System;
using System.Timers;
namespace xf.platzi.maquinaria
{
    public class Maquinaria : NotificationEnabledObject
    {
        Timer timer;

        public Maquinaria()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Elapsed += (s, a) =>
            {
                Hora = DateTime.Now.Hour;
                Minuto = DateTime.Now.Minute;
                Segundo = DateTime.Now.Second;
            };
            timer.Start();
        }

        private int _Hora;
        public int Hora
        {
            get { return _Hora; }
            set
            {
                _Hora = value;
                OnPropertyChanged();
            }
        }

        private int _Minuto;
        public int Minuto
        {
            get { return _Minuto; }
            set
            {
                _Minuto = value;
                OnPropertyChanged();
            }
        }

        private int _Segundo;
        public int Segundo
        {
            get { return _Segundo; }
            set
            {
                _Segundo = value;
                OnPropertyChanged();
            }
        }
    }
}
