using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Legacy.Core;
using Legacy.Core.Models;

namespace Legacy.Integrations
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> users = new List<User>();

        public UserRepository()
        {
            this.PopulateMockData();
        }

        public Task<User> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(this.users.FirstOrDefault(user => user.Id == id));
        }

        private void PopulateMockData()
        {
            this.users.Add(new User
            {
                Id = 1,
                Email = "people@email.com",
                Name = "Jake",
                Password = "password",
            });

            this.users.Add(new User
            {
                Id = 2,
                Email = "people@hotmail.com",
                Name = "Lily",
                Password = "password",
            });

            this.users.Add(new User
            {
                Id = 3,
                Email = "people@live.com",
                Name = "Ron",
                Password = "password",
            });
        }
    }
}
