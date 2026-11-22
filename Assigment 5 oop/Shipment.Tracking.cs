using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_5_oop
{
    internal partial class Shipment
    {
        public Shipment()
        {

        }
        public Shipment(string t)
        {
            trackingCode = t;
            descrption = "unknow";
            weight = 1;
            deleiveryFee = 50;
            destination = new DeliveryAddress();
        }
        public Shipment(string t, string d, decimal i, decimal de, DeliveryAddress delive)
        {
            TrackingCode = t;
            Descrption = d;
            Weight = i;
            DeleiveryFee = de;
            destination = delive;
            TotalShipmentsCreated++;
        }
        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }
        //
        public string TrackingCode
        {
            get
            {
                return trackingCode;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
            }

        }
        public string Descrption
        {
            get
            {
                return descrption;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    descrption = value;

                }
            }

        }
        public decimal Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }
        public virtual decimal DeleiveryFee
        {
            get
            {
                return deleiveryFee;
            }
            private set
            {
                if (value > 0)
                {
                    deleiveryFee = value;
                }
                deleiveryFee = 150;
            }

        }
    }
}
