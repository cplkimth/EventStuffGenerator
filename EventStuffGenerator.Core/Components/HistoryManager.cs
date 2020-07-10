using System;
using System.Collections;
using System.Collections.Generic;

namespace EventStuffGenerator.Core.Components
{
    public class HistoryManager : IEnumerable<HistoryItem>
    {
        private const int MaxHistoryItems = 20;

        private const string FileName = "HistoryManager";

        #region singleton
        private static HistoryManager _instance;

        public static HistoryManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HistoryManager();
                return _instance;
            }
        }

        private HistoryManager()
        {
            try
            {
                // _list = new List<HistoryItem>(MaxHistoryItems);
                _list = IsolatedStorageHelper.Instance.LoadObject<List<HistoryItem>>(FileName);
            }
            catch
            {
                _list = new List<HistoryItem>(MaxHistoryItems);
            }
        }
        #endregion

        private readonly List<HistoryItem> _list;

        public void Add(string eventName, string argument)
        {
            var item = new HistoryItem(eventName, argument);

            OnHistoryItemAdding(item, _list.Count);

            if (_list.Count == MaxHistoryItems)
                _list.RemoveAt(_list.Count - 1);

            _list.Insert(0, item);

            OnHistoryItemAdded(item, _list.Count);
        }

        public void Save()
        {
            IsolatedStorageHelper.Instance.SaveObject(_list, FileName);

            OnSaved(FileName, _list.Count);
        }

        #region IEnumerable<HistoryItem> 구현
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<HistoryItem> GetEnumerator()
        {
            foreach (var history in _list)
                yield return history;
        }
        #endregion

        #region HistoryItemAdding event things for C# 3.0
        public event EventHandler<HistoryItemAddingEventArgs> HistoryItemAdding;

        protected virtual void OnHistoryItemAdding(HistoryItemAddingEventArgs e)
        {
            if (HistoryItemAdding != null)
                HistoryItemAdding(this, e);
        }

        protected virtual void OnHistoryItemAdding(HistoryItem item, int itemCount)
        {
            if (HistoryItemAdding != null)
                HistoryItemAdding(this, new HistoryItemAddingEventArgs(item, itemCount));
        }

        public class HistoryItemAddingEventArgs : EventArgs
        {
            public HistoryItem Item { get; set; }
            public int ItemCount { get; set; }

            public HistoryItemAddingEventArgs()
            {
            }

            public HistoryItemAddingEventArgs(HistoryItem item, int itemCount)
            {
                Item = item;
                ItemCount = itemCount;
            }
        }
        #endregion

        #region HistoryItemAdded event things for C# 3.0
        public event EventHandler<HistoryItemAddedEventArgs> HistoryItemAdded;

        protected virtual void OnHistoryItemAdded(HistoryItemAddedEventArgs e)
        {
            if (HistoryItemAdded != null)
                HistoryItemAdded(this, e);
        }

        protected virtual void OnHistoryItemAdded(HistoryItem item, int itemCount)
        {
            if (HistoryItemAdded != null)
                HistoryItemAdded(this, new HistoryItemAddedEventArgs(item, itemCount));
        }

        public class HistoryItemAddedEventArgs : EventArgs
        {
            public HistoryItem Item { get; set; }
            public int ItemCount { get; set; }

            public HistoryItemAddedEventArgs()
            {
            }

            public HistoryItemAddedEventArgs(HistoryItem item, int itemCount)
            {
                Item = item;
                ItemCount = itemCount;
            }
        }
        #endregion

        #region Saved event things for C# 3.0
        public event EventHandler<SavedEventArgs> Saved;

        protected virtual void OnSaved(SavedEventArgs e)
        {
            if (Saved != null)
                Saved(this, e);
        }

        protected virtual void OnSaved(string fileName, int itemCount)
        {
            if (Saved != null)
                Saved(this, new SavedEventArgs(fileName, itemCount));
        }

        public class SavedEventArgs : EventArgs
        {
            public string FileName { get; set; }
            public int ItemCount { get; set; }

            public SavedEventArgs()
            {
            }

            public SavedEventArgs(string fileName, int itemCount)
            {
                FileName = fileName;
                ItemCount = itemCount;
            }
        }
        #endregion
    }
}