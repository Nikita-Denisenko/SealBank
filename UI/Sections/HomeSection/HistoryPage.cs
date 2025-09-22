using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.UI.Sections.HomeSection
{
    public class HistoryPage : UserControl
    {
        public HistoryPage()
        {
            Label lbl = new Label()
            {
                Text = "Страница: История операций",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("Arial", 20)
            };
            this.Controls.Add(lbl);
        }

        private void InitializeComponent()
        {

        }
    }
}
