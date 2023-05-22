﻿namespace Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models
{
    public class Combo
    {
        public Guid ID { get; set; }
        public Guid FoodID { get; set; }
        public string ComboName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }

        public ICollection<Coupons> Coupons { get; set; }
        public ICollection<Food> Food { get; set; }
    }
}
