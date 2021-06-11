using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace NetworkFunctions
{
    class PingNetwork
    {
        public static async Task<List<PingReply>> PingHost(List<string> hosts, int timeout)
        {
            IEnumerable<Task<PingReply>> tasks = hosts.Select(ip => new Ping().SendPingAsync(ip, timeout));
            PingReply[] results = await Task.WhenAll(tasks);

            return results.ToList();
        }
    }
}
