using DDDBottomUp.Entities;
using DDDBottomUp.Repositories;
using DDDBottomUp.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace DDDBottomUpTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ユーザ作成処理をテストする()
        {
            var userRepository = new InMemoryUserRepository();

            var user = new User(new UserId("05"), new UserName("Rani"));
            userRepository.Save(user);

            var head = userRepository.Store.Values.First();
            Assert.AreEqual("Rani", head.UserName.Value);
        }
    }
}
