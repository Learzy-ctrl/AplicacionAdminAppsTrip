using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionAdminAppsTrip.Controller
{
    public class FormController
    {
        List<Form> forms = new List<Form>();
        public void SetFormList(List<Form> formlist)
        {
            forms = formlist;
        }

        public List<Form> GetFormList()
        {
            return forms;
        }
    }
}
