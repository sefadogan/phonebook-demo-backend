namespace Sefd.Phonebook.Core.Utils.Results
{
    public class SuccessResult : Result, ISuccessResult
    {
        public SuccessResult(string message) : base(true, message)
        {
        }
        public SuccessResult() : base(true)
        {
        }
    }
}
