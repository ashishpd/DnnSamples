using System.ComponentModel.Composition;
using DotNetNuke.Entities.Users;
using DotNetNuke.Security.Roles;

namespace DnnEventListners
{
    [Export(typeof(IRoleEventHandlers))]
    public class RoleEventHandler : IRoleEventHandlers
    {
        public void RoleCreated(object sender, RoleEventArgs args)
        {
            Logger.Log(string.Format("Role Created {0}", args.Role.RoleName));
        }

        public void RoleDeleted(object sender, RoleEventArgs args)
        {
            Logger.Log(string.Format("Role Deleted {0}", args.Role.RoleName));
        }

        public void RoleJoined(object sender, RoleEventArgs args)
        {
            Logger.Log(string.Format("Role Joined {0}", args.Role.RoleName));
        }

        public void RoleLeft(object sender, RoleEventArgs args)
        {
            Logger.Log(string.Format("Role Left {0}", args.Role.RoleName));
        }
    }
}
