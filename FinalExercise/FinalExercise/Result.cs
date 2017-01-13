using System.Collections.Generic;

namespace FinalExercise
{
    public struct Result<T>
    {
        /// <summary>
        ///     Generic Result class constructor for list of results
        /// </summary>
        /// <param name="items">List of items to return</param>
        /// <param name="success">status of result</param>
        /// <param name="message">Possible error message</param>
        public Result(List<T> items, bool success, string message)
            : this()
        {
            Items = items;
            Success = success;
            Message = message;
        }

        public List<T> Items { get; set; }

        public string Message { get; set; }

        public bool Success { get; set; }
    }

    /// <summary>
    ///     Single Result type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public struct SingleResult<T>
    {
        /// <summary>
        ///     Generic Result class constructor for single result
        /// </summary>
        /// <param name="item">item to return</param>
        /// <param name="success">status of operation</param>
        /// <param name="message">possilbe error message</param>
        public SingleResult(T item, bool success, string message)
            : this()
        {
            Item = item;
            Success = success;
            Message = message;
        }

        public T Item { get; set; }

        public string Message { get; set; }

        public bool Success { get; set; }
    }

}
