using System.Text;

namespace DAy6;

public class SignalProcessor
{
    public int? FindMarker(string signal)
    {
        int? positionOfMarkerEnd = null;
        for (int i = 3; i <= signal.Length - 1; i++)
        {
            StringBuilder holdingPen = new StringBuilder();
            holdingPen.Append(signal.Substring(i - 3, 4));
            if (holdingPen.ToString().Distinct().Count() == 4)
            {
                positionOfMarkerEnd = i + 1;
                break;
            }
        }
        return positionOfMarkerEnd;
    }

    public int? FindMessage(string signal)
    {
        int? positionOfMessageEnd = null;
        for (int i = 13; i <= signal.Length - 1; i++)
        {
            StringBuilder holdingPen = new StringBuilder();
            holdingPen.Append(signal.Substring(i - 13, 14));
            if (holdingPen.ToString().Distinct().Count() == 14)
            {
                positionOfMessageEnd = i + 1;
                break;
            }
        }
        return positionOfMessageEnd;
    }
}