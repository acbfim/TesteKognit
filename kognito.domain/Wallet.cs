
namespace kognito.domain;

    public class Wallet : BaseObject
    {
        public long UserId { get; set; }
        public User User { get; set; }
        public long Amount { get; set; }
        public string Bank { get; set; }
    }
