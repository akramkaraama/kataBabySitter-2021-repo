using KataBabySitter_BOL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KataBabySitter_BLL
{
    public class PayCalculator
    {
        // This will create a list of work objects
        private static List<Rate> GetTimeRates()
        {
            List<Rate> rates = new List<Rate>()
            {
                // 4 hours before bedtime
                new Rate()
                {
                    Id= 1,
                    HourlyRate = 12.00
                },
                new Rate()
                {
                    Id= 2,
                    HourlyRate = 12.00
                },
                new Rate()
                {
                    Id= 3,
                    HourlyRate = 12.00
                },
                new Rate()
                {
                    Id= 4,
                    HourlyRate = 12.00
                },

                // 3 hours before midnight
                new Rate()
                {
                    Id= 5,
                    HourlyRate = 8.00
                },
                new Rate()
                {
                    Id= 6,
                    HourlyRate = 8.00
                },
                new Rate()
                {
                    Id= 7,
                    HourlyRate = 8.00
                },

                // 4 hours after midnight
                new Rate()
                {
                    Id= 8,
                    HourlyRate = 16.00
                },
                new Rate()
                {
                    Id= 9,
                    HourlyRate = 16.00
                },
                new Rate()
                {
                    Id= 10,
                    HourlyRate = 16.00
                },
                new Rate()
                {
                    Id= 11,
                    HourlyRate = 16.00
                }
            };

            return rates.ToList();
        }

        public double GetEmployeePay(WorkTime workTime)
        {
            double pay = 0.00;
            int shiftStartHour = 1;
            int shiftEndHour = 12;
            //var totalHoursWorked = endTime - startTime;

            if (workTime.StartTime == workTime.EndTime)
            {
                return 0.00;
            }

            if ((workTime.StartTime < shiftStartHour) && (workTime.EndTime > shiftEndHour))
            {
                return 0.00;
            }

            for (int hourNumber = workTime.StartTime; hourNumber < workTime.EndTime; hourNumber++)
            {
                foreach (var rate in GetTimeRates())
                {
                    if (rate.Id == hourNumber)
                    {
                        pay += rate.HourlyRate;
                    }
                }
            }

            return pay;
        }
    }
}
