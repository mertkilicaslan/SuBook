// Mert Kilicaslan
// HW1 Creating Accounts - Client
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
	public partial class Form1 : Form {

		bool terminating = false, isConnected = false;
		Socket clientSocket;

		public Form1() {
			Control.CheckForIllegalCrossThreadCalls = false;
			InitializeComponent();
			this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
		}

		private void button_connect_Click(object sender, EventArgs e) {
			clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			string ip = textBox_ip.Text;
			int portNum;
			terminating = false;

			// Can the port number be assigned to an integer?
			if (Int32.TryParse(textBox_port.Text, out portNum)) {

				// Connected to server
				try {
					clientSocket.Connect(ip, portNum);

					// Updating buttons and text boxes
					button_createAccount.Enabled = true;
					button_disconnect.Enabled = true;
					button_connect.Enabled = false;

					textBox_name.Enabled = true;
					textBox_surname.Enabled = true;
					textBox_username.Enabled = true;
					textBox_password.Enabled = true;


					isConnected = true;
					clientLogs.AppendText("You are connected!\n");

					// Client should be able to do actions concurrently (connect, send, recieve)
					Thread receiveThread = new Thread(Receive);
					receiveThread.Start();

				}
				// Server is not listening on the port
				catch {
					clientLogs.AppendText("Could not connected to the server!\n");
				}
			}
			// Port number cannot be assigned as an integer
			else
				clientLogs.AppendText("Check your port number!\n");
		}

		private void Receive() {
			while (isConnected) {
				try {
					// In 'Stream' socket type, message traverses between client and server as a byte array
					Byte[] buffer = new Byte[1024];
					clientSocket.Receive(buffer);

					// Response from the server whether the account was created successfully or not
					string serverResponse = Encoding.Default.GetString(buffer); // Convert bytes into a string
					serverResponse = serverResponse.Substring(0, serverResponse.IndexOf("\0")); // String handling for 'msg\0\0\0...'
					clientLogs.AppendText(serverResponse);
				}

				// If the server shuts itself down while client is connected
				catch {
					if (!terminating) {
						clientLogs.AppendText("Server has disconnected!\n");

						// Updating buttons and text boxes
						button_createAccount.Enabled = false;
						button_disconnect.Enabled = false;
						button_connect.Enabled = true;

						textBox_name.Enabled = false;
						textBox_surname.Enabled = false;
						textBox_username.Enabled = false;
						textBox_password.Enabled = false;
					}

					// Releasing the resources
					clientSocket.Close();
					isConnected = false;
				}
			}
		}

		private void button_createAccount_Click(object sender, EventArgs e) {
			string name = textBox_name.Text, surname = textBox_surname.Text;
			string username = textBox_username.Text, password = textBox_password.Text;

			// If one of the credential is empty
			if (name == "")
				clientLogs.AppendText("Please enter a name!\n");
			else if(surname == "")
				clientLogs.AppendText("Please enter a surname!\n");
			else if(username == "")
				clientLogs.AppendText("Please enter a username!\n");
			else if(password == "")
				clientLogs.AppendText("Please enter a password!\n");

			else {
				string credential = username + "-" + password + "-" + name + "-" + surname; // Concatenate the user credentials

				Byte [] buffer = Encoding.Default.GetBytes(credential); // Convert the string into bytes
				clientSocket.Send(buffer);

				// Clear the text boxes
				textBox_name.Clear();
				textBox_surname.Clear();
				textBox_username.Clear();
				textBox_password.Clear();
			}
		}

		private void button_disconnect_Click(object sender, EventArgs e) {
			// Updating buttons and text boxes
			button_createAccount.Enabled = false;
			button_disconnect.Enabled = false;
			button_connect.Enabled = true;

			textBox_name.Enabled = false;
			textBox_surname.Enabled = false;
			textBox_username.Enabled = false;
			textBox_password.Enabled = false;

			// Clear the text boxes
			textBox_name.Clear();
			textBox_surname.Clear();
			textBox_username.Clear();
			textBox_password.Clear();


			// Releasing the resources
			clientSocket.Close();
			isConnected = false;
			terminating = true;

			clientLogs.AppendText("Successfully disconnected!\n");
		}

		// Form closing from the right upper corner
		private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e) {
			isConnected = false;
			terminating = true;
			Environment.Exit(0);
		}
	}
}
