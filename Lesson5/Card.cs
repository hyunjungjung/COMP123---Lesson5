﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Card
    {
        /**
         * <summary>
         * This class creates an object that represents a playing card
         * </summary>
         * 
         * @class Card
         */
        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public Faces Face { get; set; }
        public Suits Suit { get; set; }
        /**
         * <summary>
         * This constructor takes two parameters: face and suit to instantiate a Card object
         * </summary>
         * 
         * @constructor Card
         * @param {Faces} face
         * @param {Suits} suit
         */
        public Card(Faces face, Suits suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
    }
}
