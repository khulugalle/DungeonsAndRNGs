using DungeonsAndRngs.Common.Enumerations;
using DungeonsAndRngs.Common.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndRngs.Common.Randomisation
{
    /// <summary>
    /// Class for rolling random dice and generating other random numbers
    /// </summary>
    public class Randomiser
    {
        /// <summary>
        /// The Random object used for generation
        /// </summary>
        protected static Random randomSeed;

        /// <summary>
        /// The singleton instance of the Randomiser
        /// </summary>
        protected static Randomiser randomiser;

        /// <summary>
        /// Singletone instance getter for the Randomiser
        /// </summary>
        public static Randomiser Instance
        {
            get
            {
                return randomiser == null ? new Randomiser() : randomiser;
            }
        }

        /// <summary>
        /// Protected constructor for a new Randomiser with a random seed
        /// </summary>
        protected Randomiser()
        {
            randomSeed = new Random();
        }

        /// <summary>
        /// Protected constructor for a new Randomiser with a specified seed value
        /// </summary>
        /// <param name="seed">The seed to use for random generation</param>
        protected Randomiser(int seed)
        {
            randomSeed = new Random(seed);
        }

        /// <summary>
        /// Resets the Randomiser seed
        /// </summary>
        public void Reset()
        {
            randomSeed = new Random();
        }

        /// <summary>
        /// Resets the Randomiser seed with the specified seed value
        /// </summary>
        /// <param name="seed">The seed to use for random generation</param>
        public void Reset(int seed)
        {
            randomSeed = new Random(seed);
        }

        /// <summary>
        /// Rolls a Dice
        /// </summary>
        /// <param name="diceType">The Dicetype to roll</param>
        /// <returns>An integer that falls within the possible values for the dice specified</returns>
        /// <remarks>Note that this means that the return value cannot be 0. i.e. a D20 will return values between 1 and 20</remarks>
        public int Roll(Dice diceType)
        {
            int sideNumber = (int) diceType;
            return Roll(sideNumber);
        }

        /// <summary>
        /// Rolls a dice based on the given number of sides
        /// </summary>
        /// <param name="sideNumber"></param>
        /// <returns></returns>
        public int Roll(int sideNumber)
        {
            int roll = (int) Math.Round(NumberUtil.RoundToCeiling(randomSeed.NextDouble(), ((double)1/sideNumber)) * sideNumber);

            return roll;
        }

        /// <summary>
        /// Rolls a D2
        /// </summary>
        /// <returns>A whole number between 1 and 2</returns>
        public int RollD2()
        {
            return Roll(Dice.D2);
        }

        /// <summary>
        /// Rolls a D3
        /// </summary>
        /// <returns>A whole number between 1 and 3</returns>
        public int RollD3()
        {
            return Roll(Dice.D3);
        }

        /// <summary>
        /// Rolls a D4
        /// </summary>
        /// <returns>A whole number between 1 and 4</returns>
        public int RollD4()
        {
            return Roll(Dice.D4);
        }

        /// <summary>
        /// Rolls a D6
        /// </summary>
        /// <returns>A whole number between 1 and 6</returns>
        public int RollD6()
        {
            return Roll(Dice.D6);
        }

        /// <summary>
        /// Rolls a D7
        /// </summary>
        /// <returns>A whole number between 1 and 7</returns>
        public int RollD7()
        {
            return Roll(Dice.D7);
        }

        /// <summary>
        /// Rolls a D28
        /// </summary>
        /// <returns>A whole number between 1 and 8</returns>
        public int RollD8()
        {
            return Roll(Dice.D8);
        }

        /// <summary>
        /// Rolls a D10
        /// </summary>
        /// <returns>A whole number between 1 and 10</returns>
        public int RollD10()
        {
            return Roll(Dice.D10);
        }

        /// <summary>
        /// Rolls a D12
        /// </summary>
        /// <returns>A whole number between 1 and 12</returns>
        public int RollD12()
        {
            return Roll(Dice.D12);
        }

        /// <summary>
        /// Rolls a D20
        /// </summary>
        /// <returns>A whole number between 1 and 20</returns>
        public int RollD20()
        {
            return Roll(Dice.D20);
        }

        /// <summary>
        /// Rolls a D100
        /// </summary>
        /// <returns>A whole number between 1 and 100</returns>
        public int RollD100()
        {
            return Roll(Dice.D100);
        }
    }
}
