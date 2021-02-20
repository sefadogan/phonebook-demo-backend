namespace Sefd.Phonebook.Core.Utils.Results
{
    public class Result : IResult
    {
        #region Constructors
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        #endregion

        #region Properties
        public bool Success { get; }
        public string Message { get; }
        #endregion
    }
}
