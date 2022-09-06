using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Servidor {
    internal class Program {
        static void Main(string[] args) {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // Socket é o que usa para fazer as comunicações

            IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234); //É o IP e porta de onde fará a comunicação
            socket.Bind(iPEndPoint); //associa o socket ao endpoint

            socket.Listen(5); //escuta 5x

            Console.WriteLine("Escutando...");

            Socket socketConnected = socket.Accept(); //quando receber alguma conexão de um cliente, vai associar essa conexão à esse socket "socketConnected"

            //como as mensagens são transmitidas por bytes, precisa pegar os bytes dessa conexão

            byte[] bytes = new byte[255];

            int length = socketConnected.Receive(bytes, 0, bytes.Length, SocketFlags.None);
            //o método Receive recebe os dados do socket que efetuou a comunicação
            //o array de bytes passado no Receive é onde ele vai gravar as informações. Então o que o "cliente" enviou para o servidor ficará salvo nesse array
            Array.Resize(ref bytes, length); //vai redimensionar o tamanho da variável "bytes" para ter o mesmo tamanho da mensagem recebida pelo "cliente"

            Console.Write("O cliente disse: ");
            Console.WriteLine(Encoding.Default.GetString(bytes));

            socketConnected.Close();

            Console.WriteLine("Pressione alguma tecla para finalizar");
            Console.ReadKey();
        }
    }
}
