using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealBank.UI.Sections.HomeSection
{
    public class FavouritesPage : UserControl
    {
        public FavouritesPage()
        {
            Label lbl = new Label()
            {
                Text = "Страница: Избранное",
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
            // FavouritesPage
            // 
            Name = "FavouritesPage";
            Size = new Size(955, 595);
            ResumeLayout(false);

        }
    }
}
