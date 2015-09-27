using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Timers;

namespace StopWatch__BLL
{
    public class StopWatch
    {
        private TimeSpan _timeStart;
        private TimeSpan _timeEnd;
        private bool _isTimerOn;
        public List<TimeSpan> Laps {get; private set;}

        public StopWatch()
        {
            Laps = new List<TimeSpan>();
            _isTimerOn = false;
        }

        public void Reset()
        {
            Laps = new List<TimeSpan>();
            _isTimerOn = false;
            _timeStart = TimeSpan.Zero;
            _timeEnd = TimeSpan.Zero; 
        }

        public void Start()
        {
            if (!_isTimerOn)
            {
                _timeStart = DateTime.Now.TimeOfDay;
                _isTimerOn = true;
            }
            else
            {
                throw new InvalidOperationException("Ugh... timer is already running");
            }
        }

        public void Stop()
        {
            if (_isTimerOn)
            {
                _timeEnd = DateTime.Now.TimeOfDay;
                storeTime(_timeStart, _timeEnd);
                _isTimerOn = false; 
            }
            else
            {
                throw new InvalidOperationException("Ugh... timer is not on");
            }
        }

        private void storeTime(TimeSpan start, TimeSpan end)
        {
            Laps.Add(end.Subtract(start));
        }
    }
}
