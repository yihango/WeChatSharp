using WeChatApi.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChatApi.Modal.Request
{
    class SendMsgRequest
    {
        /// <summary>
        /// BaseRequest
        /// </summary>
        public BaseRequest BaseRequest { get; set; }
        /// <summary>
        /// Msg
        /// </summary>
        public Msg Msg { get; set; }
        /// <summary>
        /// Scene
        /// </summary>
        public int Scene { get; set; }
    }
}
