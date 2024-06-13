using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using SymbolFactoryDotNet;

namespace Giaodiendieukhien.Sources
{
    public class Status_Display
    {
        public void stt_Lamp(StandardControl st, string value)
        {
            if (value == "True")
            {
                st.DiscreteValue1 = true;
            }
            else
            {
                st.DiscreteValue1 = false;
            }
        }
    }
}
