using System;

namespace EventStuffGenerator.TestConsole
{
    public class Marine
    {
        private int _age;

        public void GrowOrder()
        {

        }

        #region AgeC event things for C# 3.0
        public event EventHandler<AgeCEventArgs> AgeC;

        protected virtual void OnAgeC(AgeCEventArgs e)
        {
            if (AgeC != null)
                AgeC(this, e);
        }

        private AgeCEventArgs OnAgeC(int age  , int age2 )
        {
            AgeCEventArgs args = new AgeCEventArgs(age  , age2 );
            OnAgeC(args);

            return args;
        }


        private AgeCEventArgs OnAgeCForOut()
        {
            AgeCEventArgs args = new AgeCEventArgs();
            OnAgeC(args);

            return args;
        }


        public class AgeCEventArgs : EventArgs
        {
            public int Age { get; set;}  
            public int Age2 { get; set;} 

	
            public AgeCEventArgs()
            {
            }
	
            public AgeCEventArgs(int age  , int age2 )
            {
                Age = age;  
                Age2 = age2; 
            }
	
        }
        #endregion

        #region AgeCC event things for C# 3.0
        public event EventHandler<AgeCCEventArgs> AgeCC;

        protected virtual void OnAgeCC(AgeCCEventArgs e)
        {
            if (AgeCC != null)
                AgeCC(this, e);
        }

        private AgeCCEventArgs OnAgeCC()
        {
            AgeCCEventArgs args = new AgeCCEventArgs();
            OnAgeCC(args);

            return args;
        }

/*
private AgeCCEventArgs OnAgeCCForOut()
{
	AgeCCEventArgs args = new AgeCCEventArgs();
    OnAgeCC(args);

    return args;
}
*/

        public class AgeCCEventArgs : EventArgs
        {
	

            /*
            public AgeCCEventArgs()
            {
            }
            
            public AgeCCEventArgs()
            {
                
            }
            */
        }
        #endregion
    }
}