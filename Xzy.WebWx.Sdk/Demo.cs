using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xzy.WebWx.Core;
using Xzy.WebWx.Model;
using static Xzy.WebWx.Model.wx;
using System.IO;

namespace Xzy.WebWx.SdkDemo
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }


        XzyWebWxCore wx = new XzyWebWxCore();
        private void Demo_Load(object sender, EventArgs e)
        {
            //获取二维码
            wx.getQrCode += Wx_getQrCode;
            //获取当前登陆微信信息
            wx.getMyWx += Wx_getMyWx; ;
            //获取当前微信好友信息
            wx.getWxFriends += Wx_getWxFriends;
            //新增好友成功消息
            wx.getWxNewFriend += Wx_getWxNewFriend;
            //接收文字
            wx.getReceiveText += Wx_getReceiveText;
            //接收图片
            wx.getReceiveImg += Wx_getReceiveImg;
            //接收语音
            wx.getReceiveVoice += Wx_getReceiveVoice;
            //接收视频
            wx.getReceiveVideo += Wx_getReceiveVideo;
            //接收文件
            wx.getReceiveFile += Wx_getReceiveFile;
            //接收系统消息
            wx.getReceiveSysMsg += Wx_getReceiveSysMsg;
            //新好友请求
            wx.getFriengRequest += Wx_getFriengRequest;
            //日志信息
            wx.getLogMsg += Wx_getLogMsg;
            //错误信息
            wx.getErrMsg += Wx_getErrMsg; 

            wx.Start();
        }

        #region 消息回调

        private void Wx_getQrCode(string codeBase64)
        {
        }

        private void Wx_getMyWx(User model)
        {
        }

        private void Wx_getWxFriends(List<wx.Member> model)
        {
        }

        private void Wx_getWxNewFriend(string json)
        {
        }

        private void Wx_getReceiveText(string str)
        {
        }

        private void Wx_getReceiveImg(Image image)
        {
        }

        private void Wx_getReceiveVoice(byte[] file)
        {
            //string filesize = ((file.Length) / 1000).ConvertToString() + "秒";
            //FileStream fs;
            //BinaryWriter bw;
            //byte[] outbyte = null;
            //string filePath = Guid.NewGuid().ConvertToString()+".mp3";
            //fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            //bw = new BinaryWriter(fs);
            //outbyte = file;
            //bw.Write(outbyte, 0, outbyte.Length);
            //bw.Flush();
            //bw.Close();
            //fs.Close();
        }

        private void Wx_getReceiveVideo(byte[] videoFile, byte[] imgFile)
        {
          
        }

        private void Wx_getReceiveFile(byte[] file, string suffix)
        {

        }

        private void Wx_getReceiveSysMsg(string text)
        {
        }

        private void Wx_getFriengRequest(string json)
        {
        }

        private void Wx_getLogMsg(string str)
        {
        }

        private void Wx_getErrMsg(string err)
        {
        }

        #endregion

        #region 发送消息

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //发送文字
            wx.SendMsgText("", "", "", "", "你好", wx.wx);

            //发送文件  支持格式 ：".gif", ".jpg", ".jpeg", ".png", ".txt", ".html", ".xls", ".xlsx", ".doc", ".docx", ".ppt", ".pptx", ".3gp", ".pdf", ".zip", ".rar", ".mp4"
            wx.SendMsgFile("", "", "", "", "c://1.txt");
        }
    }
}
