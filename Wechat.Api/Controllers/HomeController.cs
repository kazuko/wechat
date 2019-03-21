﻿using System.Web.Http;
using Wechat.Api.Abstracts;
using Wechat.Util.Extensions;

namespace Wechat.Api.Controllers
{
    /// <summary>
    /// 首页
    /// </summary>
    public class IndexController : WebchatControllerBase
    {
        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public string Get()
        {

            //JsonFormat.printToString(GetA8Key)

            return "微信接口,接口文档地址：https://172.16.4.44:8088/svn/Arts/侠客SCRM/xiake-scrm/xiake-scrm/trunk/wechat/说明文档";
        }

    }
}
