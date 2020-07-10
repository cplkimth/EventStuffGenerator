#region
using System;
using System.Windows.Forms;

#endregion

namespace EventStuffGenerator.Win.Forms
{
    public partial class EbnfForm : Form
    {
        public EbnfForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            txtEbnf.Text = @"template = {event name | class name | argument loop | character} ;

event name = ""[EN]"";

class name = ""[CN]"";

argument loop = ""<*"" , {argument type | argument pacsal name | argument camel name | character}, "" :: "", {loop seperator} , ""*>"" ;

loop seperator = ""[N]"" | ""[T]"" | character ;

argument type = ""[AT]""
argument pacsal name = ""[AP]""
argument camel name = ""[AC]""

character = [a-z] | [A-Z] | [0-9] | white space ;
";
        }
    }
}