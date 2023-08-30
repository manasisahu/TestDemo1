using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelInsurance
{
    public partial class TravelResponseDTO
    {
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public bool CanListAuctions { get; set; }
        public bool CanListClassifieds { get; set; }
        public bool CanRelist { get; set; }
        public string LegalNotice { get; set; }
        public long DefaultDuration { get; set; }
        public List<long> AllowedDurations { get; set; }
        public Fees Fees { get; set; }
        public long FreePhotoCount { get; set; }
        public long MaximumPhotoCount { get; set; }
        public bool IsFreeToRelist { get; set; }
        public List<Promotion> Promotions { get; set; }
        public List<object> EmbeddedContentOptions { get; set; }
        public long MaximumTitleLength { get; set; }
        public long AreaOfBusiness { get; set; }
        public long DefaultRelistDuration { get; set; }
        public bool CanUseCounterOffers { get; set; }
    }

    public partial class Fees
    {
        public long Bundle { get; set; }
        public double EndDate { get; set; }
        public long Feature { get; set; }
        public long Gallery { get; set; }
        public long Listing { get; set; }
        public double Reserve { get; set; }
        public double Subtitle { get; set; }
        public double TenDays { get; set; }
        public List<ListingFeeTier> ListingFeeTiers { get; set; }
        public double SecondCategory { get; set; }
    }

    public partial class ListingFeeTier
    {
        public long MinimumTierPrice { get; set; }
        public long FixedFee { get; set; }
    }

    public partial class Promotion
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        public long MinimumPhotoCount { get; set; }
        public long? OriginalPrice { get; set; }
        public bool? Recommended { get; set; }
    }

}
