﻿namespace Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models
{
    public class BillDetail
    {
        public Guid ID { get; set; }
        public Guid BillID { get; set; }
        public Guid FoodID { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public virtual Bill Bill { get; set; }
        public virtual Food Food { get; set; }
    }
}
