using System;

namespace EventStuffGenerator.TestConsole
{
    public class Marine
    {
        private int _age;

        public void GrowOrder()
        {

        }

        #region Aaa event things for C# 3.0
        public event EventHandler<AaaEventArgs> Aaa;

        protected virtual void OnAaa(AaaEventArgs e)
        {
            if (Aaa != null)
                Aaa(this, e);
        }

        private AaaEventArgs OnAaa(int an  , int v )
        {
            AaaEventArgs args = new AaaEventArgs(an  , v );
            OnAaa(args);

            return args;
        }


        private AaaEventArgs OnAaaForOut()
        {
            AaaEventArgs args = new AaaEventArgs();
            OnAaa(args);

            return args;
        }


        public class AaaEventArgs : EventArgs
        {
            public int An { get; set;}  
            public int V { get; set;} 

	
            public AaaEventArgs()
            {
            }
	
            public AaaEventArgs(int an  , int v )
            {
                An = an;  
                V = v; 
            }
	
        }
        #endregion

        #region Baa event things for C# 3.0
        public event EventHandler<BaaEventArgs> Baa;

        protected virtual void OnBaa(BaaEventArgs e)
        {
            if (Baa != null)
                Baa(this, e);
        }

        private BaaEventArgs OnBaa()
        {
            BaaEventArgs args = new BaaEventArgs();
            OnBaa(args);

            return args;
        }

/*
private BaaEventArgs OnBaaForOut()
{
	BaaEventArgs args = new BaaEventArgs();
    OnBaa(args);

    return args;
}
*/

        public class BaaEventArgs : EventArgs
        {
	

            /*
            public BaaEventArgs()
            {
            }
            
            public BaaEventArgs()
            {
                
            }
            */
        }
        #endregion
    }
}