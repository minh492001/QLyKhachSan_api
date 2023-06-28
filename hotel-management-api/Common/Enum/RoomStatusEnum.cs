using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace hotel_management_api.Common.Enum
{
    public enum RoomStatusEnum : byte
    {
        [Description("Vacant")] Vacant= 0,
        [Description("Staying")] Staying = 1,
        [Description("Reserve")] Reserve = 2,
        [Description("Checkout")] Checkout = 3,
    }
}
