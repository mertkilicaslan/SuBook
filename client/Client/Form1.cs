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

namespace Client
{
    public partial class Form1 : Form
    {

        bool terminating = false;
        bool connected = false;
        Socket clientSocket;

        private void send_message(string messageString)
        {
            Byte[] buffer = new Byte[10000000];
            buffer = Encoding.Default.GetBytes(messageString);
            clientSocket.Send(buffer);
        }

        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            InitializeComponent();
           
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            string ipVar = ip_textbox.Text;
            string usernameString = username_textbox.Text;

            int portVar;
            if ((Int32.TryParse(port_textbox.Text, out portVar)) && (ipVar != "") && (usernameString!=""))
            {
                try
                {    
                    clientSocket.Connect(ipVar, portVar);

                    //After connecting, send username to server for validation
                    Byte[] usernameBuffer = new byte[1024];
                    usernameBuffer = Encoding.Default.GetBytes(usernameString);
                    clientSocket.Send(usernameBuffer);


                    Byte[] usernameResponseBuffer = new byte[64];
                    clientSocket.Receive(usernameResponseBuffer);
                    string usernameResponseString = Encoding.Default.GetString(usernameResponseBuffer);
                    usernameResponseString = usernameResponseString.Substring(0, usernameResponseString.IndexOf("\0"));



                    if (usernameResponseString != "yes")
                    {
                        logs.AppendText("Please enter a valid username.\n");
                    }
                    else
                    {

                        connect_button.Enabled = false;
                        logs.Enabled = true;
                        disconnect_button.Enabled = true;
                        post_textbox.Enabled = true;
                        all_posts_button.Enabled = true;
                        post_Send_Button.Enabled = true;

                        my_post_button.Enabled = true;
                        post_id_textbox.Enabled = true;
                        delete_post_button.Enabled = true;

                        add_friend_button.Enabled = true;
                        add_username_textbox.Enabled = true;
                        remove_friend_button.Enabled = true;
                        button_friend_post.Enabled = true;

                        connect_button.BackColor = Color.LawnGreen;
                        disconnect_button.BackColor = Color.IndianRed;

                        connected = true;
                        logs.AppendText("Hello " + username_textbox.Text + "! You are connected to the server.\n");
                        Thread receiveThread = new Thread(Receive);
                        receiveThread.Start();

                        friend_list_listbox.Items.Clear();
                        string sendCodeString = "GET_FRIEND";
                        Byte[] sendCodeBuffer = new byte[1024];
                        sendCodeBuffer = Encoding.Default.GetBytes(sendCodeString);
                        clientSocket.Send(sendCodeBuffer);
                        
                        
                    }


                }
                catch
                {
                    logs.AppendText("Could not connect to the server!\n");

                }
            }
            else
            {
                logs.AppendText("Check the port number!\n");
            }
            
        }

        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            connected = false;
            terminating = true;
            Environment.Exit(0);
        }


        private void Receive()
        {
            while (connected)
            {
                try
                {
                    Byte[] buffer = new Byte[10000000];
                    clientSocket.Receive(buffer);
                    string incomingMessage = Encoding.Default.GetString(buffer);
                    incomingMessage = incomingMessage.Substring(0, incomingMessage.IndexOf("\0"));
                    
                    // GET_FRIEND response
                    if (incomingMessage != "" && incomingMessage[0] == '&')
                    {                 
                        string[] friendsTokens = incomingMessage.Split('&');                       
                        foreach (string item in friendsTokens)
                        {
                            if (item != "")
                            {
                                friend_list_listbox.Items.Add(item);
                            }

                        }
                    }
                    // GET_FRIEND request from server
                    else if (incomingMessage == "GET_FRIEND_REFRESH") {
                        friend_list_listbox.Items.Clear();
                        send_message("GET_FRIEND");

                    }
                    // Output Messages
                    else
                    {
                        logs.AppendText(incomingMessage);
                    }
                }

                catch
                {
                    if (!terminating)
                    {
                        logs.AppendText("The server has disconnected!\n");

                        connect_button.Enabled = true;
                        logs.Enabled = false;
                        disconnect_button.Enabled = false;
                        post_Send_Button.Enabled = false;
                        post_textbox.Enabled = false;
                        all_posts_button.Enabled = false;

                        my_post_button.Enabled = false;
                        post_id_textbox.Enabled = false;
                        delete_post_button.Enabled = false;

                        add_friend_button.Enabled = false;
                        add_username_textbox.Enabled = false;
                        remove_friend_button.Enabled = false;
                        button_friend_post.Enabled = false;

                        connect_button.BackColor = SystemColors.Control;
                        disconnect_button.BackColor = SystemColors.Control;
                    }

                    clientSocket.Close();
                    connected = false;
                }

            }
        }

        private void disconnect_button_Click(object sender, EventArgs e)
        {
            terminating = true;
            clientSocket.Close();
            connected = false;
            logs.AppendText("Successfully disconnected.\n");

            disconnect_button.Enabled = false;
            connect_button.Enabled = true;
            logs.Enabled = false;     
            post_Send_Button.Enabled = false;
            post_textbox.Enabled = false;
            all_posts_button.Enabled = false;

            my_post_button.Enabled = false;
            post_id_textbox.Enabled = false;
            delete_post_button.Enabled = false;

            add_friend_button.Enabled = false;
            add_username_textbox.Enabled = false;
            remove_friend_button.Enabled = false;
            button_friend_post.Enabled = false;

            connect_button.BackColor = SystemColors.Control;
            disconnect_button.BackColor = SystemColors.Control;


        }

        private void post_Send_Button_Click(object sender, EventArgs e)
        {
            string sendCodeString = "SEND";
            Byte[] sendCodeBuffer = new byte[1024];
            sendCodeBuffer = Encoding.Default.GetBytes(sendCodeString);
            clientSocket.Send(sendCodeBuffer);

            string postMessage = post_textbox.Text;
            string usernameMessage = username_textbox.Text;

            List<byte> messageList = new List<byte>();
            messageList.AddRange(Encoding.Default.GetBytes(usernameMessage));
            messageList.AddRange(Encoding.Default.GetBytes("$"));
            messageList.AddRange(Encoding.Default.GetBytes(postMessage));

            Byte[] buffer = messageList.ToArray();
            clientSocket.Send(buffer);

            logs.AppendText("You have successfully sent a post!\n");
            logs.AppendText(usernameMessage + ": " + postMessage + "\n");

            post_textbox.Clear();
        }

        private void all_posts_button_Click(object sender, EventArgs e)
        {
            string sendCodeString = "ALL_POST";
            Byte[] sendCodeBuffer = new byte[1024];
            sendCodeBuffer = Encoding.Default.GetBytes(sendCodeString);
            clientSocket.Send(sendCodeBuffer);

            
            string sendUsernameString = username_textbox.Text;
            Byte[] sendUsernameBuffer = new byte[1024];
            sendUsernameBuffer = Encoding.Default.GetBytes(sendUsernameString);
            clientSocket.Send(sendUsernameBuffer);

        }

		private void my_post_button_Click(object sender, EventArgs e) {
            string sendCodeString = "MY_POST";
            Byte[] sendCodeBuffer = new byte[1024];
            sendCodeBuffer = Encoding.Default.GetBytes(sendCodeString);
            clientSocket.Send(sendCodeBuffer);


            string sendUsernameString = username_textbox.Text;
            Byte[] sendUsernameBuffer = new byte[1024];
            sendUsernameBuffer = Encoding.Default.GetBytes(sendUsernameString);
            clientSocket.Send(sendUsernameBuffer);
        }

		private void delete_post_button_Click(object sender, EventArgs e) {
            string sendCodeString = "DELETE_POST";
            Byte[] sendCodeBuffer = new byte[1024];
            sendCodeBuffer = Encoding.Default.GetBytes(sendCodeString);
            clientSocket.Send(sendCodeBuffer);

            string sendUsernameAndPostID = username_textbox.Text + "|" + post_id_textbox.Text;
            Byte[] sendUsernameAndPostIDBuffer = new byte[1024];
            sendUsernameAndPostIDBuffer = Encoding.Default.GetBytes(sendUsernameAndPostID);
            clientSocket.Send(sendUsernameAndPostIDBuffer);

            post_id_textbox.Clear();
        }

        private void add_friend_button_Click(object sender, EventArgs e)
        {
            string sendCodeString = "ADD_FRIEND";
            Byte[] sendCodeBuffer = new byte[1024];
            sendCodeBuffer = Encoding.Default.GetBytes(sendCodeString);
            clientSocket.Send(sendCodeBuffer);

            string sendUsernameAndFriend = username_textbox.Text + "|" + add_username_textbox.Text;
            Byte[] sendUsernameAndFriendBuffer = new byte[1024];
            sendUsernameAndFriendBuffer = Encoding.Default.GetBytes(sendUsernameAndFriend);
            clientSocket.Send(sendUsernameAndFriendBuffer);

            friend_list_listbox.Items.Clear();
            send_message("GET_FRIEND");

            add_username_textbox.Clear();
        }

        private void remove_friend_button_Click(object sender, EventArgs e)
        {
            send_message("REMOVE_FRIEND");

            string selectedFriend = friend_list_listbox.SelectedItem.ToString().Trim();
            send_message(selectedFriend);
            friend_list_listbox.Items.Clear();
            send_message("GET_FRIEND");

        }

        private void button_friend_post_Click(object sender, EventArgs e)
        {
            string sendCodeString = "FRIEND_POSTS";
            Byte[] sendCodeBuffer = new byte[1024];
            sendCodeBuffer = Encoding.Default.GetBytes(sendCodeString);
            clientSocket.Send(sendCodeBuffer);
        }
    }

}
