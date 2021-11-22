﻿using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public sealed class GlobalRepositoty
    {
        public static GlobalRepositoty Instance { get; } = new GlobalRepositoty();
        public int index = new int();
        public int id = new int();
        public string _filename = null;
        public Users Usuario = new Users();
        public LabTest test = new LabTest();
        public Doctors Doc = new Doctors();

        public int TyperUser = new int();
        private GlobalRepositoty()
        { }
    }
}
