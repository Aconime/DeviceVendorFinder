using System.Net.NetworkInformation;

namespace NetworkFunctions
{
    public class CheckNetworkConnection
    {
        public static bool HasNetworkConnection()
        {
            string host = "www.google.com";
            bool result = false;
            Ping p = new Ping();
            try
            {
                PingReply reply = p.Send(host, 4000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch { }
            return result;
        }
    }
}
