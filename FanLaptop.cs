using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_103022300029
{
    enum State { Quiet, Balanced, Turbo, Performance};
    enum Trigger {modeup, modedown, turboshortcut };
  

    class FanLaptop
    {
       public class Mode
        {
           public State stateAwal;
            public State stateAkhir;
            public Trigger trigger;
             public Mode(State stateAwal, State stateAkhir, Trigger trigger)
            {
                this.stateAwal = stateAwal;
                this.stateAkhir = stateAkhir;
                this.trigger = trigger;
            }

        }

        Mode[] mode =
        {
            new Mode(State.Quiet, State.Balanced, Trigger.modeup),
            new Mode(State.Balanced, State.Performance, Trigger.modeup),
            new Mode(State.Performance, State.Turbo, Trigger.modeup),
            new Mode(State.Turbo, State.Performance, Trigger.modedown),
            new Mode(State.Performance, State.Balanced, Trigger.modedown),
            new Mode(State.Balanced, State.Quiet, Trigger.modedown),
            new Mode(State.Quiet, State.Turbo, Trigger.turboshortcut),
            new Mode(State.Turbo, State.Quiet, Trigger.turboshortcut),

        };

        public State CurrrentState = State.Quiet;
        public State GetState(State stateAwal, Trigger trigger) {
            State stateAkhir = stateAwal;
            for (int i = 0; i < mode.Length; i++)
            {
                Mode gerak = mode[i];
                if (stateAwal == gerak.stateAwal && trigger == gerak.trigger)
                {
                    stateAkhir = gerak.stateAkhir;
                }

            }
            return stateAkhir;
        }
        public void setTrigger(Trigger trigger)
        {
            if (trigger == Trigger.turboshortcut)
            {
                Console.WriteLine("Mode turbo aktif bang");
            }
            else if (trigger == Trigger.modeup)
            {
                Console.WriteLine("mode up aktif");
            }
            else if (trigger == Trigger.modedown)
            {
                Console.WriteLine("mode down");
            }
            CurrrentState = GetState(CurrrentState, trigger);
            Console.WriteLine("State sekarang " + CurrrentState);
        }
       
    }
}
