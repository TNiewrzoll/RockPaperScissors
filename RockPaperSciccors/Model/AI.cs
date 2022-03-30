using System;

namespace RockPaperSciccors.Model
{
    public class AI : IAI
    {
        #region  Constructor
        public AI() { }
        #endregion

        #region Functions

        /// <summary>
        /// generates a HandGesture based on selected AI level
        /// </summary>
        /// <param name="aiLevel"></param>
        /// <param name="playerHandgesture"></param>
        /// <returns></returns>
        public HandGesture MakeDecision(AILevel aiLevel, HandGesture  playerHandgesture)
        {
            HandGesture returnGesture = HandGesture.Scissors;

            switch (aiLevel)
            {
                case AILevel.Easy:
                    returnGesture = EasyMode();
                    break;
                case AILevel.Medium:
                    returnGesture = MediumMode();
                    break;
                case AILevel.Insane:
                    returnGesture = InsaneMode(playerHandgesture);
                    break;
                default:
                    break;
            }

            return returnGesture;
        }

        /// <summary>
        /// generates an random value from the Handgesture Enum
        /// </summary>
        /// <returns></returns>
        private HandGesture EasyMode()
        {
           return (HandGesture)Enum.GetValues(typeof(HandGesture)).GetValue(new Random().Next(0, 3)); 
        }

        /// <summary>
        /// Medium Mode will Check your previous 10 decisions
        /// </summary>
        /// <returns></returns>
        private HandGesture MediumMode()
        {
            //TODO TN
            return EasyMode();
        }

        /// <summary>
        /// Insane mode is not beatable
        /// </summary>
        /// <param name="playerHandgesture"></param>
        /// <returns></returns>
        private HandGesture InsaneMode(HandGesture playerHandgesture)
        {
            switch (playerHandgesture)
            {
                case HandGesture.Rock:
                    return HandGesture.Paper;
                case HandGesture.Paper:
                    return HandGesture.Scissors;
                case HandGesture.Scissors:
                    return HandGesture.Rock;
                default:
                    return HandGesture.Rock;
            }
        }
       
        #endregion
    }
}
