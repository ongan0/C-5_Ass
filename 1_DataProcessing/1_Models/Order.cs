﻿namespace Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models
{
    public class Order
    {
        public Guid OrdelID { get; set; }
        public Guid UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public int Status { get; set; }

        public ICollection<OrderDetail> OrderDetail { get; set; }

        public virtual Users Users { get; set; }
    }
}
