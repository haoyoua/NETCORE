namespace CoreApi.Model.Common
{
    public class ApiResult<T>
    {
        public bool Success { get; set; }

        public string Code { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }

        public static ApiResult<T> Ok(T data, string message = "success")
        {
            return new ApiResult<T>
            {
                Success = true,
                Code = "0",
                Message = message,
                Data = data
            };
        }

        public static ApiResult<T> Fail(string message, string code = "-1")
        {
            return new ApiResult<T>
            {
                Success = false,
                Code = code,
                Message = message,
                Data = default(T)
            };
        }
    }
}
