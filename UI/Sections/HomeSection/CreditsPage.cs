using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.UI.Sections.HomeSection
{
    public class CreditsPage : UserControl
    {
        public CreditsPage()
        {
            Label lbl = new Label()
            {
                Text = "Страница: Кредиты",
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
            // CreditsPage
            // 
            Name = "CreditsPage";
            Size = new Size(955, 595);
            ResumeLayout(false);

        }
    }
}
