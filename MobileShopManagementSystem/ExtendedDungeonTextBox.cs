using System;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace MobileShopManagementSystem
{
    public class ExtendedDungeonTextBox : DungeonTextBox
    {
        // Public KeyDown event mà người dùng có thể đăng ký
        public new event KeyEventHandler KeyDown
        {
            add { DungeonTB.KeyDown += value; }
            remove { DungeonTB.KeyDown -= value; }
        }

        public ExtendedDungeonTextBox()
        {
            // Đảm bảo các thiết lập ban đầu của DungeonTextBox vẫn được giữ
        }

        // Override OnKeyDown để đảm bảo cả logic gốc và logic mới đều được gọi
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            // Logic bổ sung nếu cần
        }
    }
}