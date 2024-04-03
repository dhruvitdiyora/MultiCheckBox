namespace MultiSelect.IServices
{
    public interface IGenericInterface<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
