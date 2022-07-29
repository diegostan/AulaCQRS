using FrotaApp.Domain.Enums;
using FrotaApp.Domain.Notifications;
using FrotaApp.Domain.Specs;
using FrotaApp.Domain.Validations;
using FrotaApp.Domain.Validations.Interfaces;

namespace FrotaApp.Domain.Entities
{
    public class VehicleEntity : BaseEntity, IValidate
    {
        #region Internal Props
        List<Notification> _notifications;
        #endregion

        public VehicleEntity(string name, string color, int modelYear, int categoryId, double price, EVehicleType type)
        {
            Name = name;
            Color = color;
            ModelYear = modelYear;
            CategoryId = categoryId;
            Price = price;
            Type = type;
            _notifications = new List<Notification>();
            PriceCalculate();
            IsValid();
            
        }

        #region  External Props
        public string Name { get; private set; }
        public string Color { get; set; }        
        public int ModelYear { get; private set; }
        public int CategoryId { get; private set; }
        public double Price { get; private set; }
        public EVehicleType Type { get; private set; }
        public IReadOnlyCollection<Notification> Notifications  => _notifications;
        
        #endregion

        // Validations
        public bool IsValid()
        {
            return
                new VehicleValidations(this).MinNameLength().MaxNameLength().IsValid();
        }

        // Notifications
        public void PullNotification(Notification notification)
        {
            this._notifications.Add(notification);
        }
    
        // Business Roles
        private void PriceCalculate()
        {
            if(new IsTaxExemptOn2022().IsSatisfiedBy(this))
                return;

            this.Price = this.Price + (this.Price * 0.06);
        }
    }
}