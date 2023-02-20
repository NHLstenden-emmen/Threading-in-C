using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threading_in_C
{
    class MyApplicationContext : ApplicationContext
    {
        private void onFormClosed(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                ExitThread();
            }
        }

        public MyApplicationContext()
        {
            var forms = new List<Form>() {
                new DungeonMasterUI(),
                new PlayerBoard(),
                new ChoosePlayerBoardScreen()
            };

            foreach (var form in forms)
            {
                form.Show();
                form.FormClosed += onFormClosed;
            }
        }
    }
}
