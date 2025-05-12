namespace MingoButik.Models;

public class Products:BaseModel
{
    public string ImgUrl {  get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public int ProductPrice { get; set; }


}
