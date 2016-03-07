using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubMockFack
{
    public interface IDateTimeProvider
    {
        DateTime Now { get; }
    }

    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime Now { get { return DateTime.Now; } }
    }

    public class PubFake
    {
        private ICheckInFee _checkInFee;
        private decimal _inCome = 0;
        private IDateTimeProvider _date;



        public PubFake(ICheckInFee checkInFee, IDateTimeProvider date)
        {
            this._checkInFee = checkInFee;
            this._date = date;
        }

        /// <summary>
        /// Customers entry
        /// Checkin happens when customer entry, when the customer is female, then free. 
        /// If Customer is male, add one to result.
        /// </summary>
        /// <param name="customers"></param>
        /// <returns>result = How many people needs to pay</returns>

        public int CheckIn(List<Customer> customers)
        {
            var result = 0;

            foreach(var customer in customers)
            {
                bool isFemale = customer.IsFemale;

                var isLadyNight = _date.Now.DayOfWeek;

                    
                    //Today.DayOfWeek == DayOfWeek.Friday;

                if (isFemale ==true && isLadyNight == DayOfWeek.Friday)
                {
                    continue;
                }
                else
                {
                    this._inCome += this._checkInFee.GetFee(customer);
                    result++;
                }
            }
            return result;

        }

        public decimal GetInCome()
        {
            return this._inCome;
        }
    }
}
