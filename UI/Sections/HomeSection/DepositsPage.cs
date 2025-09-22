using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.UI.Sections.HomeSection
{
    public class DepositsPage : UserControl
    {
        public DepositsPage()
        {
            Label lbl = new Label()
            {
                Text = "Страница: Вклады и счета",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("Arial", 20)
            };
            this.Controls.Add(lbl);
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // DepositPage
            // 
            Name = "DepositPage";
            Size = new Size(955, 595);
            ResumeLayout(false);

        }
    }
}
