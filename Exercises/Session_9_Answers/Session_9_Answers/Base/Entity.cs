﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_9_Answers {
    public class Entity {

        public Guid ID { get; private set; }

        public Entity() {
            ID = Guid.NewGuid();
        }

    }
}
