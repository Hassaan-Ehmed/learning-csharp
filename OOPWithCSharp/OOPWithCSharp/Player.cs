﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWithCSharp {
    class Player
    {

        public string name = "Harry";
        private int health = 49;


        public int getHealth() {
            
            return health;
        
        }

        public void setHealth(int h)
        {
            health = h;
        }

         
    }
     
}
