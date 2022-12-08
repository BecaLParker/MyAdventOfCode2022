using System.Text;
using System.Linq;

namespace DAy6;

public class SignalProcessor
{
    public int? FindMarker(string signal)
    {
        int? positionOfMarkerEnd = null;
        for (int i = 3; i <= signal.Length - 1; i++)
        {
            StringBuilder holdingPen = new System.Text.StringBuilder();
            holdingPen.Append(signal.Substring(i - 3, 4));
            if (holdingPen.ToString().Distinct().Count() == 4)
            {
                positionOfMarkerEnd = i + 1;
                break;
            }
        }
        return positionOfMarkerEnd;
    }
}