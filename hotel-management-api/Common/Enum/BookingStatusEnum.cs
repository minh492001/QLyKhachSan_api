using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace hotel_management_api.Common.Enum
{
    public enum BookingStatusEnum : byte
    {
        [Description("Reserve")] Reserve = 0,
        [Description("Staying")] Staying = 1,
        [Description("Checkout")] Checkout = 2,
        [Description("Paid")] Paid = 3,
    }
}
