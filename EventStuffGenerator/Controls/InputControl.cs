#region
using System;
using System.Diagnostics;
using System.Windows.Forms;
using EventStuffGenerator.Components;
using EventStuffGenerator.Forms;

#endregion

namespace EventStuffGenerator.Controls
{
    public partial class InputControl : UserControl
    {
        public InputControl()
        {
            InitializeComponent();
        }

        public string EventName
        {
            get { return txtEventName.Text; }
        }

        public string Argument
        {
            get { return txtArgument.Text; }
        }

        public void Initiate()
        {
            foreach (HistoryItem item in HistoryManager.Instance)
                cmbHistory.Items.Add(item);

            HistoryManager.Instance.HistoryItemAdded += HisstoryManager_ItemAdded;
        }

        private void HisstoryManager_ItemAdded(object sender, HistoryManager.HistoryItemAddedEventArgs e)
        {
            cmbHistory.Items.Insert(0, e.Item);
        }

        private void cmbHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            HistoryItem historyItemItem = (HistoryItem) cmbHistory.SelectedItem;

            if (historyItemItem == null)
                return;

            txtEventName.Text = historyItemItem.EventName;
            txtArgument.Text = historyItemItem.Argument;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(@"http://kimgwajang.tistory.com/category/Dev%20Tools/이벤트%20코드%20생성기");
        }

        private void btnEbnf_Click(object sender, EventArgs e)
        {
            var form = new EbnfForm();
            form.Show();
        }
    }
}