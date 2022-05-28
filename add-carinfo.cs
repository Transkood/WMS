using System;
using System.TCP;


namespace WMS_i_guess {
    
    class WMS { 
        static void Main(string[] args) {
            
            Console.ReadLine() = carindex;
            carindex = message;
            
            static void Connect(String server, String message)
            {
                try
                {
    
                    Int32 port = 13000;
                    TcpClient client = new TcpClient(server, port);

                    // Translate the passed message into ASCII and store it as a Byte array.
                    Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);

                    // Get a client stream for reading and writing.
                    //  Stream stream = client.GetStream();

                    NetworkStream stream = client.GetStream();

                    // Send the message to the connected TcpServer.
                    stream.Write(data, 0, data.Length);

                    Console.WriteLine("Sent: {0}", message);

                    // Receive the TcpServer.response.

                    // Buffer to store the response bytes.
                    data = new Byte[256];

                    // String to store the response ASCII representation.
                    String responseData = String.Empty;

                    // Close everything.
                    stream.Close();
                    
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine("ArgumentNullException: {0}", e);
                }
                catch (SocketException e)
                {
                    Console.WriteLine("SocketException: {0}", e);
                }

                Console.WriteLine("\n Press Enter to continue...");
                Console.Read();
            }
        }
    }
}
            
