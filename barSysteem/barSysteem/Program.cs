using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barSysteem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// // Haha extra comment
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());

            Category beverages = new Category("Drankjes", 0);
            // beverages.id = 1; (doe dit als je een id bij wilt van de drankjes (beverages))
            // dat kan je ook doen voor .name of .products (voor producten dus)
        }
    }
}
