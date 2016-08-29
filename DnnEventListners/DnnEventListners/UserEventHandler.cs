using System.ComponentModel.Composition;
using DotNetNuke.Entities.Users;

namespace DnnEventListners
{
    [Export(typeof(IUserEventHandlers))]
    public class UserEventHandler : IUserEventHandlers
    {
        public void UserAuthenticated(object sender, UserEventArgs args)
        {
            Logger.Log(string.Format("User Authenticated {0}", args.User.Username));
        }

        public void UserCreated(object sender, UserEventArgs args)
        {
            Logger.Log(string.Format("User Created {0}", args.User.Username));
        }

        public void UserDeleted(object sender, UserEventArgs args)
        {
            Logger.Log(string.Format("User Deleted {0}", args.User.Username));
        }

        public void UserRemoved(object sender, UserEventArgs args)
        {
            Logger.Log(string.Format("User Removed {0}", args.User.Username));
        }

        public void UserApproved(object sender, UserEventArgs args)
        {
            Logger.Log(string.Format("User UserApproved {0}", args.User.Username));
        }

        public void UserUpdated(object sender, UpdateUserEventArgs args)
        {
            Logger.Log(string.Format("User Updated {0}", args.User.Username));
        }


    }
}
