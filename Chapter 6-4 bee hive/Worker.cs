using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_4_bee_hive
{
    class Worker : Bee
    {
        private string currentJob = "";
        private int shiftsToWork;
        private int shiftsWorked;
        const double honeyUnitsPerShiftWorked = .65;

        private string[] jobsICanDo;

        public string[] JobsICanDo
        {
            get { return jobsICanDo; }
            set { jobsICanDo = value; }
        }

        public string CurrentJob { get { return currentJob; } }
        public int ShiftsLeft { get { return shiftsToWork-shiftsWorked; } }

        public Worker(string[] jobsICanDo,double weightMg):base(weightMg)
        {
            this.jobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(string jobToDo, int forThatManyShifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
                return false;
            for (int i = 0; i < jobsICanDo.Length; i++)
                if (jobsICanDo[i]==jobToDo)
                {
                    currentJob = jobToDo;
                    this.shiftsToWork = forThatManyShifts;
                    shiftsWorked = 0;
                    return true;
                }
                return false;
        }

        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                currentJob = "";
                return true;
            }
            else
                return false; 
        }

        public override double HoneyConsumptionRate()
        {
            double consumption = base.HoneyConsumptionRate();
            consumption += shiftsWorked * honeyUnitsPerShiftWorked;
            return consumption;
        }
    }
}
