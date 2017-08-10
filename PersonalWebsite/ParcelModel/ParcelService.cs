using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParcelModel.Parcel;

namespace ParcelModel
{
    public class ParcelService: IParcelService
    {
        private List<ParcelEntity> _parcelList = null;

        public ParcelService()
        {
            _parcelList = new List<ParcelEntity>()
            {
                 ParcelFactory.CreateParcel(ParcelType.Small),
                 ParcelFactory.CreateParcel(ParcelType.Medium),
                 ParcelFactory.CreateParcel(ParcelType.Large),

        };
        }

    
      
        public  ParcelEntity Identify(AbstractParcel inputOrder)
        {
            if (_parcelList == null)
            {
                throw new InvalidOperationException();
            }
            if (inputOrder == null)
            {
                throw new ArgumentNullException(nameof(inputOrder));
            }


            var parcel = _parcelList.FirstOrDefault(x => x.Breadth >= inputOrder.Breadth && x.Length >= inputOrder.Length && x.Height >= inputOrder.Height&&x.Weight>=inputOrder.Weight);

            return parcel;
        }
    }
}
