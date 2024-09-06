using OOP_Quan.Dao;
using System;
using System.Collections.Generic;

namespace OOP_Quan
{
    public class Singleton<T> where T : class, new()
    {
        protected Singleton() { }
        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }
                return instance;
            }
        }
    }
}
