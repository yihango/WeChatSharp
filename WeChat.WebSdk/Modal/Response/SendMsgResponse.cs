using WeChat.WebSdk.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChat.WebSdk.Modal.Response
{
    public class SendMsgResponse
    {
        /// <summary>
        /// BaseResponse
        /// </summary>
        public BaseResponse BaseResponse { get; set; }
        /// <summary>
        /// 6591428511450054574
        /// </summary>
        public string MsgID { get; set; }
        /// <summary>
        /// 15101127509150611
        /// </summary>
        public string LocalID { get; set; }
    }
}
