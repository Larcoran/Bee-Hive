using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_6_4_bee_hive
{
    class Queen : Bee
    {
        #region Private Fields

        private Worker[] workers;
        private int shiftNumber = 0;

        #endregion

        #region Properties

        public Worker[] Workers
        {
            get { return workers; }
            set { workers = value; }
        }

        #endregion

        #region Constructor

        public Queen(Worker[] workers,double weightMg):base(weightMg)
        {
            this.workers = workers;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Check if there is worker availiable for a job. Assign the job to him and return true. If there is no worker available, return false.
        /// </summary>
        /// <param name="workToAssign"></param>
        /// <param name="shifts"></param>
        /// <returns></returns>
        public bool AssignWork(string workToAssign, int shifts)
        {
            for(int x = 0; x<Workers.Length; x++)
            {
                if (Workers[x].DoThisJob(workToAssign, shifts))
                    return true;
            }
            return false;

        }

        /// <summary>
        /// Generate report for this shift and move to next shift.
        /// </summary>
        /// <returns></returns>
        public string WorkTheNextShift()
        {
            double honeyConsumed = HoneyConsumptionRate();
            shiftNumber++;
            string report = "Report for shift #" + shiftNumber + "\r\n";

            for (int y=0 ; y<Workers.Length ; y++)
            {
                if (Workers[y].DidYouFinish())
                    report += "Worker #" + (y+1) + " finished the job.\r\n";
                if (String.IsNullOrEmpty(Workers[y].CurrentJob))
                    report += "Worker #" + (y + 1) + " is not working.\r\n";

                else
                {
                    if (Workers[y].ShiftsLeft > 0)
                    {
                        report += "Worker #" + (y + 1) + " is doing " + Workers[y].CurrentJob + " for " + Workers[y].ShiftsLeft + " more shifts.\r\n";
                    }
                    else
                    {
                        report += "Worker #" + (y + 1) + " will be done with " + Workers[y].CurrentJob + " after this shift.\r\n";
                    }
                }
                honeyConsumed += Workers[y].HoneyConsumptionRate();
                
            }
            report += "Total honey consumed for the shift: " + honeyConsumed + " units.\r\n";
            return report;
        }

        #endregion
    }
}
