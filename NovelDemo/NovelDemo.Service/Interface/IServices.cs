namespace NovelDemo.Service.Interface
{
    public interface IServices
    {
        IBookService Book { get; }

        ICategoryService Category { get; }

        IAuthorService Author { get; }
    }
}
