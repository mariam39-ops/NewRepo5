using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_5_oop
{
    internal  static class ShipmentExtensions
    {
        public static string GetSummary( this Shipment s)
        {
         return $"{s.TrackingCode} | {s.Descrption} | {s.Weight} KG | {s.DeleiveryFee}";

        }
        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.TrackingCode == shipment.TrackingCode;
        }
    }
}
