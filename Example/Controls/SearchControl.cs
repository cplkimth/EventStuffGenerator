using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example.Controls
{
    public partial class SearchControl : UserControl
    {
        public SearchControl()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var args = OnSearching(txbFirstName.Text, txbLastName.Text, false);
            if (args.Cancel)
                return;

            OnSearched(txbFirstName.Text, txbLastName.Text);
        }

        #region Searched event things for C# 3.0
        public event EventHandler<SearchedEventArgs> Searched;

        protected virtual void OnSearched(SearchedEventArgs e)
        {
            if (Searched != null)
                Searched(this, e);
        }

        private SearchedEventArgs OnSearched(string firstName  , string lastName )
        {
            SearchedEventArgs args = new SearchedEventArgs(firstName  , lastName );
            OnSearched(args);

            return args;
        }

        private SearchedEventArgs OnSearchedForOut()
        {
            SearchedEventArgs args = new SearchedEventArgs();
            OnSearched(args);

            return args;
        }

        public class SearchedEventArgs : EventArgs
        {
            public string FirstName { get; set;}  
            public string LastName { get; set;} 

            public SearchedEventArgs()
            {
            }
	
            public SearchedEventArgs(string firstName  , string lastName )
            {
                FirstName = firstName;  
                LastName = lastName; 
            }
        }
        #endregion

        #region Searching event things for C# 3.0
        public event EventHandler<SearchingEventArgs> Searching;

        protected virtual void OnSearching(SearchingEventArgs e)
        {
            if (Searching != null)
                Searching(this, e);
        }

        private SearchingEventArgs OnSearching(string firstName  , string lastName  , bool cancel )
        {
            SearchingEventArgs args = new SearchingEventArgs(firstName  , lastName  , cancel );
            OnSearching(args);

            return args;
        }

        private SearchingEventArgs OnSearchingForOut()
        {
            SearchingEventArgs args = new SearchingEventArgs();
            OnSearching(args);

            return args;
        }

        public class SearchingEventArgs : EventArgs
        {
            public string FirstName { get; set;}  
            public string LastName { get; set;}  
            public bool Cancel { get; set;} 

            public SearchingEventArgs()
            {
            }
	
            public SearchingEventArgs(string firstName  , string lastName  , bool cancel )
            {
                FirstName = firstName;  
                LastName = lastName;  
                Cancel = cancel; 
            }
        }
        #endregion
    }
}
