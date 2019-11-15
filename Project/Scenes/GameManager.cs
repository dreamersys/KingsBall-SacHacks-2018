using UnityEngine;
using UnityEngine.SceneManagement;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System;


public class GameManager : MonoBehaviour {
    public string UserID = "";
    public int finalscore;

    public void Everything() {
        Debug.Log("HEY HEY HEY");
        UserID = CreateID();
        finalscore = PersistentManagerScript.Instance.CurrentScore;
        sendCompletion(UserID + " " + finalscore);
    }
    public string CreateID()
    {
        string user_ID = "";
        System.Random random = new System.Random();
        const int ID_SIZE = 10;

        for (int i = 0; i < ID_SIZE; i++)
        {
            user_ID += Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));

        }
        return user_ID;
    }


    public void sendCompletion(string score_send)
    {
        Debug.Log("hey");
        byte[] byteBuffer = Encoding.ASCII.GetBytes(score_send);
        int servPort = 7;

        Socket sock = null;
        IPAddress IP = null;

        try
        {
            //foreach(IPAddress ipaddr in Dns.Resolve(Dns.GetHostName()).AddressList){
                IP = IPAddress.Parse("172.20.10.2");
                //Debug.Log(IP.ToString());
            //}
            sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint serverEndPoint = new IPEndPoint(IP, servPort);
            sock.Connect(serverEndPoint);

            Debug.Log("Connected");
            Debug.Log("I am connected to " + IPAddress.Parse(((IPEndPoint)sock.RemoteEndPoint).Address.ToString()) + "\non port number " + ((IPEndPoint)sock.RemoteEndPoint).Port.ToString());

            sock.Send(byteBuffer, 0, byteBuffer.Length, SocketFlags.None);
            string rtn_String = Encoding.UTF8.GetString(byteBuffer);

        }
        catch (Exception e)
        {
            Debug.Log("Fail to Connect");
            Debug.Log(e.Message);
        }
        finally
        {
            sock.Close();
        }
    }
}
