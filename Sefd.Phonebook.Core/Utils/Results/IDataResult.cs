namespace Sefd.Phonebook.Core.Utils.Results
{
    public interface IDataResult<TData> : IResult
    {
        TData Data { get; }
    }
}
