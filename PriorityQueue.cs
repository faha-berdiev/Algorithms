namespace Algorithms
{
    public class QueueItem
    {
        public object? Value { get; set; }
        public QueueItem NextItem { get; set; }

        public QueueItem(object? value)
        {
            Value = value;
        }
    }

    public class PriorityQueue
    {
        private QueueItem? _firstItem = null;
        private QueueItem? _lastItem = null;

        public bool IsEmpty => _firstItem == null;

        public void Enqueue(object? value)
        {
            if (_firstItem == null)
            {
                _firstItem = new QueueItem(value);
                _lastItem = new QueueItem(value);
            }
            else
            {
                _lastItem.NextItem = new QueueItem(value);
                _lastItem = _lastItem.NextItem;
            }
        }

        public object Dequeue()
        {
            if (_firstItem == null)
                return null;

            var value = _firstItem.Value;
            _firstItem = _firstItem.NextItem;
            return value;
        }
    }
}