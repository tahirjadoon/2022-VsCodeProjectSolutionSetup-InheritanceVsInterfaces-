namespace II.Library.BetterOO;

public interface IRental
{
    int RentalId { get; set; }
    string CurrentRenter { get; set; }
    decimal PricePerDay { get; set; }
}