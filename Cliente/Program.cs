using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cliente {
    internal class Program {
        static void Main(string[] args) {

            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); //Socket é o que vai fazer a comunicação com o servidor


            try {
                IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234); //IP e porta de onde tentará fazer a comunicação

                socket.Connect(iPEndPoint);

                Console.WriteLine("Conectado com sucesso! Insira a mensagem que quer enviar para o servidor: ");
                string message = Console.ReadLine();

                byte[] messageInBytes = Encoding.Default.GetBytes(message);

                socket.Send(messageInBytes, 0, messageInBytes.Length, SocketFlags.None);

                Console.WriteLine("Digite algo para fechar o console");
                Console.ReadKey();

            } catch(Exception ex) {
                Console.WriteLine("Não foi possível comunicar com o servidor! Mensagem de erro: " + ex.Message);
            } finally {
                socket.Close();
            }
        }
    }
}
