namespace Sefd.Phonebook.Core.Utils.Results
{
    public class DataResult<TData> : Result, IDataResult<TData>
    {
        #region Constructors
        public DataResult(TData data, bool success, string message) : base(success, message)
        {
            Data = data;
        }
        public DataResult(TData data, bool success) : base(success)
        {
            Data = data;
        }
        #endregion

        #region Properties
        public TData Data { get; }
        #endregion
    }
}
