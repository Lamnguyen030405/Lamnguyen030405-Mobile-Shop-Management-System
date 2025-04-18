using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopManagementSystem
{
    internal class ButtonAdapter : IButtonControl
    {
        private DungeonButtonLeft btn;
        ButtonAdapter(DungeonButtonLeft btn)
        {
            //btn = btn;
        }

        public DialogResult DialogResult { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void NotifyDefault(bool value)
        {
            throw new NotImplementedException();
        }

        public void PerformClick()
        {

        }
    }
}
