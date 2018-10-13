using WeChat.WebSdk.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeChat.WebSdk.Modal.Response
{
    public class BatchGetContactResponse
    {
        /// <summary>
        /// BaseResponse
        /// </summary>
        public BaseResponse BaseResponse { get; set; }
        /// <summary>
        /// Count
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// ContactList
        /// </summary>
        public List<Contact> ContactList { get; set; }
    }
}
