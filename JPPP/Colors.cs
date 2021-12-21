using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JPPP
{
    class Colors
    {
        public static Color topPanelDark = Color.FromArgb(44, 44, 44);
        public static Color menuPanelDark = Color.FromArgb(52, 52, 52);
        public static Color mainPanelDark = Color.FromArgb(62, 62, 62);
        public static Color selectedPanel = Color.FromArgb(223, 73, 23);
        public static Color close = Color.FromArgb(201, 54, 54);
        public static Color selectedControlDark = Color.FromArgb(76, 76, 79);
        public static Color subtitleColor = Color.FromArgb(154, 182, 216);
        public static Color labelColorDark = SystemColors.Info;

        public static Color topPanelLight = Color.FromArgb(222, 222, 222);
        public static Color menuPanelLight = Color.FromArgb(247, 247, 247);
        public static Color mainPanelLight = Color.FromArgb(255, 255, 255);
        public static Color labelColorLight = Color.FromArgb(24, 32, 45);
        public static Color selectedControlLight = Color.FromArgb(180, 180, 180);

        public static Color topPanel = topPanelDark;
        public static Color menuPanel = menuPanelDark;
        public static Color mainPanel = mainPanelDark;
        public static Color labelColor = labelColorDark;
        public static Color selectedControl = selectedControlDark;
        public static Color selectedLabelColor = labelColorLight;
    }
}
