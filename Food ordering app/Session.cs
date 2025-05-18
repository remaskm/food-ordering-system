using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Food_ordering_app
{
    public static class Session
    {
        public static int CurrentUserId { get; set; }
        public static string Role { get; set; }
        public static string UserName { get; set; }
    }
}
