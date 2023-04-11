using System;

namespace MAGLabCL
{
    public class Timeout
    {
        public UInt16 lastRecTime = 0;

        public Timeout()
        {
        }

        public bool update(bool received, UInt16 time, UInt16 timeout)
        {
            bool retVal = false;
            if (received)
            {
                lastRecTime = time;
                retVal = false;
            }

            if (time - lastRecTime >= timeout)
            {
                retVal = true;
            }

            if (time - lastRecTime > timeout)
            {
                lastRecTime += 1;
            }

            return retVal;
        }
    }

    public class ConfirmationThreshold<T> where T : IComparable
    {
        public T confirmedValue;
        public UInt16 lastConfTime = 0;
        public UInt16 confNumCounter = 0;
        public ConfirmationThreshold(T initValue)
        {
            confirmedValue = initValue;
        }

        public T update(bool received, T newValue, UInt16 time, UInt16 tReq, UInt16 nReq)
        {
            // confirmation state machine
            if (received)
            {
                // received counter processing
                if (confNumCounter <= nReq)
                {
                    confNumCounter += 1;
                }

			    // new value processing
			    if (confirmedValue.CompareTo(newValue) != 0)
			    {
				    // if both the numeric value and the counter are above the ratio, we have a new value
				    if (confNumCounter >= nReq)
				    {
					    if (time - lastConfTime > tReq)
					    {
						    confirmedValue = newValue;
					    }
				    }
			    }

			    // confirmed value processing
			    if (confirmedValue.CompareTo(newValue) == 0)
			    {
				    confNumCounter = 0;
				    lastConfTime = time;
			    }
		    }

		    if (time - lastConfTime > tReq)
		    {
			    lastConfTime += 1;
		    }

            return confirmedValue;
	    }
    }
}
