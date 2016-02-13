/// <summary>
///  Home accounting: Class PredictionList (group of predictions)
///  @author Students at IES San Vicente, Spain
/// </summary>

/* --------------------------------------------------         
   Versions history
   
   Num.   Date        By / Changes
   ---------------------------------------------------
   0.12  12-Feb-2016  Nacho: Empty skeleton
   0.13  12-Feb-2016  Jorge Montalvo, Manuel Coronado, David Gascón: Class PredictionsList
 ---------------------------------------------------- */

using System.Collections;

namespace HomeAccounting2
{
    // To do: formatting
    
    class PredictionsList
    {
        protected ArrayList predictions;

        public PredictionsList()
        {
            predictions = new ArrayList();
        }

        public void Add(Prediction newPredictions)
        {
            predictions.Add(newPredictions);
        }

        public void Remove(int position)
        {
            if (Count() > 0)
            {
                predictions.RemoveAt(position);
            }
        }

        public Prediction Get(int position)
        {
            return (Prediction)predictions[position];
        }

        public int Count()
        {
            return predictions.Count;
        }
    }
}
