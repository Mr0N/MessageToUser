using Microsoft.VisualStudio.TestTools.UnitTesting;
using MessageToUser.Service.TelegramBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using Telegram.Bot;
using Moq;
using Telegram.Bot.Polling;

namespace MessageToUser.Service.TelegramBot.Tests
{
    [TestClass()]
    public class TelegramBotCreateClientTests
    {
        [TestMethod()]
        public void CreateClientTest()
        {
            ConfigurationBuilder builder = new();
            builder.AddUserSecrets(Assembly.GetExecutingAssembly());
            var res = builder.Properties;
            var update = new Mock<IUpdateHandler>();
            update.Setup(a => a.HandlePollingErrorAsync(default, default, default))
                    .Returns(Task.CompletedTask);
            update.Setup(a => a.HandleUpdateAsync(default, default, default))
             .Returns(Task.CompletedTask);
           var obj = new TelegramBotCreateClient(builder.Build(), update.Object);
             var client =  obj.CreateClient();
            
        }
    }
}