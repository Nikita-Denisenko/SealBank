using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.UI.Sections.HomeSection
{
    public class BonusesPage : UserControl
    {
        public BonusesPage()
        {
            Label lbl = new Label()
            {
                Text = "Страница: Бонусы",
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
