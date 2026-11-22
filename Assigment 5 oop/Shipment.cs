using System;
using System.Collections.Generic;
using System.Text;

namespace Assigment_5_oop
{
    internal partial class Shipment:DeliveryAddress
    {

        public static int TotalShipmentsCreated = 0;
        private string trackingCode;
        private string descrption;
        private decimal weight;
        private decimal deleiveryFee;
        public DeliveryAddress destination { get; set; }
        
        //answer 2 part 2
        




        public void UpdateDeliveryFee(decimal newfee)
        {
            if (newfee > 0)
            {
                deleiveryFee = newfee;
            }

        }
        #region abstract method
        //public abstract string PrintShipment();

        #endregion
        #region overloding weigth answer 2 part2
        public void upDateWeigth(decimal weigth)
        {
            weigth = weigth;
        }
        public void upDateWeigthExtra(decimal weigth, decimal extra)
        {
            Weight = weigth + extra;

        }
        #endregion
        public string PrintShipment()
        {
            return  $" the code: {TrackingCode} the descrabtion : {Descrption} weigth  : {Weight} delivery cost : {DeleiveryFee} ,{destination.GetFullAdress()} ";


        }
        // part 2 q1 
        public Shipment copyShipment()
        {
            return (Shipment)this.MemberwiseClone();
        }
        public Shipment DeepCopy()
        {
            DeliveryAddress newDelive = new DeliveryAddress(
                this.destination.getCity(), this.destination.getStreet(), this.destination.getBuldingNum());
            return new Shipment(
                  this.trackingCode,
        this.Descrption,
        this.Weight,
        this.DeleiveryFee,
        newDelive);

          

           }

        }
    }


