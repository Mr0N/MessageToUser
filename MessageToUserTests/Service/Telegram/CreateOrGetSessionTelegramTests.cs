using Microsoft.VisualStudio.TestTools.UnitTesting;
using MessageToUser.Service.Telegram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Reflection;
namespace MessageToUser.Service.Telegram.Tests
{
    [TestClass()]
    public class CreateOrGetSessionTelegramTests
    {
        [TestMethod()]
        public void CreateOrGetTest()
        {
            ConfigurationBuilder builder = new();
            builder.AddUserSecrets(Assembly.GetExecutingAssembly());
            var res = builder.Properties;
            new CreateOrGetSessionTelegram(builder.Build())
                .CreateOrGet();
        }
    }
}