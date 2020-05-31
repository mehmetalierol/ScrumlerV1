using Scrumler.Interface.Base;

namespace Scrumler.Entity.Base
{
    #region ObjectResult

    /// <summary>
    /// /// BLL taleplerinde dönecek olan mesaj şablonu
    /// </summary>
    public class BllResponse : IBllResponse
    {
        public string Message { get; set; }

        public int StatusCode { get; set; }

        public object Data { get; set; }
    }

    #endregion ObjectResult

    #region GenericResult

    /// <summary>
    /// BLL taleplerinde dönecek olan mesaj şablonu
    /// </summary>
    /// <typeparam name="T">Geri dönemesini istediğimiz tip</typeparam>
    public class BllResponse<T> : IBllResponse<T>
    {
        public string Message { get; set; }

        public int StatusCode { get; set; }

        public T Data { get; set; }
    }

    #endregion GenericResult
}