using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Zephyr
{
    class calculate
    {
        public ArrayList makeArray(string msg)
        {
            ArrayList lineArray = new ArrayList();
            var msgArray = msg.Split('\t');
            lineArray.Add(msgArray[0]);
            lineArray.Add(msgArray[1]);
            lineArray.Add(msgArray[2]);
            lineArray.Add(msgArray[3]);
            lineArray.Add(msgArray[4]);
            lineArray.Add(msgArray[5]);
            lineArray.Add(msgArray[6]);
            lineArray.Add(msgArray[7]);

            return lineArray;
        }
    }
}
