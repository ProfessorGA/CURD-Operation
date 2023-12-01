namespace CURD_Operation
{
    internal class ApplicationDbContext
    {
        public object Items { get; internal set; }

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        internal void Update(Item item)
        {
            throw new NotImplementedException();
        }
    }
}