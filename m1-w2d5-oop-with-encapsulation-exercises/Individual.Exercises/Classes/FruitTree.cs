﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class FruitTree
    {
        public string typeOfFruit;
        public int piecesOfFruitLeft;

        public string TypeOfFruit
        {
            get { return typeOfFruit; }
        }

        public int PiecesOfFruitLeft
        {
            get { return piecesOfFruitLeft; }
        }

        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            this.typeOfFruit = typeOfFruit;
            piecesOfFruitLeft = startingPiecesOfFruit;
        }

        public bool PickFruit(int numberOfPiecesToRemove)
        {
            
            if (piecesOfFruitLeft > 0)
            {
                piecesOfFruitLeft -= numberOfPiecesToRemove;
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
