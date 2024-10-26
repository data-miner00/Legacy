namespace Legacy.Integrations.UnitTests
{
    using System;
    using System.Threading.Tasks;
    using Legacy.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UserRepositoryTests
    {
        private readonly IUserRepository userRepository = new UserRepository();

        [TestMethod]
        public async Task TestMethod1()
        {
            var user = await this.userRepository.GetByIdAsync(1);

            Assert.AreEqual("people@email.com", user.Email);
            Assert.AreEqual("Jake", user.Name);
        }
    }
}
