using System.ComponentModel.Composition;
using DotNetNuke.Entities.Tabs.Actions;

namespace DnnEventListners
{
    [Export(typeof(ITabEventHandler))]
    public class TabEventHandler : ITabEventHandler
    {
        public void TabCreated(object sender, TabEventArgs args)
        {
            Logger.Log(string.Format("Tab Created {0}", args.Tab.TabName));
        }

        public void TabUpdated(object sender, TabEventArgs args)
        {
            Logger.Log(string.Format("Tab Updated {0}", args.Tab.TabName));
        }

        public void TabRemoved(object sender, TabEventArgs args)
        {
            Logger.Log(string.Format("Tab Removed {0}", args.Tab.TabName));
        }

        public void TabDeleted(object sender, TabEventArgs args)
        {
            Logger.Log(string.Format("Tab Deleted {0}", args.Tab.TabName));
        }

        public void TabRestored(object sender, TabEventArgs args)
        {
            Logger.Log(string.Format("Tab Restored {0}", args.Tab.TabName));
        }

        public void TabMarkedAsPublished(object sender, TabEventArgs args)
        {
            Logger.Log(string.Format("Tab Marked As Published {0}", args.Tab.TabName));
        }
    }
}
