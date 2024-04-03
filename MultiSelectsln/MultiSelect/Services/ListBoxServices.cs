using MultiSelect.IServices;
using MultiSelect.Models;

namespace MultiSelect.Services
{
    public class ListBoxServices : GenericServices<ListBoxDatum>, IListBox
    {
        public ListBoxServices(ListBoxContext context) : base(context)
        {

        }
        public override IEnumerable<ListBoxDatum> GetAll()
        {
            var bookmark = context.ListBoxData;
            return bookmark;
        }

    }
}
