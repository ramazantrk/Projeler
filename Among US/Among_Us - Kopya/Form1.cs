using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Among_Us
{
    public partial class Form1 : Form
    {
        bool player1_left = true;
        bool player1_right = false;
        bool player1_Move_left = true;
        bool player1_Move_right = false;
        bool player1_Move_up = false;
        bool player1_Move_down = false;
        bool player1_stop = true;
        bool player1_first_movement = false;
        bool player1_this = false;
        bool player1_onile = false;
        bool player1_ready = false;
        bool player1_alive = false;



        bool player2_left = true;
        bool player2_right = false;
        bool player2_Move_left = true;
        bool player2_Move_right = false;
        bool player2_Move_up = false;
        bool player2_Move_down = false;
        bool player2_stop = true;
        bool player2_first_movement = false;
        bool player2_this = false;
        bool player2_onile = false;
        bool player2_ready = false;
        bool player2_alive = false;


        Socket amonguSsocket;
        TcpListener amonguSserver = null;
        TcpClient amongusclent;

        Socket amongus_for_player2;
        bool amongus_socket_for_player2_boelan = false;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        public void this_player_Form1_KeyDown(bool KeysLeft,bool KeysRight,bool KeysUp,bool KeysDown,
                                               ref bool player_stop,ref bool player_Move_left,ref bool player_Move_right,
                                               ref bool player_Move_up,ref bool player_Move_down,
                                               Timer player_timer1,ref bool player_left,ref bool player_right)
        {
            if ( KeysLeft || KeysRight ||  KeysUp || KeysDown)
            {
                player_stop = false;
                player_timer1.Enabled = true;
            }
            if ( KeysRight)
            {
                player_right = true;
                player_left = false;

                player_Move_right = true;
                player_Move_left = false;
            }
            if ( KeysLeft)
            {
                player_left = true;
                player_right = false;

                player_Move_left = true;
                player_Move_right = false;
            }
            if ( KeysUp)
            {
                player_Move_up = true;
                player_Move_down = false;
            }
            if  (KeysDown)
            {
                player_Move_down = true;
                player_Move_up = false;
            }

        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (player1_this)
            {
                this_player_Form1_KeyDown(e.KeyCode == Keys.Left, e.KeyCode == Keys.Right, e.KeyCode == Keys.Up, e.KeyCode == Keys.Down,
                                               ref player1_stop, ref player1_Move_left, ref player1_Move_right,
                                               ref player1_Move_up, ref player1_Move_down,
                                               this_player_timer1, ref player1_left, ref player1_right);
            }
            else if (player2_this)
            {
                this_player_Form1_KeyDown(e.KeyCode == Keys.Left, e.KeyCode == Keys.Right, e.KeyCode == Keys.Up, e.KeyCode == Keys.Down,
                                               ref player2_stop, ref player2_Move_left, ref player2_Move_right,
                                               ref player2_Move_up, ref player2_Move_down,
                                               this_player_timer1, ref player2_left, ref player2_right);
            }
        }

        public void this_player_Form1_KeyUp(bool KeysLeft, bool KeysRight, bool KeysUp, bool KeysDown,
                                               ref bool player_stop, ref bool player_Move_left, ref bool player_Move_right,
                                               ref bool player_Move_up, ref bool player_Move_down)
        {
            if (KeysLeft || KeysRight || KeysUp || KeysDown)
            {
                player_stop = true;
            }
            if (KeysRight)
            {
                player_Move_right = false;
            }
            if (KeysLeft)
            {
                player_Move_left = false;
            }
            if (KeysUp)
            {
                player_Move_up = false;
            }
            if (KeysDown)
            {
                player_Move_down = false;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (player1_this)
            {
                this_player_Form1_KeyUp(e.KeyCode == Keys.Left, e.KeyCode == Keys.Right, e.KeyCode == Keys.Up, e.KeyCode == Keys.Down,
                                               ref player1_stop, ref player1_Move_left, ref player1_Move_right,
                                               ref player1_Move_up, ref player1_Move_down);
            }
            else if (player2_this)
            {
                this_player_Form1_KeyUp(e.KeyCode == Keys.Left, e.KeyCode == Keys.Right, e.KeyCode == Keys.Up, e.KeyCode == Keys.Down,
                                               ref player2_stop, ref player2_Move_left, ref player2_Move_right,
                                               ref player2_Move_up, ref player2_Move_down);
            }
        }
        public void this_player_timer1_tick_event(bool player_stop,ref bool player_first_movement,
                                                  bool player_Move_right, bool player_Move_left,
                                                  bool player_Move_up, bool player_Move_down,
                                                  bool player_right, PictureBox player_pictureBox,
                                                  Image _1,Image _2,Image stop,
                                                  PictureBox other_player1_pictureBox1)
        {
            Image img = null;
            if (!player_stop)
            {
                if (player_first_movement)
                {
                    img =_1;

                    player_first_movement = false;
                }

                else
                {
                    img =_2;

                    player_first_movement = true;
                }
                if (player_Move_right && !right_limits())
                {
                    Map_pictureBox1.Left = Map_pictureBox1.Left - 10;
                    other_player1_pictureBox1.Left = other_player1_pictureBox1.Left - 10;
                }
                else if (player_Move_left && !left_limits())
                {
                    Map_pictureBox1.Left = Map_pictureBox1.Left + 10;
                    other_player1_pictureBox1.Left = other_player1_pictureBox1.Left + 10;
                }
                else if (player_Move_up && !up_limits())
                {
                    Map_pictureBox1.Top = Map_pictureBox1.Top + 10;
                    other_player1_pictureBox1.Top = other_player1_pictureBox1.Top + 10;
                }
                else if (player_Move_down && !down_limits())
                {
                    Map_pictureBox1.Top = Map_pictureBox1.Top - 10;
                    other_player1_pictureBox1.Top = other_player1_pictureBox1.Top - 10;
                }
            }
            else
            {
                player_first_movement = true;
                this_player_timer1.Enabled = false;

                img =stop;
            }
            if (player_right)
            {
                img.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
            player1_pictureBox1.BackgroundImage = img;

        }
        private void this_player_timer1_Tick(object sender, EventArgs e)
        {
            if (player1_this)
            {
                this_player_timer1_tick_event(player1_stop, ref player1_first_movement,
                                                   player1_Move_right, player1_Move_left,
                                                   player1_Move_up, player1_Move_down,
                                                   player1_right, player1_pictureBox1,
                                                   Properties.Resources.red_1, Properties.Resources.red_2, Properties.Resources.red_stop,
                                                   player2_pictureBox1);
            }
            else if (player2_this)
            {
                this_player_timer1_tick_event(player2_stop, ref player2_first_movement,
                                                   player2_Move_right, player2_Move_left,
                                                   player2_Move_up, player2_Move_down,
                                                   player2_right, player2_pictureBox1,
                                                   Properties.Resources.blue_1, Properties.Resources.blue_2, Properties.Resources.blue_stop,
                                                   player1_pictureBox1);
            }
        }
        public bool right_limits()
        {
            bool limit = false;

            if ((Map_pictureBox1.Left == -10 && Map_pictureBox1.Top <= -120 && Map_pictureBox1.Top >= -290) ||
                (Map_pictureBox1.Left == -10 && Map_pictureBox1.Top <= -320 && Map_pictureBox1.Top >= -1090) ||
                (Map_pictureBox1.Left == -110 && Map_pictureBox1.Top <= 100 && Map_pictureBox1.Top >= 10) ||
                (Map_pictureBox1.Left == -110 && Map_pictureBox1.Top <= -20 && Map_pictureBox1.Top >= -110) ||
                (Map_pictureBox1.Left == -110 && Map_pictureBox1.Top <= -1100 && Map_pictureBox1.Top >= -1190) ||
                (Map_pictureBox1.Left == -110 && Map_pictureBox1.Top <= -1220 && Map_pictureBox1.Top >= -1310) ||
                (Map_pictureBox1.Left == -310 && Map_pictureBox1.Top <= -200 && Map_pictureBox1.Top >= -810) ||
                (Map_pictureBox1.Left == -410 && Map_pictureBox1.Top <= -1020 && Map_pictureBox1.Top >= -1090) ||
                (Map_pictureBox1.Left == -410 && Map_pictureBox1.Top <= -1120 && Map_pictureBox1.Top >= -1210) ||
                (Map_pictureBox1.Left == -510 && Map_pictureBox1.Top <= -20 && Map_pictureBox1.Top >= -190) ||
                (Map_pictureBox1.Left == -710 && Map_pictureBox1.Top <= -200 && Map_pictureBox1.Top >= -510) ||
                (Map_pictureBox1.Left == -710 && Map_pictureBox1.Top <= -700 && Map_pictureBox1.Top >= -1010) ||
                (Map_pictureBox1.Left == -1110 && Map_pictureBox1.Top <= -420 && Map_pictureBox1.Top >= -590) ||
                (Map_pictureBox1.Left == -1110 && Map_pictureBox1.Top <= -620 && Map_pictureBox1.Top >= -790) ||
                (Map_pictureBox1.Left == -1210 && Map_pictureBox1.Top <= -800 && Map_pictureBox1.Top >= -990) ||
                (Map_pictureBox1.Left == -1210 && Map_pictureBox1.Top <= -1020 && Map_pictureBox1.Top >= -1310) ||
                (Map_pictureBox1.Left == -1410 && Map_pictureBox1.Top <= -100 && Map_pictureBox1.Top >= 10) ||
                (Map_pictureBox1.Left == -1410 && Map_pictureBox1.Top <= -20 && Map_pictureBox1.Top >= -410) ||
                (Map_pictureBox1.Left == -1410 && Map_pictureBox1.Top <= -1000 && Map_pictureBox1.Top >= -1190) ||
                (Map_pictureBox1.Left == -1510 && Map_pictureBox1.Top <= -600 && Map_pictureBox1.Top >= -810) ||
                (Map_pictureBox1.Left == -1710 && Map_pictureBox1.Top <= -300 && Map_pictureBox1.Top >= -380) ||
                (Map_pictureBox1.Left == -1710 && Map_pictureBox1.Top <= -420 && Map_pictureBox1.Top >= -710) ||
                (Map_pictureBox1.Left == -1810 && Map_pictureBox1.Top <= -120 && Map_pictureBox1.Top >= -1090) ||
                (Map_pictureBox1.Left == -1910 && Map_pictureBox1.Top <= 100 && Map_pictureBox1.Top >= -1310))
            {
                limit = true;
            }

            return limit;
        }

        public bool left_limits()
        {
            bool limit = false;

            if ((Map_pictureBox1.Left == 100 && Map_pictureBox1.Top <= 100 && Map_pictureBox1.Top >= -1310) ||
                (Map_pictureBox1.Left == 0 && Map_pictureBox1.Top <= -120 && Map_pictureBox1.Top >= -1090) ||
                (Map_pictureBox1.Left == -200 && Map_pictureBox1.Top <= -200 && Map_pictureBox1.Top >= -290) ||
                (Map_pictureBox1.Left == -200 && Map_pictureBox1.Top <= -320 && Map_pictureBox1.Top >= -810) ||
                (Map_pictureBox1.Left == -400 && Map_pictureBox1.Top <= -200 && Map_pictureBox1.Top >= -510) ||
                (Map_pictureBox1.Left == -400 && Map_pictureBox1.Top <= -700 && Map_pictureBox1.Top >= -1190) ||
                (Map_pictureBox1.Left == -500 && Map_pictureBox1.Top <= -20 && Map_pictureBox1.Top >= -190) ||
                (Map_pictureBox1.Left == -800 && Map_pictureBox1.Top <= 100 && Map_pictureBox1.Top >= -410) ||
                (Map_pictureBox1.Left == -800 && Map_pictureBox1.Top <= -800 && Map_pictureBox1.Top >= -1090) ||
                (Map_pictureBox1.Left == -800 && Map_pictureBox1.Top <= -1120 && Map_pictureBox1.Top >= -1310) ||
                (Map_pictureBox1.Left == -1100 && Map_pictureBox1.Top <= -420 && Map_pictureBox1.Top >= -790) ||
                (Map_pictureBox1.Left == -1300 && Map_pictureBox1.Top <= -620 && Map_pictureBox1.Top >= -810) ||
                (Map_pictureBox1.Left == -1400 && Map_pictureBox1.Top <= -1020 && Map_pictureBox1.Top >= -1210) ||
                (Map_pictureBox1.Left == -1600 && Map_pictureBox1.Top <= -300 && Map_pictureBox1.Top >= -710) ||
                (Map_pictureBox1.Left == -1700 && Map_pictureBox1.Top <= 100 && Map_pictureBox1.Top >= 10) ||
                (Map_pictureBox1.Left == -1700 && Map_pictureBox1.Top <= -20 && Map_pictureBox1.Top >= -110) ||
                (Map_pictureBox1.Left == -1700 && Map_pictureBox1.Top <= -1100 && Map_pictureBox1.Top >= -1190) ||
                (Map_pictureBox1.Left == -1700 && Map_pictureBox1.Top <= -1220 && Map_pictureBox1.Top >= -1310) ||
                (Map_pictureBox1.Left == -1800 && Map_pictureBox1.Top <= -120 && Map_pictureBox1.Top >= -380) ||
                (Map_pictureBox1.Left == -1800 && Map_pictureBox1.Top <= -420 && Map_pictureBox1.Top >= -1090))
            {
                limit = true;
            }

            return limit;
        }
        public bool up_limits()
        {
            bool limit = false;

            if ((Map_pictureBox1.Top == 100 && Map_pictureBox1.Left <= 100 && Map_pictureBox1.Left >= -1910) ||
                (Map_pictureBox1.Top == 0 && Map_pictureBox1.Left <= -120 && Map_pictureBox1.Left >= -790) ||
                (Map_pictureBox1.Top == 0 && Map_pictureBox1.Left <= -1420 && Map_pictureBox1.Left >= -1690) ||
                (Map_pictureBox1.Top == -200 && Map_pictureBox1.Left <= -200 && Map_pictureBox1.Left >= -310) ||
                (Map_pictureBox1.Top == -200 && Map_pictureBox1.Left <= -400 && Map_pictureBox1.Left >= -490) ||
                (Map_pictureBox1.Top == -200 && Map_pictureBox1.Left <= -520 && Map_pictureBox1.Left >= -710) ||
                (Map_pictureBox1.Top == -300 && Map_pictureBox1.Left <= -20 && Map_pictureBox1.Left >= -190) ||
                (Map_pictureBox1.Top == -300 && Map_pictureBox1.Left <= -1600 && Map_pictureBox1.Left >= -1710) ||
                (Map_pictureBox1.Top == -390 && Map_pictureBox1.Left <= -1720 && Map_pictureBox1.Left >= -1790) ||
                (Map_pictureBox1.Top == -600 && Map_pictureBox1.Left <= -1120 && Map_pictureBox1.Left >= -1510) ||
                (Map_pictureBox1.Top == -700 && Map_pictureBox1.Left <= -400 && Map_pictureBox1.Left >= -710) ||
                (Map_pictureBox1.Top == -800 && Map_pictureBox1.Left <= -800 && Map_pictureBox1.Left >= -1090) ||
                (Map_pictureBox1.Top == -800 && Map_pictureBox1.Left <= -1120 && Map_pictureBox1.Left >= -1210) ||
                (Map_pictureBox1.Top == -1000 && Map_pictureBox1.Left <= -1120 && Map_pictureBox1.Left >= -1410) ||
                (Map_pictureBox1.Top == -1100 && Map_pictureBox1.Left <= 100 && Map_pictureBox1.Left >= 10) ||
                (Map_pictureBox1.Top == -1100 && Map_pictureBox1.Left <= -20 && Map_pictureBox1.Left >= -110) ||
                (Map_pictureBox1.Top == -1100 && Map_pictureBox1.Left <= -420 && Map_pictureBox1.Left >= -790) ||
                (Map_pictureBox1.Top == -1100 && Map_pictureBox1.Left <= -1700 && Map_pictureBox1.Left >= -1790) ||
                (Map_pictureBox1.Top == -1100 && Map_pictureBox1.Left <= -1810 && Map_pictureBox1.Left >= -1910) ||
                (Map_pictureBox1.Top == -1200 && Map_pictureBox1.Left <= -120 && Map_pictureBox1.Left >= -390) ||
                (Map_pictureBox1.Top == -1200 && Map_pictureBox1.Left <= -1420 && Map_pictureBox1.Left >= -1690))
            {
                limit = true;
            }

            return limit;
        }
        public bool down_limits()
        {
            bool limit = false;

            if ((Map_pictureBox1.Top == -10 && Map_pictureBox1.Left <= -120 && Map_pictureBox1.Left >= -490) ||
                (Map_pictureBox1.Top == -10 && Map_pictureBox1.Left <= -520 && Map_pictureBox1.Left >= -790) ||
                (Map_pictureBox1.Top == -10 && Map_pictureBox1.Left <= -1420 && Map_pictureBox1.Left >= -1690) ||
                (Map_pictureBox1.Top == -110 && Map_pictureBox1.Left <= 100 && Map_pictureBox1.Left >= 10) ||
                (Map_pictureBox1.Top == -110 && Map_pictureBox1.Left <= -20 && Map_pictureBox1.Left >= -110) ||
                (Map_pictureBox1.Top == -110 && Map_pictureBox1.Left <= -1700 && Map_pictureBox1.Left >= -1790) ||
                (Map_pictureBox1.Top == -110 && Map_pictureBox1.Left <= -1820 && Map_pictureBox1.Left >= -1910) ||
                (Map_pictureBox1.Top == -310 && Map_pictureBox1.Left <= -20 && Map_pictureBox1.Left >= -190) ||
                (Map_pictureBox1.Top == -410 && Map_pictureBox1.Left <= -800 && Map_pictureBox1.Left >= -1090) ||
                (Map_pictureBox1.Top == -410 && Map_pictureBox1.Left <= -1120 && Map_pictureBox1.Left >= -1410) ||
                (Map_pictureBox1.Top == -410 && Map_pictureBox1.Left <= -1720 && Map_pictureBox1.Left >= -1790) ||
                (Map_pictureBox1.Top == -510 && Map_pictureBox1.Left <= -400 && Map_pictureBox1.Left >= -710) ||
                (Map_pictureBox1.Top == -610 && Map_pictureBox1.Left <= -1120 && Map_pictureBox1.Left >= -1290) ||
                (Map_pictureBox1.Top == -710 && Map_pictureBox1.Left <= -1600 && Map_pictureBox1.Left >= -1710) ||
                (Map_pictureBox1.Top == -810 && Map_pictureBox1.Left <= -200 && Map_pictureBox1.Left >= -310) ||
                (Map_pictureBox1.Top == -810 && Map_pictureBox1.Left <= -1300 && Map_pictureBox1.Left >= -1510) ||
                (Map_pictureBox1.Top == -1010 && Map_pictureBox1.Left <= -420 && Map_pictureBox1.Left >= -710) ||
                (Map_pictureBox1.Top == -1010 && Map_pictureBox1.Left <= -1220 && Map_pictureBox1.Left >= -1390) ||
                (Map_pictureBox1.Top == -1110 && Map_pictureBox1.Left <= -420 && Map_pictureBox1.Left >= -790) ||
                (Map_pictureBox1.Top == -1210 && Map_pictureBox1.Left <= -120 && Map_pictureBox1.Left >= -390) ||
                (Map_pictureBox1.Top == -1210 && Map_pictureBox1.Left <= -1400 && Map_pictureBox1.Left >= -1690) ||
                (Map_pictureBox1.Top == -1310 && Map_pictureBox1.Left <= 100 && Map_pictureBox1.Left >= -1690))

            {
                limit = true;
            }

            return limit;
        }

        private void connection_label1_Click(object sender, EventArgs e)
        {
            if (connection_label1.Text=="Baglan")
            {
                connection_label1.Text = "Lütfen Digerlerini Bekleyin";
                create_or_join_server();
            }
        }
        public void create_or_join_server()
        {
            try
            {
                //Katıl
                amongusclent = new TcpClient("localhost",5732);
                amonguSsocket = amongusclent.Client;
                ready_label1.Enabled = true;
                BackgroundWorker ınfo_receiver = new BackgroundWorker();
                ınfo_receiver.DoWork += ınfo_receiver_dowork;
                ınfo_receiver.RunWorkerAsync();

            }
            catch
            {
                //olustur
                player1_connection_label1.ForeColor = Color.Yellow;
                amonguSserver = new TcpListener(IPAddress.Any,5732);
                amonguSserver.Start();
                player1_onile = true;
                player1_this = true;
                server_timer1.Enabled = true;
                ready_label1.Enabled = true;
            }
        }
        private void server_timer1_Tick(object sender, EventArgs e)
        {
            if (amonguSserver.Pending())
            {
                if (!player2_onile)
                {
                    amongus_for_player2 = amonguSserver.AcceptSocket();
                    if (amongus_for_player2 != null)
                    {
                        amongus_socket_for_player2_boelan = true;
                        server_timer1_sending_via_socket(amongus_for_player2);
                    }
                }
            }
            if (amongus_socket_for_player2_boelan)
            {
                server_timer1_sending_via_socket(amongus_for_player2);
                
            }
        }
        public void server_timer1_sending_via_socket(Socket amongus_for_player)
        {
            amongus_for_player.Send(Encoding.Default.GetBytes(player_ınfo_2_send("P1",player1_onile,player1_ready,
                                                              Map_pictureBox1.Left.ToString(), Map_pictureBox1.Top.ToString(),
                                                              player1_alive,player1_right,player1_stop) +
                                                              player_ınfo_2_send("P2", player2_onile, player2_ready,
                                                              (player1_pictureBox1.Left + Map_pictureBox1.Left - player2_pictureBox1.Left).ToString(),
                                                              (player1_pictureBox1.Top + Map_pictureBox1.Top - player2_pictureBox1.Top).ToString(),
                                                              player2_alive, player2_right, player2_stop)));


            BackgroundWorker ınfo_receiver = new BackgroundWorker();
            ınfo_receiver.DoWork += ınfo_receiver_dowork;
            ınfo_receiver.RunWorkerAsync();
        }
        public string player_ınfo_2_send(string player_number,bool player_onile,bool player_ready,
                                         string player_location_X,
                                         string player_location_Y,
                                         bool player_alive, bool player_right,bool player_stop)
        {
            //P1>C:1>R:1>X:+0000>Y:+0000>A:1>L:1>S:1*

            string information = player_number + ">C:";

            if (player_onile)
            {
                information += "1>R";
            }
            else
            {
                information += "0>R";
            }
            if (player_ready)
            {
                information += "1>X";
            }
            else
            {
                information += "0>X";
            }

            string location_x = player_location_X;

            if (player_location_X.Contains("-")) 
            {
                location_x = "+" + location_x;
            }
            int x_lenght = location_x.Length;

            if (location_x.Length != 5)
            {
                for (int i = 0; i < 5 - x_lenght; i++)
                {
                    location_x = location_x.Insert(1, "0");
                }
            }
            information += location_x + ">Y";
            string location_y = player_location_Y;

            if (player_location_Y.Contains("-")) 
            {
                location_y = "+" + location_y;
            }
            int y_lenght = location_y.Length;

            if (location_y.Length != 5)
            {
                for (int i = 0; i < 5 - y_lenght; i++)
                {
                    location_y = location_y.Insert(1, "0");
                }
            }
            information += location_y + ">A:";

            if (player_alive)
            {
                information += "1>L";
            }
            else
            {
                information += "0>L";
            }
            if (player_right)
            {
                information += "0>S";
            }
            else
            {
                information += "1>S";
            }
            if (player_stop)
            {
                information += "1*";
            }
            else
            {
                information += "0*";
            }
            return information;
        }
        public void ınfo_receiver_dowork(object sender ,DoWorkEventArgs e)
        {
            receive_info();
        }

        public void receive_info()
        {
            if (player1_this)
            {
                byte[] player2_info_buffer = new byte[39];
                if (amongus_for_player2 != null)
                {
                    amongus_for_player2.Receive(player2_info_buffer);

                    string player_info_full_string = Encoding.ASCII.GetString(player2_info_buffer, 0, player2_info_buffer.Length);

                    string[] player2_info_full_string = player_info_full_string.Split('*');

                    string[] player2s_info_string = player2_info_full_string[0].Split('>');

                    Byte_2_players_ınformation(player2s_info_string, ref player2_onile, player2_connection_label1,
                                                                     ref player2_ready,player2_pictureBox1, ref player2_alive, ref player2_right,
                                                                     ref player2_stop, ref player2_first_movement,
                                                                     Properties.Resources.blue_1, Properties.Resources.blue_2,
                                                                     Properties.Resources.blue_stop);
                }
                if (player1_right && player2_ready && connetction_panel1.Visible)
                {
                    ready_label1.Enabled = true;
                    
                }
            }
            else
            {
                byte[] players_info_buffer = new byte[78];
                amonguSsocket.Receive(players_info_buffer);


                string players_info_full_string = Encoding.ASCII.GetString(players_info_buffer, 0, players_info_buffer.Length);

                string[] players_info_string = players_info_full_string.Split('*');

                string[] player1s_info_string = players_info_string[0].Split('>');

                string[] player2s_info_string = players_info_string[1].Split('>');

                string[] player2_connection_info_label1 = player2s_info_string[1].Split(':');

                if (player2_connection_info_label1[1] == "0")
                {
                    player2_this = true;
                    player2_onile = true;
                    player2_connection_label1.ForeColor = Color.Yellow;
                }
                if (player2_this)
                {
                    Byte_2_players_ınformation(player2s_info_string, ref player1_onile, player1_connection_label1,
                                                                   ref player1_ready, player2_pictureBox1, ref player1_alive, ref player1_right,
                                                                   ref player1_stop, ref player1_first_movement,
                                                                   Properties.Resources.red_1, Properties.Resources.red_2,
                                                                   Properties.Resources.red_stop);
                }
                if (player2_this)
                {
                    amonguSsocket.Send(Encoding.Default.GetBytes(player_ınfo_2_send("P2", player2_onile, player2_ready,
                                                               Map_pictureBox1.Left.ToString(),
                                                              Map_pictureBox1.Top.ToString(),
                                                              player2_alive, player2_right, player2_stop)));


                    BackgroundWorker ınfo_receiver = new BackgroundWorker();
                    ınfo_receiver.DoWork += ınfo_receiver_dowork;
                    ınfo_receiver.RunWorkerAsync();
                    
                }
            }
        }
        public void Byte_2_players_ınformation(string[] players_info_string,ref bool player_onile,
                                              Label player_connection_label1,ref bool player_ready,
                                              PictureBox player_picturebox1,ref bool player_alive,
                                              ref bool player_right,ref bool player_stop,
                                              ref bool player_first_movement,Image _1,Image _2,Image stop)
        {
            string[] player_connection_info_string = players_info_string[1].Split(':');
            string[] player_ready_info_string = players_info_string[2].Split(':');
            string[] player_x_location_info_string = players_info_string[3].Split(':');
            string[] player_y_location_info_string = players_info_string[4].Split(':');
            string[] player_alive_info_string = players_info_string[5].Split(':');
            string[] player_left_info_string = players_info_string[6].Split(':');
            string[] player_stop_info_string = players_info_string[7].Split(':');


            if (player_connection_info_string[1] =="1")
            {
                player_onile = true;

                player_connection_label1.ForeColor = Color.Yellow;
            }
            else
            {
                player_onile = false;
            }

            if (player_ready_info_string[1] == "1")
            {
                player_ready = true;

                player_connection_label1.ForeColor = Color.Lime;
            }
            else
            {
                player_ready = false;
            }

            if (player1_this)
            {
                player_picturebox1.Left = player1_pictureBox1.Left + (Map_pictureBox1.Left -Convert.ToInt32(player_x_location_info_string[1]));
                player_picturebox1.Top = player1_pictureBox1.Top + (Map_pictureBox1.Top - Convert.ToInt32(player_y_location_info_string[1]));
            }
            if (player2_this)
            {
                player_picturebox1.Left = player2_pictureBox1.Left + (Map_pictureBox1.Left - Convert.ToInt32(player_x_location_info_string[1]));
                player_picturebox1.Top = player2_pictureBox1.Top + (Map_pictureBox1.Top - Convert.ToInt32(player_y_location_info_string[1]));
            }


            if (player_alive_info_string[1] == "1")
            {
                player_alive = true;

                if (connetction_panel1.Visible)
                {
                    if (player2_this)
                    {
                        player1_pictureBox1.Location = new Point(-1690, 110);
                        player2_pictureBox1.Location = new Point(110, 110);

                        Map_pictureBox1.Location = new Point(-1800, 0);

                        player2_alive = true;

                    }
                    connetction_panel1.Visible = false;
                }
            }
            else
            {
                player_alive = false;
            }


            if (player_left_info_string[1] == "0")
            {
                player_right = true;

                
            }
            else
            {
                player_right = false;
            }

            if (player_stop_info_string[1] == "1")
            {
                player_stop = true;
 
            }
            else
            {
                player_stop = false;
            }


            other_player_movemt(player_stop, ref player_first_movement,  player_right,
                                _1, _2, stop, player_picturebox1);

        }
        public void other_player_movemt(bool player_stop,ref bool player_first_movement,bool player_right,
                                        Image _1, Image _2 , Image stop, PictureBox other_player_picturebox1)
        {
            Image img = null;

            if (!player_stop)
            {
                if (player_first_movement)
                {
                    img = _1;
                    player_first_movement = false;
                }
                else
                {
                    img = _2;
                    player_first_movement = true;
                }
                    
            }
            else
            {
                player_first_movement = true;
                img = stop;
                
            }
            if (player_right)
            {
                img.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
            other_player_picturebox1.BackgroundImage = img;

        }
        private void ready_label1_Click(object sender, EventArgs e)
        {
            if (ready_label1.Text =="Hazırım")
            {
                if (player1_this)
                {
                    player1_connection_label1.ForeColor = Color.Lime;
                    player1_ready = true;
                }
                if (player2_this)
                {
                    player2_connection_label1.ForeColor = Color.Lime;
                    player2_ready = true;
                }
                ready_label1.Enabled = false;
                if (player1_this)
                {
                    ready_label1.Text = "Başla";
                    if (player1_ready && player2_ready)
                    {
                        ready_label1.Enabled = true;
                    }
                }
                else
                {
                    ready_label1.Text = "1.Oyuncunun başlamasını bekle";
                }
            }
            else if (ready_label1.Text == "Start")
            {
                connetction_panel1.Visible = false;
                player1_alive = true;
            }
        }

     
    }
   
}
