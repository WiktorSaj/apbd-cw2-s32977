namespace apbd_cw2_s32977;

public class Laptop : Sprzet
{
 public int ramInGB { get; set; }
 public double weightInKg { get; set; }

 public Laptop(int id, bool available, String name, double pricePerDay, int ramInGB, double weightInKg) : base(id,
  available, name, pricePerDay)
 {
  this.ramInGB = ramInGB;
  this.weightInKg = weightInKg;
 }
}