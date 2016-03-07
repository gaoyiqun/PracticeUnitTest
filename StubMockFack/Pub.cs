using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StubMockFack
{
    public interface ICheckInFee
    {
        decimal GetFee(Customer customer);
    }

    public class Customer
    {
        public bool IsFemale { get; set; }

        public int Seq { get; set; }
    }

    public class Pub
    {
        private ICheckInFee _checkInFee;
        private decimal _inCome = 0;

        public Pub(ICheckInFee checkInFee)
        {
            this._checkInFee = checkInFee;
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

                if (isFemale)
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
