using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarApp.Models
{
    public enum AssetStateEnum
    {
        NEW,
        ASSIGNED,
        ACCEPTED,
        RETURNED,
        AWAITINGRETURN,
        RECEIVED
    }
}