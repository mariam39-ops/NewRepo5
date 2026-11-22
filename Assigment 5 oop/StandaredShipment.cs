using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_5_oop
{
    internal class StandaredShipment : Shipment, ITrackable, IInsurable
    {
        #region constractor chining 2 answer 3 part 3
        public StandaredShipment(string t, string dec, decimal w, decimal df, DeliveryAddress d) : base(t, dec, w, df, d)
        {

        }
        public  decimal EstimatedCost
        {
            get
            {
                return DeleiveryFee + (Weight * 2);
            }
        }
        #endregion
        //method over ride 1 standardshipment
        public  string PrintShipment()
        {
            return $"TrackingNumber: {TrackingCode}Description: {Descrption}EstimatedCost:{EstimatedCost}";
        }
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is done.";
        }
        // override form intervace لازم قدام جايخ من انترفيس اعمل ليها وافررايد
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }
    }
}

