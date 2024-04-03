using MultiSelect.IServices;
using MultiSelect.Models;

namespace MultiSelect.Services
{
    public class GenericServices<T> : IGenericInterface<T> where T : class
    {
        protected readonly ListBoxContext context;
        public GenericServices(ListBoxContext _context)
        {
            context = _context;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return context.Set<T>();
        }
    }
}
