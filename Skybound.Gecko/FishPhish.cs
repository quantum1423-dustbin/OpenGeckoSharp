//CREDITS to Eltu lefngap 'eveng for improving the following code

using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
namespace Skybound.Gecko
{
    class FishPhish
    {
        public static string string2domain(string Url)
        {
            if (!Url.Contains("://"))
                Url = "http://" + Url;

            return new Uri(Url).Host;
        }

        public static bool CheckAll(string content, string url)
        {
            try
            {
                //PayPal
                if (new Uri(url).Port != 443)
                {
                    if (content.Contains("webscr?cmd=_account-recovery"))
                    {
                        return true;
                    }
                }
                //Taobao
                if (string2domain(url).ToString() != "login.taobao.com")
                {
                    if (content.Contains("<p>移动<em>106575258196</em></p>") ||
                        content.Contains("<h4>您需要安装安全控件，才可使用安全登录。</h4>") ||
                        content.Contains("<span class=\"visitor\" id=\"J_VisitorTips_1\">"))
                    {
                        return true;
                    }
                }
                //Alipay
                if (string2domain(url).ToString() != "auth.alipay.com")
                {
                    if (content.Contains("<!--CMS大区域开始/标准登录页/标准登录页banner/loginBanner-->") ||
                        content.Contains("h2 seed=\"auth-alipayMember\">") ||
                        content.Contains("login.jhtml?style=alipay&amp;goto=") ||
                        content.Contains("<form name=\"loginForm\" id=\"login\" action=\"https://auth.alipay.com/login/index.htm\" method=\"post\" > "))
                    {
                        return true;
                    }
                }
                if (string2domain(url).ToString() != "mail.qq.com")
                {
                    if (content.Contains("https://res.mail.qq.com/zh_CN/htmledition/images/ico_help023457.gif") ||
                        content.Contains("src=\"/cgi-bin/getverifyimage?aid=23000101&f=html&ck=1&54973\"") ||
                        content.Contains("login.jhtml?style=alipay&amp;goto=") ||
                        content.Contains("><li>如上述方式仍然无法解决问题，请登录<a href=\"http://maildisk.bbs.qq.com\"_top>邮箱论坛通知我们</a>") ||
                        content.Contains("*margin-left:45px;color:#868686;clear:left;"))
                    {
                        return true;
                    }
                }
                if (string2domain(url).ToString() != "mail.163.com")
                {
                    if (content.Contains("<a href=\"http://uinfo.mail.163.com/cgi-bin/hseed/two.pl\"></a>"))
                    {
                        return true;
                    }
                }
                if (string2domain(url).ToString() != "signin.ebay.com")
                {
                    if (content.Contains("<b>Not an eBay member?</b></div></div><form method=\"post\" name=\"RegisterEnterInfo\" action=\"https://scgi.ebay.com/ws/eBayISAPI.dll?RegisterEnterInfo&amp;siteid=0&amp;UsingSSL=1&amp"))
                    {
                        return true;
                    }
                }
                if (string2domain(url).ToString() != "www.amazon.com")
                {
                    if (content.Contains("href=\"http://www.amazon.com/gp/registry/baby/ref=gno_listpop_br\">Baby Registry</a></li>"))
                    {
                        return true;
                    }
                }
                if (string2domain(url).ToString() != "www.facebook.com")
                {
                    if (content.Contains("nv={ffid1:\"Q5tApOLftAgaC6m8kqm0mg\",ffid2:\"8glFScqinWrvwX6Fsry6Ng\",ffid3:\"TUp0blRtRy05amRFRXZpV0xNanRDMTBm\",ffid4:\"SpgdcXnbu7nclLCHQ51BVw\",ffver:63083,user:0,"))
                    {
                        return true;
                    }
                }
                if (string2domain(url).ToString().Contains("twitter.com")==false)
                {
                    if (content.Contains("<a class=\"mobile\" href=\"/account/complete\">Already using Twitter via SMS?</a>"))
                    {
                        return true;
                    }
                }
                if (string2domain(url).ToString().Contains("walmart.com") == false)
                {
                    if (content.Contains("<a id=\"showLAUrl\" href=\"http://localad.walmart.com/walmart/new_user_entry.aspx\">"))
                    {
                        return true;
                    }
                }
                /*
                Foobar code.
                if (string2domain(url).ToString() != "m")
                {
                    if (content.Contains("<b>superfoooobar</b>"))
                    {
                        return true;
                    }
                }*/
            }
            catch {  }
            return false;
        }

    }
}
