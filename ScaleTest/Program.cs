using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ScaleTest
{
    public class Program
    {
        private static bool _shouldStop;

        public static void Main(string[] args)
        {
            Thread scaleThread = new Thread(CallTcpClient);
            scaleThread.Start();
        }

        public static void CallTcpClient()
        {
            while (!_shouldStop)
            {
                try
                {
                    
                    // Create a TcpClient. 
                    // Note, for this client to work you need to have a TcpServer  
                    // connected to the same address as specified by the server, port 
                    // combination.                     
                    Int32 port = 4001;
                    Ping ping = new Ping();
                    string scaleIp = "192.168.0.150";

                    if (scaleIp != string.Empty && scaleIp != null)
                    {
                        PingReply pingResult = ping.Send(scaleIp);

                        if (pingResult.Status == IPStatus.Success)
                        {
                            TcpClient client = new TcpClient(scaleIp, port);

                            if (client.Connected)
                            {
                                // Translate the passed message into ASCII and store it as a Byte array.
                                //var data = System.Text.Encoding.ASCII.GetBytes("S");
                                // Get a client stream for reading and writing. 
                                // Stream stream = client.GetStream(); 
                                NetworkStream stream = client.GetStream();

                                // Send the message to the connected TcpServer. 
                                //stream.Write(data, 0, data.Length);

                                //MessageBox.Show("Sent: " + message);

                                // Receive the TcpServer.response. 
                                // Buffer to store the response bytes.

                                var data = new byte[128];

                                // String to store the response ASCII representation. 
                                string responseData = string.Empty;

                                // Read the first batch of the TcpServer response bytes. 
                                Int32 bytes = stream.Read(data, 0, data.Length);
                                responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                                //InsertScaleInfo(responseData, bascula);
                                Console.WriteLine(responseData.Trim());
                                //MessageBox.Show("Recieved: " + responseData);
                                //SetMemoText(responseData + "IP BASCULA: " + scaleIp + "   PUERTO: " + port + "   HORA: " + DateTime.Now);

                                // Close everything.
                                stream.Close();
                                client.Close();

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
