namespace API.Helpers
{
    public class Pagination<T> where T :class
    {
        public int PageIndex { get; set; }
        public int Page { get; set; }
    }
}