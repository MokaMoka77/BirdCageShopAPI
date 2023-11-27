

namespace Ecommerce.BusinessLogic.RequestModels.OrderDetail 
{

   public class CreateOrderDetailRequestModel {
        public string ProductId { get; set; } = null!;
        public int CartQuantity { get; set; }
        public string? ProductName { get; set; }
        public int? BirdTypeId { get; set; }
        public string? Model { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public int? Status { get; set; }
        public int? Size { get; set; }
        public int? Quantity { get; set; }
        public string? ProductMaterial { get; set; }
        public int? BirdCageType { get; set; }
        public string? Image { get; set; }
        public string? Color { get; set; }
        public decimal? Sale { get; set; }

    }

}
