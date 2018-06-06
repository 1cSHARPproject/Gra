using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Helpers
{
    /// <summary>
    /// Nothing,Hammer,Sword,FireExinguisher
    /// </summary>
    public enum Item
    {
        /// <summary>
        /// Nothing/null
        /// </summary>
        Nothing,
        /// <summary>
        /// An universal tool to build and repair
        /// </summary>
        Hammer,
        /// <summary>
        /// A tool to fight with enemys
        /// </summary>
        Sword,
        /// <summary>
        /// A tool to fight with fire
        /// </summary>
        FireExinguisher
    }
    /// <summary>
    /// Nothing,SpaceSuit,ArmoredSpaceSuit
    /// </summary>
    public enum Suit
    {
        /// <summary>
        /// Nothing/null
        /// </summary>
        Nothing,
        SpaceSuit,
        ArmoredSpaceSuit
    }
    public enum Class
    {
        Warior,
        Healer,


    }
    public static class EnumHelper
    {
    }
}
