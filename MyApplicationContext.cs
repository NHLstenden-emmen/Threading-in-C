using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Threading_in_C.OpenFiveApi;

namespace Threading_in_C
{
    class MyApplicationContext : ApplicationContext
    {
        public static int screenOfPlayerboard;
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
                new PlayerBoard()
            };
            var SelectScreenForm = new ChoosePlayerBoardScreen(forms).ShowDialog();

            foreach (var form in forms)
            {
                form.Show();
                form.FormClosed += onFormClosed;
            }
        }
    }
}