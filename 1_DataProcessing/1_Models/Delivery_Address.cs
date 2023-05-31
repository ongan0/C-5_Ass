namespace Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models
{
    public class Delivery_Address
    {
        public Guid ID { get; set; }
        public Guid CustomerID { get; set; }
        public string Receiver_Name { get; set; }
        public string Receiver_Address { get; set; }
        public string PhoneNumber { get; set; }

        public virtual Users User { get; set; }
        public ICollection<Bill> Bills { get; set; }
    }
}
