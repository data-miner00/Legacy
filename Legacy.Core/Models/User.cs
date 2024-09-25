namespace Legacy.Core.Models
{
    /// <summary>
    /// The user of some sort.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the unencrypted password.
        /// </summary>
        public string Password { get; set; }
    }
}
