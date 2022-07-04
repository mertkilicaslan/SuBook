// Mert Kilicaslan
// HW1 Creating Accounts - Server
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
	public partial class Form1 : Form {

		Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		List<Socket> clientSockets = new List<Socket>(); // In order to handle multiple clients

		bool terminating = false, listening = false;

		public Form1() {
			Control.CheckForIllegalCrossThreadCalls = false;
			this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
			InitializeComponent();
		}

		private void button_listen_Click(object sender, EventArgs e) {
			int serverPort;

			// Can the port number be assigned to an integer?
			if (Int32.TryParse(textBox_port.Text, out serverPort)) {

				// Started to listen
				IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, serverPort);
				serverSocket.Bind(endPoint);
				serverSocket.Listen(3); // Number of elements in the queue

				listening = true;
				button_listen.Enabled = false;

				// Server must perform different opperations at the same time (listen, connect...)
				Thread acceptThread = new Thread(Accept);
				acceptThread.Start();

				serverLogs.AppendText("Started listening on port: " + serverPort + ".\n");
			}

			// Port number cannot be assigned as an integer
			else
				serverLogs.AppendText("Check your port number!\n");
		}

		private void Accept() {
			while (listening) {
				try {
					// Client connected to the server
					Socket newClient = serverSocket.Accept();
					clientSockets.Add(newClient);
					serverLogs.AppendText("A client has connected!\n");

					// Client must perform different opperations at the same time (send, receive...)
					Thread receiveThread = new Thread(() => Receive(newClient)); 
					receiveThread.Start();
				}

				catch {
					// Server was intentionally shuted down
					if (terminating)
						listening = false;

					//Sserver was unintentionally shuted down
					else
						serverLogs.AppendText("The socket stopped working.\n");
				}
			}
		}

		private void Receive(Socket thisClient) {
			bool connected = true;

			while (connected && !terminating) {
				try {
					Byte[] buffer = new byte[1024];
					thisClient.Receive(buffer);

					// Getting credentials from client
					string credential = Encoding.Default.GetString(buffer);
					credential = credential.Substring(0, credential.IndexOf("\0"));

					string username = credential.Substring(0, credential.IndexOf("-")); // Extracting username
					bool doesExistUsername = false;

					// Searching for username in database.txt (it must be unique)
					foreach (string line in File.ReadLines(@"../../database.txt", Encoding.UTF8)) 
						if (username == line.Substring(0, line.IndexOf("-")))
							doesExistUsername = true;

					// Username is already in database.txt
					if (doesExistUsername) {
						buffer = Encoding.Default.GetBytes("There is already an account with this username!\n");
						thisClient.Send(buffer);
						serverLogs.AppendText(username + " cannot create an account since this username is used!\n");
					}

					// Username is not found in database.txt
					else {
						using (StreamWriter file = new StreamWriter("../../database.txt", append: true)) {
							file.WriteLine(credential);
						}
						buffer = Encoding.Default.GetBytes("You have created an account!\n");
						thisClient.Send(buffer);
						serverLogs.AppendText(username + " has created an account!\n");
					}
				}

				catch {
					// Session ended by a client
					if (!terminating)
						serverLogs.AppendText("A client has disconnected!\n");

					thisClient.Close();
					clientSockets.Remove(thisClient);
					connected = false;
				}
			}
		}

		// Form closing from the right upper corner
		private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e) {
			listening = false;
			terminating = true;
			Environment.Exit(0);
		}
	}
}
