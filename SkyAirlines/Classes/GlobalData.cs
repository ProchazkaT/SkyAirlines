using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using WiLBiT;

namespace SkyAirlines
{
    public static class GlobalData
    {
        public static string Username { get; set; }
        public static System.Windows.Forms.Label lblMoney { get; set; }
        public static string airlineID { get; set; }

        public static System.Windows.Forms.Button btnChat { get; set; }
        public static System.Windows.Forms.Button btnLeaveAirline { get; set; }

        public static string Departure { get; set; }
        public static string Arrival { get; set; }
        public static string AirplaneForFlight { get; set; }
        public static bool isFlown { get; set; }

        public static Task flightTrackingThread { get; set;}
    }
}
