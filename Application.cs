using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessManagerSDKLib;
using NBioBSPCOMLib;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace NitgenRealtimeLog
{
    class Application
    {

        public AccessManager m_AccessManager;
        public TerminalInfo m_terminalInfo;        
        //public UserInfo m_userInfo;
        


        public Application(string message = null)
        {
            Console.Out.WriteLine(message);

            //string name = getUserName("0005");
            //Console.Out.WriteLine(name);
            m_AccessManager = new AccessManager();
            //m_terminalInfo = (TerminalInfo)m_AccessManager.TerminalInfo;
            //m_userInfo = (UserInfo)m_AccessManager.UserInfo;
            //listUser();
            /*
            m_terminalInfo.OnRealtimeTerminalEvent
               += new _ITerminalInfoEvents_OnRealtimeTerminalEventEventHandler((int nIndex, int nTerminalID, int byType, int byEvent, int byParameter, int byResult, string szUserID, DateTime dtEventTime) => {
                   m_terminalIno_OnRealtimeTerminalEvent(nIndex, nTerminalID, byType, byEvent, byParameter, byResult, szUserID, dtEventTime, "Extra");
            });
            */
            //showUser();

        }

        //set userinfo
        public void setLoginData(AccessManager m_AccessManager)
        {
            
            //this.showUser();
            
            m_terminalInfo = (TerminalInfo)m_AccessManager.TerminalInfo;
            //m_userInfo = (UserInfo)m_AccessManager.UserInfo;

            m_terminalInfo.OnRealtimeTerminalEvent
               += new _ITerminalInfoEvents_OnRealtimeTerminalEventEventHandler((int nIndex, int nTerminalID, int byType, int byEvent, int byParameter, int byResult, string szUserID, DateTime dtEventTime) => {
                   m_terminalIno_OnRealtimeTerminalEvent(nIndex, nTerminalID, byType, byEvent, byParameter, byResult, szUserID, dtEventTime, "extra");
               });
        }

        //show user details
        /*
        private void showUser()
        {
            m_userInfo.GetUserInfoByUserID("0003");          
            Console.Out.WriteLine(m_userInfo.Errorcode.ToString("x"));
            if (m_userInfo.Errorcode == ErrCode.ACAMAPI_ERROR_NONE)
            {
                Console.Out.WriteLine(m_userInfo.wszUserName);
            }
        }*/
        /*
        public void listUser(AccessManager m_AccessManager)
        {
            m_userInfo = (UserInfo)m_AccessManager.UserInfo;

            if (m_userInfo != null)
                m_userInfo.GetUserList();
            if (m_userInfo.Errorcode == ErrCode.ACAMAPI_ERROR_NONE)
            {
                Console.Out.WriteLine(m_userInfo.Count);
            }
        }*/
        //connect terminal
        public int connect_terminal(int txtTimeout = 15)
        {
            int connection_success = 0;

            string serverIp = ConfigurationManager.AppSettings["AccessServerIp"];
            int serverPort = Convert.ToInt32(ConfigurationManager.AppSettings["AccessServerPort"]);

            m_AccessManager.ConnectToServer(1,
                               serverIp,
                              serverPort);
            Console.Out.WriteLine("Error Code: " + m_AccessManager.Errorcode);

            switch (m_AccessManager.Errorcode)
            {
                case ErrCode.ACAMAPI_ERROR_NONE:


                    Console.Out.WriteLine("Success Connection!..Now Login");
                    m_AccessManager.SetNetworkTimeout(txtTimeout);
                    connection_success = 1;
                    break;
                case ErrCode.ACSERVER_ERROR_USERNOTFOUND:
                    Console.Out.WriteLine("User is not.");
                    break;
                case ErrCode.ACSERVER_ERROR_ADMINNOTFOUND:
                    Console.Out.WriteLine("Admin is not.");
                    break;
                case ErrCode.ACAMAPI_ERROR_CONNECTIONFAIL:
                    Console.Out.WriteLine("Connetion Fail.");
                    m_AccessManager.DisconnectServer();
                    break;
                default:

                    Console.Out.WriteLine("Connection fail : [" + m_AccessManager.Errorcode.ToString("x") + "]");
                    m_AccessManager.DisconnectServer();
                    break;
            }

            return connection_success;

        }
        //login
        public void login()
        {
            //string userId = "0001";
            //string userPassword = "1234";
            string userId = ConfigurationManager.AppSettings["AccessServerUserId"];
            string userPassword = ConfigurationManager.AppSettings["AccessServerUserPassword"];
            m_AccessManager.CheckAdmin(userId,
                            userPassword,
                            Convert.ToInt32(Define.AC_UserAuthType.AC_USER_AUTHTYPE_PW));

            if (m_AccessManager.Errorcode != ErrCode.ACAMAPI_ERROR_NONE)
                Console.Out.WriteLine("Fail.");
            else
            {
                Console.Out.WriteLine("Login Success.Ivoking Realtime Event");
            }
        }

        /**
         * https://snag.gy/Cqv8ZT.jpg
         **/
         
        //realtime method
        void m_terminalIno_OnRealtimeTerminalEvent(int nIndex, int nTerminalID, int byType, int byEvent, int byParameter, int byResult, string szUserID, DateTime dtEventTime, string extra)
        {

           
            if (byResult == 0 && szUserID.Length > 0)
            {
                /*
                try
                {

                    //Dispatcher.Invoke((Action)(() => m_userInfo.GetUserInfoByUserID(szUserID) ));

                    //Console.Out.WriteLine(m_userInfo.GetType().GetInterfaces());
                    
                    m_userInfo.GetUserInfoByUserID(szUserID);
                    if (m_userInfo.Errorcode == ErrCode.ACAMAPI_ERROR_NONE)
                    {
                        Console.Out.WriteLine(m_userInfo.wszUserName);
                    }
                }catch(Exception ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                }
                */

                Dictionary<string, string> data = getUserName(szUserID, nTerminalID);
                //Console.Out.WriteLine("name="+name);
                Console.Out.WriteLine("Index:" + nIndex + ", terminal id:" + nTerminalID+"("+ data["terminalname"] + ")" + ", user:" + "(" + szUserID + "), time:" + dtEventTime + ", Result=" + "Success");
                insert(szUserID, dtEventTime.ToString("yyyy-MM-dd HH:mm:ss"), nTerminalID, data["username"], data["terminalname"]);
                
                //m_userInfo.GetUserInfoByUserID(szUserID);
                //Console.Out.WriteLine("Index:" + nIndex + ", terminal id:" + nTerminalID + ", user:" + m_userInfo.wszUserName + "(" + szUserID + "), time:" + dtEventTime + ", Result=" + "Success");
            }
        }

        //select data from sql server
        public Dictionary<string, string> getUserName(string userid, int terminalid)
        {

            Dictionary<string, string> data = new Dictionary<string, string>();
            string cs = ConfigurationManager.ConnectionStrings["nitgenDatabaseConnection"].ConnectionString;
            
            
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select Name from NGAC_USERINFO where ID = @USERID", con);
                cmd.Parameters.Add("@USERID", SqlDbType.VarChar);
                cmd.Parameters["@USERID"].Value = userid;

                SqlCommand cmdterminal = new SqlCommand("select Name from NGAC_TERMINAL where ID = @TERMINALID", con);
                cmdterminal.Parameters.Add("@TERMINALID", SqlDbType.Int);
                cmdterminal.Parameters["@TERMINALID"].Value = terminalid;


                try
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        //name = reader.GetString(0);
                        data.Add("username", reader.GetString(0));
                    }

                    using (SqlDataReader reader = cmdterminal.ExecuteReader())
                    {
                        reader.Read();
                        //name = reader.GetString(0);
                        data.Add("terminalname", reader.GetString(0));
                    }


                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                }
            }
                return data;
        }

        //insert
        public void insert(string userid, string checktime, int terminalid, string fullname, string terminalname)
        {
            string cs = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
            string messageBody = ConfigurationManager.AppSettings["MessageBody"];
            int MagzineIn = Convert.ToInt32(ConfigurationManager.AppSettings["MagzineIn"]);
            int ArmoryIn = Convert.ToInt32(ConfigurationManager.AppSettings["ArmoryIn"]);

            using (MySqlConnection con = new MySqlConnection(cs))
            {

                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = con;
                    cmd.Connection.Open();
                    //Console.Out.WriteLine(cs + ":=MySQL[state=" + con.State + "| server=" + con.ServerVersion);
                    cmd.CommandText = "insert into device_log(userid,checktime,terminalid, name ) values(@userid, @checktime, @terminalid, @name)";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@userid", userid);
                    cmd.Parameters.AddWithValue("@checktime", checktime);
                    cmd.Parameters.AddWithValue("@terminalid", terminalid);
                    cmd.Parameters.AddWithValue("@name", fullname);
                    cmd.ExecuteNonQuery();
                    if (terminalid == ArmoryIn || terminalid == MagzineIn)
                    {
                        string message = String.Format(messageBody, fullname, terminalname);
                        cmd.CommandText = "insert into sms_outbox(create_dt,msg,status) values(@create_dt, @msg, @status);";
                        cmd.Parameters.AddWithValue("@create_dt", checktime);
                        cmd.Parameters.AddWithValue("@msg", message);
                        cmd.Parameters.AddWithValue("@status", 0);
                        cmd.ExecuteNonQuery();
                    }

                    //con.Open();
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Error: {0}", ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                //Console.Out.WriteLine(cs + ":=MySQL[state=" + con.State + "| server=" + con.ServerVersion);
            }

        }

        }
}
