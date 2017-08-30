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
            lineArray.Add(msgArray[0]); //name
            lineArray.Add(msgArray[1]); //date
            lineArray.Add(msgArray[2]); //time
            lineArray.Add(msgArray[3]); //rawTmp
            lineArray.Add(msgArray[4]); //rawPrs
            lineArray.Add(msgArray[5]); //calcPrs
            lineArray.Add(msgArray[6]); //elevation
            lineArray.Add(msgArray[7]); //oldTmp
            if (msgArray.Length > 8)
            {
                lineArray.Add(msgArray[8]); //newTmp
                lineArray.Add(msgArray[9]); //newHum
            }
            else
            {
                lineArray.Add("0.0");
                lineArray.Add("0.0");
            }
            return lineArray;
        }
    }
}
