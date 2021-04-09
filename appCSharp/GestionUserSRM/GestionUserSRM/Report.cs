using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionUserSRM
{
    public class Report
    {
        int _reportID;
        string _reportDescription;
        int _messageID;
        string _messageContent;
        int _senderID;
        string _senderName;
        int _receiverID;
        string _receiverName;

        public int ReportID { get => _reportID; set => _reportID = value; }
        public string ReportDescription { get => _reportDescription; set => _reportDescription = value; }
        public int MessageID { get => _messageID; set => _messageID = value; }
        public string MessageContent { get => _messageContent; set => _messageContent = value; }
        public int SenderID { get => _senderID; set => _senderID = value; }
        public string SenderName { get => _senderName; set => _senderName = value; }
        public int ReceiverID { get => _receiverID; set => _receiverID = value; }
        public string ReceiverName { get => _receiverName; set => _receiverName = value; }

        public Report(int reportID, string reportDescription, int messageID, string messageContent, int senderID, string senderName, int receiverID, string receiverName) {
            this.ReportID = reportID;
            this.ReportDescription = reportDescription;
            this.MessageID = messageID;
            this.MessageContent = messageContent;
            this.SenderID = senderID;
            this.SenderName = senderName;
            this.ReceiverID = receiverID;
            this.ReceiverName = receiverName;
        }

        public override string ToString()
        {
            return this.ReportID + " : " + this.ReportDescription;
        }
    }
}
