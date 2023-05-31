using Assignment_Chsarp5_datntph19899._1_DataProcessing._1_Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Assignment_Chsarp5_datntph19899._1_DataProcessing._2_Configurations
{
    public class BillConfiguration : IEntityTypeConfiguration<Bill>
    {
        public void Configure(EntityTypeBuilder<Bill> builder)
        {
            builder.HasKey(c => c.ID);
            builder.Property(c=>c.OrderDate).IsRequired();
            builder.Property(c=>c.TotalPrice).IsRequired();
            builder.Property(c=>c.Delivery_Date).IsRequired();
            builder.Property(c=>c.Actual_Delivery_Date).IsRequired();
            builder.Property(c=>c.Delivery_Status).IsRequired();
            builder.Property(c=>c.Shipping_Cost).IsRequired();
            builder.Property(c=>c.Shipping_Address).IsRequired();
            builder.Property(c=>c.Payment_Status).IsRequired();

            builder.HasOne(c => c.Users).WithMany(c => c.Bills).HasForeignKey(c => c.UserID);
            builder.HasMany(c=>c.BillDetails).WithOne(c=>c.Bill).HasForeignKey(c=>c.ID);
            builder.HasOne(c => c.Delivery_Address).WithMany(c => c.Bills).HasForeignKey(c => c.Delivery_AddressId);
            //builder.HasOne(c => c.Express_Delivery).WithOne(c => c.Bill).HasForeignKey<Express_Delivery>(c => c.ID);
        }
    }
}
