using System.Net.NetworkInformation;

namespace NetworkFunctions
{
    public class NetworkGateway
    {
        public static string Gateway()
        {
            string ipAddress = null;

            foreach (NetworkInterface netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (netInterface.OperationalStatus == OperationalStatus.Up)
                    foreach (GatewayIPAddressInformation d in netInterface.GetIPProperties().GatewayAddresses) ipAddress = d.Address.ToString();
            }

            return ipAddress;
        }
    }
}
